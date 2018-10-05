using core.Model;

namespace core
{
    public interface IResultFormatter
    {
        string Format(Piece target);
    }
}