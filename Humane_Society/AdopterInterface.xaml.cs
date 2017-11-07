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

namespace Humane_Society
{
    /// <summary>
    /// Interaction logic for AdopterInterface.xaml
    /// </summary>
    public partial class AdopterInterface : Window
    {
        public AdopterInterface()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeePaymentsDisplay MakePayment = new EmployeePaymentsDisplay();
            MakePayment.Show();
        }
    }
}
