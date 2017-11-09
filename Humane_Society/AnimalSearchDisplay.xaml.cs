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
using System.Data.SqlClient;
using System.Data;

namespace Humane_Society
{
    /// <summary>
    /// Interaction logic for AnimalSearchDisplay.xaml
    /// </summary>
    public partial class AnimalSearchDisplay : Window
    {
        DataClassesDataContext dc = new DataClassesDataContext(Properties.Settings.Default.HumaneSocietyConnectionString);

        public AnimalSearchDisplay()
        {
            InitializeComponent();

            if (dc.DatabaseExists()) SearchDatagrid.ItemsSource = dc.Animals;
        }


        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show();
        }

        private void inputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //ListBox dataListBox = new ListBox();

            //var query = from a in dc.Animals
            //            orderby a.AnimalType
            //            select a;

            //dataListBox.ItemsSource = query.ToList();
        }

      
    }
}
