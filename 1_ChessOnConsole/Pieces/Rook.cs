using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole.Pieces
{
    internal class Rook : IPiece
    {
        private readonly char _tipo = 'r';

        public char Cor { get; set; }
        public int[] CasaAtual { get; set; }

        public Rook(char cor, int[] casaAtual)
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
