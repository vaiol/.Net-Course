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

namespace NetLaba2
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //AdressBox.Text = "localhost";
            //SchemaBox.Text = "netLaba2";
            //LoginBox.Text = "root";
            //PassBox.Password = "zkycewuf";
            Util.DB = new DBConnector(AdressBox.Text, SchemaBox.Text, LoginBox.Text, PassBox.Password);
            if (Util.DB.OpenConnection())
            {
                Util.DB.CloseConnection();
                Switcher.Switch(new MainPage());
            }
            else
            {
                Util.DB.CloseConnection();
                AdressBox.Text = "localhost";
                SchemaBox.Text = "netLaba2";
                LoginBox.Text = "";
                PassBox.Password = "";
            }

        }
    }
}
