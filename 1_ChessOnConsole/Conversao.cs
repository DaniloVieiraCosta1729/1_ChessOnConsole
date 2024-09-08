using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole
{
    public class Conversao
    {
        public static char[][] FenToMatrix(string fen)
        {
            string[] partes = fen.Split('/', ' ');

            char[][] TabuleiroMatriz = new char[][]
            {
                new char[]{'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r'},
                new char[]{'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                new char[]{' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                new char[]{' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                new char[]{' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                new char[]{' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                new char[]{'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P'},
                new char[]{'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R'}
            };

            return TabuleiroMatriz;
        }
    }
}
