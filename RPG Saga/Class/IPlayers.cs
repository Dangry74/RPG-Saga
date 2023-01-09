using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public interface IPlayers
    {
        string Name { get; set; }
        float Attack { get; set; }
        float Defence { get; set; }
        float Health { get; set; }
        float Mana { get; set; }
        bool Skil { get; set; }
    }
}
