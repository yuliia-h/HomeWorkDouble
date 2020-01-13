using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_009_HomeTask_2_massiv
{
    class Program
    {
        private static int index = 0;

        static void Initialization(int[,] mas)
        {
            for(int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = i + j;
                }
            }
        }

        static void Show(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }                
            }
        }
        static void ArithveticOddElementsUpTrack(int[,] mas)
        {
            int age = 0;
            for (int i = 0; i < mas.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j - i == 1)
                    {
                        if (mas[i, j] % 2 != 0)
                        {
                            age += mas[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("Age odd elements = {0}.", age);
        }

        static void ArithvetMeanEvenElementsBelowTrack(int[,] mas)
        {
            int sum = 0;
            int k = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i - j == 1)
                    {
                        if (mas[i, j] % 2 == 0)
                        {
                            sum += mas[i, j];
                            k++;
                        }
                    }
                }
            }
            if (k == 0) Console.WriteLine("Not even elements!!!");
            else
                Console.WriteLine("Age even elements = {0}.", sum / k);
        }

        static void SumElementsSideDiagonal(int[,] mas)
        {
            int x = mas.GetLength(0);
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == x - i - 1)
                    {
                        sum += mas[i, j];
                    }
                }
            }
            Console.WriteLine("SumElementsSideDiagonal = {0}.", sum);
        }

        static void ArithmeticMeanElementsAboveSideDiagonal(int[,] mas)
        {
            int x = mas.GetLength(0);
            int k = 0;
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == x - i - 2)
                    {
                        if (mas[i, j] != 0)
                        {
                            sum += mas[i, j];
                            k++;
                        }
                    }
                }
            }
            if (k == 0) Console.WriteLine("Not even elements!!!");
            else
                Console.WriteLine("Age elements !=0 : {0}; where sum = {1}, qt. = {2}", sum / k, sum, k);
        }

        static void ArithmeticMeanElementsBelowSideDiagonal(int[,] mas)
        {
            int x = mas.GetLength(0);
            int k = 0;
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i > 0 && j == x - i)
                    {
                        sum += mas[i, j];
                        k++;
                    }
                }
            }
            if (k == 0) Console.WriteLine("Not count!!!");
            else
                Console.WriteLine("Age elements Below Side Diagonal: {0}; where sum = {1}, qt. = {2}", sum / k, sum, k);
        }

        static void SwapColumns(int[,] mas)
        {
            int y = mas.GetLength(0);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1) / 2; j++)
                {
                    {
                        int x = mas[i, j];
                        mas[i, j] = mas[i, (y - 1) - j];
                        mas[i, (y - 1) - j] = x;
                    }
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SwapRowIfEvenRow(int[,] mas)
        {
            int n = 0;
            int m = 0;

            if (mas.GetLength(0) % 2 == 0)
            {
                n = mas.GetLength(0) / 2 - 1;
                m = mas.GetLength(1) / 2;
            }
            else
            {
                m = mas.GetLength(0) / 2;
            }

            for (int i = 0; i < mas.GetLength(0) - 1; i++)
            {
                int temp = mas[n, i];
                mas[n, i] = mas[m, i];
                mas[m, i] = temp;
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SwapColumnsIfEvenColumns(int[,] mas)
        {
            int n = 0;
            int m = 0;

            if (mas.GetLength(1) % 2 == 0)
            {
                n = mas.GetLength(0) / 2 - 1;
                m = mas.GetLength(1) / 2;
            }
            else
            {
                m = mas.GetLength(0) / 2;
            }

            for (int i = 0; i < mas.GetLength(1) - 1; i++)
            {
                int temp = mas[i, n];
                mas[i, n] = mas[i, m];
                mas[i, m] = temp;
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0}\t", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SwapRowIfEvenRowOneTwo(int[,] mas)
        {
            if (mas.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < mas.GetLength(0) - 1; i += 2)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        int temp = mas[i + 1, j];
                        mas[i + 1, j] = mas[i, j];
                        mas[i, j] = temp;
                    }
                }

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mas[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mas[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void SwapColumsIfEvenColulmnsOneTwo(int[,] mas)
        {
            if (mas.GetLength(1) % 2 == 0)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1) - 1; j += 2)
                    {
                        int temp = mas[i, j + 1];
                        mas[i, j + 1] = mas[i, j];
                        mas[i, j] = temp;
                    }
                }

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mas[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mas[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void MatrixDeterminant(int[,] mas)
        {            
            int temp1 = mas[0, 0],
                temp2 = mas[0, 1],
                temp3 = mas[0, 2],
                temp4 = mas[1, 0],
                temp5 = mas[1, 1],
                temp6 = mas[1, 2],
                temp7 = mas[2, 0],
                temp8 = mas[2, 1],
                temp9 = mas[2, 2];

            int Determinant = (temp1*temp9*temp5)+
                              (temp2*temp6*temp7)+
                              (temp3*temp4*temp8)-
                              (temp3*temp5*temp7)-
                              (temp1*temp6*temp7)-
                              (temp2*temp4*temp9);
            Console.WriteLine("Determinant = {0}", Determinant);

        }
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            List<string> menuItem = new List<string>() 
            {
                "1.  Подсчитать среднее арифметическое четных элементов, расположенных ниже главной диагонали.",
                "2.  Подсчитать сумму элементов, расположенных на побочной диагонали.",
                "3.  Подсчитать среднее арифметическое ненулевых элементов, расположенных над побочной диагональю.",
                "4.  Подсчитать среднее арифметическое элементов, расположенных под побочной диагональю.",
                "5.  Поменять местами столбцы по правилу: первый с последним, второй с предпоследним и т.д.",
                "6.  Поменять местами две средних строки, если количество строк четное, и первую со средней строкой, если количество строк нечетное.",
                "7.  Поменять местами два средних столбца, если количество столбцов четное, и первый со средним столбцом, если количество столбцов нечетное.",
                "8.  Если количество строк в массиве четное, то поменять строки местами по правилу: первую строку со второй, третью -с четвертой и т.д.Если количество строк в массиве нечетное, то оставить массив без изменений.",
                "9.  Если количество столбцов в массиве четное, то поменять столбцы местами по правилу: первый столбец со вторым, третий -с четвертым и т.д.Если количество столбцов в массиве нечетное, то оставить массив без изменений.",
                "10. Вычислить An, где n - натуральное число.",
                "Exit"
            };
            Console.CursorVisible = false;
            

            while (true)
            {
                string selectdMenuItem = drawMenu(menuItem);
                switch (selectdMenuItem)
                {
                    case "1.  Подсчитать среднее арифметическое четных элементов, расположенных ниже главной диагонали.":
                        {
                            Console.Clear();
                            Initialization(arr);
                            Show(arr);
                            ArithvetMeanEvenElementsBelowTrack(arr);
                            Console.Read();
                            break;
                        }

                    case "2.  Подсчитать сумму элементов, расположенных на побочной диагонали.":
                        {
                            Console.Clear();
                            Show(arr);
                            SumElementsSideDiagonal(arr);
                            Console.Read();
                            break;
                        }

                    case "3.  Подсчитать среднее арифметическое ненулевых элементов, расположенных над побочной диагональю.":
                        {
                            Console.Clear();
                            Show(arr);
                            ArithmeticMeanElementsAboveSideDiagonal(arr);
                            Console.Read();
                            break;
                        }

                    case "4.  Подсчитать среднее арифметическое элементов, расположенных под побочной диагональю.":
                        {
                            Console.Clear();
                            Show(arr);
                            ArithmeticMeanElementsBelowSideDiagonal(arr);
                            Console.Read();
                            break;
                        }

                    case "5.  Поменять местами столбцы по правилу: первый с последним, второй с предпоследним и т.д.":
                        {
                            Console.Clear();
                            Show(arr);
                            SwapColumns(arr);
                            Console.Read();
                            break;
                        }

                    case "6.  Поменять местами две средних строки, если количество строк четное, и первую со средней строкой, если количество строк нечетное.":
                        {
                            Console.Clear();
                            Show(arr);
                            SwapRowIfEvenRow(arr);
                            break;
                        }

                    case "7.  Поменять местами два средних столбца, если количество столбцов четное, и первый со средним столбцом, если количество столбцов нечетное.":
                        {
                            Console.Clear();
                            Show(arr);
                            SwapColumnsIfEvenColumns(arr);
                            Console.Read();
                            break;
                        }

                    case "8.  Если количество строк в массиве четное, то поменять строки местами по правилу: первую строку со второй, третью -с четвертой и т.д.Если количество строк в массиве нечетное, то оставить массив без изменений.":
                        {
                            Console.Clear();
                            Show(arr);
                            SwapRowIfEvenRowOneTwo(arr);
                            Console.Read();
                            break;
                        }

                    case "9.  Если количество столбцов в массиве четное, то поменять столбцы местами по правилу: первый столбец со вторым, третий -с четвертым и т.д.Если количество столбцов в массиве нечетное, то оставить массив без изменений.":
                        {
                            Console.Clear();
                            Show(arr);
                            SwapColumsIfEvenColulmnsOneTwo(arr);
                            Console.Read();
                            break;
                        }

                    case "10. Вычислить An, где n - натуральное число.":
                        {
                            Console.Clear();
                            int[,] arr2 = new int[3, 3];
                            Initialization(arr2);
                            Show(arr2);
                            MatrixDeterminant(arr2);                            
                            Console.Read();
                            break;
                        }

                    case "Exit":
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.Clear();
            }
           
        }

        private static string drawMenu(List<string> items)
        {
            Console.WriteLine("***********************HomeTask_2_massiv**********************\n");

            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
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
                else index++;
            }

            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = items.Count - 1;
                }
                else index--;
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
