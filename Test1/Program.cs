using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 4; i++)
            {
                for (j = i; j <= 4; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            Console.ReadLine();

    }   }
}
