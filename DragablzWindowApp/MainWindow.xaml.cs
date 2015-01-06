using System.Net.Mime;
using System.Windows;
using Common;
using Dragablz;

namespace DragablzWindowApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DragablzWindow
    {
        private static bool _hackyIsFirstWindow = true;

        public MainWindow()
        {
            InitializeComponent();
            
            if (_hackyIsFirstWindow)
                DataContext = MainWindowViewModel.CreateWithSamples();

            _hackyIsFirstWindow = false;
        }
    }
}
