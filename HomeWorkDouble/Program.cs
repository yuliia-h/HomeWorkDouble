using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. периметр квадрата, площадь которого равна а
            Console.Write("s=");
            float s = float.Parse(Console.ReadLine());
            double p = 4 * Math.Sqrt(s);
            Console.WriteLine("p=" + p);
            Console.WriteLine(new string('*', 50));

            //2.площадь равностороннего треугольника, периметр которого равен p; 
            Console.WriteLine("Введите периметр " +
                "равностороннего треугольника");
            Console.Write("P = ");
            Int16 P = Int16.Parse(Console.ReadLine());
            int a = P / 3;
            double S = ((Math.Pow(a, 2) * Math.Sqrt(3)) / 4);
            Console.WriteLine("Площадь равностороннего треугольника \n " +
                "равна " + S);
            Console.WriteLine(new string('*', 50));

            //3.среднее арифметическое кубов двух данных чисел;
            Console.WriteLine("Введите два числа:");
            Console.Write("a, b = ");
            float a3 = Int16.Parse(Console.ReadLine());
            float b = Int16.Parse(Console.ReadLine());
            double с = ((Math.Pow(a3, 3) + Math.Pow(b, 3)) / 2);
            Console.WriteLine("Средне арифметичное кубов " +
                "данных чисел \n равн0 " + с);
            Console.WriteLine(new string('*', 50));

            //4.среднее геометрическое модулей двух данных чисел;
            Console.WriteLine("Введите два числа:");
            Console.Write("a, b = ");
            float a4 = Int16.Parse(Console.ReadLine());
            float b4 = Int16.Parse(Console.ReadLine());
            double с4 = ((Math.Abs(a4) + Math.Abs(b4)) / 2);
            Console.WriteLine("Средне геометрическое модулей " +
                "данных чисел \n равно " + с4);
            Console.WriteLine(new string('*', 50));

            //5.площадь прямоугольного треугольника по двум катетам a, b.
            Console.WriteLine("Введите катеты прямоугольного треугольника:");
            Console.Write("a, b = ");
            float a5 = Int16.Parse(Console.ReadLine());
            float b5 = Int16.Parse(Console.ReadLine());
            double с5 = (a * b / 2);
            Console.WriteLine("Площадь прямоугольного треугольника " +
                "равна " + с5);
            Console.WriteLine(new string('*', 50));

            //6.периметр прямоугольного треугольника по двум катетам a, b.
            Console.WriteLine("Введите катеты прямоугольного треугольника:");
            Console.Write("a, b = ");
            float a6 = Int16.Parse(Console.ReadLine());
            float b6 = Int16.Parse(Console.ReadLine());
            double c6 = (Math.Sqrt(Math.Pow(a6, 2) + Math.Pow(b6, 2)));
            double P6 = (int)(c6 + a6 + b6);
            Console.WriteLine("Периметр прямоугольного треугольника " +
                "равен " + P6);
            Console.WriteLine(new string('*', 50));

            //7.ребро куба, площадь полной поверхности которого равна s;
            Console.WriteLine("Введите площадь куба:");
            Console.Write("S = ");
            float S7 = Int16.Parse(Console.ReadLine());
            double a7 = (int)(Math.Sqrt(S7 / 6));
            Console.WriteLine("Ребро куба равно " + a7);
            Console.WriteLine(new string('*', 50));

            //8.периметр и площадь треугольника, заданного координатами вершин x1, y1, x2, y2, x3, y3;
            int x1 = 2, x2 = 4, x3 = 7, y1 = 1, y2 = 6, y3 = 4;
            double perimeter, square;
            Console.WriteLine("Координаты первой вершины: х = "
                + x1 + " y = " + y1);
            Console.WriteLine("Координаты второй вершины: х = "
                + x2 + " y = " + y2);
            Console.WriteLine("Координаты третей вершины: х = "
                + x3 + " y = " + y3);
            perimeter = Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) +
                Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) +
                Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5);
            double p8 = perimeter / 2;
            square = Math.Sqrt((p8 * (p8 - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) *
                (p - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5) *
                (p - Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(y1 - y2, 2), 0.5))))));
            Console.WriteLine("Периметр треугольника по заданным координатам" +
                "равен {0:#.##}", perimeter);
            Console.WriteLine("Площадь треугольна равна {0:#.##}", square);
            Console.WriteLine(new string('*', 50));

            //9.радиус окружности, длина которой равна L;
            Console.WriteLine("Введите длину окружности ");
            int L = int.Parse(Console.ReadLine());
            double _2p = 3.14 * 2;
            double r = L / _2p;
            Console.WriteLine("Радиус окружности равен {0:#,##}", r);
            Console.WriteLine(new string('*', 50));

            //10.площадь кольца с внутренним радиусом r1 и внешним r2;
            Console.WriteLine("Введите внутренний радиус окружности ");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите внешний угол окружносты ");
            int r2 = int.Parse(Console.ReadLine());
            double squareAll;
            squareAll = 3.14 * Math.Pow(r1, 2);
            double square_small;
            square_small = 3.14 * Math.Pow(r2, 2);
            double ring = squareAll - square_small;
            Console.WriteLine("Площадь кольца равна {0:#.##}", ring);
            Console.WriteLine(new string('*', 50));

            //11-13
            Random rand = new Random();
            int temp;

            Console.WriteLine(" ***** 10 случайных чисел *****");
            for (int i = 1; i <= 10; i++)
            {
                temp = rand.Next();
                Console.Write(temp + " ");
            }

            Console.WriteLine("\n\n***** 10 случайных чисел в диапазоне [0;10]");
            for (int f = 1; f <= 10; f++)
            {
                temp = rand.Next(0, 11);
                Console.Write(temp + " ");
            }

            Console.WriteLine("\n\n***** 10 случайных чисел в диапазоне [20;50] *****");
            for (int j = 1; j <= 10; j++)
            {
                temp = rand.Next(20, 51);
                Console.Write(temp + " ");
            }

            Console.WriteLine("\n\n***** 10 случайных чисел в диапазоне [-10;10]******");
            for (int k = 1; k <= 10; k++)
            {
                temp = rand.Next(-10, 11);
                Console.Write(temp + " ");
            }

            Console.WriteLine("\n\n***** [3;15] случайных чисел в диапазоне [-10;35]******");
            temp = rand.Next(3, 16);
            for (int d = 1; d <= temp; d++)
            {

                int temp2 = rand.Next(-10, 35);
                Console.Write(temp2 + " ");
            }

            Console.WriteLine("\n\n****** 5 случайных веществественых чисел в диапазоне [-100;100] *****");
            for (int q = 1; q <= 5; q++)
            {
                double temp3 = Convert.ToDouble(rand.Next(-100, 101));
                Console.Write(temp3 + " ");
            }

            Console.WriteLine("\n\n****** 5 случайных веществественых чисел в диапазоне [-100;100]*****");
            for (int w = 1; w <= 5; w++)
            {
                double temp3;
                temp3 = rand.NextDouble() * 201 - 100;
                Console.Write(" {0:#.##}", temp3);
            }

            Console.ReadKey();
        }
    }
}
