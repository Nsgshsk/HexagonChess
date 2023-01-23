using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class Queen : HexChessPiece
    {
        public Queen(bool isBlack, Point location) : base(isBlack, location, true, true)
        {
            Image = isBlack ? Resources.WQueen : Resources.BQueen;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();
            AvailableMoves.AddRange(HorizontalMoveCalc());
            AvailableMoves.AddRange(DiagonalMoveCalc());
        }
    }
}
