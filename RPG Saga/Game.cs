using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Saga
{
    using Class;
    using Name;

    public class Game
    {
        public void GameRun()
        {
            var rand=new Random();
            IPlayers Player1;
            IPlayers Generate1()
            {
                int RandCountGenerate1 = rand.Next(0, 3);
                switch (RandCountGenerate1)
                {
                    case 1:
                        {
                            string WarName = NameWarrior.GenerateNameWarrior(NameWarrior.WarriorName);
                            float WarAttack = rand.Next(20, 45);
                            float WarDefence = rand.Next(20, 35);
                            float WarHealth = rand.Next(500, 700);
                            float WarMana = rand.Next(0, 10);
                            Player1 = new Warrior(WarName, WarAttack, WarDefence, WarHealth, WarMana);
                            return Player1;
                        }
                    case 2:
                        {
                            string ArchName = NameArcher.GenerateNameArcher(NameArcher.ArcherName);
                            float ArchAttack = rand.Next(80, 100);
                            float ArchDefence = rand.Next(5, 15);
                            float ArchHealth = rand.Next(600, 900);
                            float ArchMana = rand.Next(0, 20);
                            Player1 = new Archer(ArchName, ArchAttack, ArchDefence, ArchHealth, ArchMana);
                            return Player1;
                        }
                    default:
                        {
                            string MageName = NameMage.GenerateNameMage(NameMage.MageName);
                            float MageAttack = rand.Next(10, 30);
                            float MageDefence = rand.Next(2, 5);
                            float MageHealt = rand.Next(200, 350);
                            float MageMana = rand.Next(100, 200);
                            Player1 = new Mage(MageName, MageAttack, MageDefence, MageHealt, MageMana);
                            return Player1;
                        }
                }
            }
            IPlayers Player2;
            IPlayers Generate2()
            {
                int RandCountGenerate2 = rand.Next(0, 3);
                switch (RandCountGenerate2)
                {
                    case 1:
                        {
                            string WarName = NameWarrior.GenerateNameWarrior(NameWarrior.WarriorName);
                            float WarAttack = rand.Next(20, 45);
                            float WarDefence = rand.Next(20, 35);
                            float WarHealth = rand.Next(500, 700);
                            float WarMana = rand.Next(0, 10);
                            Player2 = new Warrior(WarName, WarAttack, WarDefence, WarHealth, WarMana);
                            return Player2;
                        }
                    case 2:
                        {
                            string ArchName = NameArcher.GenerateNameArcher(NameArcher.ArcherName);
                            float ArchAttack = rand.Next(80, 100);
                            float ArchDefence = rand.Next(5, 15);
                            float ArchHealth = rand.Next(600, 900);
                            float ArchMana = rand.Next(0, 20);
                            Player2 = new Archer(ArchName, ArchAttack, ArchDefence, ArchHealth, ArchMana);
                            return Player2;
                        }
                    default:
                        {
                            string MageName = NameMage.GenerateNameMage(NameMage.MageName);
                            float MageAttack = rand.Next(10, 30);
                            float MageDefence = rand.Next(2, 5);
                            float MageHealt = rand.Next(200, 350);
                            float MageMana = rand.Next(100, 200);
                            Player2 = new Mage(MageName, MageAttack, MageDefence, MageHealt, MageMana);
                            return Player2;
                        }
                }
            }

            Generate1();
            Generate2();
            Console.WriteLine($"{Player1.Name}\t vs \t{Player2.Name}");
            Console.WriteLine($"{Player1.Attack} атаки \t{Player2.Attack} атаки");
            Console.WriteLine($"{Player1.Defence} защиты \t{Player2.Defence} защиты");
            Console.WriteLine($"{Player1.Health} здоровья \t{Player2.Health} здоровья");
            Console.WriteLine($"{Player1.Mana} Маны \t\t{Player2.Mana} Маны\n");

            while ((Player1.Health > 0) && (Player2.Health > 0))
            {
                float Damage;
                if ((Player1 is Mage) && (Player1.Mana >= 10))
                {
                    Damage = (float)(Player1.Attack * 5 / (Player2.Defence * 0.1));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} Осталось {Player1.Mana} маны.");
                    Player1.Mana = Player1.Mana - 10;
                }
                else
                {
                    Damage = (float)(Player1.Attack * 1.8 / (Player2.Defence * 1.02));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья");
                }
                if (Player2.Health > 0)
                    if ((Player2 is Mage) && (Player2.Mana >= 10))
                    {
                        Damage = (float)(Player2.Attack * 5 / (Player1.Defence * 0.1));
                        Player1.Health = Player1.Health - Damage;
                        Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} Осталось {Player2.Mana} маны.");
                        Player2.Mana = Player2.Mana - 10;
                    }
                    else
                    {
                        Damage = (float)(Player2.Attack * 1.8 / (Player1.Defence * 1.02));
                        Player1.Health = Player1.Health - Damage;
                        Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья");
                    }
                else
                {
                    Console.WriteLine($"{Player2.Name} Терпит поражение");
                }
            }

            if (Player1.Health <= 0)
            {
                Console.WriteLine($"{Player1.Name} Терпит поражение");
            }
        }
    }
}
