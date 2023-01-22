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
        public static HexChessBoard Board { get => board; set => board = value; }
    }
}
