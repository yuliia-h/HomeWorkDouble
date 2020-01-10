using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shifts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            int[] Arr = { 1, 2, 3, -4, -5, 6, -7, 8, 9 };
            int i, j, k;
            //k = Arr.Length;//первоначально в массиве все элементы
            //Console.WriteLine("Изначально: ");
            //for (i = 0; i < k; i++) Console.Write(Arr[i] + " ");
            //Console.WriteLine();
            //****************1 вариант*********************************
            //Затем к будет означать колличество оставшиеся после удаления
            //for (i = 0; i < k; i++)
            //{
            //    if (Arr[i] < 0) //условие на удаление элементов массива
            //    {
            //        k--;//уменьшаем колличество
            //        for (j = i; j < k; j++)//сдвиг влево
            //            Arr[j] = Arr[j + 1];
            //        i--;//Снова просматриваем  i-й элемент
            //    }
            //}
            //Console.WriteLine("Итог: ");
            //for (i = 0; i < k; i++) Console.Write(Arr[i] + " ");

            //********************2 вариатнт***************
            //for (i = k - 1; i >= 0; i--)
            //{
            //    if (Arr[i] < 0)
            //    {
            //        k--;
            //        for (j = i; j < k; j++)
            //            Arr[j] = Arr[j + 1];
            //    }
            //}
            //Console.WriteLine("Итог: ");
            //for (i = 0; i < k; i++) Console.Write(Arr[i] + " ");

            //*****************3 вариант**********************
            //k = 0;  //Вначале это позиция, в которую отправляем оставшиеся
            //        //Затем к будет означать кол-во оставшихся 
            //for (i = 0; i < Arr.Length; i++)
            //{
            //    if (!(Arr[i] < 0))
            //    {
            //        Arr[k] = Arr[i];
            //        k++;
            //    }
            //}
            //Console.WriteLine("Итог: ");
            //for (i = 0; i < k; i++) Console.Write(Arr[i] + " ");

            //****************4 вариант*******************
            //перед каждым положительным числом добавить число 0
            int[] arr2 = new int[Arr.Length * 2];
            Random random = new Random();
            for (i = 0; i < Arr.Length; i++)
            {
                arr2[i] = random.Next(-9, 10);
            }
            k = Arr.Length*2;
            Console.WriteLine("Изначально: ");
            for (i = 0; i < k; i++) Console.Write(arr2[i] + " ");
            Console.WriteLine();

            for (i = 0; i < k; i++)
            {
                if (arr2[i] > 0)
                {
                    for (j = k; j > i; j--)
                        arr2[j] =arr2[j - 1];
                    arr2[i] = 0;
                    k++;
                    i++;
                }
            }
            Console.WriteLine("Итог: ");
            for (i = 0; i < k; i++) Console.Write(arr2[i] + " ");

            Console.ReadKey();
        }
    }
}
