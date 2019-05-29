using ArchitecturalPatternsImplementation.MVC.Controller;
using ArchitecturalPatternsImplementation.MVC.Model;
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

namespace ArchitecturalPatternsImplementation.MVC.View
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        OrderController orderController;
        int pbt;
        double tax = 0.00, total = 0.00;
        public OrderWindow()
        {
            orderController = new OrderController();
            InitializeComponent();
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        { 
            Coffee coffee  = new Coffee
            {
                beanSelection = (BeanSelection)bean.SelectedValue,
                iceSelection = (IceSelection)ice.SelectedValue,
                condimentType = (CondimentType)condiment.SelectedValue,
                creamSelection = (CreamSelection)cream.SelectedValue,
                sizeSelection = (SizeSelection)size.SelectedValue,
                price = (int)(BeanSelection)bean.SelectedValue + (int)(IceSelection)ice.SelectedValue + (int)(CondimentType)condiment.SelectedValue + (int)(CreamSelection)cream.SelectedValue + (int)(SizeSelection)size.SelectedValue
            };
            orderController.addCoffee(coffee);
            if ((CommonOrder)cofee.SelectedValue == CommonOrder.Custom)
            { 
                addToCurrentOrder($"Order #{orderController.getCount()} Custom = {coffee.price} Br.", coffee.price);
            }
            else if((CommonOrder)cofee.SelectedValue == CommonOrder.Espresso)
            {
                addToCurrentOrder($"Order #{orderController.getCount()} Espresso = {coffee.price} Br.", coffee.price);
            }
            else if((CommonOrder)cofee.SelectedValue == CommonOrder.Latte)
            {
                addToCurrentOrder($"Order #{orderController.getCount()} Latte = {coffee.price} Br.", coffee.price);
            }
            else if((CommonOrder)cofee.SelectedValue == CommonOrder.Machiatto)
            {
                addToCurrentOrder($"Order #{orderController.getCount()} Machiatto = {coffee.price} Br.", coffee.price);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CoffeeController coffeeController = new CoffeeController();
            coffeeController.finishOrder(orderController.getCoffees());
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.Children.RemoveRange(0, orderController.getCoffees().Count);
            orderController.clear();
            pbt = 0;
            tax = 0.00;
            total = 0.00;
            pbtOrder.Content = $"PBT : {pbt} Br.";
            taxOrder.Content = $"Tax : {tax} Br.";
            totalOrder.Content = $"Total : {total} Br.";
        }

        private void Cofee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((CommonOrder)cofee.SelectedIndex == CommonOrder.Custom)
            {
                if (bean != null) bean.IsEnabled = true;
                if (ice != null) ice.IsEnabled = true;
                if (condiment != null) condiment.IsEnabled = true;
                if (cream != null) cream.IsEnabled = true;
            }
            else if((CommonOrder)cofee.SelectedIndex == CommonOrder.Machiatto)
            {
                if (bean != null) bean.SelectedIndex = 2;
                if (ice != null) ice.SelectedIndex = 0;
                if (condiment != null) condiment.SelectedIndex = 1;
                if (cream != null) cream.SelectedIndex = 4;
                if (bean != null) bean.IsEnabled = false;
                if (ice != null) ice.IsEnabled = false;
                if (condiment != null) condiment.IsEnabled = false;
                if (cream != null) cream.IsEnabled = false;
            }
            else if ((CommonOrder)cofee.SelectedIndex == CommonOrder.Espresso)
            {
                if (bean != null) bean.SelectedIndex = 3;
                if (ice != null) ice.SelectedIndex = 0;
                if (condiment != null) condiment.SelectedIndex = 2;
                if (cream != null) cream.SelectedIndex = 2;
                if (bean != null) bean.IsEnabled = false;
                if (ice != null) ice.IsEnabled = false;
                if (condiment != null) condiment.IsEnabled = false;
                if (cream != null) cream.IsEnabled = false;
            }
            else if ((CommonOrder)cofee.SelectedIndex == CommonOrder.Latte)
            {
                if (bean != null) bean.SelectedIndex = 0;
                if (ice != null) ice.SelectedIndex = 1;
                if (condiment != null) condiment.SelectedIndex = 0;
                if (cream != null) cream.SelectedIndex = 5;
                if (bean != null) bean.IsEnabled = false;
                if (ice != null) ice.IsEnabled = false;
                if (condiment != null) condiment.IsEnabled = false;
                if (cream != null) cream.IsEnabled = false;
            }
        }

        private void Chip_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void addToCurrentOrder(String order, int price)
        {
            Label label = new Label();
            label.Content = order;
            label.Foreground = System.Windows.Media.Brushes.White;
            pbt += price;
            tax = 0.15 * pbt;
            total = pbt + tax;
            pbtOrder.Content = $"PBT : {pbt} Br.";
            taxOrder.Content = $"Tax : {tax} Br.";
            totalOrder.Content = $"Total : {total} Br.";
            currentOrder.Children.Insert(currentOrder.Children.Count - 3, label);
        }
    }
}
