using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public class AladinService
    {
        private static HttpClient httpClient;
        private static JsonSerializerOptions serializerOptions;

        static AladinService()
        {
            httpClient = new HttpClient();
            serializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        }


        public AladinService(string ttbKey)
        {
            if (string.IsNullOrWhiteSpace(ttbKey))
            {
                throw new ArgumentException("ttbKey should not be null or whitespace");
            }

            TTBKey = ttbKey;
        }

        public string TTBKey { get; }

        public ItemSearchRequest CreateItemSearchRequest() => new ItemSearchRequest(this);

        public ItemLookUpRequest CreateItemLookUpRequest() => new ItemLookUpRequest(this);

        public ItemListRequest CreateItemListRequest() => new ItemListRequest(this);

        internal async Task<ResT> SendAsync<ResT>(string requestUri, CancellationToken cancellationToken = default)
            where ResT : ItemResponse
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            var res = await JsonSerializer.DeserializeAsync<ResT>(stream, serializerOptions, cancellationToken);
            if (res.ErrorCode != 0)
            {
                throw new AladinException(res.ErrorCode, res.ErrorMessage);
            }
            return res;
        }
    }
}
