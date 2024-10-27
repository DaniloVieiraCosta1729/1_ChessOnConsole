using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole.Pieces
{
    internal interface IPiece
    {
        public char Cor { get; set; }
        public int[] CasaAtual { get; set; }

        public string Move(int[] destino);
        public string ValidaMove(int[] destino);

    }
}
