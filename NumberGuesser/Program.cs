using System;

//Namespace
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for user's name and greet

            while (true)
            {



                //Init correct number 
                // int correctNumber = 7;

                //Create a new Random object 
                Random random = new Random();

                //Correct Number 
                int correctNumber = random.Next(1, 10);


                //Init guess var 
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                //User can guess n-times
                while (correctNumber != guess)
                {
                    //User input 
                    string? tryAgain = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(tryAgain, out guess))
                    {

                        //Print error message 
                        PrintColor(ConsoleColor.Red, "Please use an actual number");

                        //Keep going 
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(tryAgain);
                    //Match guess to correct number 
                    if (guess != correctNumber)
                    {

                        PrintColor(ConsoleColor.Red, "Wrong number, please try again");


                    }
                }


                PrintColor(ConsoleColor.Yellow, "You guessed number correctly");



                //Ask the user to play again 
                Console.WriteLine("Play again? [Y or N]");

                //Get answer 
                string? answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;

                }
                else
                {
                    return;

                }


            }
        }
        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars 
            string appName = "Number Guesser";
            string appAuthor = "Pera Peric";
            string appVersion = "1.0.0";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appAuthor, appVersion);
            //Reset text color 
            Console.ResetColor();

        }
        static void GreetUser()
        {
            //Ask user's name 
            Console.WriteLine("What's your name?");

            //Get user input 
            string? input = Console.ReadLine();
            Console.WriteLine("Hello {0},let's play a game...", input);
        }
        //Print color message 
        static void PrintColor(ConsoleColor color, string message)
        {
            //Change text color 
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            //Reset text color 
            Console.ResetColor();

        }

    }
}