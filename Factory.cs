using System;

namespace randomnumbergame
{
    public static class Factory
    {
        public static Difficulty GetDifficulty(Level level)
        {
            switch(level)
            {
                case Level.Easy:
                    return new Easy();
                case Level.Medium:
                    return new Medium();
                case Level.Hard:
                    return new Hard();
                case Level.Godlike:
                    return new GodLike();
                default:
                    return new Difficulty();
            }
        }
    }
}