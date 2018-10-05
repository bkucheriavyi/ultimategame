using System;

namespace core
{
    public class Piece
    {
        public Piece(){}
        public Piece(int x, int y, Direction direction)
        {
            Position = new Point
            {
                X = x,
                Y = y
            };

            Direction = direction;
        }

        public Point Position { get; set; }
        public Direction Direction { get; set; }
    }

    public class Point
    {
        public Point(){}
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}