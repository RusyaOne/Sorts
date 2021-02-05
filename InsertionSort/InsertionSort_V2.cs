using System;

namespace Sorts
{
    class InsertionSort_V2
    {
        // {4, 3, 10, 16, 0, 18, 4, 35, 4, 77, 0};
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                int tempIndex = i;
                while(tempIndex > 0 && current < array[tempIndex - 1])
                {
                    WriteFromPrevious(ref array[tempIndex - 1], ref array[tempIndex]); 
                    tempIndex--;
                }   

                array[tempIndex] = current;
            }                                  
        }

        private void WriteFromPrevious(ref int a, ref int b)
        {
            b = a;
        }
    }
}