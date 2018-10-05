using System;
using System.Collections.Generic;
using core.Interfaces;
using core.Model;

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

        public static Dictionary<Direction, Point> _directionToMoveVectorMapping = new Dictionary<Direction, Point>() {
            {Direction.North, new Point(0,1) },
            {Direction.East, new Point(1,0) },
            {Direction.South, new Point(0,-1) },
            {Direction.West, new Point(-1,0)}
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

        public Point MapDirectionToMoveVector(Direction direction)
        {
            return _directionToMoveVectorMapping[direction];
        }

        public Direction RightOf(Direction current)
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
                    throw new InvalidOperationException($"{current}{nameof(current)} vale does not contains mapping");
            }
        }

        public Direction LeftOf(Direction current)
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
                    throw new InvalidOperationException($"{current}{nameof(current)} vale does not contains mapping");
            }
        }
    }
}
