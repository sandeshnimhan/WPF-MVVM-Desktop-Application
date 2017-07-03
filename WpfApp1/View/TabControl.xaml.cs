using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for TabControl.xaml
    /// </summary>
    public partial class TabControl : UserControl
    {
        private TabWindow tabWindow = null; // Reference to the MainWindow - TabWindow
        public TabControl()
        {
            InitializeComponent();
        }

        private void OnControlLoaded(object sender, RoutedEventArgs e)
        {
            tabWindow = Window.GetWindow(this) as TabWindow;
            tabNameLabel.Content = "This is tab " + (tabWindow.tabControl.SelectedItem as TabItem).Header;
        }

    }
}
