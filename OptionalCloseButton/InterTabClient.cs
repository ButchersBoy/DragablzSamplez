using System.Windows;
using Dragablz;

namespace OptionalCloseButton
{
    public class InterTabClient : IInterTabClient
    {
        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var view = new MainWindow();
            var model = new MainWindowViewModel();
            view.DataContext = model;
            return new NewTabHost<Window>(view, view.TabablzControl);            
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}