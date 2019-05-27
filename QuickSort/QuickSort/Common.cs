namespace QuickSort
{
    public abstract class Common
    {
        protected static void Swap(int[] input, int start, int end)
        {
            int tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;
        }
    }
}
