using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week15B_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "person99.dat";
            var numb = Regex.Matches(fileName, "\\d{1,2}");
            foreach (var n in numb)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
