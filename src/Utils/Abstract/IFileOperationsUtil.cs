using System.Threading.Tasks;

namespace Soenneker.Runners.ffprobe.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(string filePath);
}