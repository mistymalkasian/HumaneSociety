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

namespace Humane_Society
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

        
        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeInterface EmployeeInterface = new EmployeeInterface();
            EmployeeInterface.Show();
        }

        private void AdopterButton_Click(object sender, RoutedEventArgs e)
        {
            AdopterInterface AdopterInterface = new AdopterInterface();
            AdopterInterface.Show();
        }
    }
}
