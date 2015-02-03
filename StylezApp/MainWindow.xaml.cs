using Common;
using MahApps.Metro.Controls;

namespace StylezApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
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
