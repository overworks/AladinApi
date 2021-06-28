using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public abstract class ItemRequest<ResT> : IRequest<ResT>
    {
        public const string Version = "20131101";

        internal ItemRequest()
        {
        }

        public CoverSize? Cover { get; set; }
        public string Partner { get; set; }

        public abstract Task<ResT> SendAsync(CancellationToken cancellationToken = default);
    }
}
