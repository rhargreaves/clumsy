using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clumsy
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new StandardConsole();
            console.BannerValues.ProgramName = "default";
            console.DrawBanner();

            console.ReadLine();
        }
    }
}
