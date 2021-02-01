using System;

namespace Sorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] array = new int [] {4, 5, 2, 8, 3, 5, 1, 0, 2, 9};
            bubbleSort.Sort(ref array);

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}