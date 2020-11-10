using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    public class Person
    {
        //things that make up what we call a person

        public string firstName { get; set; }
         public string lastName { get; set; }
        public string DOB { get; set; }
        public string favfood { get; set; }
        public double accountbalance { get; set; }

      //  public void SetAccountBalance (double val)
     

        
        public Person()
        {
            //starting values for all stuff
            firstName = string.Empty;
            lastName = string.Empty;
            DOB = string.Empty;
            favfood = string.Empty;
            accountbalance = 0;

            //we are building the house but not picking out colors or tile

        }
        public Person (string fName, string lname, string dob, string food, double bal)
        {
                firstName = fName;
                lastName = lname;
                DOB = dob;
                accountbalance = bal;
        }

        public override string ToString()
        {
            string output = $"{firstName} {lastName} {DOB} likes {favfood} and has {accountbalance.ToString("C")}";
            return output;
        }

    }
}
