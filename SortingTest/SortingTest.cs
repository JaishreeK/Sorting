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

        //[TestMethod]
        //public void TestCountSwaps()
        //{
        //    int[] a = new int[] { 6, 4, 1 };
        //    Program.countSwaps(a);
        //}

        //[TestMethod]
        //public void TestJumpingOnClouds()
        //{
        //    int[] a = new int[] { 0, 0, 1, 0, 0, 1, 0 };
        //    Program.jumpingOnClouds(a);
        //}

        //7 50
        //1 12 5 111 200 1000 10

        [TestMethod]
        public void TestMaximumToys()
        {
            int[] a = new int[] { 1, 12, 5, 111, 200, 1000, 10 };
            Program.maximumToys(a,50);
        }
    }


}
