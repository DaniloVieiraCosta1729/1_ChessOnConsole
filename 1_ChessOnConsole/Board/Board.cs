using _1_ChessOnConsole.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole.Board
{
    internal class Board
    {
        private string[] _board = new string[64];

        public Board(string initialPosition = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this._board = Atualizar(initialPosition);
        }

        /// <summary>
        /// Atualiza o array string[] que representa o tabuleiro.
        /// </summary>
        /// <param name="fen">string FEN que representa o tabuleiro após a atualização.</param>
        public static string[] Atualizar(string fen)
        {
            string[] fileiras = fen.Split('/', ' ');

            string tabuleiroFEN = "";

            for (int i = 0; i < 8; i++)
            {
                tabuleiroFEN += fileiras[i];
            }

            string[] tabuleiroArray = new string[64];
            int indexTabuleiroArray = 0;

            for (int i = 0; i < tabuleiroFEN.Length; i++)
            {
                bool ehNumerico = int.TryParse(tabuleiroFEN[i].ToString(), out int numeroEspacos);

                if (ehNumerico)
                {
                    indexTabuleiroArray += numeroEspacos;
                }
                else
                {
                    tabuleiroArray[indexTabuleiroArray] = tabuleiroFEN[i].ToString();
                    indexTabuleiroArray++;
                }
            }

            return tabuleiroArray;
        }

        public string[] ShowBoard()
        {
            Console.WriteLine("Tabuleiro:");
            Console.WriteLine(string.Join(" ,", _board));
            return _board;
        }
    }
}

