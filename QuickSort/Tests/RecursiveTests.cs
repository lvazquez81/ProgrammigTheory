using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace Tests
{
    [TestClass]
    [TestCategory("Recursive")]
    public class RecursiveTests
    {
        private IQuickSort _sorter;

        [TestInitialize]
        public void TestSetup()
        {
            _sorter = new RecursiveQuickSort();
        }

        [TestMethod]
        public void OnUnsorted_returnsSortedNumbers()
        {
            int[] values = new int[] { 3, 5, 2, 1, 4 };

            _sorter.Sort(values);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, values);
        }

        [TestMethod]
        public void OnSorted_returnsValues()
        {
            int[] values = new int[] { 1, 2, 3, 4, 5 };

            _sorter.Sort(values);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, values);
        }

        [TestMethod]
        public void OnEmptyInput_returnsEmpty()
        {
            int[] values = new int[] { };

            _sorter.Sort(values);

            CollectionAssert.AreEqual(new int[] { }, values);
        }

        [TestMethod]
        public void OnOnlyOneNumberInput_returnsSameValues()
        {
            int[] values = new int[] { 1 };

            _sorter.Sort(values);

            CollectionAssert.AreEqual(new int[] { 1 }, values);
        }

        [TestMethod]
        public void OnTwoNumberInput_returnsSortedValues()
        {
            int[] values = new int[] { 2, 1 };

            _sorter.Sort(values);

            CollectionAssert.AreEqual(new int[] { 1, 2}, values);
        }

    }
}
