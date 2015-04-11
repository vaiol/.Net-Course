using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl, ISwitchable
    {
        public MainPage()
        {
            InitializeComponent();
            ObservableCollection<Entity> collection = new ObservableCollection<Entity>(Util.DB.Select());
            MyDataGrid.DataContext = collection;
            MyDataGrid.CanUserAddRows = false;
        }


        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new InputPage());
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Entity> collection = (ObservableCollection<Entity>) MyDataGrid.DataContext;
            List<Entity> cll = collection.ToList<Entity>();
            foreach (Entity ent in cll)
            {
                Util.DB.Update(ent);
            }
            collection = new ObservableCollection<Entity>(Util.DB.Select());
            MyDataGrid.DataContext = collection;


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Entity tmp = (Entity)MyDataGrid.SelectedItem;
            Util.DB.Delete(tmp.ID);
            ObservableCollection<Entity> collection = new ObservableCollection<Entity>(Util.DB.Select());
            MyDataGrid.DataContext = collection;
        }

        public void UtilizeState(object state)
        {
            MessageBox.Show("Big trouble!!!");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new StartPage());
        }


    }
}
