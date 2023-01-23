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
        public static HexChessBoard Board { get => board; set => board = value; }
        public static bool BlackTurn { get => blackTurn; set => blackTurn = value; }
    }
}
