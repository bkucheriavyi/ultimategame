using System.Collections.Generic;
using core.Interfaces;
using core.Model;

namespace core
{
    public class Game
    {
        private readonly IGameboard _gameboard;
        private readonly ICommandPathReducer _commandReducer;
        private readonly ICommandToCoordinateMapper _commandToCoordinateMapper;
        private readonly IResultFormatter _resultFormatter;

        public Game(IGameboard gameboard,
                    ICommandPathReducer commandReducer,
                    ICommandToCoordinateMapper commandToCoordinateMapper,
                    IResultFormatter resultFormatter)
        {
            _gameboard = gameboard;
            _commandReducer = commandReducer;
            _commandToCoordinateMapper = commandToCoordinateMapper;
            _resultFormatter = resultFormatter;
        }

        public GameResult Play(Piece originalPiece, string moveCommands, Direction startingDirection)
        {
            _gameboard.Add(originalPiece);

            string reducedCommands = _commandReducer.Reduce(moveCommands, startingDirection);
            IEnumerable<Point> moveSequence = _commandToCoordinateMapper.Map(reducedCommands);

            Piece target = _gameboard.Get(originalPiece.Position);
            foreach (var movingVector in moveSequence)
            {
                target = _gameboard.MovePiece(target.Position, movingVector);
            }

            return new GameResult
            {
                Piece = target,
                Result = _resultFormatter.Format(target)
            };
        }
    }
}