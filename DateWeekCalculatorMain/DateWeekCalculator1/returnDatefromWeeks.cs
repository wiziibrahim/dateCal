using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{
    class returnDatefromWeeks
    {
        public static string returnDate(int day, int noOfweeksDays, string month, int year)
        {
            string monthCheck4 = "January March May July August October December";//months containing 31 days
            var monthCheck5 = "April June September November Null Null Null";//months containing 30 days
            string[] monthCheckSplitWhSpace11 = monthCheck4.Split(' ');//converts string monthCheck to an array
            var monthCheckSplitWhsSpace12 = monthCheck5.Split(' ');
            string monthCheck6 = "February Null Null Null Null Null Null";//month with 28 days
            var monthCheckSplitWhSpace13 = monthCheck6.Split(' ');
            string JanuaryToDecember = "January February March April May June July August September October November December";

            int i;
            int k;
            int m;
            int countDays = day;
            int countDownWeeks = noOfweeksDays;

            for (i = 0; i < 7; i++)
            {
                //Console.WriteLine("main for loop count - " + i);
                if (month == monthCheckSplitWhSpace11[i])//check if month entered on console matches a month with 31 days
                {
                    Console.WriteLine("\n\n\t\t\t31 days month");
                    for (k = 0; k <= 4; k++)//for loop for week count
                    {
                        countDays = countDays + 7;//add 7 days to current day count to get day of the following week 
                        Console.Write("\t\t\t");
                        Console.WriteLine("day - " + countDays + ", month - " + monthCheckSplitWhSpace11[i]);
                        countDownWeeks = countDownWeeks - 7;//decrement week count by 7
                        //Console.WriteLine("\t\t\tcheck countDownWeeks = " + countDownWeeks);
                        //Console.WriteLine("\t\t\tK count = " + k + "\n");
                        if (countDownWeeks == 0)//check if week count is zero to return final date of the month
                        {
                            if (countDays > 31)//check if the current day count goes into the next month
                            {
                                countDays = countDays - 31;//obtain the day count in the following month
                                string[] nextMonth = JanuaryToDecember.Split(' ');//create an array of months from Jan to Dec
                                for (m = 0; m <= 11; m++)
                                {
                                    if (monthCheckSplitWhSpace11[i] == nextMonth[m])//search for the current month
                                    {
                                        if (monthCheckSplitWhSpace11[i] == "December")//if condition is true set month to January 
                                        {
                                            month = "January"; //set month to January 
                                            year++;//increment the year by 1 since end of 2018 is reached - beyond 31 Dec of current year
                                            //Console.WriteLine("start of new year");
                                            m = 11;
                                            k = 4;
                                            i = -1;
                                        }
                                        else
                                        {
                                            month = nextMonth[m + 1];//obtain the next month 
                                            m = 11;//make m = 11 to exit the for (m = 0; m < 11; m++) loop
                                            k = 4;
                                            i = -1;
                                        }
                                    }
                                }
                                return countDays + " " + month + " " + year;//return days count of next month if weeks count equals zero and days count>31
                            }
                            else// else if week count is not equal to zero
                            {
                                return countDays + " " + month + " " + year;
                                //return countDays + " " + monthCheckSplitWhSpace11[i];//return days count and current month if week count equals zero but the days is less than 31
                            }//the return statement above ends the for loop returns the value to the main program, as such codes below are not executed as a result.
                        }//if the "if statement" is not true nothing is returned and the codes below are executed.

                        if (countDays > 31)//check if days count is greater than 31 - if condition is not true skid the block
                        {
                            countDays = countDays - 31;//if above statement is true obtain days count of next month
                            string[] nextMonth = JanuaryToDecember.Split(' ');//create an array of months from Jan to Dec
                            for (m = 0; m <= 11; m++)
                            {
                                if (monthCheckSplitWhSpace11[i] == nextMonth[m])//search for a match of the current month from Jan to Dec
                                {
                                    if(monthCheckSplitWhSpace11[i] == "December")
                                    {
                                        month = "January";
                                        year++;
                                        //Console.WriteLine("start of new year");
                                        m = 11;
                                        k = 4;
                                        i = -1;
                                    }
                                    else
                                    {
                                        month = nextMonth[m + 1];//obtain the next month
                                        m = 11;//make m 11 to exit the for (m = 0; m < 11; m++) for loop
                                        Console.Write("\t\t\t");
                                        Console.WriteLine("\n\t\t\tEnd of the month reached\n" + "\t\t\tDay of next month - " + countDays + "\n" + "\t\t\tNext month - " + month + "\n");
                                        k = 4;//make k=4 to end the for loop as the end of the current month is reached.
                                        i = -1;//setting -=-1 allows the for (i = 0; i < 7; i++) to start count from 0.
                                    }                                   
                                }
                            }
                           // Console.WriteLine("End of the month reached,  day - " + countDays + "  month - " + month);
                            //Console.WriteLine("Week count - " + countDownWeeks + ",   k count = " + k);
                        }
                    }
                }
                

                else if (month == monthCheckSplitWhsSpace12[i])//if month matches a month with 30 days
                {
                    Console.WriteLine("\n\t\t\t30 days month");
                    for (k = 0; k <= 4; k++)
                        {
                            countDays = countDays + 7;
                            countDownWeeks = countDownWeeks - 7;
                            Console.Write("\t\t\t");
                            Console.WriteLine("day - " + countDays + ", month - " + monthCheckSplitWhsSpace12[i]);
                        if (countDownWeeks == 0)
                        {
                                if (countDays > 30)
                                {
                                    countDays = countDays - 30;
                                    string[] nextMonth = JanuaryToDecember.Split(' ');
                                    for (m = 0; m < 11; m++)
                                    {
                                        if (month == nextMonth[m])
                                        {
                                            month = nextMonth[m + 1];
                                            m = 11;
                                            Console.Write("\t\t\t");
                                            Console.WriteLine("\n\t\t\tEnd of the month reached\n" + "\t\t\tDay of next month - " + countDays + "\n" + "\t\t\tNext month - " + month + "\n");
                                            k = 4;
                                            i = -1;
                                        }
                                    }
                                    return countDays + " " + month + " " + year;
                                }
                                else
                                {
                                    return countDays + " " + month + " " + year;
                                }
                        }
                            if (countDays > 30)
                            {
                                countDays = countDays - 30;
                                string[] nextMonth = JanuaryToDecember.Split(' ');
                                for (m = 0; m < 11; m++)
                                {
                                    if (month == nextMonth[m])
                                    {
                                        month = nextMonth[m + 1];
                                        m = 11;
                                        Console.Write("\t\t\t");
                                        Console.WriteLine("\n\t\t\tEnd of the month reached\n" + "\t\t\tDay of next month - " + countDays + "\n" + "\t\t\tNext month - " + month + "\n");
                                        k = 4;
                                        i = -1;
                                    }
                                }
                            }
                    }
                }
                else if (month == monthCheckSplitWhSpace13[i])//if month matches a month with 28 days
                {
                    //Console.WriteLine("end of the month second check,  day - " + countDays + "  month - " + month);
                    //int n = (28 - countDays) / 7;
                    Console.WriteLine("\n\t\t\t28 days month");
                    for (k = 0; k <= 4; k++)
                    {
                        Console.Write("\t\t\t");
                        Console.WriteLine("day - " + countDays + ", month - " + monthCheckSplitWhSpace13[i]);
                        countDays = countDays + 7;
                        countDownWeeks = countDownWeeks - 7;
                        //Console.WriteLine("final result,  "+ "day  -"+ countDays + "weeks count - " + countDownWeeks);
                        if (countDownWeeks == 0)
                        {
                                    if (countDays > 28)
                                    {
                                        countDays = countDays - 28;
                                        string[] nextMonth2 = JanuaryToDecember.Split(' ');
                                        Console.WriteLine("final result,  " + countDays + "month - " + month);
                                        for (m = 0; m < 11; m++)
                                        {
                                            if (monthCheckSplitWhSpace13[i] == nextMonth2[m])
                                            {
                                                month = nextMonth2[m + 1];
                                                Console.Write("\t\t\t");
                                                Console.WriteLine("\n\t\t\tEnd of the month reached\n" + "\t\t\tDay of next month - " + countDays + "\n" + "\t\t\tNext month - " + month + "\n");
                                                m = 11;
                                                k = 4;
                                                i = -1;
                                            }
                                        }                               
                                        return countDays + " " + month + " " + year;
                                    }
                                    else
                                    {
                                        return countDays + " " + monthCheckSplitWhSpace13[i] + "  " + year;
                                    }
                        }

                                if (countDays > 28)
                                {
                                    countDays = countDays - 28;
                                    string[] nextMonth3 = JanuaryToDecember.Split(' ');
                                    for (m = 0; m < 11; m++)
                                    {
                                        if (monthCheckSplitWhSpace13[i] == nextMonth3[m])
                                        {
                                            month = nextMonth3[m + 1];
                                            Console.Write("\t\t\t");
                                            Console.WriteLine("\n\t\t\tEnd of the month reached\n" + "\t\t\tDay of next month - " + countDays + "\n" + "\t\t\tNext month - " + month + "\n");
                                            m = 11;                                           
                                            k = 4;
                                            i = -1;
                                        }
                                    }

                                }
                    }
                }                
            }
            return "Invalid data entered";
        }
    }
}
