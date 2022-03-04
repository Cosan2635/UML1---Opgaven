using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Pizza
    {
        string _name;
        private string _topping;
        int _price;
    
        public Pizza(string name, string topping, int price)
        {
            _name = name;
            _topping = topping;
            _price = price;
        }
    public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }
   
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return _name + " " + _topping + " " + _price + " ";
        }

    }
}
