using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_04_HW_array_sorting
{
    class Program
    {

        static void InitializationArray(int[] ar)
        {
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(-100, 100);
            }
        }

        static void InitializationArray(double[] ar)
        {
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.NextDouble() * 201 - 100;
            }
        }

        static void InitializationArray(string[] ar)
        {
            Random rand = new Random();
            string[] Names = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska", "Maggie", "Penny",
                          "Saya", "Princess", "Abby", "Laila",
                          "Sadie", "Olivia", "Starlight", "Talla" };

            int[] vs = new int[ar.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = rand.Next(Names.Length);
            }

            for (int i = 0; i < vs.Length; i++)
            {
                ar[i] = Names[vs[i]];
            }
        }

        static void InitializationArray(bool[] ar)
        {
            Random rand = new Random();
            int[] vs = new int[ar.Length];

            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = rand.Next(0, 2);
            }

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToBoolean(vs[i]);
            }
        }

        static void Show(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write($"{ar[i]} ");
            Console.WriteLine();
        }
        static void Show(double[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write($"{ar[i]:#.##} ");
            Console.WriteLine();
        }
        static void Show(string[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write($"{ar[i]} ");
            Console.WriteLine();
        }
        static void Show(bool[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write($"{ar[i]} ");
            Console.WriteLine();
        }

        static int MinElement(int[] ar)
        {
            int x = ar[0], temp = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (x > ar[i])
                {
                    x = ar[i];
                    temp = i;
                }
            }
            Console.WriteLine("Index minElementa = " + temp);
            return x;
        }

        static int MaxElement(int[] ar)
        {
            int x = ar[0], temp = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (x < ar[i]) x = ar[i];
            }
            Console.WriteLine("Index maxElementa = " + temp);
            return x;
        }

        static int SumNot(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (i % 2 != 0) sum += ar[i];
            }

            return sum;
        }

        static void ReverseArray(int[] ar)
        {
            int[] arRever = new int[ar.Length];
            for (int i = ar.Length - 1; i >= 0; i--)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }

        static void CountNot(int[] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 != 0) count++;
            }
            Console.WriteLine("Count not elements for array = " + count);
        }

        static void ChangePlace(int[] ar)
        {
            Console.WriteLine("Data array: ");
            for (int i = 0; i < ar.Length; i++) Console.Write(ar[i] + " ");
            Console.WriteLine("\nArray changePlace: ");

            for (int i = ar.Length / 2; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            for (int i = 0; i < ar.Length / 2; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }
        //********************************************Sorting*************************************************************
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
        private static void BubbleSort(int[] data)
        {
            int i, j;
            Console.WriteLine("Array before Bubble Sorting: ");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            for (j = data.Length - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        Swap(data, i, i + 1);
                }
            }
            Console.WriteLine("Array Bubble Sorting: ");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        public static void InsertionSort(int[] data)
        {
            int i, j;
            Console.WriteLine("Array before Insertion Sorting: ");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            for (j = 1; j < data.Length; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                    Swap(data, i, i - 1);
            }

            Console.WriteLine("Array Insertion Sorting: ");
            for (i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        private static void ShellSort(int[] data)
        {
            Console.WriteLine("Array before Shell Sorting: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            int step = data.Length / 2;
            int temp;

            while (step > 0)
            {
                for (int i = 0; i + step < data.Length; i++)
                {
                    int j = i + step;
                    temp = data[j];

                    while (j - step >= 0 && temp < data[j - step])
                    {
                        data[j] = data[j - step];
                        j = j - step;
                    }

                    data[j] = temp;
                }

                step = step / 2;
            }
            Console.WriteLine("Array Shell Sorting: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    Swap(arr, left, right);
                }
                else
                {
                    return right;
                }
            }
        }
        private static void QuickSort(int[] arr, int left, int right)
        {            
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        private static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int middle = array.Length / 2;
            //для лаконичности используем linq    
            return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray()));            
        }

        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                else
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
            }

            return merged;
        }

        static void HeapSort(int[] data)
        {
            var length = data.Length;
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(data, length, i);
            }
            for (int i = length - 1; i >= 0; i--)
            {
                int temp = data[0];
                data[0] = data[i];
                data[i] = temp;
                Heapify(data, i, 0);
            }
        }

        /* Пирамиду можно строить по разному, самый оптимальный вариант - в виде массива,
        где потомки элемента data[i] хранятся в ячейках a[2i+1] и a[2i+2]. 
        */
        static void Heapify(int[] data, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && data[left] > data[largest])
            {
                largest = left;
            }
            if (right < length && data[right] > data[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                Swap(data, i, largest);
                Heapify(data, length, largest);
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[11];
            double[] arrayD = new double[10];
            string[] arrayS = new string[10];
            bool[] arrayB = new bool[10];

            InitializationArray(array);
            InitializationArray(arrayD);
            InitializationArray(arrayS);
            InitializationArray(arrayB);

            Show(array);
            Show(arrayD);
            Show(arrayS);
            Show(arrayB);

            Console.WriteLine("Min element mass = " + MinElement(array));
            Console.WriteLine("Max element mass = " + MaxElement(array));

            Console.WriteLine("SumNot = " + SumNot(array));
            ReverseArray(array);
            CountNot(array);
            ChangePlace(array);

            BubbleSort(array);

            int[] arr2 = new int[8];
            InitializationArray(arr2);
            InsertionSort(arr2);

            int[] arr3 = new int[8];
            InitializationArray(arr3);
            ShellSort(arr3);

            int[] arr4 = new int[8];
            InitializationArray(arr4);
            Console.WriteLine("Array before Quick Sorting: ");
            Show(arr4);
            int left = 0;
            int right = arr4.Length - 1;
            QuickSort(arr4,left,right);
            Console.WriteLine("Array Quick Sorting: ");
            Show(arr4);                      
            Console.WriteLine();

            int[] arr5 = new int[8];
            InitializationArray(arr5);
            Console.WriteLine("Array before Merge Sorting: ");
            Show(arr5);
            MergeSort(arr5);
            Console.WriteLine("Array Merge Sorting: ");
            Show(arr5);
            Console.WriteLine();

            int[] arr6 = new int[8];
            InitializationArray(arr6);
            Console.WriteLine("Array before Heap Sorting: ");
            Show(arr6);
            MergeSort(arr6);
            Console.WriteLine("Array Heap Sorting: ");
            Show(arr6);
            Console.WriteLine();

            Console.Write("Enter number day week: 1-7 ");
            int day = int.Parse(Console.ReadLine());
            string[] dayString = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            day--;
            for (int i = 0; i < dayString.Length; i++)
            {
                if (i == day)
                {
                    Console.WriteLine("This " + dayString[i]);
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
