using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class SecondaryItem: Item
    {
        public bool isPotion;
        public bool isMagic;
        public SecondaryItem(int id, string name, string namePlural, int price, int minLevel) : base(id, name, namePlural, price, minLevel)
        {
        }
    }
}
