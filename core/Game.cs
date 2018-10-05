using System.Collections.Generic;
using core;

namespace core
{
    public class Game
    {
        private readonly Stack<Gameboard> _gameState = new Stack<Gameboard>();
        private readonly Gameboard _gameboard;
        private readonly CommandPathReducer _commandReducer;
        private readonly ICommandToCoordinateMapper _commandToCoordinateMapper;

        public Game(Gameboard gameboard,
                    CommandPathReducer commandReducer,
                    ICommandToCoordinateMapper commandToCoordinateMapper)
        {
            _gameboard = gameboard;
            _commandReducer = commandReducer;
            _commandToCoordinateMapper = commandToCoordinateMapper;
        }

        public GameResult Play(Piece piece, string moveCommands, Direction startingDirection)
        {
            _gameboard.Add(piece);

            var reducedCommands = _commandReducer.Reduce(moveCommands, startingDirection);
            IEnumerable<Point> moveSequence = _commandToCoordinateMapper.Map(reducedCommands);

            Piece target = _gameboard.Get(piece.Position);
            foreach(var movingVector in moveSequence)
            {
                target = _gameboard.MovePiece(target.Position, movingVector);
            }

            return new GameResult { Piece = target };
        }
    }
}
