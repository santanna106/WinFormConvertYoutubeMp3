using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormConvertYoutubeMp3.service
{
    public interface IService
    {
        void Convert(string url, string dest);
    }
}
