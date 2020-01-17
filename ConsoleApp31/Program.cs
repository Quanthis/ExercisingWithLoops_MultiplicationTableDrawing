using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {//3.9
            int j;
            for (int i=1; i<=10; i++)
            {
                for (j = 1; j <= 10; j++)
                    Console.Write("{0, 3} ", j*i);
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
