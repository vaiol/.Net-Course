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
    /// Interaction logic for InputPage.xaml
    /// </summary>
    public partial class InputPage : UserControl
    {
        public InputPage()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            Entity entity = new Entity();
            entity.Name = NameBox.Text;
            bool condition = true;
            if (!String.IsNullOrEmpty(PriceBox.Text) && ! String.IsNullOrWhiteSpace(PriceBox.Text))
            {
                String price = PriceBox.Text;
                price = price.Replace(".", ",");
                try
                {
                    entity.Price = Convert.ToDouble(price);
                }
                catch (Exception)
                {
                    MessageBox.Show("Price is INCORRRECT!");
                    PriceBox.Text = "";
                    condition = false;
                }
            }

            if (!String.IsNullOrEmpty(CountBox.Text) && ! String.IsNullOrWhiteSpace(CountBox.Text))
            {
                try
                {
                    entity.Count = Convert.ToInt32(CountBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Count is INCORRRECT!");
                    CountBox.Text = "";
                    condition = false;
                }
            }
            if (condition)
            {
                Util.DB.Insert(entity);
                Switcher.Switch(new MainPage());
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainPage());
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
