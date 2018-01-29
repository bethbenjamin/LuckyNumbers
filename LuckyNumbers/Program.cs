using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {


        static void Main(string[] args)
        {

            string highNumberMessage = "Please choose a high number";
            string lowNumberMessage = "Please choose a low number";
            string welcomeMessage = "Welcome to Lucky Numbers! The jackpot is $600,000.00.  Good Luck!";
            int highNumber, lowNumber;
            int matches = 0;
            string action = " ";
            int count = 0;


            while (action != "exit")
            {
                Console.WriteLine(welcomeMessage); //welcome message
                Console.WriteLine(highNumberMessage); //enter high #
                highNumber = int.Parse(Console.ReadLine());//turn ask into number variable
                Console.WriteLine(lowNumberMessage); // ask for low #
                lowNumber = int.Parse(Console.ReadLine()); // turn ask into number variable




                //ask user to guess 6 lucky numbers in an array data structure and must use a loop to populate the array
                int g; //g = guess (in my mind) to reference it.
                int[] luckyGuess = new int[6]; // 6 size array
                Console.WriteLine("Please enter 6 Lucky Numbers.");
                // Accepting input value from user 

                for (g = 0; g < 6; g++)
                {
                    Console.Write("Enter your lucky number:");

                    luckyGuess[g] = Convert.ToInt32(Console.ReadLine()); //storing value in the array
                }
                Console.WriteLine("\n"); //carrage return to display their value // found this on microsoft community forum /i think we discussed it in class though.
                                         //we are going to be printing the value on console
                for (g = 0; g < 6; g++)
                {
                    Console.WriteLine("You've selected : {0}", luckyGuess[g]); //telling user their lucky number output
                }
                Console.ReadLine();

                //random number generator
                Random r = new Random();
                int[] rArray = new int[6];
                for (int i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(lowNumber, highNumber); //array will display a random array based on user input of lowest # and hightest #
                    Console.WriteLine("Lucky Number: " + rArray[i]); //display numbers per line with the word "Lucky Number : x <br>
                }



                for (int k = 0; k < luckyGuess.Length; k++) //iterates through the lucky guess
                {
                    if (rArray.Contains(luckyGuess[k])) //if random array contains value of element at index of k add one
                    {
                        matches += 1; //if rarray finds a match it increments one to matches
                        Console.WriteLine("You guessed " + matches + "number(s) correctly!");
                    }

                }
                if (matches == 1)
                    Console.WriteLine("You matched 1");
                else if (matches == 2)
                    Console.WriteLine("You matched 2");
                else if (matches == 3)
                    Console.WriteLine("You matched 3");
                else if (matches == 4)
                    Console.WriteLine("You matched 4");
                else if (matches == 5)
                    Console.WriteLine("You matched 5");
                else if (matches == 6)
                    Console.WriteLine("You won the jackpot");
                else if (matches == 0)
                    Console.WriteLine("Sorry, you didnt match any");




                int matchesAmount = (matches * 100000);
                Console.WriteLine("You won $" + matchesAmount+ "!");


                while (action != "exit")// action is NOT equal to exit
                {
                    
                    Console.WriteLine("Would you like to play again? ");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.ReadLine();
                    }
                   
                    else
                    {
                        if (answer != "Thanks for playing!") ;
                    }
                    Console.WriteLine("Thanks for playing!");
                    action = Console.ReadLine(); //assigning variable to action


                }


            }





        }
    }
}
