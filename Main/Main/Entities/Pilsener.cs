using System;
using System.Collections.Generic;
using System.Text;

namespace BeerFactory.Entities
{
    class Pilsener : Beer
    {
        public Pilsener(string name, string type, string alcohol) : base(name, type, alcohol)
        {
            this.getName = "Pilserazor";
            this.getType = "Pilser";
            this.getAlcohol = "6% Alcohol";
        }
    }
}
