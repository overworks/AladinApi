using System.Threading.Tasks;
using Xunit;

namespace Mh.Aladin.Tests
{
    public class AladinServiceTests
    {
        [Fact]
        public async Task TestSingle()
        {
            var service = new AladinService("valid-ttbkey");

            var itemListReq = service.CreateItemListRequest();
            itemListReq.QueryType = ItemListQueryType.ItemNewAll;
            itemListReq.MaxResults = 1;

            var itemListRes = await itemListReq.SendAsync();

            Assert.Single(itemListRes.Item);
        }
    }
}
