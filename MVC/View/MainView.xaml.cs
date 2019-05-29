using ArchitecturalPatternsImplementation.MVC.Model;
using ArchitecturalPatternsImplementation.MVC.View;
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
using System.Windows.Shapes;

namespace ArchitecturalPatternsImplementation.MVC
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public ObservableCollection<Coffee> coffees { get; set; }
        public MainView(ObservableCollection<Coffee> coffee)
        {
            InitializeComponent();
            this.coffees = coffee;
        }
        private void CoffeeViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            CoffeeModel coffeeModel = new CoffeeModel();
            coffeeModel.coffees = coffees;
            CoffeeViewControl.DataContext = coffeeModel;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }
    }
}
