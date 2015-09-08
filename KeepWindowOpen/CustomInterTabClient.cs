using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Dragablz;

namespace KeepWindowOpen
{
    public class CustomInterTabClient : IInterTabClient
    {        
        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {            
            var childWindow = new ChildWindow();

            childWindow.TabablzControl.Items.Clear();

            return new NewTabHost<Window>(childWindow, childWindow.TabablzControl);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {   
            if (window is ChildWindow)
                return TabEmptiedResponse.CloseWindowOrLayoutBranch;
            return TabEmptiedResponse.DoNothing;
        }
    }
}
