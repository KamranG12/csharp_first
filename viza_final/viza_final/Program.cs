using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viza_final
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            if(netice()>=45)
            {
                a="Kechdin";
              Console.WriteLine(a);
              Console.ReadLine();
            }else{
                a="Qaldin";
              Console.WriteLine(a);
              Console.ReadLine();
            }
        }
        static double netice(ushort viza=10,ushort final=200)
            {
              return (viza*0.4)+(final*0.6);
            }
    }
}
