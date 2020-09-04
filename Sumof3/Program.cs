using System;

namespace Sumof3
{
    class Program
    {
        readonly int firstnum = 0;
        int secondnum = 0;
        int thirdnum = 0;
        string firstresponse = "";
        string secondresponse = "";
        string thirdresponse = "";

        /* THIS PART IS FOR USER TO ENTER 3 DIFFERENT NUMBERS */
        Console.WriteLine( " Please enter three different numbers 1 is a valid input and so is 5.5 >>" );
        firstresponse = Console.ReadLine(); 
            firstnum = Convert.ToDouble(firstresponse);
        secondresponse = Console.ReadLine(); 
            secondnum = Convert.ToDouble(secondresponse); 
        thirdresponse = Console.ReadLine();
            thirdnum = Convert.ToDouble(thirdresponse);
            
    /* TO PRINT THE SUM with 3 decimal places */
        int sum = firstnum + secondnum + thirdnum;
        Console.WriteLine("sum");

    /* MULTIPLY <<< THE SUM BY A CONST VALUE OF 7.777 */
    /* HINT MAKE CONST VARIABLE DOUBLE */ 
    const double value = 7.777
public Program(string firstesponse)
        {
            this.firstesponse = firstesponse;
        }

        Console.WriteLine("Multiply by 7.777"); 

       


    
    }