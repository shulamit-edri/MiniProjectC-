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
    /// Interaction logic for WindowUpdateTester.xaml
    /// </summary>
    public partial class WindowUpdateTester : Window
    {
        public WindowUpdateTester()
        {
            InitializeComponent();
            this.CmbGender.ItemsSource = Enum.GetValues(typeof(BE.myEnum.Gender));
            this.CmbTypeCar.ItemsSource = Enum.GetValues(typeof(BE.myEnum.CarType));
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {

        }
    }
}
