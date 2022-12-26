using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    public class NameWarrior
    {
        public static string[] WarriorName = { "Груток", "Шугог", "Мугруб",
        "Абзуг", "Гурдах", "Вархал"};

        public static string GenerateNameWarrior(string[] WarriorName)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 5);
            return WarriorName[value];
        }
    }
}
