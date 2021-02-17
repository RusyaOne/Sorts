namespace Sorts
{
    class InsertionSortCustomStep
    {
        public void Sort(int[] array, int step, int subArrayPosition)
        {
            for (int i = step + subArrayPosition; i < array.Length; i += step)
            {
                var current = array[i];
                int tempIndex = i;
                while(tempIndex > subArrayPosition && current < array[tempIndex - step])
                {
                    WriteFromPrevious(ref array[tempIndex - step], ref array[tempIndex]);
                    tempIndex -= step;
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