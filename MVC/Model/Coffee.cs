using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ArchitecturalPatternsImplementation.MVC.Model
{
    public class CoffeeModel { public ObservableCollection<Coffee> coffees { get; set; } }
    public class Coffee
    {
        public CondimentType condimentType { get; set; }
        public IceSelection iceSelection { get; set; }
        public BeanSelection beanSelection { get; set; }
        public CreamSelection creamSelection { get; set; }
        public SizeSelection sizeSelection { get; set; }
        public int price { get; set; }
    }
    public enum CommonOrder
    {
        Latte = 0, Espresso = 1, Machiatto = 2, Custom = 3
    }
    public enum CondimentType
    {
        NONE = 0, SALT = 1, SUGAR = 2
    }
    public enum IceSelection
    {
        HOT = 0, ICED = 1
    }
    public enum BeanSelection
    {
        HARRAR = 5, YIRGACHEFE = 4, SIDAMO = 6, ARABICA = 8 
    }
    public enum CreamSelection
    {
        NONE = 0, MILK = 2, WHIPPED = 4, DOUBLE = 3, HALFANDHALF = 5, HEAVY = 6
    }
    public enum SizeSelection
    {
        SMALL = 10, MEDIUM = 15, LARGE = 20
    } 
}
