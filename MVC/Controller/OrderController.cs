using ArchitecturalPatternsImplementation.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatternsImplementation.MVC.Controller
{
    class OrderController
    {
        List<Coffee> coffees;
        public OrderController()
        {
            coffees = new List<Coffee>();
        }
        public void addCoffee(Coffee coffee)
        {
            coffees.Add(coffee);
        }
        public void clear()
        {
            coffees = new List<Coffee>();
        }
        public int getCount()
        {
            return coffees.Count;
        }
        public List<Coffee> getCoffees()
        {
            return coffees;
        }
    }
}
