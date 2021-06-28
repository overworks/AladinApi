using System.Threading;
using System.Threading.Tasks;

namespace Mh.Aladin
{
    public interface IRequest<ResT>
    {
        Task<ResT> SendAsync(CancellationToken cancellationToken = default);
    }
}
