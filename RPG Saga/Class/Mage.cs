using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Mage: IPlayers
    {
        public string Name { get; set; }
        public float Attack { get; set; }
        public float Defence { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }
        public bool Skil { get; set; }

        public Mage(string mageName, float mageAttack, float mageDefence, float mageHealth, float mageMana, bool skil)
        {
            Name = mageName;
            Attack = mageAttack;
            Defence = mageDefence;
            Health = mageHealth;
            Mana = mageMana;
            Skil = skil;
        }
    }
}
