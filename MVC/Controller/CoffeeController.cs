using ArchitecturalPatternsImplementation.MVC.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatternsImplementation.MVC.Controller
{
    class CoffeeController
    {
        public CoffeeController()
        {

        }
        public void finishOrder(List<Coffee> coffees)
        {
            ObservableCollection<Coffee> coffee = new ObservableCollection<Coffee>();
            foreach(Coffee c in coffees)
            {
                coffee.Add(c);
            }
            MainView mainView = new MainView(coffee);
            mainView.Show();
        }
    }
}
