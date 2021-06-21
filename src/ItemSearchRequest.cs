using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public class ItemSearchRequest : ItemRequest<ItemSearchResponse>
    {
        internal ItemSearchRequest(AladinService service) : base(service)
        {
        }

        public override Task<ItemSearchResponse> SendAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
