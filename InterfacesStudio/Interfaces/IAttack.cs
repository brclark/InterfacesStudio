using System;
namespace InterfacesStudio.Interfaces
{
    public interface IAttack
    {
        public double Strength { get; set; }

        public double Attack(IMortal mortal);

    }
}
