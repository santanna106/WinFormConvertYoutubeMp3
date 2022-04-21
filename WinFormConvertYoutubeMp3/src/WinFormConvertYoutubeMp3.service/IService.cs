using System.Threading.Tasks;

namespace WinFormConvertYoutubeMp3.service
{
    public interface IService
    {
       Task Convert(string url, string dest);
    }
}
