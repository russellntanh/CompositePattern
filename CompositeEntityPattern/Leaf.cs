using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public class Leaf : IComponent
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Leaf(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine("\t" + Name + " : " + Price);
        }
        public int GetPrice()
        {
            return Price;
        }
    }
}
