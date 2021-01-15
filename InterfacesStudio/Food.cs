using System;
using InterfacesStudio.Interfaces;

namespace InterfacesStudio
{
    public class Food : Item, IConsumable
    {
        public double BoonOrIll { get; set; }
        public int NumUses { get; set; }

        public Food(string name, double boonOrIll, int numUses)
        {
            Space = 1;
            Name = name;
            NumUses = numUses;
            BoonOrIll = boonOrIll;
        }

    }
}
