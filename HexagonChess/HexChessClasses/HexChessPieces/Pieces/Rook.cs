using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class Rook : HexChessPiece
    {
        public Rook(bool isBlack, Point location) : base(isBlack, location, false, true)
        {
            Image = isBlack ? Resources.BRook : Resources.WRook;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();
            AvailableMoves = HorizontalMoveCalc();
        }
    }
}
