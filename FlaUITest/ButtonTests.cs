using FlaUI.Core.AutomationElements;

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
        var inputBox = mainAppWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtName")).AsTextBox();
        inputBox!.Enter("Test Name");

        var button = mainAppWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnSubmit")).AsButton();
        Assert.AreEqual("Press me", button!.Name, "Button text is incorrect");
        button.Click();

        var resultLabel = mainAppWindow.FindFirstDescendant(cf => cf.ByAutomationId("ResultWindow")).AsLabel();
        Assert.AreEqual("Input was Test Name", resultLabel!.Text, "Result text is incorrect");
    }

    [TestCleanup]
    public void TestCleanUp()
    {
        mainAppWindow.Close();
    }
}
