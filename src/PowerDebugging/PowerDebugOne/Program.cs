using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDebugOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdef";
            string start = getHalf(str).Insert(0, "ghij");
            ExceptionGenerator.GenerateFileNotFoundException();
            Console.ReadKey();
        }

        private static string getHalf(string str)
        {
            return str.Substring(str.Length / 2);
        }
    }
}
