using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clumsy.Interfaces
{
    public interface IConsole
    {
        BannerValues BannerValues { get; }
        void DrawBanner();
        string ReadLine();
        void WriteLine(object value);
        void WriteLine(string format, params object[] values);
    }
}
