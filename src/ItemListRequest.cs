using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public class ItemListRequest : ItemRequest<ItemListResponse>
    {
        public ItemListQueryType QueryType { get; set; }
        public int CategoryId { get; set; }
        public SearchTarget SearchTarget { get; set; }

        public int? Start { get; set; }
        public int? MaxResults { get; set; }

        internal ItemListRequest(AladinService service) : base(service)
        {
        }

        public override Task<ItemListResponse> SendAsync(CancellationToken cancellationToken = default)
        {
            var sb = new StringBuilder("http://www.aladin.co.kr/ttb/api/itemlist.aspx?");
            sb.Append("ttbkey=").Append(TTBKey);
            sb.Append("&querytype=").Append(QueryType);
            sb.Append("&output=").Append("js");
            sb.Append("&categoryid=").Append(CategoryId);
            sb.Append("&searchtarget=").Append(SearchTarget);
            sb.Append("&version=").Append(Version);

            if (Cover.HasValue)
            {
                sb.Append("&cover=").Append(Cover.Value);
            }

            if (Partner != null)
            {
                sb.Append("&partner=").Append(Partner);
            }

            if (Start.HasValue)
            {
                sb.Append("&start=").Append(Start.Value);
            }

            if (MaxResults.HasValue)
            {
                sb.Append("&maxresults=").Append(MaxResults.Value);
            }

            return service.SendAsync<ItemListResponse>(sb.ToString(), cancellationToken);
        }
    }
}
