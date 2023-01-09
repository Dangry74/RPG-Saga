using Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Saga
{
    internal class Status
    {
        bool bleeding = false;
        bool fire = false;
        int BleedingTime;
        int FireTime;
        int i = 3;
        public static float  UseStatus (IPlayers Player, string Name, float Health, int ID)
        {
            var st = new Status ();
            if ((ID == 1) && (st.bleeding == false))
            {
                st.BleedingTime = st.i;
                st.bleeding=true;
                Player.Health = Player.Health-20;
                Console.WriteLine($"{Name} получает 20 урона от кровотечения");
                return Player.Health;
            }
            else if (st.BleedingTime !=0)
            {
                st.BleedingTime = st.BleedingTime - 1;
                Player.Health = Player.Health - 20;
                Console.WriteLine($"{Name} получает 20 урона от кровотечения");
                if (st.BleedingTime == 0)
                {
                    st.bleeding = false;
                }
                return Player.Health;
            }

            if ((ID == 2) && (st.fire == false))
            {
                st.FireTime = st.i;
                st.fire = true;
                Player.Health = Player.Health - 20;
                Console.WriteLine($"{Name} получает 20 урона от огня");
                return Player.Health;
            }
            else if (st.FireTime != 0)
            {
                st.FireTime = st.FireTime - 1;
                Player.Health = Player.Health - 20;
                Console.WriteLine($"{Name} получает 20 урона от огня");
                if (st.FireTime == 0)
                {
                    st.fire = false;
                }
                return Player.Health;
            }

            else return 0;

        }
    }
}
