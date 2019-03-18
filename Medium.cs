using System;

namespace randomnumbergame
{
    public class Medium : Difficulty
    {
        public Medium()
        {
            Name = "Medium";
            NumberOfTries = 5;
            LowerLimit = 1;
            UpperLimit = 100;
        }
    }
}