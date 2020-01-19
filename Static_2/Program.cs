using System;

namespace Static_2
{
    static class ArrayExtension
    {
        public static void SortAscending(this int[] arr, int first, int last)//quicksort
        {
            if (first < last)
            {
                int middle = arr[(first + last) / 2];
                int i = first, j = last;
                while (i <= j)
                {
                    while (i <= last && arr[i] < middle) ++i;
                    while (j >= first && arr[j] > middle) --j;
                    if (i <= j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i; --j;
                    }
                }
                if (i < last) SortAscending(arr, i, last);
                if (j > first) SortAscending(arr, first, j);

            }
        }
        public static void SortByDecreasing(this int[] arr, int first, int last)
        {
            if (first < last)
            {
                int middle = arr[(first + last) / 2];
                int i = first, j = last;
                while (i <= j)
                {
                    while (i <= last && arr[i] > middle) ++i;
                    while (j >= first && arr[j] < middle) --j;
                    if (i <= j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i; --j;
                    }
                }
                if (i < last) SortByDecreasing(arr, i, last);
                if (j > first) SortByDecreasing(arr, first, j);
            }
        }
        public static void SortByBool(this int[] arr, int first, int last, bool way)
        {
            if (way) //asceding
                SortAscending(arr, first, last);
            else  //decreasing
            {
                SortByDecreasing(arr, first, last);
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = new int[] { 126, 9, 7745, 56, 82, 123, 564, 5, 66, 71, 2503, 809, 74 };
                Console.WriteLine("Массив перед сортировкой:");
                foreach (int a in arr)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine("Если вы хотите отсортировать массив по возрастанию, то введите 0, если по убыванию, то 1.");
                if (Console.ReadLine() == "0")
                {
                    arr.SortByBool(0, arr.Length - 1, true);
                    foreach (int a in arr)
                    {
                        Console.WriteLine(a);
                    }
                }
                else if (Console.ReadLine() == "1")
                {
                    arr.SortByBool(0, arr.Length - 1, false);
                    foreach (int a in arr)
                    {
                        Console.WriteLine(a);
                    }
                }
                else
                    Console.WriteLine("Некорректный ввод!");

                Console.ReadKey();
            }
        }
 }

