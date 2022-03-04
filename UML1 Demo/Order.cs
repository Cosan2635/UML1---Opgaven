using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Order
    {
        private int _orderNo;
        private double totalPrice;
        private Pizza pizza;
        private Customers customers;
        

        public Order(int orderNo, Pizza pizza, Customers customers)
        {
            _orderNo = orderNo;
            this.pizza = pizza;
            CalculateTotalprice (this.pizza.Price);
            this.customers = customers;
        }

        public Customers GetCustomers() { 
                return customers;
            }

        public int OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; }
        }
    
        public void CalculateTotalprice (double price)
        {
            double totalPrice = price + 40;
            double taxes = 0.25 * price;
            this.totalPrice = totalPrice + taxes;
        }
      public double GetTotalPrice()
        {
            return this.totalPrice;
        }
        public override string ToString()
        {
            return "Ordernumber"+" "+_orderNo + " "+ customers + " "+ pizza + " kr" + " = " + totalPrice + "kr. inklussiv levering";

        }

    }
}
