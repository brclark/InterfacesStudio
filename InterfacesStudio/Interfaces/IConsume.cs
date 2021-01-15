using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesStudio.Interfaces
{
    public interface IConsume
    {
        public double Health { get; set; }
        public double Magic { get; set; }

        // Affects Health
        public void OmNomNom(IConsumable item);

        // Affects Magic
        public void GulpUlpUlp(IConsumable item);
    }
}
