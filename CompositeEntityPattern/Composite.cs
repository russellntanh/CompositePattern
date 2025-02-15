using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public class Composite : IComponent
    {
        List<IComponent> composite = new List<IComponent>();
        public string Name { get; set; }
        public int TotalPrice { get; set; }
        public Composite(string name)
        {
            Name = name;
        }
        public void DisplayPrice()
        {
            foreach (IComponent component in composite)
            {
                component.DisplayPrice();
                
            }
        }

        public int GetPrice()
        {
            return this.composite.Sum( x => x.GetPrice());
        }

        public void Add(IComponent component)
        {
            composite.Add(component);
        }

        public void Remove(IComponent component)
        {
            composite.Remove(component);
        }
    }
}
