namespace core
{
    public interface ICommandPathReducer
    {
        string Reduce(string input, Direction initialDirection);
    }
}