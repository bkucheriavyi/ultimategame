using System.Collections.Generic;

namespace core.Interfaces
{
    public interface ICommandProcessor
    {
        IEnumerable<object> Process(string command);
    }
}