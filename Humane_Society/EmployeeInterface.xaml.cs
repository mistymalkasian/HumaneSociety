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
    /// Interaction logic for EmployeeInterface.xaml
    /// </summary>
    public partial class EmployeeInterface : Window
    {
        public EmployeeInterface()
        {
            InitializeComponent();
        }

        private void Database_Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDatabaseDisplay DatabaseDisplay = new EmployeeDatabaseDisplay();
            DatabaseDisplay.Show();
        }

        private void Payments_Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeePaymentsDisplay PaymentDisplay = new EmployeePaymentsDisplay();
            PaymentDisplay.Show();
        }
    }
}
