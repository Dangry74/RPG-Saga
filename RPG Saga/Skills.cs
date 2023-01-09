using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RPG_Saga
{
    internal class Skills
    {
        string Name { get; set; }

        public Skills(string name) 
        {
            Name = name;
        }


        Skills ShieldStrike = new Skills("Рассекающий удар");
        Skills FireArrow = new Skills("Огненная стрела");
        Skills FireBall = new Skills("магическая стрела");

        public static bool ApplicationSkills(IPlayers Player, float Attack, float Defence, float Health, float Mana, bool Skil)
        {
            Random rnd = new Random();
            if (Player is Warrior)
            {
                if (Player.Mana >= 10)
                {
                    double Probability = 20;
                    double Chance = rnd.Next(0, 100);
                    if (Chance < Probability)
                    {
                        Player.Skil = true;
                        Player.Mana=Player.Mana - 10;
                    }
                    return Player.Skil;
                }
            }

            if(Player is Archer)
            {
                if(Player.Mana >= 10)
                {
                    double Probability = 20;
                    double Chance = rnd.Next(0, 100);
                    if (Chance < Probability)
                    {
                        Player.Skil = true;
                        Player.Mana = Player.Mana - 10;
                    }
                    return Player.Skil;
                }
            }

            if(Player is Mage)
            {
                if (Player.Mana >= 10)
                {
                    double Probability = 95;
                    double Chance = rnd.Next(0, 100);
                    if (Chance < Probability)
                    {
                        Player.Skil = true;
                        Player.Mana = Player.Mana - 10;
                    }
                    return Player.Skil;
                }
            }

            return false;

        }

        public static int SelectSkills(IPlayers Player, bool Skil)
        {
            if (Player is Warrior) { return 1; }
            if (Player is Archer) { return 2; }
            if (Player is Mage) { return 3; }
            else return 0;
        }


        public static float UseSkills(IPlayers Player1, IPlayers Player2, string Name1, string Name2, float Attack, float defence, float health, float mana, int ID )
        {
            float Damage;
            switch(ID)
            {
                case 1:
                    Damage = (float)(Player1.Attack * 3 / (Player2.Defence * 1.02));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} применяет рассекающий удар");
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                    return Player2.Health;
                case 2:
                    Damage = (float)(Player1.Attack * 2.5 / (Player2.Defence * 1.02));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} применяет Огенную стрелу");
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                    return Player2.Health;
                case 3:
                    Damage = (float)(Player1.Attack * 5 / (Player2.Defence * 0.1));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} применяет магическую стрелу");
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name}   {Damage}  Урона. У  {Player2.Name}  осталось  {Player2.Health}  здоровья. У  {Player1.Name}  осталось  {Player1.Mana} маны.");
                    return Player2.Health;
                default: return 0;
            }
        }
    }


}
