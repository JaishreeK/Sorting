using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void TestCountSwaps()
        {
            int[] a = new int[] { 6, 4, 1 };
            Program.countSwaps(a);
        }

        [TestMethod]
        public void TestJumpingOnClouds()
        {
            int[] a = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            Program.jumpingOnClouds(a);
        }

        //7 50
        //1 12 5 111 200 1000 10

        [TestMethod]
        public void TestMaximumToys()
        {
            int[] a = new int[] { 1, 12, 5, 111, 200, 1000, 10 };
            Program.maximumToys(a, 50);
        }


        [TestMethod]
        public void TestActivityNotifications()
        {
            int[] a = new int[] { 1, 2, 3, 4, 4 };
            Program.activityNotifications(a, 4);
        }


        [TestMethod]
        public void TestActivityNotifications1()
        {
            int[] a = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            Program.activityNotifications(a, 5);
        }

        [TestMethod()]
        public void MissingLeastIntegerTest()
        {
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            int r = Program.MissingLeastInteger(A);
            Assert.AreEqual(5, r);
        }

        [TestMethod()]
        public void Insert5toGetMaxNoTest1()
        {
            int r = Program.Insert5toGetMaxNo(670);
            Assert.AreEqual(6750,r);
        }

        [TestMethod()]
        public void Insert5toGetMaxNoTest2()
        {
            int r = Program.Insert5toGetMaxNo(268);
            Assert.AreEqual(5268, r);
        }

        [TestMethod()]
        public void Insert5toGetMaxNoTest3()
        {
            int r = Program.Insert5toGetMaxNo(-999);
            Assert.AreEqual(-5999, r);
        }
    }

}
