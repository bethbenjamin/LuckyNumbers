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
            int highNumber,lowNumber;
           

           
            Console.WriteLine(welcomeMessage); //welcome message
            Console.WriteLine(highNumberMessage); //enter high #
            highNumber = int.Parse(Console.ReadLine());//turn ask into number variable
            Console.WriteLine(lowNumberMessage); // ask for low #
            lowNumber = int.Parse(Console.ReadLine()); // turn ask into number variable


            //ask user to guess 6 lucky numbers in an array data structure and must use a loop to populate the array
            int g; //g = //guess (in my mind) to reference it.
            int[] array = new int[6]; // 6 size array
            Console.WriteLine("Please enter 6 Lucky Numbers.");
            // Accepting input value from user 
            for (g = 0; g < 6; g++) 
            {
                Console.Write("Enter your lucky number:");
               
                array[g] = Convert.ToInt32(Console.ReadLine()); //storing value in the array
            }
            Console.WriteLine("\n"); //carrage return to display their value // found this on microsoft community forum /i think we discussed it in class though.
            //we are going to be printing the value on console
            for (g = 0; g < 6; g++)
            {
                Console.WriteLine("You selected : {0}", array[g]); //telling user their lucky number output
            }
            Console.ReadLine();
            
            //random number generator
            Random r = new Random();
            int[] rArray = new int[6];
            for (int i = 0; i < rArray.Length; i++)
            {
                rArray[i] = r.Next(lowNumber, highNumber); //array will display a random array based on user input of lowest # and hightest #
                Console.WriteLine("Lucky Number: " +rArray[i]); //display numbers per line with the word "Lucky Number : x <br>
            }

            // create an if else statement to compare the input numbers and the random numbers
            // if guess numbers match, add x amount to each matching number
            
            

            
        }
    }
}
