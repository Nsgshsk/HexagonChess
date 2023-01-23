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

        protected void StartUpCheck()
        {
            if (ClientManager.Board.Pieces.Values.Where(e => e.IsSelected).FirstOrDefault() != null)
            {
                if (ClientManager.Board.Pieces.Values.Where(e => e.IsSelected).First().IsSelected)
                {
                    var tmp = ClientManager.Board.Pieces.Values.Where(e => e.IsSelected).First();
                    foreach (var item in tmp.AvailableMoves)
                    {
                        var cell = ClientManager.Board.Cells[$"{item.X};{item.Y}"];
                        if (ClientManager.Board.Pieces.Values.Where(e => e.Location.X == item.X && e.Location.Y == item.Y).FirstOrDefault() == default(HexChessPiece))
                        {
                            cell.BackgroundImage = null;
                            cell.Enabled = false;
                            cell.Visible = false;
                            cell.BackColor = Color.Transparent;
                        }
                        else
                        {
                            cell.Enabled = false;
                            cell.BackColor = Color.Transparent;
                        }
                    }
                    tmp.AvailableMoves.Clear();
                    tmp.IsSelected = false;
                }
            }
            AvailableMoves.Clear();
            IsSelected = true;
        }

        protected List<Point> DiagonalMoveCalc()
        {
            var AvailableMoves = new List<Point>();
            int x = Location.X + 1, y = Location.Y - 2;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x++; y -= 2;
            }

            x = Location.X - 1; y = Location.Y + 2;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x--; y += 2;
            }
            //
            x = Location.X - 1; y = Location.Y - 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x--; y--;
            }

            x = Location.X + 1; y = Location.Y + 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x++; y++;
            }
            //
            x = Location.X + 2; y = Location.Y - 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x += 2; y--;
            }

            x = Location.X - 2; y = Location.Y + 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x -= 2; y++;
            }
            return AvailableMoves;
        }

        protected List<Point> HorizontalMoveCalc()
        {
            var AvailableMoves = new List<Point>();
            int x = Location.X + 1, y = Location.Y - 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x++; y--;
            }

            x = Location.X - 1; y = Location.Y + 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x--; y++;
            }
            //
            x = Location.X; y = Location.Y + 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                y++;
            }

            x = Location.X; y = Location.Y - 1;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                y--;
            }
            //
            x = Location.X + 1; y = Location.Y;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x++;
            }

            x = Location.X - 1; y = Location.Y;
            while (ClientManager.Board.Cells.ContainsKey($"{x};{y}"))
            {
                if (!ClientManager.Board.Cells.Where(e => e.Key == $"{x};{y}").First().Value.Visible)
                    AvailableMoves.Add(new Point(x, y));
                else if (ClientManager.Board.Pieces.Where(e => e.Value.Location.X == x && e.Value.Location.Y == y).First().Value.IsBlack != ClientManager.BlackTurn)
                { AvailableMoves.Add(new Point(x, y)); break; }
                else break;
                x--;
            }
            return AvailableMoves;
        }
    }
}
