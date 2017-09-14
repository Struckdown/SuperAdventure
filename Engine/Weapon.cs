using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minLevel, int minimumDamage, int maximumDamage, int price) : base(id, name, namePlural, price, minLevel)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
