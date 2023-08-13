using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActionAndDeploy;
using System;

namespace ActionAndDeploy_UnitTest
{
    [TestClass]
    public class IStack_UnitTest
    {
        [TestMethod]
        public void TestStack()
        {
            StackImp<string> stackImp = new StackImp<string>();
            stackImp.Push("a");
            Assert.IsTrue(stackImp.StackStorage.Count == 1);
            Assert.IsTrue(stackImp.StackStorage[0] == "a");
        }

        [TestMethod]
        public void TestEmptyStack()
        {
            StackImp<string> stackImp = new StackImp<string>();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => stackImp.Pop());
        }

    }
}
