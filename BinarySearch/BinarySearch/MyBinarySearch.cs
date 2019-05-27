namespace BinarySearch
{
    public class MyBinarySearch : IBinarySearch
    {
        public int Find(int[] source, int value)
        {
            int start = 0;
            int end = source.Length - 1;

            while (start <= end)
            {
                int pivotIndex = (start + end) / 2;

                if (source[pivotIndex] == value)
                {
                    return pivotIndex;
                }
                else if (pivotIndex < source[pivotIndex])
                {
                    end = pivotIndex - 1;
                }
                else
                {
                    start = pivotIndex + 1;
                }
            }

            return -1; // Not found
        }
    }
}
