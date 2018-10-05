using core.Interfaces;
using core.Model;

namespace core
{
    public class DefaultResultFormatter: IResultFormatter
    {
        private readonly IDirectionsMapper _directionsMapper;

        public DefaultResultFormatter(IDirectionsMapper directionsMapper)
        {
            _directionsMapper = directionsMapper;
        }

        public string Format(Piece target)
        {
            return $"{target.Position.X}{target.Position.Y}{_directionsMapper.MapFromDirection(target.Direction)}";
        }
    }
}