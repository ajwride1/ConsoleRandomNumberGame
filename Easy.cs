using System;

namespace randomnumbergame
{
    public class Easy : Difficulty
    {
        public Easy()
        {
            this.NumberOfTries = 10;
            this.LowerLimit = 1;
            this.UpperLimit = 50;
            this.Name = "Easy";
        }
    }
}