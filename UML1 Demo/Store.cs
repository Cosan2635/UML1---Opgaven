using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_Demo
{
    class Store
    {
        public void Start()
        {
          
            Pizza p1 = new Pizza("Peperoni Pizza","Tomat sauce", 65);
            Pizza p2 = new Pizza("New york","Kylling",60);
            Pizza p3 = new Pizza("Brøndby Speciel", "Kødsauce", 72);

            Customers c1 = new Customers(265717,"Muhammed Cosan",  "Mcppmuhammed@live.dk", 42167725);
            Customers c2 = new Customers(717265,"Kasper Rasmussen"  , "Kasper.Rasmussenss@live.dk", 41285214);
            Customers c3 = new Customers(414144,"Michelle Sørensenss"  ,  "Michelle.Sørensen@hotmail.com",  41758291);

            Order o1 = new Order(4, p1, c1);

            Order o2 = new Order(1, p2, c2);
            Order o3 = new Order(33, p3, c3);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
        }

    }
}
