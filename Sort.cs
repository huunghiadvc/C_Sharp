using System;

namespace Demo
{
    internal class Sort
    {
        // static void Main(String[] args)
        // {
        //     int[] arr = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 11, 12, 13, 14, 15, 16, 17, 18, 19];

        //     InsertSort(arr);

        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         Console.WriteLine(arr[i]);
        //     }
        // }

        static void InsertSort(int[] arr)
        {
            int v, j;
            for (int i = 1; i < arr.Length; i++)
            {
                v = arr[i];
                j = i;
                while (j >= 1 && arr[j - 1] > v)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = v;
            }
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int k = 0; k <= i - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }

    }
}