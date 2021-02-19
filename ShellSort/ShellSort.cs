using Sorts;

namespace ShellSort
{
    class ShellSort
    {
        public int[] Sort(int[] data)
        {
            var shell = new InsertionSortCustomStep();
            for (int step = data.Length / 2; step > 0; step /= 2)
            {
                for (int i = 0; i < step; i++)
                {
                    shell.Sort(data, step, i);
                }
            }
            return data;
        }
    }
}
