namespace BinarySearch
{
    public class MyBinarySearch : IBinarySearch
    {
        private bool IsSortedArray(int[] source)
        {
            bool result = true;

            for (int i = 0; i < source.Length - 1; i++)
            {
                if (source[i] > source[i + 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public int Find(int[] source, int value)
        {
            if (!IsSortedArray(source))
            {
                return -1; // Binary search requires sorted arrays
            }

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
