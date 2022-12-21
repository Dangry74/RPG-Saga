using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    internal class NameMage
    {
        public static string[] MageName = { "Аваддон", "Вальдемар", "Воланд",
        "Идрис", "Люциферус", "Малигос"};

        public static string GenerateNameMage(string[] MagerName)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 5);
            return MageName[value];
        }
    }
}
