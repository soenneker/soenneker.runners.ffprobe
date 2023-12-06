using System.Threading.Tasks;

namespace Soenneker.Runners.ffprobe.Utils.Abstract;

public interface IDownloadUtil
{
    ValueTask<string> Download();
}