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
    /// Interaction logic for UserProfileDatabaseDisplay.xaml
    /// </summary>
    public partial class UserProfileDatabaseDisplay : Window
    {
        DataClassesDataContext DC = new DataClassesDataContext(Properties.Settings.Default.HumaneSocietyConnectionString);

        public UserProfileDatabaseDisplay()
        {
            InitializeComponent();

            if (DC.DatabaseExists()) UserProfileDatagrid.ItemsSource = DC.UserInfos;
        }
    }
}
