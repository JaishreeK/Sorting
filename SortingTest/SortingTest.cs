using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void TestCountSwaps()
        {
            int[] a = new int[] { 6, 4, 1 };
            Program.countSwaps(a);
        }
    }
}
