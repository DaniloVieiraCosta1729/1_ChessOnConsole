using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ChessOnConsole
{
    public class ChessEntities
    {
        public string tabuleiroFEN;

        public ChessEntities()
        {
            tabuleiroFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        }


        /// <summary>
        /// Gerador de um vetor FEN. Esse vetor possui 13 elementos: os elementos de 0 à 7 são as linhas do tabuleiro em ordem decrescente; o elemento 8 indica quem move neste turno; 9, Indica o direito ao roque da brancas e das pretas; 10, casa que permite en passant; 11, quantidade de meio-lance; 12, lance atual.
        /// </summary>
        /// <param name="tabuleiro">string FEN</param>
        /// <returns>Um array com as partes do FEN</returns>
        public string[] geradorVetorFEN(string tabuleiro)
        {
            string[] vetorFEN = tabuleiro.Split('/', ' '); // o split divide a string em várias partes, usando os argumentos passados para identificar onde ela precisa quebrar a string. As partes resultantes são armazenas em um array de strings.
            return vetorFEN;
        }

        public ChessPiece[,] tabuleiroMatriz = new ChessPiece[8, 8];

        public ChessPiece[,] AlimentaTabuleiroMatriz(string[] vetorFen)
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var v in vetorFen[i])
                {
                    if (Char.IsDigit(v))
                    {

                    }
                }
            }

            return tabuleiroMatriz;
        }
    }

    // Definindo as peças com ASCII
    public enum ChessPiece
    {
        vazio = ' ',

        peaoPreto = 'p',
        torrePreta = 'n',
        cavaloPreto = 'n',
        bispoPreto = 'b',
        damaPreta = 'q',
        reiPreto = 'k',

        peaoBranco = 'P',
        torreBranca = 'R',
        cavaloBranco = 'N',
        bispoBranco = 'B',
        damaBranca = 'Q',
        reiBranco = 'K'
    }

}
