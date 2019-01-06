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
using BE;
namespace PLWPF.Tester
{
    /// <summary>
    /// Interaction logic for WindowAddTester.xaml
    /// </summary>
    public partial class WindowAddTester : Window
    {
        BL.IBL bl;
        BE.Tester tester;

        public WindowAddTester()
        {
            InitializeComponent();
            tester = new BE.Tester();
            Grid.DataContext = tester;
            bl = BL.FactoryBl.GetBL();
            this.CmbGender.ItemsSource = Enum.GetValues(typeof(BE.myEnum.Gender));
            this.CmbTypeCar.ItemsSource = Enum.GetValues(typeof(BE.myEnum.CarType));
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxId.Text == "")
                    throw new Exception("must have id");
                if (TxLastName.Text == "")
                    throw new Exception("must have last mame");
                if (TxFirstName.Text == "")
                    throw new Exception("must have FirstName");
                if (DpBirthDate.Text == "")
                    throw new Exception("must have birth date");
                if (CmbTypeCar.Text == "")
                    throw new Exception("must have type car");

                tester.Id = this.TxId.Text;
                tester.LastName = this.TxLastName.Text;
                tester.FirstName = this.TxFirstName.Text;
                //tester.Birthday = this.DpBirthDate.Text;

                bl.addTester(tester);
                //tester = new BE.Tester();
                //this.DataContext = tester;
                MessageBox.Show("ADD SUCCESSFUL!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
