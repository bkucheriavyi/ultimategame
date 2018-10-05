using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    public class CommandPathReducer
    {
        public const char LeftChar = 'L';
        public const char RightChar = 'R';
        public const char MoveChar = 'M';

        public static Dictionary<Direction, char> _directionCharMapping = new Dictionary<Direction, char>
        {
            {Direction.East, 'E'},
            {Direction.West, 'W'},
            {Direction.South, 'S'},
            {Direction.North, 'N'},
        };

        public string Reduce(string input, Direction initialDirection)
        {
            var sb = new StringBuilder();
            var currentDirection = initialDirection;

            foreach (var c in input.ToUpperInvariant())
            {
                if (c == LeftChar){
                    currentDirection = LeftOf(currentDirection);
                }
                if( c == RightChar){
                    currentDirection = RightOf(currentDirection);
                }
                if (c == MoveChar) {
                    sb.Append(_directionCharMapping[currentDirection]);
                    sb.Append(MoveChar);
                }
            }
            return sb.ToString();
        }
        
        private Direction RightOf(Direction current)
        {
            switch (current)
            {
                case Direction.North:
                    {
                        return Direction.East;
                    }
                case Direction.East:
                    {
                        return Direction.South;
                    }
                case Direction.South:
                    {
                        return Direction.West;
                    }
                case Direction.West:
                    {
                        return Direction.North;
                    }
                default:
                    throw new InvalidOperationException($"Something really bad happened here:\n " +
                                                        $"{current}{nameof(current)} vale does not contains mapping in runtime :(");
            }
        }

        private Direction LeftOf(Direction current)
        {
            switch (current)
            {
                case Direction.North:
                    {
                        return Direction.West;
                    }
                case Direction.East:
                    {
                        return Direction.North;
                    }
                case Direction.South:
                    {
                        return Direction.East;
                    }
                case Direction.West:
                    {
                        return Direction.South;
                    }
                default:
                    throw new InvalidOperationException($"Something really bad happened here:\n " +
                                                        $"{current}{nameof(current)} vale does not contains mapping in runtime :(");
            }
        }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}
