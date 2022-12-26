using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Archer : IPlayers
    {
        public string Name { get; set; }
        public float Attack { get; set; }
        public float Defence { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }

        public Archer(string archName, float archAttack, float archDefence, float archHealth, float archMana)
        {
            Name = archName;
            Attack = archAttack;
            Defence = archDefence;
            Health = archHealth;
            Mana = archMana;
        }
    }
}
