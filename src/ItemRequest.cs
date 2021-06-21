using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public abstract class ItemRequest<ResT> where ResT : ItemResponse
    {
        public const string Version = "20131101";


        internal ItemRequest(AladinService service)
        {
            this.service = service;
        }

        public string TTBKey => service.TTBKey;


        public CoverSize? Cover { get; set; }
        public string Partner { get; set; }

        public abstract Task<ResT> SendAsync(CancellationToken cancellationToken = default);

        protected readonly AladinService service;
    }
}
