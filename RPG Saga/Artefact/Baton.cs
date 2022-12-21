using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artefact
{
    using Class;
    internal class Baton : IArtefact
    {
        public string Name { get; set; } = "Дубинка";
        public float UpAttack { get; set; } = 10;

        public Baton(float upAttack)
        {
            UpAttack = upAttack;
        }

        public float UpCharacteristic(IPlayers Player, float Attack)
        {
            Player.Attack = Player.Attack + UpAttack;
            return Player.Attack;
        }
    }
}
