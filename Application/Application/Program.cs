using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Application
{
    class Program
    {
        private static string Print() => "Hello World!";

        static void Main(string[] args)
        {

            Write(Print());
            ReadKey();
        }
    }
}
