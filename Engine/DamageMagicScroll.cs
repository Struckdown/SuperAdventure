using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageMagicScroll : SecondaryItem
    {
        public int MinDamageAmount { get; set; }
        public int MaxDamageAmount { get; set; }

        public DamageMagicScroll(int id, string name, string namePlural, int price, int minLevel, int minDamageAmount, int maxDamageAmount) : base(id, name, namePlural, price, minLevel)
        {
            isMagic = true;
            MinDamageAmount = minDamageAmount;
            MaxDamageAmount = maxDamageAmount;
        }
    }
}
