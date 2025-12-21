using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace TestProject.Utils
{
    public class TestBase
    {
        private const string _applicationPath = @"..\..\app\Release\net8.0-windows\WpfApp.exe";
        protected Window mainAppWindow = null;

        public bool StartTestApplication()
        {
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
}
