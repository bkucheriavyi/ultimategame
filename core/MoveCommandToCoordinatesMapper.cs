using System;
using System.Collections.Generic;
using System.Linq;
using core.Interfaces;
using core.Model;

namespace core
{
    public class MoveCommandToCoordinatesMapper : ICommandToCoordinateMapper
    {
        private readonly IDirectionsMapper _directionsMapper;

        public MoveCommandToCoordinatesMapper(IDirectionsMapper directionMapper)
        {
            _directionsMapper = directionMapper;
        }

        public IEnumerable<Point> Map(string reducedCommands)
        {
            var splited = reducedCommands
                .ToUpperInvariant()
                .Trim()
                .Split(Constants.MoveChar);

            if(splited.Length == 1){
                throw new FormatException("Missing move command");
            }

            var skipedEmptyLast = splited.Take(splited.Length - 1);

            if (skipedEmptyLast.Any(s=> s.Length != 1)){
                throw new FormatException($"Input string in invalid format.Expected example 'NMEMSMWM'\nbut was\n{reducedCommands}");
            }

            return skipedEmptyLast
                .Select(c => _directionsMapper.MapFromChar(c[0]))
                .Select(_directionsMapper.MapDirectionToMoveVector);
        }
    }
}