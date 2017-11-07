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
    /// Interaction logic for EmployeePaymentsDisplay.xaml
    /// </summary>
    public partial class EmployeePaymentsDisplay : Window
    {
        DataClassesDataContext dc = new DataClassesDataContext(Properties.Settings.Default.HumaneSocietyConnectionString);

        public EmployeePaymentsDisplay()
        {
            InitializeComponent();

            if (dc.DatabaseExists()) PaymentsDatagrid.ItemsSource = dc.PaymentAccounts;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            dc.SubmitChanges();
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
