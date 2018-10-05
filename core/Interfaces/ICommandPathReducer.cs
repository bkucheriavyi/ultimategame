using core.Model;

namespace core.Interfaces
{
    public interface ICommandPathReducer
    {
        string Reduce(string input, Direction initialDirection);
    }
}