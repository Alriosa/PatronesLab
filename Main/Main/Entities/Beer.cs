namespace BeerFactory.Entities
{
    public class Beer
    {
        private string name; 
        private string type;
        private string alcohol;

        public Beer()
        {

        }


        public Beer(string name, string type, string alcohol)
        {
            
        }

        public string getName
        {
            get { return name; }
            set { name = value; }
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
