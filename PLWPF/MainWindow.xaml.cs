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
using PLWPF.Tester;
using PLWPF.Trainee;
using PLWPF.Test;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ClickTester(object sender, RoutedEventArgs e)
        {
            Window WindowTester = new WindowTester();
            WindowTester.Show();
        }

        private void Button_ClickTrainee(object sender, RoutedEventArgs e)
        {
            Window WindowTrainee = new WindowTrainee();
            WindowTrainee.Show();
        }

        private void Button_ClickTest(object sender, RoutedEventArgs e)
        {
            Window WindowTest = new WindowTest();
            WindowTest.Show();
        }
    }
}
