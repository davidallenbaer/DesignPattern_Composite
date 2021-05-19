using System;

namespace DesignPattern_Composite
{
    public class Leaf : IComponent
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name + " : " + Price);
        }
    }
}