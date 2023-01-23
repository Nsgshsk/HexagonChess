using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class King : HexChessPiece
    {
        public King(bool isBlack, Point location) : base(isBlack, location, true, true)
        {
            Image = isBlack ? Resources.BKing : Resources.WKing;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();

            //Horizontal Moves
            int x = Location.X + 1, y = Location.Y - 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X - 1; y = Location.Y + 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X; y = Location.Y + 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X; y = Location.Y - 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X + 1; y = Location.Y;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X - 1; y = Location.Y;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            //Diagonal Moves
            x = Location.X + 1; y = Location.Y - 2;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X - 1; y = Location.Y + 2;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X - 1; y = Location.Y - 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X + 1; y = Location.Y + 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X + 2; y = Location.Y - 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));

            x = Location.X - 2; y = Location.Y + 1;
            if (ClientManager.Board.Cells.ContainsKey($"{x};{y}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                AvailableMoves.Add(new Point(x, y));
            else if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault() != default && ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                AvailableMoves.Add(new Point(x, y));
        }
    }
}
