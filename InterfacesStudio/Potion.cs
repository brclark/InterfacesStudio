using System;
using InterfacesStudio.Interfaces;

namespace InterfacesStudio
{
    public class Potion : Item, IConsumable
    {
        public double BoonOrIll { get; set; }
        public int NumUses { get; set; }

        public Potion(string name, double boonOrIll, int numUses)
        {
            Name = name;
            NumUses = numUses;
            BoonOrIll = boonOrIll;
        }
    }
}
