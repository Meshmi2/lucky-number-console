using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LUCKY_NUMBER_V2._0_CONSOLE_APP
{
    namespace Luckynumber
    {
        class Program
        {
            static void Main(string[] args)
            {
                // creates a number between 1 and 90
                Random numerocasuale = new Random();
                int numero1 = numerocasuale.Next(1, 90);
                int numero2 = numerocasuale.Next(1, 90);
                int numero3 = numerocasuale.Next(1, 90);
                int numero4 = numerocasuale.Next(1, 90);
                int numero5 = numerocasuale.Next(1, 90);
                int numero6 = numerocasuale.Next(1, 90);
                // show the number with a pause of 3000 milliseconds
                Console.WriteLine("hello :) the lucky number for today are...");
                Thread.Sleep(3000);
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero1);
                Thread.Sleep(3000);
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero2);
                Thread.Sleep(3000);
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero3);
                Thread.Sleep(3000);            
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero4);
                Thread.Sleep(3000);
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero5);
                Thread.Sleep(3000);    
                //change text and background Color
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numero6);
                Console.WriteLine("now the program exits");
                // end of number generation
                Thread.Sleep(9000);
                // the application exit after 9 second
            }
        }
    }
}