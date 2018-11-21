using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWeekCalculator1
{
    public class actualWeeksCalc
    {
        public static string getDate2(int enterDateData1, int weekstoDays1, int count, string month2, string monthCheckSplitWhSpace11, string month3)
        {
            //(enterDateData, weekstoDays, iv, NewDate[1], monthCheckSplitWhSpace11[iv], splitMonths[ii])
            Console.WriteLine("NewDate - " + month2);
            Console.WriteLine("monthCheckSplitWhSpace11[iv] - " + monthCheckSplitWhSpace11);
            count = 7;
            int vi;
            int enterDateData33 = enterDateData1;
            int firstWeek2 = weekstoDays1;
            Console.WriteLine("weektoDays " + weekstoDays1);
            for (vi = 0; vi <= weekstoDays1; vi = vi + 7)
            {
                if (enterDateData33 <= 31 && firstWeek2 == 0)
                {
                    Console.WriteLine(enterDateData33 + " " + month3);
                    firstWeek2 = 0;
                    vi = weekstoDays1;
                    Console.ReadKey();
                    //return;
                }

                Console.WriteLine("Display date " + enterDateData33);
                int enterDateData44 = enterDateData33 + 7;

                int firstWeek22 = firstWeek2;
                Console.WriteLine("firstWeek22 " + firstWeek22);
                if (enterDateData44 > 31)
                {
                    int firstWeek33 = firstWeek2;
                    Console.WriteLine("firstWeek33 " + firstWeek33);

                    enterDateData33 = enterDateData33 - 31 + 7;
                    Console.WriteLine("enterDateData33 " + enterDateData33);
                }
                enterDateData33 = enterDateData33 + 7;
                firstWeek2 = firstWeek2 - 7;
            }
            return "Not valid";
        }
    }
}
