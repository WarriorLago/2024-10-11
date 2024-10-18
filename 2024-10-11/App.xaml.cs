using System.Configuration;
using System.Data;
using System.Windows;

namespace _2024_10_11
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Diagnostics.Debug.WriteLine("1.OnStartup被触发");
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            System.Diagnostics.Debug.WriteLine("2.OnActivated被触发");
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            System.Diagnostics.Debug.WriteLine("3.OnDeactivated被触发");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            System.Diagnostics.Debug.WriteLine("4.OnExit被触发");
        }
    }

}
