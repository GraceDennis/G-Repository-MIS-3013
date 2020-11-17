using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_Classes_2_Toys
{
    class ToyBox
    { 
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            //setting Toys to a new instance of toys
            Toys = new List<Toy>();
        }

    }
}
