using core.Model;

namespace core.Interfaces
{
    public interface IDirectionsMapper
    {
        Direction MapFromChar(char direction);
        char MapFromDirection(Direction direction);
        Direction MapFromMovingVector(Point vector);
        Point MapDirectionToMoveVector(Direction direction);
        Direction RightOf(Direction direction);
        Direction LeftOf(Direction direction);
    }
}