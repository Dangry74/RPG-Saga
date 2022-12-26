using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artefact
{
    using Class;
    internal class Artefact
    {
        string Name { get; set; }
        float UpAttack { get; set; }
        float UpDefence { get; set; }
        float UpHealth { get; set; }
        float UpMana { get; set; }

        public Artefact(string name, float upAttack, float upDefence, float upHealth, float upMana)
        {
            Name = name;
            UpAttack = upAttack;
            UpDefence = upDefence;
            UpHealth = upHealth;
            UpMana = upMana;
        }
        public static float UpCharacteristic(IPlayers Player, float Attack, float Defence, float Health, float Mana)
        {
            Random rnd = new Random();
            int Id = rnd.Next(1, 5);
            switch(Id)
            {
                case 1:
                    Artefact Buton = new Artefact("Дубинка", 10, 0, 0, 0);
                    Player.Attack = Player.Attack + Buton.UpAttack;
                    Console.WriteLine($"{Player.Name} получает {Buton.Name} : (+10 атаки)\t");
                    return Player.Attack;
                case 2:
                    Artefact WoodArmor = new Artefact("Деревянная броня", 0, 10, 0, 0);
                    Player.Defence = Player.Defence+ WoodArmor.UpDefence;
                    Console.WriteLine($"{Player.Name} получает {WoodArmor.Name} : (+10 защиты)\t");
                    return Player.Defence;
                case 3:
                    Artefact AmuletOfHealth = new Artefact("Амулет здоровья", 0, 0, 100, 0);
                    Player.Health = Player.Health + AmuletOfHealth.UpHealth;
                    Console.WriteLine($"{Player.Name} получает {AmuletOfHealth.Name} : (+100 здоровья) \t");
                    return Player.Health;
                case 4:
                    Artefact MagicStick = new Artefact("Волшебная палочка", 0, 0, 0, 50);
                    Player.Mana = Player.Mana + MagicStick.UpMana;
                    Console.WriteLine($"{Player.Name} получает {MagicStick.Name} : (+50 маны) \t");
                    return Player.Mana;
                default: return 0;

            }
        }
    }


}
