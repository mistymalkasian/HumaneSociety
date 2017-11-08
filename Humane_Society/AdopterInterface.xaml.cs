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
            AnimalSearchDisplay AnimalSearch = new AnimalSearchDisplay();
            AnimalSearch.Show();
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeePaymentsDisplay PaymentView = new EmployeePaymentsDisplay();
           PaymentView.Show();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileDatabaseDisplay UserProfile = new UserProfileDatabaseDisplay();
            UserProfile.Show();
        }
    }
}
