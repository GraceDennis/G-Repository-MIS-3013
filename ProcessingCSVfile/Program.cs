using System;
using System.Data.SqlTypes;
using System.IO;

namespace ProcessingCSVfile
{
    class Program
    {
        static void Main(string[] args)
        {
            // string filePath = @"C:\Users\grace\Downloads\__sales_data_sample.csv";
            string filePath = @"__sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            // 0 = ORDERNUMBER	1 = QUANTITYORDERED	2 = PRICEEACH 3 = ORDERLINENUMBER 4 =	SALES	ORDERDATE	STATUS	QTR_ID	MONTH_ID	YEAR_ID	PRODUCTLINE	MSRP	PRODUCTCODE	CUSTOMERNAME	PHONE	ADDRESSLINE1	ADDRESSLINE2	CITY	STATE	POSTALCODE	COUNTRY	TERRITORY	CONTACTLASTNAME	CONTACTFIRSTNAME	DEALSIZE
            // sales = 4
            //status = 6
            //year = 9
            //month = 8


            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;
            string January = "1";
            string February = "2";
            string March = "3";
            string April = "4";
            string May = "5";
            string June = "6";
            string July = "7";
            string August = "8";
            string September = "9";
            string October = "10";
            string November = "11";
            string December = "12";
            double sum = 0;

            double SumForJanuary2003 = 0;
            double SumForFebruary2003 = 0;
            double SumForMarch2003 = 0;
            double SumForApril2003 = 0;
            double SumForMay2003 = 0;
            double SumForJune2003 = 0;
            double SumForJuly2003 = 0;
            double SumForAugust2003 = 0;
            double SumForSeptember2003 = 0;
            double SumForOctober2003 = 0;
            double SumForNovember2003 = 0;
            double SumForDecember2003 = 0;

            double SumForJanuary2004 = 0;
            double SumForFebruary2004 = 0;
            double SumForMarch2004 = 0;
            double SumForApril2004 = 0;
            double SumForMay2004 = 0;
            double SumForJune2004 = 0;
            double SumForJuly2004 = 0;
            double SumForAugust2004 = 0;
            double SumForSeptember2004 = 0;
            double SumForOctober2004 = 0;
            double SumForNovember2004 = 0;
            double SumForDecember2004 = 0;

            double SumForJanuary2005 = 0;
            double SumForFebruary2005 = 0;
            double SumForMarch2005 = 0;
            double SumForApril2005 = 0;
            double SumForMay2005 = 0;
            double SumForJune2005 = 0;
            double SumForJuly2005 = 0;
            double SumForAugust2005 = 0;
            double SumForSeptember2005 = 0;
            double SumForOctober2005 = 0;
            double SumForNovember2005 = 0;
            double SumForDecember2005 = 0;
            // string filePath = @"__sales_data_sample.csv";

            // string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string status = pieces[4];
                string month = pieces[8];
                //sum = sum + Convert.ToDouble(pieces[4]);
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }

                    sum += sale;
                    if (year == "2003")
                    {
                        sumFor2003 += sale;


                        if (month == January)
                        {
                            SumForJanuary2003 += sale;

                        }
                        if (month == February)
                        {
                            SumForFebruary2003 += sale;
                        }
                        if (month == March)
                        {
                            SumForMarch2003 += sale;
                        }
                        if (month == April)
                        {
                            SumForApril2003 += sale;
                        }
                        if (month == May)
                        {
                            SumForMay2003 += sale;
                        }
                        if (month == June)
                        {
                            SumForJune2003 += sale;
                        }
                        if (month == July)
                        {
                            SumForJuly2003 += sale;
                        }
                        if (month == August)
                        {
                            SumForAugust2003 += sale;
                        }
                        if (month == September)
                        {
                            SumForSeptember2003 += sale;
                        }
                        if (month == October)
                        {
                            SumForOctober2003 += sale;
                        }
                        if (month == November)
                        {
                            SumForNovember2003 += sale;
                        }
                        if (month == December)
                        {
                            SumForDecember2003 += sale;
                        }

                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;

                        if (month == January)
                        {
                            SumForJanuary2004 += sale;
                        }
                        if (month == February)
                        {
                            SumForFebruary2004 += sale;
                        }
                        if (month == March)
                        {
                            SumForMarch2004 += sale;
                        }
                        if (month == April)
                        {
                            SumForApril2004 += sale;
                        }
                        if (month == May)
                        {
                            SumForMay2004 += sale;
                        }
                        if (month == June)
                        {
                            SumForJune2004 += sale;
                        }
                        if (month == July)
                        {
                            SumForJuly2004 += sale;
                        }
                        if (month == August)
                        {
                            SumForAugust2004 += sale;
                        }
                        if (month == September)
                        {
                            SumForSeptember2004 += sale;
                        }
                        if (month == October)
                        {
                            SumForOctober2004 += sale;
                        }
                        if (month == November)
                        {
                            SumForNovember2004 += sale;
                        }
                        if (month == December)
                        {
                            SumForDecember2004 += sale;
                        }

                    }
                    else
                    {
                        sumFor2005 += sale;

                        if (month == January)
                        {
                            SumForJanuary2005 += sale;
                        }
                        if (month == February)
                        {
                            SumForFebruary2005 += sale;
                        }
                        if (month == March)
                        {
                            SumForMarch2005 += sale;
                        }
                        if (month == April)
                        {
                            SumForApril2005 += sale;
                        }
                        if (month == May)
                        {
                            SumForMay2005 += sale;
                        }
                        if (month == June)
                        {
                            SumForJune2005 += sale;
                        }
                        if (month == July)
                        {
                            SumForJuly2005 += sale;
                        }
                        if (month == August)
                        {
                            SumForAugust2005 += sale;
                        }
                        if (month == September)
                        {
                            SumForSeptember2005 += sale;
                        }
                        if (month == October)
                        {
                            SumForOctober2005 += sale;
                        }
                        if (month == November)
                        {
                            SumForNovember2005 += sale;
                        }
                        if (month == December)
                        {
                            SumForDecember2005 += sale;
                        }
                    }
                }


            }
            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")} >>>");
            Console.WriteLine($"The sale total for 2003 is {sumFor2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for January in 2003 is {SumForJanuary2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for February in 2003 is {SumForFebruary2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for March in 2003 is {SumForMarch2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for April in 2003 is {SumForApril2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for May in 2003 is {SumForMay2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for June in 2003 is {SumForJune2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for July in 2003 is {SumForJuly2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for August in 2003 is {SumForAugust2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for September in 2003 is {SumForSeptember2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for October in 2003 is {SumForOctober2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for November in 2003 is {SumForNovember2003.ToString("C2")}");
            Console.WriteLine($"    The sale total for December in 2003 is {SumForDecember2003.ToString("C2")}");

            Console.WriteLine($"The sale total for 2004 is {sumFor2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for January in 2004 is {SumForJanuary2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for February in 2004 is {SumForFebruary2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for March in 2004 is {SumForMarch2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for April in 2004 is {SumForApril2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for May in 2004 is {SumForMay2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for June in 2004 is {SumForJune2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for July in 2004 is {SumForJuly2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for August in 2004 is {SumForAugust2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for September in 2004 is {SumForSeptember2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for October in 2004 is {SumForOctober2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for November in 2004 is {SumForNovember2004.ToString("C2")}");
            Console.WriteLine($"    The sale total for December in 2004 is {SumForDecember2004.ToString("C2")}");

            Console.WriteLine($"The sale total for 2005 is {sumFor2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for January in 2005 is {SumForJanuary2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for February in 2005 is {SumForFebruary2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for March in 2005 is {SumForMarch2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for April in 2005 is {SumForApril2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for May in 2005 is {SumForMay2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for June in 2005 is {SumForJune2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for July in 2005 is {SumForJuly2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for August in 2005 is {SumForAugust2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for September in 2005 is {SumForSeptember2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for October in 2005 is {SumForOctober2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for November in 2005 is {SumForNovember2005.ToString("C2")}");
            Console.WriteLine($"    The sale total for December in 2005 is {SumForDecember2005.ToString("C2")}");
            Console.ReadKey();
        }

    }
}
            //Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}");


            /* if (year == "2003")
            {
                sumFor2003 += sale;
            }
            else if (year == "2004")
            {
                sumFor2004 += sale;
            }
            else
            {
                sumFor2005 += sale;
            }

            sum += sale; */

        
            /*Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C")}!");
            }.");
            // pt 2 ; we have 3 years = 3 variables */
  
      
    




