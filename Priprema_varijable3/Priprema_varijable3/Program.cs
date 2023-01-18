using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_varijable3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite rečenicu:");
            
            string[] rijeci = Console.ReadLine().Split(' ');

            Console.WriteLine(rijeci.First() + "\n" + rijeci.Last());

            Console.ReadKey();
        }
    }
}
