using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dragablz;

namespace OptionalCloseButton
{
    public class Boot
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new App {ShutdownMode = ShutdownMode.OnLastWindowClose};            

            var viewModel = new MainWindowViewModel(
                new HeaderedItemViewModel {Header = "HOME", Content = "There is a TabablzControl.ShowDefault close button, but this demo illustrates how you can have close buttons on and off per tab, in the same TabablzControl."},
                new HeaderedItemViewModel
                {
                    Header = new HeaderWithCloseViewModel {Header = "Closable"},
                    Content =
                        "This tab is closeable."
                }
                );

            new MainWindow()
            {
                DataContext = viewModel
            }.Show();

            app.Run();
        }
    }
}
