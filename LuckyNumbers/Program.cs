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
            int j;
            int[] array = new int[6]; // 6 size array

            // Accepting value from user 
            for (j = 0; j < 6; j++)
            {
                Console.Write("Enter your lucky number:");
                //Storing value in an array
                array[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n"); //carrage return to display their value
            //we are goign to be printing the value on console
            for (j = 0; j < 6; j++)
            {
                Console.WriteLine("Lucky Number: {0}", array[j]); //telling user their lucky number output
            }
            Console.ReadLine();



            //random number generator
            Random r = new Random();
            int[] rArray = new int[6];
            for (int i = 0; i < rArray.Length; i++)
            {
                rArray[i] = r.Next(lowNumber, highNumber); //array will display a random array based on user input of lowest # and hightest #
                Console.WriteLine(rArray[i]); //display numbers 
            }


            
            int[] userInputArray = new int[6]; //new array for a user input of 6 elements
            for (int i=0; i == rArray[i]; i++) // if int is equal to random array of higher and lower numbers
            {
               // rArray[i] = 
            }

            
        }
    }
}
