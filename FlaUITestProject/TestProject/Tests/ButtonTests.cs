using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject.Utils;

namespace TestProject.Tests
{
    [TestClass]
    public class ButtonTests : TestBase, ITest
    {
        [TestInitialize]
        public void InitTest()
        {
            StartTestApplication();
        }

        [TestMethod]
        public void Test_AutomationIdButton()
        {
            throw new NotImplementedException();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            throw new NotImplementedException();
        }
    }
}
