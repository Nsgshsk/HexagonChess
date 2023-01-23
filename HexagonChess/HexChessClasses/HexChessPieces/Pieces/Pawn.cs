using HexagonChess.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses.HexChessPieces.Pieces
{
    internal class Pawn : HexChessPiece
    {
        public Pawn(bool isBlack, Point location, bool firstMove = true) : base(isBlack, location, false, true, true, firstMove)
        {
            Image = isBlack ? Resources.BPawn : Resources.WPawn;
        }

        public override void CalculateMoves()
        {
            StartUpCheck();

            if (FirstMove)
            {
                if (!IsBlack)
                {
                    for (int i = Location.Y - 1; i >= Location.Y - 2; i--)
                    {
                        if (ClientManager.Board.Cells.ContainsKey($"{Location.X};{i}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{Location.X};{i}").First().Value.Visible)
                            AvailableMoves.Add(new Point(Location.X, i));
                        else break;
                    }
                }
                else
                {
                    for (int i = Location.Y + 1; i <= Location.Y + 2; i++)
                    {
                        if (ClientManager.Board.Cells.ContainsKey($"{Location.X};{i}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{Location.X};{i}").First().Value.Visible)
                            AvailableMoves.Add(new Point(Location.X, i));
                        else break;
                    }
                }
            }
            else
            {
                if (!IsBlack)
                {
                    if (ClientManager.Board.Cells.ContainsKey($"{Location.X};{Location.Y - 1}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{Location.X};{Location.Y - 1}").First().Value.Visible)
                        AvailableMoves.Add(new Point(Location.X, Location.Y - 1));
                }
                else
                {
                    if (ClientManager.Board.Cells.ContainsKey($"{Location.X};{Location.Y + 1}") && !ClientManager.Board.Cells.Where(e => e.Key == $"{Location.X};{Location.Y + 1}").First().Value.Visible)
                        AvailableMoves.Add(new Point(Location.X, Location.Y + 1));
                }
            }
            AttackMoves();
            EnPassantMoves();
        }

        private void AttackMoves()
        {
            void Attack(int x, int y)
            {
                var tmpPiece = ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y).FirstOrDefault();
                if (ClientManager.Board.Cells.ContainsKey($"{x};{y}")
                    && tmpPiece != default
                    && tmpPiece.IsBlack != ClientManager.BlackTurn)
                    AvailableMoves.Add(new Point(x, y));
            }


            int x, y;
            if (!IsBlack)
            {
                x = Location.X + 1; y = Location.Y - 1;
                Attack(x, y);
                x = Location.X - 1; y = Location.Y;
                Attack(x, y);
            }
            else
            {
                x = Location.X - 1; y = Location.Y + 1;
                Attack(x, y);
                x = Location.X + 1; y = Location.Y;
                Attack(x, y);
            }
        }

        private void EnPassantMoves()
        {
            void Attack(int x, int y)
            {
                HexChessPiece? tmpPiece;
                if (!IsBlack) tmpPiece = ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y + 1).FirstOrDefault();
                else tmpPiece = ClientManager.Board.Pieces.Values.Where(e => e.Location.X == x && e.Location.Y == y - 1).FirstOrDefault();

                if (ClientManager.Board.Cells.ContainsKey($"{x};{y}")
                    && tmpPiece != default
                    && tmpPiece.LastMove
                    && tmpPiece.Location.X == x
                    &&tmpPiece.IsBlack != ClientManager.BlackTurn)
                    //&& ((tmpPiece.Location.Y == y + 1 && tmpPiece.IsBlack != ClientManager.BlackTurn) || (tmpPiece.Location.Y == y - 1 && tmpPiece.IsBlack != ClientManager.BlackTurn)))
                    AvailableMoves.Add(new Point(x, y));
                
            }

            int x, y;
            if (!IsBlack)
            {
                x = Location.X + 1; y = Location.Y - 1;
                Attack(x, y);
                x = Location.X - 1; y = Location.Y;
                Attack(x, y);
            }
            else
            {
                x = Location.X - 1; y = Location.Y + 1;
                Attack(x, y);
                x = Location.X + 1; y = Location.Y;
                Attack(x, y);
            }
        }
    }
}
