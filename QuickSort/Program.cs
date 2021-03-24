using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 8, 5, 4, 7, 2, 4 };

            QuickSortArray(arr, 0, arr.Length-1);
        }

        private static void QuickSortArray(int[] arr, int startIndex, int endIndex)
        {
            if (endIndex - startIndex < 1 )
            {
                return;
            }

            int i = startIndex - 1;

            for (int j = startIndex; j <= endIndex; j++)
            {
                if (arr[j] <= arr[endIndex])
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            QuickSortArray(arr, startIndex, i-1);
            QuickSortArray(arr, i+1, endIndex);
        }

        private static void Swap(ref int a, ref int b)
        {
            int buffer = b;
            b = a;
            a = buffer;
        }
    }
}