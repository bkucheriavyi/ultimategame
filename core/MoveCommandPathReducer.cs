using System.Text;
using core.Interfaces;
using core.Model;

namespace core
{
    public class MoveCommandPathReducer : ICommandPathReducer
    {
        private readonly IDirectionsMapper _directionsMapper;

        public MoveCommandPathReducer(IDirectionsMapper directionsMapper)
        {
            _directionsMapper = directionsMapper;
        }

        public string Reduce(string input, Direction initialDirection)
        {
            var sb = new StringBuilder();
            var currentDirection = initialDirection;

            foreach (var c in input.ToUpperInvariant())
            {
                if (c == Constants.LeftChar)
                {
                    currentDirection = _directionsMapper.LeftOf(currentDirection);
                }
                if (c == Constants.RightChar)
                {
                    currentDirection = _directionsMapper.RightOf(currentDirection);
                }
                if (c == Constants.MoveChar)
                {
                    sb.Append(_directionsMapper.MapFromDirection(currentDirection));
                    sb.Append(Constants.MoveChar);
                }
            }
            return sb.ToString();
        }
    }
}
