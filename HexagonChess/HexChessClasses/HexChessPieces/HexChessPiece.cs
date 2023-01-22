using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces
{
    internal abstract class HexChessPiece
    {
        private bool isSelected;
        private bool isBlack;
        private Bitmap image;

        private Point location;

        private bool canMoveDiaganol;
        private bool canMoveHorizontal;

        private bool firstMove;
        private List<Point> availableMoves;

        protected HexChessPiece(bool isBlack, Point location, bool canMoveDiaganol, bool canMoveHorizontal ,bool firstMove = false)
        {
            IsBlack = isBlack;
            Location = location;
            CanMoveDiaganol = canMoveDiaganol;
            CanMoveHorizontal = canMoveHorizontal;
            FirstMove = firstMove;
            IsSelected = false;
            AvailableMoves = new List<Point>();
        }

        public bool IsBlack { get => isBlack; protected set => isBlack = value; }
        public Point Location { get => location; set => location = value; }
        public bool CanMoveDiaganol { get => canMoveDiaganol; protected set => canMoveDiaganol = value; }
        public bool CanMoveHorizontal { get => canMoveHorizontal; protected set => canMoveHorizontal = value; }
        public bool FirstMove { get => firstMove; set => firstMove = value; }
        public List<Point> AvailableMoves { get => availableMoves; protected set => availableMoves = value; }
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        public Bitmap Image { get => image; protected set => image = value; }

        public abstract void CalculateMoves();
    }
}
