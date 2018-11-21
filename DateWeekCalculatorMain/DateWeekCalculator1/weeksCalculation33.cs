using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{
    public class weeksCalculation33
    {
        public static string getDate(int date, string month)
        {
            string monthCheck = "January March May July August October December";//months containing 31 days
            var monthCheck2 = "April June September November Null Null Null";//months containing 30 days
            string[] monthCheckSplitWhSpace = monthCheck.Split(' ');//converts string monthCheck to an array
            var monthCheckSplitWhsSpace2 = monthCheck2.Split(' ');
            string monthCheck3 = "February Null Null Null Null Null Null";
            var monthCheckSplitWhSpace3 = monthCheck3.Split(' ');

            int iii;
            if (date <= 0 || date > 31)//validate if date is between 0 and 31 days 
            {
                return "Invalid try again";
            }
            else
            {
                for (iii = 0; iii < 7; iii++)
                {
                    if (month == monthCheckSplitWhSpace[iii])//check if date entered is for month containing 31 days
                    {
                        Console.Write("\t\t\t");
                        Console.WriteLine("Month contains 31 days");
                        string dateData = date + " " + month;
                        //string dateData = month;
                        //Console.Write("\t\t\t");
                        //Console.WriteLine((31 - date) + " days left to end of the month");
                        return dateData + " " + (31 - date);

                    }
                    else if ((month == monthCheckSplitWhsSpace2[iii]))

                    {
                        Console.Write("\t\t\t");
                        Console.WriteLine("Month contains 30 days");
                        string dateData = date + " " + month;
                        //string dateData = month;
                        Console.Write("\t\t\t");
                        Console.WriteLine((30 - date) + " days left to end of the month");
                        return dateData + " " + (31 - date);
                    }
                    else if (month == monthCheckSplitWhSpace3[iii])

                    {
                        Console.Write("\t\t\t");
                        Console.WriteLine("Month contains 28 days");
                        string dateData = date + " " + month;
                        Console.Write("\t\t\t");
                        Console.WriteLine((28 - date) + " days left to end of the month");
                        return dateData + " " + (28 - date);
                    }
                }
                return "Invalid entry";
            }
            // return "not for Month with 31 days";
        }

    }
}
