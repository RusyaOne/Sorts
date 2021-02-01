namespace Sorts
{
    public class BubbleSort
    {
        public void Sort(ref int [] array)
        {
            for (int i = 0; i < array.Length-1; i++)            
                for (int j = 0; j < array.Length-i-1; j++)                
                    if (array[j] > array[j+1])                    
                        Swap(ref array[j], ref array[j+1]);
        }

        private void Swap(ref int a, ref int b)
        {
            int buffer = b;
            b = a;
            a = buffer;
        }
    }
}