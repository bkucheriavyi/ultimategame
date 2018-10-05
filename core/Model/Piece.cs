using System;

namespace core.Model
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
}