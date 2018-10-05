using core.Model;

namespace core.Interfaces
{
    public interface IGameboard
    {
        int Length { get; }
        int Width { get; }

        void Add(Piece piece);
        Piece Get(Point point);
        Piece MovePiece(Point from, Point vector);
        void Remove(Point point);
    }
}