using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPattern
{
    public interface IComponent
    {
        public void DisplayPrice();
        public int GetPrice();
    }
}
