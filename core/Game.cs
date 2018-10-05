using System;
using System.Collections.Generic;

namespace core
{
    public class Game
    {
        private readonly Stack<Gameboard> _gameState = new Stack<Gameboard>();
        private readonly Gameboard _gameboard;
        private readonly ICommandProcessor _commandProcessor;

        public Game(Gameboard gameboard, ICommandProcessor commandProcessor)
        {
            _gameboard = gameboard;
            _commandProcessor = commandProcessor;
        }

        public void Start(params Piece[] pieces)
        {
            foreach(var piece in pieces){
                _gameboard.Add(piece);
            }
         //   _gameState.Push(_gameboard.GetState());
        }

        public void Move(string command, params Piece[] pieces)
        {
            IEnumerable<object> moves = _commandProcessor.Process(command);

            foreach(var piece in pieces){
                foreach (var move in moves)
                {
                    Gameboard newState = (Gameboard)_gameboard.Move(piece, move);
                    _gameState.Push(newState);
                }
            }
        }
    }

    public class Gameboard
    {
        IEnumerable<Piece> Pieces { get; set; }

        internal void Add(Piece piece)
        {
            throw new NotImplementedException();
        }

        internal Gameboard Move(Piece piece, object move)
        {
            throw new NotImplementedException();
        }
    }
}
