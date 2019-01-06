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
    /// Interaction logic for WindowAddTrainee.xaml
    /// </summary>
    public partial class WindowAddTrainee : Window
    {
        public WindowAddTrainee()
        {
            InitializeComponent();
            this.CmbGender.ItemsSource = Enum.GetValues(typeof(BE.myEnum.Gender));
            this.CmbCarType.ItemsSource = Enum.GetValues(typeof(BE.myEnum.CarType));
            this.CmbGearBox.ItemsSource = Enum.GetValues(typeof(BE.myEnum.GearBox));
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {

        }
    }
}
