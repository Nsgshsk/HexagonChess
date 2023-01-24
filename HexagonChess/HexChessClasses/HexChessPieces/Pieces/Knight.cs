using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class Knight : HexChessPiece
    {
        public Knight(bool isBlack, Point location) : base(isBlack, location, false, false)
        {
            Image = isBlack ? Resources.BKnight : Resources.WKnight;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();

            void CheckMove(int x, int y)
            {
                if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                    AvailableMoves.Add(new Point(x, y));
            }

            //x axis
            int x = Location.X - 1, y = Location.Y - 2;
            CheckMove(x, y);

            x = Location.X + 1; y = Location.Y - 3;
            CheckMove(x, y);

            x = Location.X - 1; y = Location.Y + 3;
            CheckMove(x, y);

            x = Location.X + 1; y = Location.Y + 2;
            CheckMove(x, y);

            //y axis
            x = Location.X - 2; y = Location.Y - 1;
            CheckMove(x, y);

            x = Location.X - 3; y = Location.Y + 1;
            CheckMove(x, y);

            x = Location.X + 3; y = Location.Y - 1;
            CheckMove(x, y);

            x = Location.X + 2; y = Location.Y + 1;
            CheckMove(x, y);

            //-x-y(z) axis
            x = Location.X - 3; y = Location.Y + 2;
            CheckMove(x, y);

            x = Location.X - 2; y = Location.Y + 3;
            CheckMove(x, y);

            x = Location.X + 2; y = Location.Y - 3;
            CheckMove(x, y);

            x = Location.X + 3; y = Location.Y - 2;
            CheckMove(x, y);
        }
    }
}
