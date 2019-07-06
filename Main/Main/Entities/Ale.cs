using System;
using System.Collections.Generic;
using System.Text;

namespace BeerFactory.Entities
{
    class Ale : Beer
    {
        public Ale(string name, string type, string alcohol) : base(name, type, alcohol)
        {
        }
    }
}
