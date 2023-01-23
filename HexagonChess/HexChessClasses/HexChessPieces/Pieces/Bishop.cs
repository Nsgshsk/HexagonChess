using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class Bishop : HexChessPiece
    {
        public Bishop(bool isBlack, Point location) : base(isBlack, location, true, false)
        {
            Image = isBlack ? Resources.BBishop : Resources.WBishop;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();
            AvailableMoves = DiagonalMoveCalc();
        }
    }
}
