using System.Collections.Generic;
using core.Model;

namespace core.Interfaces
{
    public interface ICommandToCoordinateMapper
    {
        IEnumerable<Point> Map(string reducedCommands);
    }
}
