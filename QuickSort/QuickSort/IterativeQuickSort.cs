using System.Collections.Generic;

namespace QuickSort
{
    public class IterativeQuickSort : Common, IQuickSort
    {
        public void Sort(int[] input)
        {
            if (input.Length > 1)
            {
                Sort(input, 0, input.Length - 1);
            }
        }

        private void Sort(int[] input, int start, int end)
        {
            var stack = new Stack<int>();

            stack.Push(start);
            stack.Push(end);

            while (stack.Count > 0)
            {
                end = stack.Pop();
                start = stack.Pop();

                int pivot = input[end];
                int nextPivot = Partition(input, start, end, pivot);

                if (nextPivot - 1 > start)
                {
                    stack.Push(start);
                    stack.Push(nextPivot - 1);
                }

                if (nextPivot + 1 < end)
                {
                    stack.Push(nextPivot + 1);
                    stack.Push(end);
                }
            }
        }

        private int Partition(int[] input, int start, int end, int pivot)
        {
            int i = (start - 1);

            for (int j = start; j <= end - 1; ++j)
            {
                if (input[j] <= pivot)
                {
                    ++i;
                    Swap(input, i, j);
                }
            }

            Swap(input, i + 1, end);

            return (i + 1);
        }
    }
}