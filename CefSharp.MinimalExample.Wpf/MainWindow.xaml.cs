using System.Windows;
using System.Windows.Input;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Browser.RequestHandler = new DefaultRequestHandler();
            Browser.MenuHandler = new DefaultMenuHandler();
            Browser.IsBrowserInitializedChanged += BrowserInstance_IsBrowserInitializedChanged;
        }

        private void BrowserInstance_IsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Browser.IsBrowserInitialized)
            {
                Browser.LoadUrl(TestUrl.TestLink);
                Browser.Reload();
            }
        }

        private void Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            Browser.WebBrowser.ShowDevTools();
        }
    }
}
