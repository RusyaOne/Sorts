using System;

namespace Sorts
{
    public class MergeSort
    {
        public void Sort(ref int [] array)
        {
            //38, 27, 43, 3, 9, 82, 10

            
            (int[] left, int[] right) = SplitOnce(array);




        }

        private Split(){
            
        }


        private (int[], int[]) SplitOnce(int[] array)
        {
            int halfLength = array.Length / 2;
            int[] left = array[..halfLength];
            int[] right = array[halfLength..];
            return (left, right);
        }

        // private int[] Merge(){

        // }
    }
}