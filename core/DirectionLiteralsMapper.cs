using System.Collections.Generic;

namespace core
{
    public class DirectionLiteralsMapper : IDirectionsMapper
    {
        public static Dictionary<Direction, char> _directionToCharMapping = new Dictionary<Direction, char>
        {
            {Direction.East, 'E'},
            {Direction.West, 'W'},
            {Direction.South, 'S'},
            {Direction.North, 'N'},
        };

        public static Dictionary<char, Direction> _charToDirectionMapping = new Dictionary<char, Direction>
        {
            {'E', Direction.East},
            {'W', Direction.West},
            {'S', Direction.South},
            {'N', Direction.North},
        };

        public static Dictionary<Point, Direction> _moveVectorToDirectionMapping = new Dictionary<Point, Direction>(){
            {new Point(0,1), Direction.North},
            {new Point(1,0), Direction.East},
            {new Point(0,-1), Direction.South},
            {new Point(-1,0), Direction.West},
        };

        public Direction MapFromChar(char direction)
        {
            return _charToDirectionMapping[direction];
        }

        public char MapFromDirection(Direction direction)
        {
            return _directionToCharMapping[direction];
        }
        public Direction MapFromMovingVector(Point vector)
        {
            return _moveVectorToDirectionMapping[vector];
        }
    }
}
