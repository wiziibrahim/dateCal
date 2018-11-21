using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Hello Ibrahim");
            Console.ReadKey();
            CalCulateDaysOfWeek(300);
        }

        static void CalCulateDaysOfWeek();
        int days = 7;
        if(days <0) {
            Console.Write("Invalid Week");
        } else {
    internal int Weeks = days / 7;
    Console.Write(Weeks);
    }

}
}
