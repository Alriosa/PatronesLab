using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BeerFactory.Entities
{
    public class Lager
    {
        private string name;
        private string type;
        private string alcohol;

        public Lager()
        {
        }

        public Lager(string name, string type, string alcohol)
        {
            this.name = name;
            this.type = type;
            this.alcohol = alcohol;
        }
    }
}
