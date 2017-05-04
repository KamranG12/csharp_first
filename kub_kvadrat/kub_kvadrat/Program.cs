using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kub_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil et:");
            Console.WriteLine(kvadratKub());
            Console.ReadLine();
        }
        static int kvadratKub()
        {
            int result;
            int eded = Convert.ToInt32(Console.ReadLine());
            if (eded % 2 == 0)
            {
                result = eded * eded;
            }
            else
            {
                result = eded * eded * eded;
            }
            return result;

        }
    }
}
