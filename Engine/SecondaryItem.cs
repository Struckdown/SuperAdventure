using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class SecondaryItem: Item
    {
        public SecondaryItem(int id, string name, string namePlural, int minLevel, int price) : base(id, name, namePlural, minLevel, price)
        {
        }
    }
}
