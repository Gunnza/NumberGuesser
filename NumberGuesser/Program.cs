using System;

//Namespace
namespace NumberGuesser
{
    //Mian Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run function to get app info
            GetAppInfo();
    
            //Ask users info
            GreetUser();
           
            while (true)
            {
                //Create a new Random Object
                Random random = new Random();

                //Init Correct Number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess the muber between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get users Input
                    string numInput = Console.ReadLine();

                    //Make sure it is a Number
                    if (!int.TryParse(numInput, out guess))
                    {
                        //Print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(numInput);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number. Try Again!");
                    }
                }

                //Output Success Message

                PrintColorMessage(ConsoleColor.Yellow, "Your Correct");

                //Ask to play again
                Console.WriteLine("Play again> [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else {
                    return;
                }
            }
        }

        static void GetAppInfo() {

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christopher McGovern";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write Out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset the color 
            Console.ResetColor();
        }

     
        static void GreetUser() {
            //Ask users name 
            Console.WriteLine("What is your name?");

            //Get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", input);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            //Change text color
            Console.ForegroundColor = color;

            //Not number 
            Console.WriteLine(message);

            //Reset the color 
            Console.ResetColor();
        }
    }
}
