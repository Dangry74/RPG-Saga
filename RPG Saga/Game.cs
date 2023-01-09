﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Saga
{
    using Artefact;
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
                int RandCountGenerate1 = rand.Next(1, 4);
                switch (RandCountGenerate1)
                {
                    case 1:
                        {
                            string WarName = NameWarrior.GenerateNameWarrior(NameWarrior.WarriorName);
                            float WarAttack = rand.Next(20, 45);
                            float WarDefence = rand.Next(20, 35);
                            float WarHealth = rand.Next(500, 700);
                            float WarMana = rand.Next(10, 30);
                            Player1 = new Warrior(WarName, WarAttack, WarDefence, WarHealth, WarMana, false);
                            return Player1;
                        }
                    case 2:
                        {
                            string ArchName = NameArcher.GenerateNameArcher(NameArcher.ArcherName);
                            float ArchAttack = rand.Next(80, 100);
                            float ArchDefence = rand.Next(5, 15);
                            float ArchHealth = rand.Next(600, 900);
                            float ArchMana = rand.Next(10, 30);
                            Player1 = new Archer(ArchName, ArchAttack, ArchDefence, ArchHealth, ArchMana, false);
                            return Player1;
                        }
                    default:
                        {
                            string MageName = NameMage.GenerateNameMage(NameMage.MageName);
                            float MageAttack = rand.Next(10, 30);
                            float MageDefence = rand.Next(2, 5);
                            float MageHealt = rand.Next(200, 350);
                            float MageMana = rand.Next(100, 200);
                            Player1 = new Mage(MageName, MageAttack, MageDefence, MageHealt, MageMana, false);
                            return Player1;
                        }
                }
            }
            IPlayers Player2;
            IPlayers Generate2()
            {
                int RandCountGenerate2 = rand.Next(1, 4);
                switch (RandCountGenerate2)
                {
                    case 1:
                        {
                            string WarName = NameWarrior.GenerateNameWarrior(NameWarrior.WarriorName);
                            float WarAttack = rand.Next(20, 45);
                            float WarDefence = rand.Next(20, 35);
                            float WarHealth = rand.Next(500, 700);
                            float WarMana = rand.Next(10, 30);
                            Player2 = new Warrior(WarName, WarAttack, WarDefence, WarHealth, WarMana, false);
                            return Player2;
                        }
                    case 2:
                        {
                            string ArchName = NameArcher.GenerateNameArcher(NameArcher.ArcherName);
                            float ArchAttack = rand.Next(80, 100);
                            float ArchDefence = rand.Next(5, 15);
                            float ArchHealth = rand.Next(600, 900);
                            float ArchMana = rand.Next(10, 30);
                            Player2 = new Archer(ArchName, ArchAttack, ArchDefence, ArchHealth, ArchMana, false);
                            return Player2;
                        }
                    default:
                        {
                            string MageName = NameMage.GenerateNameMage(NameMage.MageName);
                            float MageAttack = rand.Next(10, 30);
                            float MageDefence = rand.Next(2, 5);
                            float MageHealt = rand.Next(200, 350);
                            float MageMana = rand.Next(100, 200);
                            Player2 = new Mage(MageName, MageAttack, MageDefence, MageHealt, MageMana, false);
                            return Player2;
                        }
                }
            }

            Generate1();
            Generate2();

            Console.WriteLine("Базовые характеристики:");
            Console.WriteLine($"{Player1.Name}\t vs \t{Player2.Name}");
            Console.WriteLine($"{Player1.Attack} атаки \t{Player2.Attack} атаки");
            Console.WriteLine($"{Player1.Defence} защиты \t{Player2.Defence} защиты");
            Console.WriteLine($"{Player1.Health} здоровья \t{Player2.Health} здоровья");
            Console.WriteLine($"{Player1.Mana} Маны \t\t{Player2.Mana} Маны\n");

            Artefact.UpCharacteristic(Player1, Player1.Attack, Player1.Defence, Player1.Health, Player1.Mana);
            Artefact.UpCharacteristic(Player2, Player2.Attack, Player2.Defence, Player2.Health, Player2.Mana);

            Console.WriteLine("\t ");

            Console.WriteLine("Характеристики с учётом артефактов:");
            Console.WriteLine($"{Player1.Name}\t vs \t{Player2.Name}");
            Console.WriteLine($"{Player1.Attack} атаки \t{Player2.Attack} атаки");
            Console.WriteLine($"{Player1.Defence} защиты \t{Player2.Defence} защиты");
            Console.WriteLine($"{Player1.Health} здоровья \t{Player2.Health} здоровья");
            Console.WriteLine($"{Player1.Mana} Маны \t\t{Player2.Mana} Маны\n");

            bool FlagStan1 = false;
            bool FlagFireArrow1 = false;
            bool FlagFireBall1 = false;
            bool FlagStan2 = false;
            bool FlagFireArrow2 = false;
            bool FlagFireBall2 = false;

            /*while ((Player1.Health > 0) && (Player2.Health > 0))
            {
                FlagStan1 = false;
                FlagFireArrow1 = false;
                FlagFireBall1 = false;
                int Id;
                float Damage;
                Skills.ApplicationSkills(Player1, Player1.Attack, Player1.Defence, Player1.Health, Player1.Mana, Player1.Skil);
                if (Player1.Health > 0)
                {
                    while (FlagStan2 == false)
                    {
                        if (Player1.Skil == true)
                        {
                            Id = Skills.SelectSkills(Player1, Player1.Skil);

                            switch (Id)
                            {
                                case 1:
                                    FlagStan1 = true;
                                    Damage = (float)(Player1.Attack * 1.8 / (Player2.Defence * 1.02));
                                    Player2.Health = Player2.Health - Damage;
                                    Console.WriteLine($"{Player1.Name} применяет Удар щитом");
                                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                                    break;
                                case 2:
                                    FlagFireArrow1 = true;
                                    Damage = (float)(Player1.Attack * 1.8 / (Player2.Defence * 1.02));
                                    Player2.Health = Player2.Health - Damage;
                                    Console.WriteLine($"{Player1.Name} применяет Огенную стрелу");
                                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                                    break;
                                case 3:
                                    FlagFireBall1 = true;
                                    Damage = (float)(Player1.Attack * 5 / (Player2.Defence * 0.1));
                                    Player2.Health = Player2.Health - Damage;
                                    Console.WriteLine($"{Player1.Name} применяет Огенный шар");
                                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                                    break;
                            }
                        }

                        else
                        {
                            Damage = (float)(Player1.Attack * 1.8 / (Player2.Defence * 1.02));
                            Player2.Health = Player2.Health - Damage;
                            Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                        }

                        break;
                    }

                }

                if (Player2.Health > 0)
                {
                    FlagStan2 = false;
                    FlagFireArrow2 = false;
                    FlagFireBall2 = false;
                    while (FlagStan1 == false)
                    {
                        Skills.ApplicationSkills(Player2, Player2.Attack, Player2.Defence, Player2.Health, Player2.Mana, Player2.Skil);
                        if (Player2.Skil == true)
                        {
                            Id = Skills.SelectSkills(Player2, Player2.Skil);

                            switch (Id)
                            {
                                case 1:
                                    FlagStan2 = true;
                                    Damage = (float)(Player2.Attack * 1.8 / (Player1.Defence * 1.02));
                                    Player1.Health = Player1.Health - Damage;
                                    Console.WriteLine($"{Player2.Name} применяет Удар щитом");
                                    Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} осталось {Player2.Mana} маны.");
                                    break;
                                case 2:
                                    FlagFireArrow2 = true;
                                    Damage = (float)(Player2.Attack * 1.8 / (Player1.Defence * 1.02));
                                    Player2.Health = Player1.Health - Damage;
                                    Console.WriteLine($"{Player2.Name} применяет Огенную стрелу");
                                    Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} осталось {Player2.Mana} маны.");
                                    break;
                                case 3:
                                    FlagFireBall2 = true;
                                    Damage = (float)(Player2.Attack * 5 / (Player1.Defence * 0.1));
                                    Player1.Health = Player1.Health - Damage;
                                    Console.WriteLine($"{Player2.Name} применяет Огенный шар");
                                    Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} осталось {Player2.Mana} маны.");
                                    break;
                            }
                        }

                        else
                        {
                            Damage = (float)(Player2.Attack * 1.8 / (Player1.Defence * 1.02));
                            Player1.Health = Player1.Health - Damage;
                            Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} осталось {Player2.Mana} маны.");
                        }

                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{Player2.Name} Терпит поражение");
                }

            }
            if (Player1.Health <= 0)
            {
                Console.WriteLine($"{Player1.Name} Терпит поражение");
            }*/




            int Id = 0;


            while ((Player1.Health > 0) && (Player2.Health > 0))
            {
                float Damage;
                Player1.Skil = false;
                Skills.ApplicationSkills(Player1, Player1.Attack, Player1.Defence, Player1.Health, Player1.Mana, Player1.Skil);
                Status.UseStatus(Player1, Player1.Name, Player1.Health, Id);
                Id = 0;
                if (Player1.Skil==true)
                {
                    Id = Skills.SelectSkills(Player1, Player1.Skil);
                   Skills.UseSkills(Player1, Player2, Player1.Name, Player2.Name, Player1.Attack, Player2.Defence, Player2.Health, Player1.Mana, Id);
                }
                else
                {
                    Damage = (float)(Player1.Attack * 1.8 / (Player2.Defence * 1.02));
                    Player2.Health = Player2.Health - Damage;
                    Console.WriteLine($"{Player1.Name} наносит {Player2.Name} {Damage} Урона. У {Player2.Name} осталось {Player2.Health} здоровья. У {Player1.Name} осталось {Player1.Mana} маны.");
                }
                if (Player2.Health > 0)
                {
                    Player2.Skil = false;
                    Skills.ApplicationSkills(Player2, Player2.Attack, Player2.Defence, Player2.Health, Player2.Mana, Player2.Skil);
                    Status.UseStatus(Player2, Player2.Name, Player2.Health, Id);
                    Id = 0;
                    if (Player2.Skil==true)
                    {
                        Id = Skills.SelectSkills(Player2, Player2.Skil);
                        Skills.UseSkills(Player2, Player1, Player2.Name, Player1.Name, Player2.Attack, Player1.Defence, Player1.Health, Player2.Mana, Id);
                    }
                    else
                    {
                        Damage = (float)(Player2.Attack * 1.8 / (Player1.Defence * 1.02));
                        Player1.Health = Player1.Health - Damage;
                        Console.WriteLine($"{Player2.Name} наносит {Player1.Name} {Damage} Урона. У {Player1.Name} осталось {Player1.Health} здоровья. У {Player2.Name} осталось {Player2.Mana} маны.");
                    }
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
