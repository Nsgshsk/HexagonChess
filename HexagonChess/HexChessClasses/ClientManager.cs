using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses
{
    public static class ClientManager
    {
        private static HexChessBoard board;
        private static bool blackTurn = false;
        private static int numPiece = 0;
        public static HexChessBoard Board { get => board; set => board = value; }
        public static bool BlackTurn { get => blackTurn; set => blackTurn = value; }
        public static int NumPiece { get => numPiece; set => numPiece = value; }
    }
}
