using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{

class Program
{
    static void Main(string[] args)
    {
            LoginData loginID = new LoginData();//login class LoginData
            Console.WriteLine("\n\n\n");
            Console.Write("\t\t\t");
            Console.WriteLine("Enter username:");
            Console.Write("\t\t\t");
            String Username = Console.ReadLine();
            Console.Write("\t\t\t");
            Console.WriteLine("Enter Password:");
            Console.Write("\t\t\t");
            String Password = Console.ReadLine();

            String account = LoginData.loginInfo(Username, Password);
            if (account=="locked")
            {
                //Console.ReadKey();
                return;
            }
            else
            {
                Console.Write("\t\t\t");
                Console.WriteLine(account);
            }

            string months = "January February March April May June July August September October November December";
        var splitMonths = months.Split(' ');//split the string months into an array by whitespace ' '
                                            /*Console.WriteLine(splitMonths[0]);//return string in position 0 which is January
                                            Console.WriteLine(splitMonths[0].Length);//prints to console length of January
                                            Console.WriteLine(months.Length);//prints to console length of string month
                                            var whiteSpace = months.IndexOf(' ');//evaluate the position of the first whitespace in string months
                                            //Console.WriteLine(whiteSpace);// print the position represented by the first whitespace in months
                                            var L = months.LastIndexOf(Console.ReadLine());
                                            Console.WriteLine(L);*/

        Console.WriteLine("\n\n");//create new line in console
        Console.Write("\t\t\t");//create tab in console
        Console.WriteLine("Enter the Month of the year:");
        Console.Write("\t\t\t");
        string newMonth = Console.ReadLine();//enter month of the year on Console and store in newMonth
        int ii;
        for (ii = 0; ii < 12; ii++)
        {
            //Console.WriteLine(splitMonths[ii]);
            if (newMonth == splitMonths[ii])//if  newMonth is equal to the matching month in the for loop
                                            //execute the code below. The purpose of this code is to determine the number of the particular month
                                            //in the year. If April was entered on the console then ii+1 should be 4.
            {
                Console.Write("\t\t\t");
                Console.WriteLine("Month Entered is - " + splitMonths[ii]);
                Console.Write("\t\t\t");
                Console.WriteLine("Month " + (ii + 1) + " of the year");

                Console.ReadKey();
                Console.WriteLine("\n\n");
                Console.Write("\t\t\t");
                Console.WriteLine("Months to Year End as Follows:");
                Console.WriteLine("\n");
                int startMonthCal;
                for (startMonthCal = ii + 1; startMonthCal < 12; startMonthCal++)//display the remaining months of the year                                                                                //starting from month determined in for loop above. 
                {
                    Console.Write("\t\t\t");
                    Console.WriteLine(splitMonths[startMonthCal]);
                }
                //Console.ReadKey();
                // return;//at end of result return to start of code. 
                Console.WriteLine("\n");
                Console.Write("\t\t\t");
                Console.WriteLine("Enter date of the month");
                Console.Write("\t\t\t");
                int enterDateData = int.Parse(Console.ReadLine()); //Convert number string from console to integer
                    weeksCalculation33 getDate44 = new weeksCalculation33();
                string showDateResult = weeksCalculation33.getDate(enterDateData, splitMonths[ii]); //execute method getDate with two parameters (date and month)               
                string[] NewDate = showDateResult.Split(' ');
                    Console.Write("\t\t\t");
                    Console.WriteLine("Date Entered is - " + NewDate[0] + " " + NewDate[1]);
                    Console.Write("\t\t\t");
                    Console.WriteLine("Days to end of " + NewDate[1] + " = " + NewDate[2]);
                int UU = int.Parse(NewDate[2]);
                    //Console.WriteLine(UU);
                    Console.WriteLine("\n\t\t\t");
                    Console.WriteLine("\n\t\t\tEnter year: ");
                    Console.Write("\t\t\t");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n\n");
                    Console.Write("\t\t\t");
                    Console.WriteLine("Enter number of weeks");
                    Console.Write("\t\t\t");
                    int weekstoDays = int.Parse(Console.ReadLine()) * 7;// convert weeks into integer and get total no of days

                    Console.Write("\t\t\t");
                    Console.WriteLine("Number of weeks = " + weekstoDays + "days");
                    //Console.WriteLine("date - " + enterDateData);

                    string result = returnDatefromWeeks.returnDate(enterDateData, weekstoDays, newMonth, year);
                    Console.WriteLine("\n\n\t\t\t" + (weekstoDays/7) + 
                        " weeks from" + " " + NewDate[0] + " " + NewDate[1] + " " + year + " is:-" + "\n\t\t\t"+ result);                  
                    Console.ReadKey();
            }
        }
    }    
}
}
