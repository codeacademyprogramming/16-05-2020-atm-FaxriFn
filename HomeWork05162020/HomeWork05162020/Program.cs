using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05162020
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Console Color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            #endregion


            #region ATM-program
            Console.WriteLine("Please enter pin:");
            Console.WriteLine("\n");
            Atm atm = new Atm();
            string pin = Console.ReadLine();
            atm.Operation(pin);
            #endregion





        }

   
    }
}
