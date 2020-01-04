using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_HomeTasks_01_4_For
{
    class Program
    {
        private static int index = 0;
        static void Main(string[] args)
        {
            List<string> menuItem = new List<string>()
             {
                    "1.Найти сумму четных чисел и их количество в диапазоне от 1 до 99",
                    "2.Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)",
                    "3.Найти корень натурального числа с точностью до целого(рассмотреть вариант последовательного подбора и метод бинарного поиска)",
                    "4.Вычислить факториал числа n",
                    "5.Вывести число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321",
                    "6.Таблицу перевода расстояний в дюймах в сантиметры для значений 2, 4, 6, …, 12 дюймов(1 дюйм = 25.4 мм);",
                    "7.Кубы всех целых чисел из диапазона от А до В(А <= В) в обратном порядке;",
                    "8.Bсе целые числа из диапазона от А до В(А<= В), оканчивающиеся на цифру Х или У;",
                    "9.Bсе целые числа из диапазона от А до В(А<= В), оканчивающиеся на любую четную цифру;",
                    "10.Bсе двухзначные числа, в записи которых все цифры разные;",
                    "11.Bсе двухзначные числа, в которых старшая цифра отличается от младшей не больше чем на 1;",
                    "12.Bсе трехзначные числа, в которых все цифры повторяются.",
                "Exit"
             };
            Console.CursorVisible = false;


            while (true)
            {
                string selectedMenuItem = drawMenu(menuItem);
                switch (selectedMenuItem)
                {
                    case "1.Найти сумму четных чисел и их количество в диапазоне от 1 до 99":
                        {
                            Console.Clear();
                            Console.WriteLine("Диапазон чисел от 1 до 99");
                            int quantity = 0;
                            int sum = 0;
                            for (int i = 1; i <= 99; i++)
                            {

                                if (i % 2 == 0)
                                {
                                    quantity++;
                                    sum += i;
                                }
                            }
                            Console.WriteLine($"Sum = {sum} and count = {quantity} ");
                            Console.Read();
                            break;
                        }
                    case "2.Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)":
                        {
                            Console.Clear();
                            int x;
                            bool result = true;
                            RightNumber:
                            Console.WriteLine("Введите число: ");
                            while (!int.TryParse(Console.ReadLine(), out x))
                            {
                                Console.WriteLine("Можно вводить только цифры!");
                                goto RightNumber;
                            }
                            if (x != 0)
                            {
                                for (int i = 2; i <= x / 2; i++)
                                {
                                    if (x % i == 0) result = false;
                                }
                                if (result) Console.WriteLine(x + " - Число простое");
                                else Console.WriteLine(x + "- Число не простое");

                            }
                            else Console.WriteLine("Вы ввели ноль!!!");
                            Console.Read();
                            break;
                        }
                    case "3.Найти корень натурального числа с точностью до целого(рассмотреть вариант последовательного подбора и метод бинарного поиска)":
                        {
                            Console.Clear();
                            double x3;
                            double num = 0;
                            double numEnd;
                            double rez = 0;
                            for (; ; )
                            {
                                Console.WriteLine("Enter a number more 0: ");
                                if (!double.TryParse(Console.ReadLine(), out x3))
                                {
                                    Console.WriteLine("Error!!! Need a number!");
                                }
                                else if (x3 == 0) Console.WriteLine("Number more 0!!!");
                                else { numEnd = x3; break; }
                            }
                            //последовательный поиск
                            Console.Write($"Koren {numEnd} = ");
                            for (; x3 > 0; x3 -= num)
                            {
                                num += 2;
                                rez += (x3 < 0) ? 0 : 1;
                            }
                            Console.WriteLine($"{rez} ");
                            //бинарный поиск
                            Console.Write($"Koren {numEnd} = ");
                            double l = 0, r = numEnd;
                            double delta = 0.000000001;
                            double p;
                            while (true)
                            {
                                p = (l + r) / 2;

                                var attempt = p * p;

                                if (Math.Abs(numEnd - attempt) < delta)
                                    break;
                                else if (attempt > numEnd)
                                    r = p;
                                else
                                    l = p;
                            }
                            Console.WriteLine(p);
                            Console.Read();
                            break;
                        }
                    case "4.Вычислить факториал числа n":
                        {
                            Console.Clear();
                            int n = 5;
                            int factorial = 1;
                            for (int i = 1; i <= n; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine("Факториал числа {0} равен {1}", n, factorial);
                            Console.Read();
                            break;
                        }
                    case "5.Вывести число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321":
                        {
                            Console.Clear();
                            Console.Write("Enter number: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.Write("Number revers: ");
                            do
                            {
                                Console.Write(x % 10);
                            } while ((x /= 10) != 0);
                            Console.Read();
                            break;
                        }
                    case "6.Таблицу перевода расстояний в дюймах в сантиметры для значений 2, 4, 6, …, 12 дюймов(1 дюйм = 25.4 мм);":
                        {
                            Console.Clear();
                            Console.WriteLine("Таблица перевода расстояния в дюймах в сантиметры");
                            for (int i = 2; i <= 12; i += 2)
                            {
                                double c = 25.4;
                                Console.WriteLine("{0} дюйма = {1:0.00} см", i, (c * i) / 100);
                            }
                            Console.Read();
                            break;
                        }
                    case "7.Кубы всех целых чисел из диапазона от А до В(А <= В) в обратном порядке;":
                        {
                            Console.Clear();
                            int x, y;
                            for (; ; )
                            {
                                NumberOne:
                                Console.WriteLine("Enter first number (begin diapason): ");
                                if (!int.TryParse(Console.ReadLine(), out x))
                                {
                                    Console.WriteLine("Error!");
                                    goto NumberOne;
                                }
                                else
                                {
                                    NumberTwo:
                                    Console.WriteLine("Enter second number (end diapason): ");
                                    if (!int.TryParse(Console.ReadLine(), out y))
                                    {
                                        Console.WriteLine("Error!");
                                        goto NumberTwo;
                                    }
                                    else break;
                                }
                            }
                            if (x <= y)
                            {
                                for (int i = y; i >= x; i--)
                                {
                                    Console.Write(Math.Pow(i, 3) + " ");
                                }
                            }
                            else
                            {
                                for (int i = x; i >= y; i--)
                                {
                                    Console.Write(Math.Pow(i, 3) + " ");
                                }
                            }
                            Console.Read();
                            break;
                        }
                    case "8.Bсе целые числа из диапазона от А до В(А<= В), оканчивающиеся на цифру Х или У;":
                        {
                            Console.Clear();
                            int x, y;
                            for (; ; )
                            {
                                NumberOne:
                                Console.WriteLine("Enter first number (begin diapason): ");
                                if (!int.TryParse(Console.ReadLine(), out x))
                                {
                                    Console.WriteLine("Error!");
                                    goto NumberOne;
                                }
                                else
                                {
                                    NumberTwo:
                                    Console.WriteLine("Enter second number (end diapason): ");
                                    if (!int.TryParse(Console.ReadLine(), out y))
                                    {
                                        Console.WriteLine("Error!");
                                        goto NumberTwo;
                                    }
                                    else break;
                                }
                            }
                            Console.WriteLine("***1 and ****2");
                            if (x <= y)
                            {
                                for (int i = x; i <= y; i++)
                                {
                                    if (i % 10 == 1 || i % 10 == 2)
                                        Console.Write(i + " ");
                                }
                            }
                            else
                            {
                                for (int i = y; i <= x; i++)
                                {
                                    if (i % 10 == 1 || i % 10 == 2)
                                        Console.Write(i + " ");
                                }
                            }
                            Console.Read();
                            break;
                        }
                    case "9.Bсе целые числа из диапазона от А до В(А<= В), оканчивающиеся на любую четную цифру;":
                        {
                            Console.Clear();
                            int x, y;
                            for (; ; )
                            {
                                NumberOne:
                                Console.WriteLine("Enter first number (begin diapason): ");
                                if (!int.TryParse(Console.ReadLine(), out x))
                                {
                                    Console.WriteLine("Error!");
                                    goto NumberOne;
                                }
                                else
                                {
                                    NumberTwo:
                                    Console.WriteLine("Enter second number (end diapason): ");
                                    if (!int.TryParse(Console.ReadLine(), out y))
                                    {
                                        Console.WriteLine("Error!");
                                        goto NumberTwo;
                                    }
                                    else break;
                                }
                            }
                            Console.WriteLine(" x % 2 == 0 ");
                            if (x <= y)
                            {
                                for (int i = x; i <= y; i++)
                                {
                                    if (i % 2 == 0)
                                        Console.Write(i + " ");
                                }
                            }
                            else
                            {
                                for (int i = y; i <= x; i++)
                                {
                                    if (i % 2 == 0)
                                        Console.Write(i + " ");
                                }
                            }
                            Console.Read();
                            break;
                        }
                    case "10.Bсе двухзначные числа, в записи которых все цифры разные;":
                        {
                            Console.Clear();
                            for (int i = 10; i < 100; i++)
                            {
                                if (i / 10 != i % 10) Console.Write(i + " ");
                            }
                            Console.Read();
                            break;
                        }
                    case "11.Bсе двухзначные числа, в которых старшая цифра отличается от младшей не больше чем на 1;":
                        {
                            Console.Clear();
                            for (int i = 10; i < 100; i++)
                            {
                                if ((i / 10 - i % 10) == 1) Console.Write(i + " ");
                            }
                            Console.Read();
                            break;
                        }
                    case "12.Bсе трехзначные числа, в которых все цифры повторяются.":
                        {
                            Console.Clear();
                            for (int i = 100; i < 1000; i++)
                            {
                                int sotni = i / 100;
                                int des = (i % 100) / 10;
                                int ed = i % 10;
                                if (sotni == des && sotni == ed)
                                    Console.Write(i + " ");
                            }
                            Console.Read();
                            break;
                        }
                    case "Exit": Environment.Exit(0); break;
                }
                Console.Clear();
            }
        }

        private static string drawMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == items.Count - 1)
                {
                    index = 0;
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[index];

            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";

        }
    }
}
