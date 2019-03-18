using System;

namespace randomnumbergame
{
    public class Hard : Difficulty
    {
        public Hard()
        {
            Name = "Hard";
            NumberOfTries = 3;
            LowerLimit = 1;
            UpperLimit = 1000;
        }
    }
}