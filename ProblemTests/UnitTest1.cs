using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_E;


namespace ProblemTests
{
    [TestClass]
    public class UnitTest1
    {

        private void Test(IProblem sot)
        {
            Assert.AreEqual(sot.ValidatedAnswer(), sot.Evaluate());
        }

        [TestMethod]
        public void Test_Problem1()
        {
            Test(new Problem1());
        }

        [TestMethod]
        public void Test_Problem2()
        {
            Test(new Problem2());            
        }

        [TestMethod]
        public void Test_Problem3()
        {
            Test(new Problem3());
        }

    }
}
