using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_Classes_2_Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Toy()
        {
            Manufacturer  = "";
            Notes = "Rememer to shuffle the cards.";
            Name = "";
            Price = 0; 
        }
        //class using manufacturer previous class
        public string GetAisle()
        {
            //initializing new instance of Random class
            Random rand = new Random();
            // .Next returns a non-negatice 
            int find = rand.Next(1, 25);
            char manuletter = Manufacturer[0];
            string getaisle = $"{manuletter}" + $"{find}";
            return getaisle;

        }
    }
}
