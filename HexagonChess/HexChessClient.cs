using HexagonChess.HexChessClasses;
using HexagonChess.Properties;

namespace HexagonChess
{
    public partial class HexChessClient : Form
    {
        private HexChessBoard board;
        public HexChessClient()
        {
            InitializeComponent();
            board = new HexChessBoard(this);
            ClientManager.Board = board;
            foreach (var item in board.Cells.Values)
            {
                if (!item.Enabled)
                item.Visible= false;
            }
        }

        private void c01_Click(object sender, EventArgs e)
        {
            if (c01.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(0, 1);
            else
                board.MovePiece(0, 1);
        }

        private void c0N1_Click(object sender, EventArgs e)
        {
            if (c0N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(0, -1);
            else
                board.MovePiece(0, -1);
        }

        private void c00_Click(object sender, EventArgs e)
        {
            if (c00.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(0, 0);
            else
                board.MovePiece(0, 0);
        }

        private void cN12_Click(object sender, EventArgs e)
        {
            if (cN12.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(-1, 2);
            else
                board.MovePiece(-1, 2);
        }

        private void cN11_Click(object sender, EventArgs e)
        {
            if (cN11.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(-1, 1);
            else
                board.MovePiece(-1, 1);
        }

        private void cN10_Click(object sender, EventArgs e)
        {
            if (cN10.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(-1, 0);
            else
                board.MovePiece(-1, 0);
        }

        private void c10_Click(object sender, EventArgs e)
        {
            if (c10.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(1, 0);
            else
                board.MovePiece(1, 0);
        }

        private void c1N1_Click(object sender, EventArgs e)
        {
            if (c1N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(1, -1);
            else
                board.MovePiece(1, -1);
        }

        private void c11_Click(object sender, EventArgs e)
        {
            if (c11.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution)
                board.AddMoves(1, 1);
            else
                board.MovePiece(1, 1);
        }
    }
}