using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Application
{

    public delegate string MyHandler();

    class Program
    {
        private static string Print() => "Hello World!";

        static void Main(string[] args)
        {
            MyHandler d = Print;

            Write(d());
            ReadKey();
        }
    }
}
