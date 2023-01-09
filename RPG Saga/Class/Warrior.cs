using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Warrior: IPlayers
    {
        public string Name { get; set; }
        public float Attack { get; set; }
        public float Defence { get; set; }
        public float Health { get; set; }
        public float Mana { get; set; }
        public bool Skil { get; set; }

        public Warrior(string warName, float warAttack, float warDefence, float warHealth, float warMana, bool skil)
        {
            Name = warName;
            Attack = warAttack;
            Defence = warDefence;
            Health = warHealth;
            Mana = warMana;
            Skil = skil;
        }
    }

}
