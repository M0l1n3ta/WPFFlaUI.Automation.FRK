using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace FlaUITest;

public class TestBase
{
    private string _applicationPath;
    protected Window mainAppWindow = null;

    public bool StartTestApplication()
    {
        _applicationPath = $@"{Environment.CurrentDirectory}\WpfApp.exe";
        Application app = Application.Launch(_applicationPath);

        if (app != null)
        {
            var automation = new UIA3Automation();
            mainAppWindow = app.GetMainWindow(automation);
            return true;
        }

        return false;
    }


}

