namespace QuickSort
{
    public class RecursiveQuickSort : IQuickSort
    {
        public void Sort(int[] input)
        {
            Sort(input, 0, input.Length - 1);
        }

        private void Sort(int[] input, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = input[(start + end) / 2]; // Middlepoint of input
            int index = Partition(input, start, end, pivot);

            Sort(input, start, index - 1);
            Sort(input, index, end);
        }

        private int Partition(int[] input, int start, int end, int pivot)
        {
            while (start <= end)
            {
                while (input[start] < pivot)
                {
                    start++;
                }

                while (input[end] > pivot)
                {
                    end--;
                }

                if (start <= end)
                {
                    Swap(input, start, end);
                    start++;
                    end--;
                }
            }

            return start;
        }

        private static void Swap(int[] input, int start, int end)
        {
            int tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;
        }
    }
}