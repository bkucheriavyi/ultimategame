using System.Collections.Generic;

namespace core
{
    public interface ICommandToCoordinateMapper
    {
        IEnumerable<Point> Map(string reducedCommands);
    }
}
