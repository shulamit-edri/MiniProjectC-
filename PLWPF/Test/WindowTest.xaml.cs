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

namespace PLWPF.Test
{
    /// <summary>
    /// Interaction logic for WindowTest.xaml
    /// </summary>
    public partial class WindowTest : Window
    {
        public WindowTest()
        {
            InitializeComponent();
        }

        private void Button_ClickAddTest(object sender, RoutedEventArgs e)
        {
            Window WindowAddTest = new WindowAddTest();
            WindowAddTest.Show();
        }

        private void Button_ClickRemoveTest(object sender, RoutedEventArgs e)
        {
            Window WindowRemoveTest = new WindowRemoveTest();
            WindowRemoveTest.Show();
        }

        private void Button_ClickUpdateTest(object sender, RoutedEventArgs e)
        {
            Window WindowUpdateTest = new WindowUpdateTest();
            WindowUpdateTest.Show();
        }
    }
}
