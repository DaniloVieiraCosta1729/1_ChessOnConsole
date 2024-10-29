using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole.Pieces.BasePieces
{
    internal abstract class BasePawn : IPiece
    {        
        public string Move(string partida, string destino, string board)
        {
            throw new NotImplementedException();
        }

        public bool ValidaMove(string destino)
        {
            throw new NotImplementedException();
        }
    }
}
