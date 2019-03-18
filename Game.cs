using System;

namespace randomnumbergame
{
    public class Game
    {
        private int _RandomNumber;
        public Difficulty Difficulty {get;set;}
        public int TriesLeft {get;set;}

        public Game(Level level)
        {
            Difficulty = Factory.GetDifficulty(level);

            Random rnd = new Random();
            _RandomNumber = rnd.Next(Difficulty.LowerLimit, Difficulty.UpperLimit);
        }

        public bool CheckTriesLeft()
        {
            if(TriesLeft <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Response Guess(int guess)
        {
            if(!Between(guess, Difficulty.LowerLimit, Difficulty.UpperLimit))
            {
                return new Response()
                {
                    Success = false,
                    Result = $"Your guess isn't within the limits, try guessing between {Difficulty.LowerLimit} and {Difficulty.UpperLimit}"
                };
            }

            TriesLeft--;

            if(guess == _RandomNumber)
            {
                return new Response()
                {
                    Success = true,
                    Result = "Congratulations, you got it right!"
                };
            }

            if(guess < _RandomNumber)
            {
                return new Response()
                {
                    Success = false,
                    Result = "Too low, try again, this time, guess higher!"
                };
            }

            if(guess > _RandomNumber)
            {
                return new Response()
                {
                    Success = false,
                    Result = "Too high, try again, this time, guess lower!"
                };
            }

            return null;
        }

        public void PrintTriesLeft()
        {
            Console.WriteLine($"You have {TriesLeft} guesses left!");
        }

        private bool Between(int x, int lower, int upper)
        {
            if(x >= lower && x <= upper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}