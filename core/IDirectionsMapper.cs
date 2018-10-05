namespace core
{
    public interface IDirectionsMapper
    {
        Direction MapFromChar(char direction);
        char MapFromDirection(Direction direction);
        Direction MapFromMovingVector(Point vector);
    }
}