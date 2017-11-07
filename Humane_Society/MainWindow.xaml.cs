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
        DataClassesDataContext DC = new DataClassesDataContext(Properties.Settings.Default.HumaneSocietyConnectionString);
        public MainWindow()
        {
            InitializeComponent();

            if (DC.DatabaseExists()) AnimalsDatagrid.ItemsSource = DC.Animals;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DC.SubmitChanges();
        }
    }
}
