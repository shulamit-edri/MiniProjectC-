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

namespace PLWPF.Trainee
{
    /// <summary>
    /// Interaction logic for WindowTrainee.xaml
    /// </summary>
    public partial class WindowTrainee : Window
    {
        public WindowTrainee()
        {
            InitializeComponent();
        }

        private void Button_ClickAddTrainee(object sender, RoutedEventArgs e)
        {
            Window WindowAddTrainee = new WindowAddTrainee();
            WindowAddTrainee.Show();
        }

        private void Button_ClickRemoveTrainee(object sender, RoutedEventArgs e)
        {
            Window WindowRemoveTrainee = new WindowRemoveTrainee();
            WindowRemoveTrainee.Show();
        }

        private void Button_ClickUpdateTrainee(object sender, RoutedEventArgs e)
        {
            Window WindowUpdateTrainee = new WindowUpdateTrainee();
            WindowUpdateTrainee.Show();
        }
    }
}
