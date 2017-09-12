namespace Chess.Game.Globals.Validators
{
    using Chess.Game.Commons;
    using System;

    public static class ObjectValidator
    {
        public static void CheckIfObjectIsValid(object obj, string errorMessage)
        {
            if (obj == null)
            {
                throw new NullReferenceException(errorMessage);
            }
        }

        public static void CheckIfPositionIsValid(Position position, string errorMessage)
        {
            if (position.Row < 1 || position.Row > 8)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }

            if (position.Col < 'a' || position.Col > 'h')
            {
                throw new IndexOutOfRangeException(errorMessage);
            }
        }
    }
}
