namespace ConnectTheDotsTester
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TwoPlayerGameTester
    {
        private ConnectTheDots.TwoPlayerGame mainClassTester;
        [TestMethod]
        public void initializeClass()
        {
            mainClassTester = new ConnectTheDots.TwoPlayerGame(5, 5);
            int[] test1 = { 0, 1 };
            int[] test2 = { 1, 1 };
            Assert.IsTrue(mainClassTester.addEdge(test1, test2) == 0);
            test1 = new int[] { 1, 0 };
            test2 = new int[] { 1, 1 };
            Assert.IsTrue(mainClassTester.addEdge(test1, test2) == 0);
            test1 = new int[] { 0, 0 };
            test2 = new int[] { 1, 0 };
            Assert.IsTrue(mainClassTester.addEdge(test1, test2) == 0);
            test1 = new int[] { 0, 0 };
            test2 = new int[] { 0, 1 };
            Assert.IsTrue(mainClassTester.addEdge(test1, test2) == 1);
        }
    }
}
