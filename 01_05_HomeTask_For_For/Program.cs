using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_05_HomeTask_For_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, c = 9, d = 4; i <= 4; ++i, Console.WriteLine())
            {
                for (int j = 1; j <= i; j++, Console.Write(c + " ")) ;
                c--;
                Console.WriteLine();
                for (int j = 1; j <= i; j++, Console.Write(d + " ")) ;
                d--;
            }
            Console.WriteLine(new string('-', 50));

            for (int i = 1, y = 10; i < 6; ++i, Console.WriteLine())
            {
                for (int j = i, z = 3; j > 0; --j)
                {

                    if (i >= 2 && j >= 2) Console.Write(" " + 2);
                    else Console.Write(" " + z);
                }
                Console.WriteLine();
                for (int q = i, h = 0; q > 0; --q, ++h)
                {
                    if ( q == 1) Console.Write(" " + 0);
                    else Console.Write(" " + (y + h));
                }
                --y;
            }


            Console.WriteLine(new string('-', 50));
            int x = 3;
            for (int i = 1, y = 6; i <= 5; ++i, --y, Console.WriteLine())
            {
                for (int j = i; j <= 5; ++j)
                {
                    Console.Write(" " + "2");
                }
                Console.WriteLine();
                for (int z = i; z <= 5; ++z, ++x)
                {
                    Console.Write(" " + x);
                }
                x -= y;
            }





            Console.ReadKey();
        }
    }
}
