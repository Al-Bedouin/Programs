/****************************************************************/
/*   Name of Program: Coin Flip Simulation 						*
/*   Description:		This program simulates a coin flip(s).	*
/*   Authour(s):		Al Bedouin (Render)						*
/****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        // The acutal value of each probability
        static int heads = 0;
        static int tails = 1;

        // Determine if the coin is either heads or tails.
        static int flipped = 0;
        static int x;


        static void Main(string[] args)
        {
            Print("Welcome to the Coin Flip Simulator!", true);
            Restart();
        }

        // Application
        static void Restart()
        {
            Print("Enter the amount of flips: ", false);
            string line = Console.ReadLine();
            if (!int.TryParse(line, out x))
            {
                Console.WriteLine("'{0}' is not an integer", line);
                Restart();
            }

            if (x > 10000)
            {
                Print("The number is too large, please choose another number!", true);
                Restart();
            }
            else
            {
                Flip(x);
            }

       
          
            Print("Try again? Enter y|Y or n|N to quit. ", false);
            string choice = Console.ReadLine();

            if (choice == "y" || choice == "Y")
                Restart();
            else if (choice == "n" || choice == "N")
            {
                Print("exiting");
            }
            else
            {
                Print("An error has occured.");
                Print("Attempt at restarting...");
                Print("Success!");
                NewLine();
                Restart();
            }

            NewLine(2);
        }

        // Flip the Coin Method
        static void Flip(int flips)
        {
                // Heads is 0 and Tails is 1
                int value;
                Random random = new Random();

                // Counter
                int NumberofHeads = 0;
                int NumberofTails = 0;

            for (var i = 0; i < flips; i++)
               {
                value = random.Next(0, 2);

                 switch (value)
                {
                     case 0:
                         Print("Heads");
                         NumberofHeads++;
                         break;
                     default:
                         Print("Tails");
                         NumberofTails++;
                         break;                        
                } 
            }
            NewLine(1);
            Console.WriteLine("You had {0} number of heads.", NumberofHeads);
            Console.WriteLine("You had {0} number of tails.", NumberofTails);
            Console.WriteLine("Totaling to {0} number of flips.", flips);
            NewLine(1);
        }

        /* These are universal */
        // Simplify making new lines.
        static void NewLine(int AmountofLines = 1)
        {
            for(int i = 0; i < AmountofLines; i++)
            {
                Print("");
            }
        }

        // Simplify Console.WriteLine(string)
        static void Print(string str, bool NewLine = true)
        {
            if (NewLine)
                Console.WriteLine(str);
            else
                Console.Write(str);
        }
    }
}
