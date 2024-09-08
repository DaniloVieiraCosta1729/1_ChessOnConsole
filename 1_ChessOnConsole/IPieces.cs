using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole
{
    internal interface IPieces
    {
        public char nome { get; set; }

        public char cor { get; set; }

        public char[][] move(string partida, string chegada);
    }
}
