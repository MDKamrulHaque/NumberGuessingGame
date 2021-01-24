using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random ();

            int winNum = r.Next ( 0, 100);

            bool win = false;

            do
            {

                Console.Write( "Guess a number inbetween 0 and 100; ");
                string s = Console.ReadLine();
                
                int i = int.Parse( s);
                
                if  (i > winNum)
                {

                    Console.WriteLine("Too High! Guess Lower...");

                            
                } 

                else if (i < winNum )
                {

                    Console.WriteLine("Too low! Guess Higher...");

                }

                else if (i == winNum)

                {

                    Console.WriteLine("You Win!");
                    win = true;
                }

                Console.WriteLine();


            } while (win == false);

            Console.WriteLine("Thanks for Playing The Game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
