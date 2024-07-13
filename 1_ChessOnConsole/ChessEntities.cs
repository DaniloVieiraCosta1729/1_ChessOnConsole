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
            tabuleiroFEN = "r1bq1rk1/ppp2ppp/2p2n2/2b5/2B1P3/2N5/PPPP1PPP/R1BQ1RK1 b - - 3 7";
        }

        public string[] geradorVetorFEN(string tabuleiro)
        {
            string[] vetorFEN = tabuleiro.Split('/', ' ');
            return vetorFEN;
        }

        delegate string[] geradorVetor(string tabuleiro);        
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
