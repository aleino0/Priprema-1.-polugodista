using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_varijable4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli i decimalni broj razdvojene razmakom (cijeli decimalni)");
            string[] brojevi = Console.ReadLine().Split(' ');

            int x = 2*Convert.ToInt32(brojevi[0]);
            double y = 2*Convert.ToDouble(brojevi[1]);

            Console.WriteLine("Cijeli*2: {0} \nDecimalni*2: {1}", x, y);

            Console.ReadKey();
        }
    }
}
