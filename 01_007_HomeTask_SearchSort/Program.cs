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

        static void NegativElement(int[] arr)
        {
            int left=0, right=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    left = i;
                    break;
                }
            }

            for (int i = arr.Length-1; i >=0; i--)
            {
                if (arr[i] < 0)
                {
                    right = i;
                    break;
                }
            }
            
            for (int i = left+1; i < right; i++)
            {
                //перебираеь все элементы справа от i
                for (int j = i + 1; j < right; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Result: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }

        static void RandomFunc(int[] arr)
        {
            Random rnd = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 21);
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                        i--;
                }
            }
        }

        static void RandomNumberCount(int[] arr)
        {
            Random rnd = new Random();
            int number = rnd.Next(arr.Length);
            int position = 0;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    position = i;
                    Console.WriteLine("Position number {0} arr[{1}]", number, i);
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                    
                }
            }
            Console.WriteLine("Number {0} count {1}", number, count);

            if (position == 0 || position == 1)
            {
                for (int i = position; i < arr.Length - 1; i++)
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
            else if(position==arr.Length-1 || position == arr.Length - 2)
            {
                for (int i = position; i > 0; i--)
                {
                    //перебираеь все элементы справа от i
                    for (int j = i - 1; j < position; j--)
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
            {
                for (int i = 0; i < position-1; i++)
                {
                    //перебираеь все элементы справа от i
                    for (int j = i + 1; j < position; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                for (int i = position+1; i < arr.Length - 1; i++)
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
        }

        static void CountArr(int[,] arr)
        {
            int sumRow = 0;
            int sumColumn = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sumColumn = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sumRow += arr[i, j];
                    sumColumn += arr[i, j];
                    Console.Write(arr[i, j] + "  ");
                    if (j == arr.GetLength(1) - 1) Console.Write(" | "+sumRow);
                    if (i == arr.GetLength(0)-1 && j==arr.GetLength(1)-1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-------------");

                        for (i = 0; i < arr.GetLength(0); i++)
                        {
                            sumColumn = 0;
                            for (j = 0; j < arr.GetLength(1); j++)
                            {                               
                                sumColumn += arr[j, i];
                            }
                            Console.Write(sumColumn+" ");
                            
                        }
                    }
                    


                }
                sumRow = 0;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Initializ(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-20, 21);
            }            
        }

        static void Initializ(int[,] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 10);
                }
            }
        }

        static void Show(int[,] arr)
        {            
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
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
                "3. Дан массив из 20 целых чисел со значениями от 1 до 20. Необходимо:\n"+
                "■  написать функцию, разбрасывающую элементы массива произвольным образом;\n"+
                "■  создать случайное число из того же диапазона и найти позицию(первую) этого случайного числа в массиве и сколько раз оно встречается;\n"+
                "■  отсортировать элементы массива, находящиеся слева от найденной позиции по убыванию, а элементы массива,\n"+
                " находящиеся справа от найденной позиции по возрастанию.",
                "4.  Создайте двумерный массив. Заполните его случайными числами и покажите на экран.\n"+
                "    Пользователь выбирает количество сдвигов и положение (влево, вправо, вверх, вниз).\n"+
                "    Выполнить сдвиг массива и показать на экран полученный результат. Сдвиг циклический.",
                "5.  В двумерном массиве целых чисел подсчитать сумму элементов: в каждой строке; в каждом столбце; одновременно по всем строкам и всем столбцам.",
                "6.  Создайте двумерный массив. Заполните его случайными числами и покажите на экран.\n"+
                "  Пользователь выбирает количество сдвигов и положение (влево, вправо, вверх, вниз). Выполнить сдвиг массива и показать на экран полученный результат. Сдвиг циклический.",

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

                            int[] arr1 = new int[20];
                            Initializ(arr1);
                            Show(arr1);
                            NegativElement(arr1);

                            Console.Read();
                            break;
                        }

                    case "3. Дан массив из 20 целых чисел со значениями от 1 до 20. Необходимо:\n" +
                            "■  написать функцию, разбрасывающую элементы массива произвольным образом;\n" +
                            "■  создать случайное число из того же диапазона и найти позицию(первую) этого случайного числа в массиве и сколько раз оно встречается;\n" +
                            "■  отсортировать элементы массива, находящиеся слева от найденной позиции по убыванию, а элементы массива,\n" +
                            " находящиеся справа от найденной позиции по возрастанию.":
                        {
                            Console.Clear();

                            int[] arr1 = new int[20];
                            for (int i = 0; i < arr1.Length; i++) arr1[i] = i+1;
                            Show(arr1);
                            RandomFunc(arr1);
                            Show(arr1);
                            RandomNumberCount(arr1);
                            Show(arr1);

                            Console.Read();
                            break;
                        }

                    case "4.  Создайте двумерный массив. Заполните его случайными числами и покажите на экран.\n" +
                            "    Пользователь выбирает количество сдвигов и положение (влево, вправо, вверх, вниз).\n" +
                            "    Выполнить сдвиг массива и показать на экран полученный результат. Сдвиг циклический.":
                        {
                            Console.Clear();
                            Random rnd = new Random();
                            int[,] arr2 = new int[5, 5];
                            Initializ(arr2);
                            Show(arr2);

                            Console.Write("Enter count shift: ");
                            int shift = int.Parse(Console.ReadLine());
                            Console.Write("Enter down=1, up=2, left=3, right=4 : ");
                            int direction = int.Parse(Console.ReadLine());



                            Console.Read();
                            break;
                        }

                    case "5.  В двумерном массиве целых чисел подсчитать сумму элементов: в каждой строке; в каждом столбце; одновременно по всем строкам и всем столбцам.":
                        {
                            Console.Clear();

                            int[,] arr = new int[3, 3];
                            Initializ(arr);
                            Show(arr);
                            CountArr(arr);


                            Console.Read();
                            break;
                        }

                    case "6.  Создайте двумерный массив. Заполните его случайными числами и покажите на экран.\n" +
                            "  Пользователь выбирает количество сдвигов и положение (влево, вправо, вверх, вниз). Выполнить сдвиг массива и показать на экран полученный результат. Сдвиг циклический.":
                        {
                            Console.Clear();
                            int[,] vs = new int[2, 6];
                            Initializ(vs);
                            Show(vs);
                            Console.Write("Enter count shift: ");
                            int shift = int.Parse(Console.ReadLine());
                            Console.Write("Enter down=1, up=2, left=3, right=4 : ");
                            int direction = int.Parse(Console.ReadLine());


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
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

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
