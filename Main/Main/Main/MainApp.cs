using System;
using BeerFactory.Entities;
using BeerFactory.Factory;
using BeerFactory.Interfaces;



namespace MainClass
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Ale ale = new Ale();
            Lager lager = new Lager();
            Pilsener pilsener = new Pilsener();

            int option;
            string nameServe="";
            string typeServe = "";
            string alcoholServe = "";

            Console.WriteLine("Welcome to Razor bar, which beer do you want?");
            Console.WriteLine("1- Lagger");
            Console.WriteLine("2- Ale");
            Console.WriteLine("3- Pilsener");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    nameServe = ale.getName;
                    typeServe = ale.getType;
                    alcoholServe = ale.getAlcohol;
                    Console.WriteLine(nameServe);
                    Console.WriteLine(typeServe);
                    Console.WriteLine(alcoholServe);
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
            }
        }
    }
}
