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
        public Pawn(bool isBlack, Point location, bool firstMove = true) : base(isBlack, location, false, true, firstMove)
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
        }
    }
}
