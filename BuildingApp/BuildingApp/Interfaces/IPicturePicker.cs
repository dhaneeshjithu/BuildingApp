

using System.IO;
using System.Threading.Tasks;

namespace BuildingApp.Interfaces
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}
