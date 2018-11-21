using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{
    class LoginData
    {
        public static string loginInfo(string username, string password) {
            int noOfEntries = 0;
            while (noOfEntries < 3)
            {              
                if (username == "ibrahim" & password=="chowizi")
                {
                    noOfEntries = 3;
                    return "Login successful";
                }
                else
                {
                    Console.Write("\t\t\t");
                    Console.WriteLine("Incorrect login ID");
                    while (noOfEntries <2)
                    {
                        Console.WriteLine("\n\n\n");
                        Console.Write("\t\t\t");
                        Console.WriteLine("Enter username");
                        Console.Write("\t\t\t");
                        String username2 = Console.ReadLine();
                        Console.Write("\t\t\t");
                        Console.WriteLine("Enter password");
                        Console.Write("\t\t\t");
                        String password2 = Console.ReadLine();

                        if (username2 == "ibrahim" & password2 == "chowizi")
                        {
                            noOfEntries = 2;
                            return "Login successful";
                        }
                        else
                        {
                            Console.Write("\t\t\t");
                            Console.WriteLine("Incorrect login ID");
                            noOfEntries ++;
                        }                         
                    }
                    Console.Write("\t\t\t");
                    Console.WriteLine("Account locked - too many failed entries");                       
                    Console.ReadKey();
                    return "locked"; 
                }
            }
            return "invalid login ID";
        }
    }
}
