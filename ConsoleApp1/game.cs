using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // access modifier
    public class game
    {
        // rating   =
        // name     = =
        // platform = = = properties
        // costs    = =
        // sold out =
        //access modifier
        public String Name { get; set; }
        public int rating { get; set; }
        public double costs { get; set; }
        public String Platform { get; set; }
        public Boolean soldOut { get; set; }

        public int Persons { get; set; }

        // access modifier: return type (void)
        public void Start()
        {
            // code block
            //Console.WriteLine(Name + " wordt gestart...");
        }
        public void PrintRating()
        {
            // code block
        }
        public void PrintCosts()
        {
            // code block
            Console.WriteLine("Dit spel kost $" + costs);
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        public void StelNameEnRatingIn(String nameGame, int rating123)
        {
            //Rating is property = waarde argument
            Name = nameGame;
            rating = rating123;
            Console.WriteLine(Name + " wordt gestart...");
            Console.WriteLine("De rating van dit spel is " + rating);

        }
        public void StelAllesIn(String nameGame, int rating123, double Waarde, string Waar, Boolean Uitverkocht)
        {
            //Rating is property = waarde argument
            Name = nameGame;
            rating = rating123;
            costs = Waarde;
            Platform = Waar;
            soldOut = Uitverkocht;  
            Console.WriteLine(Name + " wordt gestart...");
            Console.WriteLine("De rating van dit spel is " + rating);
            Console.WriteLine("De waarde van dit spel is $" + costs);
            Console.WriteLine("Je kunt dit spel vinden op " + Platform);
            Console.WriteLine("uitverkocht? " + soldOut);

        }
        public int WatIsDeRating()
        {

            return rating +3;
        }

        public Boolean IsRatingHogerDan5() 
        {
            if (rating > 5) 
                return true;
            else return false;
        }
    }
}
