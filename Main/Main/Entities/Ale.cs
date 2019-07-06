using System;
using System.Collections.Generic;
using System.Text;

namespace BeerFactory.Entities
{
    class Ale
    {
        private string name; 
        private string type;
        private string alcohol;

        public Ale()
        {
        }

        public Ale(string name, string type, string alcohol)
        {
            this.getName = name;
            this.getType = type;
            this.getAlcohol = alcohol;
        }


        public string getName
        {
            get { return name; }
            set { name = "AleRazor"; }
        }

        public string getType
        {
            get { return type; }
            set { type = value; }
        }

        public string getAlcohol
        {
            get { return alcohol; }
            set { alcohol = value; }
        }
    }
}
