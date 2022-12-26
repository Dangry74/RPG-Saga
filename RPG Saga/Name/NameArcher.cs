using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    public class NameArcher
    {
        public static string[] ArcherName = { "Амрас", "Аредэль", "Галадриэль",
        "Ингвэ", "Келегорм", "Маблунг"};

        public static string GenerateNameArcher(string[] ArcherName)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 6);
            return ArcherName[value];
        }
    }
}
