using System;
using System.Collections.Generic;
using System.Text;
using InterfacesStudio.Interfaces;

namespace InterfacesStudio
{

    public class Hero : IConsume, IMortal
    {
        private const int MAX_HEALTH = 100;
        private const int MAX_MAGIC = 100;

        private static int NextId = 1;

        public int Id { get; private set; }
        public Inventory Inventory { get; set; }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Strength { get; set; }

        public double Magic { get; set; }
        public double Mana { get; set; }

        public int Gold { get; set; }
        public double Experience { get; set; }
        public int Level { get; set; }

        public Hero()
        {
            Id = NextId;
            NextId++;
            Inventory = new Inventory();
            Experience = 0;
            Level = 0;
            Gold = 10;
        }

        public Hero(string name, double strength, double magic) : this()
        {
            Name = name;
            Strength = strength;
            Magic = magic;
            Health = 5.0 + strength / 2;
            Mana = 5.0 + magic / 2;

        }

        public void Acquire(Item item)
        {
            if (item.Space + Inventory.Items.Count <= Inventory.Size)
            {
                Inventory.Items.Add(item);
            }
        }

        public void Toss(Item item)
        {
            Inventory.Items.Remove(item);
        }

        public double Attack(IMortal mortal)
        {

        }

        // Affects Health
        public void OmNomNom(IConsumable item)
        {
            // TODO
        }
        public void GulpUlpUlp(IConsumable item)
        {
            // TODO
        }
        
    }
}
