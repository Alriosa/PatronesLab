using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BeerFactory.Entities
{
    public class Lager : Beer
    {
     
        public Lager(string name, string type, string alcohol) : base(name, type, alcohol)
        {
            this.getName = "Lagerazor";
            this.getType = "Lager";
            this.getAlcohol = "4% Alcohol";
        }
    }
}
