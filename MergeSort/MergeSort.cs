using System;

namespace Sorts
{
    public class MergeSort
    {
        public void Sort(ref int [] array)
        {
            if (array.Length.Equals(1))
                return;
            
            (int[] left, int[] right) = SplitOnce(array);

            Sort(ref left);

            Sort(ref right);

            array = Merge(left, right);         
        }

        private (int[], int[]) SplitOnce(int[] array)
        {
            int halfLength = array.Length / 2;
            int[] left = array[..halfLength];
            int[] right = array[halfLength..];
            return (left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int[] resultArray = new int[left.Length + right.Length];
            
            do
            {
                if (GetValueByIndexSafe(left, leftIndex) > GetValueByIndexSafe(right, rightIndex))
                {
                    resultArray[leftIndex + rightIndex] = GetValueByIndexSafe(right, rightIndex);
                    rightIndex++;
                }
                else
                {
                    resultArray[leftIndex + rightIndex] = GetValueByIndexSafe(left, leftIndex);
                    leftIndex++;
                }
            } while (leftIndex + rightIndex < resultArray.Length);

            return resultArray;

            int GetValueByIndexSafe(int[] array, int index) =>
                index >= array.Length ? Int32.MaxValue : array[index];
        }
    }
}