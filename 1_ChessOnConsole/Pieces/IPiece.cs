using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_ChessOnConsole.Board;

namespace _1_ChessOnConsole.Pieces
{
    internal interface IPiece
    {
        private static char _tipo;
        public string Move(string partida, string destino, string board);
        public bool ValidaMove(string destino);

    }
}
