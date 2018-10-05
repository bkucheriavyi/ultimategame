using System;
using System.Collections.Generic;

namespace core
{
    public class Gameboard
    {
        public int Length { get; private set; }
        public int Width { get; private set; }

        private Dictionary<Point, Piece> _pieces = new Dictionary<Point, Piece>();

        private readonly IDirectionsMapper _directionsMapper;

        public Gameboard(int width, int length, IDirectionsMapper directionMapper)
        {
            Width = width;
            Length = length;
            _directionsMapper = directionMapper;
        }

        public void Add(Piece piece)
        {
            if (_pieces.ContainsKey(piece.Position))
            {
                throw new InvalidOperationException("This place is already taken. Try another one.");
            }
            _pieces.Add(piece.Position, piece);
        }

        public Piece Get(Point point)
        {
            if (!_pieces.ContainsKey(point))
            {
                throw new InvalidOperationException("Nothing here :(");
            }

            return _pieces[point];
        }

        public void Remove(Point point)
        {
            if (!_pieces.ContainsKey(point))
            {
                throw new InvalidOperationException("This place is already free. Try another one.");
            }
            _pieces.Remove(point);
        }

        public Piece MovePiece(Point from, Point vector)
        {
            var current = this.Get(from);

            var newPiece = new Piece
            {
                Position = new Point
                {
                    X = current.Position.X + vector.X,
                    Y = current.Position.Y + vector.Y,
                },

                Direction = _directionsMapper.MapFromMovingVector(vector)
            };

            if (IsPositionWithingGameBoard(newPiece.Position))
            {
                this.Remove(from);
                this.Add(newPiece);
                return newPiece;
            }

            return current;
        }

        private bool IsPositionWithingGameBoard(Point position)
        {
            return position.X <= this.Width - 1 && position.Y <= Length - 1;
        }
    }
}
