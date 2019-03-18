using System;

namespace randomnumbergame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Random Number Game");
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Let's start by selecting a difficulty");

            foreach(Level level in Enum.GetValues(typeof(Level)))
            {
                Difficulty difficulty = Factory.GetDifficulty(level);
                Console.WriteLine($"{(int)level} - {difficulty.Name} - {difficulty.NumberOfTries} tries to guess a number from {difficulty.LowerLimit} to {difficulty.UpperLimit}");
            }

            int difficultySelection;
            bool validInput = false;

            validInput = int.TryParse(Console.ReadLine(), out difficultySelection);
            validInput = Enum.IsDefined(typeof(Level), difficultySelection);

            while(!validInput)
            {
                WriteInvalidSelection();    
                validInput = int.TryParse(Console.ReadLine(), out difficultySelection);
                validInput = Enum.IsDefined(typeof(Level), difficultySelection);
            }

            Game game = new Game((Level)difficultySelection);            
            Console.WriteLine("Let's start, put in your first guess...");

            Response response = new Response
            {
                Result = "",
                Success = false
            };

            while(game.CheckTriesLeft() && response.Success == false)
            {
                response = MakeGuess(ref game);
                Console.WriteLine(response.Result);

                if(response.Success)
                {
                    Start();
                }
            }
        }

        static void WriteInvalidSelection()
        {
            Console.WriteLine("Looks like you put in an invalid selection, please try again!");
        }

        static Response MakeGuess(ref Game game)
        {
            int guess;
            bool validInput;

            validInput = int.TryParse(Console.ReadLine(), out guess);
            
            while(!validInput)
            {
                WriteInvalidSelection();
                validInput = int.TryParse(Console.ReadLine(), out guess);
            }

            Response response;
            response = game.Guess(guess);
            return response;
        }
    }
}
