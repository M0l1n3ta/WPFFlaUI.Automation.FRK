using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlaUITest;

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
        var button = mainAppWindow.FindFirstDescendant(cf => cf.ByAutomationId("AutoBtn"));
        button!.Click();
    }

    [TestCleanup]
    public void TestCleanUp()
    {
        mainAppWindow.Close();
    }
}
