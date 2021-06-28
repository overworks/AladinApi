using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public class ItemLookUpRequest : ItemRequest<ItemLookUpResponse>
    {
        internal ItemLookUpRequest(IService service)
        {
            this.service = service;
        }

        public string ItemId { get; set; }
        public ItemIdType? ItemIdType { get; set; }


        public override async Task<ItemLookUpResponse> SendAsync(CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(ItemId))
            {
                throw new InvalidOperationException($"{nameof(ItemId)} must be set");
            }

            var sb = new StringBuilder("http://www.aladin.co.kr/ttb/api/itemlookup.aspx?");
            sb.Append("ttbkey=").Append(service.TTBKey);
            sb.Append("&version=").Append(Version);
            sb.Append("&output=").Append("js");
            sb.Append("&itemid=").Append(ItemId);

            if (Cover.HasValue)
            {
                sb.Append("&cover=").Append(Cover.Value);
            }

            if (Partner != null)
            {
                sb.Append("&partner=").Append(Partner);
            }

            if (ItemIdType.HasValue)
            {
                sb.Append("&itemidtype=").Append(ItemIdType.Value);
            }

            return await service.SendAsync<ItemLookUpResponse>(sb.ToString(), cancellationToken);
        }

        private readonly IService service;
    }
}