using System;
using System.Collections.Generic;

namespace InterfacesStudio
{
    public class Inventory
    {
        public List<Item> Items { get; set; }
        public int Size { get; set; }

        public Inventory() : this(4){ }

        public Inventory(int size)
        {
            Items = new List<Item>();
            Size = size;
        }

    }
}
