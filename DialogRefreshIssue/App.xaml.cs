using System.Windows;
using System.Windows.Media;
using System.Windows.Interop;

namespace DialogRefreshIssue
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
        }
    }
}