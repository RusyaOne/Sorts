using System;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 3, 10, 16, 0, 18, 4, 35, 4, 77, 0};
            InsertionSort_V2 sort = new InsertionSort_V2();
            sort.Sort(array);

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
