using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_varijable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.33;
            double b = 13.05;
            double c = 2.1;
            double d = 15.99;
            double x =(a*2+b*2+c*2+d*2)/((a+b)*2+(c+d)*2);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
