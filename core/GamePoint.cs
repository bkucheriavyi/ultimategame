using System;

namespace core
{
    public struct Piece
    {
        public Piece(int v1, int v2, Direction north)
        {
            this.X = v1;
            this.Y = v2;
            this.Direction = north;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Direction { get; private set; }
    }
}