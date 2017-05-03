using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Gelir:"+" "+ netGelir());
            Console.WriteLine("Faiz:" + " " + faiz());
            Console.ReadLine();
        }

        static double brutGelir(ushort a=90,byte b=20)
        {
            return a * b;
        }
        static double faiz()
        {
            if (brutGelir() >= 1000)
            {
                return brutGelir() * 0.18;
            }
            else
            {
                return brutGelir() * 0.04;
            }
        }
        static double netGelir()
        {
            return brutGelir() - faiz();
        }
    }
}
