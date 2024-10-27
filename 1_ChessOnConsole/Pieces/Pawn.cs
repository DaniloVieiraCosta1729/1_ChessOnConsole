using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole.Pieces
{
    internal class Pawn : IPiece
    {
        private char _tipo = 'p';

        public char Cor { get; set; }
        public int[] CasaAtual { get; set; }

        public Pawn(char cor, int[] casaAtual)
        {
            Cor = cor;
            CasaAtual = casaAtual;
        }

        public string Move(int[] destino)
        {
            throw new NotImplementedException();
        }

        public string ValidaMove(int[] destino)
        {
            throw new NotImplementedException();
        }
    }
}
