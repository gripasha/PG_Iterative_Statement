using System;

namespace PG_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value between 1 and 100");
            try
                // checks for invalid input if yes -- send to catch statements execution
            {
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int number = int.Parse(input);
                int value = 1; 
                if (number >= 0 && number <= 100)
                    // If the number is between 0 and 100 --- perform a loop
                {
                    while (number > 0)  // will iterate as long asnumber is >0
                    {
                        Console.WriteLine("You have entered " + input.ToString() + "." +
                        " This is the current integer value in the loop: " + value.ToString());
                        number--;   // subtracts 1 from number for the while loop
                        value++;    // adds 1 to the value to display the current integer value in the loop properly
                    }
                }
                else
                // if the number is out of a 0 to 100 range --- do actions below:
                {
                    Console.WriteLine("Please enter an integer value between 0 and 100 ...");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
            }
            catch
            // catches invalid input (those that are not integers)
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
