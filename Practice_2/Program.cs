using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCaseState = "Inconclusives";

           // if (testCaseState == "passed")
           // {
             //   Console.WriteLine("The case passed");
          //  }
          //  else if (testCaseState == "failed")
           // {
          //      Console.WriteLine("the case failed");
          //  }
          //  else 
           // { 
            //    Console.WriteLine("inconclusive");
            //} 
            switch (testCaseState)
            {
                case "Passed":
                    {
                        Console.WriteLine("case passed");
                        break;
                    }
                case "Failed":
                    {
                        Console.WriteLine("failed case");
                        break;
                    }
                case "inconclusive":
                    {
                        Console.WriteLine("inconclusive");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("the case is not the one you sent");
                        break;
                    }


            }


            Console.ReadLine();
        } 
    }
}
