using System;

namespace randomnumbergame
{
    public class GodLike : Difficulty
    {
        public GodLike()
        {
            Name = "GodLike";
            NumberOfTries = 1;
            LowerLimit = 1;
            UpperLimit = 10000;
        }
    }
}