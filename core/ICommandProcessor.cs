using System.Collections.Generic;

namespace core
{
    public interface ICommandProcessor
    {
        IEnumerable<object> Process(string command);
    }
}