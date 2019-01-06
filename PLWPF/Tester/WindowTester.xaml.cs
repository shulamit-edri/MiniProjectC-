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
using System.Windows.Shapes;

namespace PLWPF.Tester
{
    /// <summary>
    /// Interaction logic for WindowTester.xaml
    /// </summary>
    public partial class WindowTester : Window
    {
        public WindowTester()
        {
            InitializeComponent();
        }

        private void Button_ClickAddTester(object sender, RoutedEventArgs e)
        {
            Window WindowAddTester = new WindowAddTester();
            WindowAddTester.Show();
        }

        private void Button_ClickRemoveTester(object sender, RoutedEventArgs e)
        {
            Window WindowRemoveTester = new WindowRemoveTester();
            WindowRemoveTester.Show();
        }

        private void Button_ClickUpdateTester(object sender, RoutedEventArgs e)
        {
            Window WindowUpdateTester = new WindowUpdateTester();
            WindowUpdateTester.Show();
        }
    }
}
