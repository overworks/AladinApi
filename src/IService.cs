using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public interface IService
    {
        string TTBKey { get; }

        ItemSearchRequest CreateItemSearchRequest();
        ItemLookUpRequest CreateItemLookUpRequest();
        ItemListRequest CreateItemListRequest();

        Task<ResT> SendAsync<ResT>(string requestUri, CancellationToken cancellationToken = default)
            where ResT : IResponse;
    }
}
