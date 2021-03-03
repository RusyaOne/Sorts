using System;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort mergeSort = new MergeSort();
            
            int[] array = new int[] {38, 27, 43, 3, 9, 82, 10};
            mergeSort.Sort(ref array);

            foreach (int element in array)
                Console.Write(element + " ");
        }
    }
}
