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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArchitecturalPatternsImplementation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MVC.View.OrderWindow orderWindow = new MVC.View.OrderWindow();
            orderWindow.Show();
            this.Close();
        }
         
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //MVVM.View.OrderWindow orderWindow = new MVVM.View.OrderWindow();
            //orderWindow.Show();
            //this.Close();
        }
    }

}
