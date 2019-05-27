using BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void OnSortedArray_findsIndexOfValue()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };

            IBinarySearch search = new MyBinarySearch();

            int result = search.Find(input, 3);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OnValueNotInArray_returnsNotFound()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };

            IBinarySearch search = new MyBinarySearch();

            int result = search.Find(input, 6);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void OnEmptyArray_returnsNotFound()
        {
            int[] input = new int[] { };

            IBinarySearch search = new MyBinarySearch();

            int result = search.Find(input, 3);

            Assert.AreEqual(-1, result);
        }


        [TestMethod]
        public void OnUnsortedArray_returnsNotFound()
        {
            int[] input = new int[] { 3, 1, 2, 4, 5};

            IBinarySearch search = new MyBinarySearch();

            int result = search.Find(input, 3);

            Assert.AreEqual(-1, result);
        }
    }
}
