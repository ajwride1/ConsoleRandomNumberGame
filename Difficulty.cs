using System;

namespace randomnumbergame
{
    public enum Level
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Godlike = 4
    }

    public class Difficulty
    {
        public int NumberOfTries {get;set;}
        public string Name {get;set;}
        public int LowerLimit {get;set;}
        public int UpperLimit {get;set;}
    }
}