using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses
{
    internal class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => x; private set => x = value; }
        public int Y { get => y; private set => y = value; }
    }
}
