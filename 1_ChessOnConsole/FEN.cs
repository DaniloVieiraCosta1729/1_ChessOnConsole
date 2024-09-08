using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole
{
    public class FEN
    {
        // Essa classe contém a lógica de conversão entre uma string que contém o estado do tabuleiro em notação FEN e a matriz que representa o tabuleiro.

        private string fenString;

        public string FenString 
        {
            get { return fenString; }
            set { fenString = value; }
        }

        public FEN(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            fenString = fen;
        }
    }
}
