using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_007_HomeTask_SearchSort
{
    class Program
    {
        private static int index = 0;
        static void BubbleSort(int[] arr)
        {
            //перебираем элементы массива (без последнего)
            for(int i = 0; i < arr.Length-1; i++)
            {
                //перебираеь все элементы справа от i
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }                
            }
        }

        static void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                
                    if (arr[j] < arr[min]) min = j;
                    if (min != i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[min];
                        arr[min] = temp;
                    }
            }
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int x = arr[(left + right) / 2];
            do
            {
                while (arr[i] < x) ++i;
                while (arr[j] > x) --j;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) QuickSort(arr, left, j);
            if (i < right) QuickSort(arr, i, right);
        }

        static int IndexOf(ref int[] arr, int Value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == Value) return i;
            return -1;
        }

        static int IndexOfDixot(ref int[] arr, int Value,
            int Left, int Right)
        {
            int x = (Left + Right) / 2;
            if (arr[x] == Value) return x;
            if ((x == Left) || (x == Right)) return -1;
            if (arr[x] < Value)
                return IndexOfDixot(ref arr, Value, x, Right);
            else
                return IndexOfDixot(ref arr, Value, Left,x);
        }

        static void SortBackForth(int[] arr, int size, int x)
        {
            if (x == 0)
            {
                //перебираем элементы массива (без последнего)
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    //перебираеь все элементы справа от i
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            else
            //перебираем элементы массива (без последнего)
            for (int i = arr.Length - 1; i > 0; i--)
            {
                //перебираеь все элементы справа от i
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Initializ(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }            
        }

        static void Show(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> menuItem = new List<string>()
            {
                "TheorySearchSort\n",
                "HomeWork_Task: ",
                "1. Дан массив чисел размерностью 10 элементов.\n" +
                " Написать  функцию, которая сортирует массив по возрастанию \n" +
                " или по убыванию, в зависимости от третьего параметра функции.\n" +
                " Если он равен 1, сортировка идет по убыванию, если 0, то по возрастанию.\n " +
                "Первые 2 параметра функции — это массив и его размер, третий параметр по умолчанию равен 1.\n",
                "2. Дан массив случайных чисел в диапазоне от –20 до +20.\n" +
                "  Необходимо найти позиции крайних отрицательных  элементов\n" +
                " (самого левого отрицательного элемента и самого правого отрицательного элемента)\n" +
                " и отсортировать элементы, находящиеся между ними.\n",
                "Exit"
            };
            Console.CursorVisible = false;

            while (true)
            {
                string selectdMenuItem = drawMenu(menuItem);
                switch (selectdMenuItem)
                {
                    case "TheorySearchSort\n":
                        {
                            Console.Clear();
                            
                            int[] arr1 = new int[6];
                            Initializ(arr1);
                            Show(arr1);
                            BubbleSort(arr1);
                            Show(arr1);

                            int[] arr2 = new int[6];
                            Initializ(arr2);
                            Show(arr2);
                            SelectionSort(arr2);
                            Show(arr2);

                            int[] arr3 = new int[6];
                            Initializ(arr3);
                            Show(arr3);
                            int left = 0;
                            int right = arr3.Length - 1;
                            QuickSort(arr3, left, right);
                            Show(arr3);

                            int[] arr4 = new int[10];
                            Initializ(arr4);
                            Show(arr4);
                            Console.Write("Written number search in massiv: ");
                            try
                            {
                                int x = int.Parse(Console.ReadLine());
                                int y = IndexOf(ref arr4, x);
                                if (y >= 0)
                                {
                                    Console.WriteLine("Search {0} in massiv whis index[{1}]", x, y);
                                }
                                else Console.WriteLine("Search {0} not this massiv", x);
                                int[] arr5 = new int[10];
                                Initializ(arr5);
                                BubbleSort(arr5);
                                Show(arr5);
                                Console.Write("Written number search in massiv: ");
                                x = int.Parse(Console.ReadLine());
                                left = 0;
                                right = arr5.Length - 1;
                                y = IndexOfDixot(ref arr5, x, left, right);
                                if (y >= 0)
                                {
                                    Console.WriteLine("Search {0} in massiv whis index[{1}]", x, y);
                                }
                                else Console.WriteLine("Search {0} not this massiv", x);
                            }
                            catch
                            {
                                Console.WriteLine("Error!!! Please, number written: ");
                            };  
                            Console.Read();
                            break;
                        }
                    case "1. Дан массив чисел размерностью 10 элементов.\n" +
                            " Написать  функцию, которая сортирует массив по возрастанию \n" +
                            " или по убыванию, в зависимости от третьего параметра функции.\n" +
                            " Если он равен 1, сортировка идет по убыванию, если 0, то по возрастанию.\n " +
                            "Первые 2 параметра функции — это массив и его размер, третий параметр по умолчанию равен 1.\n":
                        {
                            Console.Clear();
                            
                            int[] arr1 = new int[8];
                            Initializ(arr1);
                            Show(arr1);
                            int size = arr1.Length;
                            SortBackForth(arr1, size, 1);
                            Show(arr1);
                            SortBackForth(arr1, size, 0);
                            Show(arr1);
                            Console.Read();
                            break;
                        }

                    case "2. Дан массив случайных чисел в диапазоне от –20 до +20.\n" +
                            "  Необходимо найти позиции крайних отрицательных  элементов\n" +
                            " (самого левого отрицательного элемента и самого правого отрицательного элемента)\n" +
                            " и отсортировать элементы, находящиеся между ними.\n":
                        {
                            Console.Clear();
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
            for(int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;

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
