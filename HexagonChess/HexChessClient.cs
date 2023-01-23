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
        }

        private void c01_Click(object sender, EventArgs e)
        {
            if (c01.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c01.BackColor == Color.Transparent)
                board.AddMoves(0, 1);
            else
                board.MovePiece(0, 1);
        }

        private void c0N1_Click(object sender, EventArgs e)
        {
            if (c0N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c0N1.BackColor == Color.Transparent)
                board.AddMoves(0, -1);
            else
                board.MovePiece(0, -1);
        }

        private void c00_Click(object sender, EventArgs e)
        {
            if (c00.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c00.BackColor == Color.Transparent)
                board.AddMoves(0, 0);
            else
                board.MovePiece(0, 0);
        }

        private void cN12_Click(object sender, EventArgs e)
        {
            if (cN12.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN12.BackColor == Color.Transparent)
                board.AddMoves(-1, 2);
            else
                board.MovePiece(-1, 2);
        }

        private void cN11_Click(object sender, EventArgs e)
        {
            if (cN11.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN11.BackColor == Color.Transparent)
                board.AddMoves(-1, 1);
            else
                board.MovePiece(-1, 1);
        }

        private void cN10_Click(object sender, EventArgs e)
        {
            if (cN10.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN10.BackColor == Color.Transparent)
                board.AddMoves(-1, 0);
            else
                board.MovePiece(-1, 0);
        }

        private void c10_Click(object sender, EventArgs e)
        {
            if (c10.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c10.BackColor == Color.Transparent)
                board.AddMoves(1, 0);
            else
                board.MovePiece(1, 0);
        }

        private void c1N1_Click(object sender, EventArgs e)
        {
            if (c1N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N1.BackColor == Color.Transparent)
                board.AddMoves(1, -1);
            else
                board.MovePiece(1, -1);
        }

        private void c11_Click(object sender, EventArgs e)
        {
            if (c11.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c11.BackColor == Color.Transparent)
                board.AddMoves(1, 1);
            else
                board.MovePiece(1, 1);
        }

        private void c21_Click(object sender, EventArgs e)
        {
            if (c21.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c21.BackColor == Color.Transparent)
                board.AddMoves(2, 1);
            else
                board.MovePiece(2, 1);
        }

        private void c20_Click(object sender, EventArgs e)
        {
            if (c20.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c20.BackColor == Color.Transparent)
                board.AddMoves(2, 0);
            else
                board.MovePiece(2, 0);
        }

        private void c2N1_Click(object sender, EventArgs e)
        {
            if (c2N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c2N1.BackColor == Color.Transparent)
                board.AddMoves(2, -1);
            else
                board.MovePiece(2, -1);
        }

        private void c2N2_Click(object sender, EventArgs e)
        {
            if (c2N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c2N2.BackColor == Color.Transparent)
                board.AddMoves(2, -2);
            else
                board.MovePiece(2, -2);
        }

        private void cN23_Click(object sender, EventArgs e)
        {
            if (cN23.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN23.BackColor == Color.Transparent)
                board.AddMoves(-2, 3);
            else
                board.MovePiece(-2, 3);
        }

        private void cN22_Click(object sender, EventArgs e)
        {
            if (cN22.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN22.BackColor == Color.Transparent)
                board.AddMoves(-2, 2);
            else
                board.MovePiece(-2, 2);
        }

        private void cN21_Click(object sender, EventArgs e)
        {
            if (cN21.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN21.BackColor == Color.Transparent)
                board.AddMoves(-2, 1);
            else
                board.MovePiece(-2, 1);
        }

        private void cN20_Click(object sender, EventArgs e)
        {
            if (cN20.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN20.BackColor == Color.Transparent)
                board.AddMoves(-2, 0);
            else
                board.MovePiece(-2, 0);
        }

        private void cN31_Click(object sender, EventArgs e)
        {
            if (cN31.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN31.BackColor == Color.Transparent)
                board.AddMoves(-3, 1);
            else
                board.MovePiece(-3, 1);
        }

        private void cN33_Click(object sender, EventArgs e)
        {
            if (cN33.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN33.BackColor == Color.Transparent)
                board.AddMoves(-3, 3);
            else
                board.MovePiece(-3, 3);
        }

        private void cN34_Click(object sender, EventArgs e)
        {
            if (cN34.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN34.BackColor == Color.Transparent)
                board.AddMoves(-3, 4);
            else
                board.MovePiece(-3, 4);
        }

        private void cN30_Click(object sender, EventArgs e)
        {
            if (cN30.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN30.BackColor == Color.Transparent)
                board.AddMoves(-3, 0);
            else
                board.MovePiece(-3, 0);
        }

        private void cN32_Click(object sender, EventArgs e)
        {
            if (cN32.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN32.BackColor == Color.Transparent)
                board.AddMoves(-3, 2);
            else
                board.MovePiece(-3, 2);
        }

        private void cN43_Click(object sender, EventArgs e)
        {
            if (cN43.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN43.BackColor == Color.Transparent)
                board.AddMoves(-4, 3);
            else
                board.MovePiece(-4, 3);
        }

        private void cN45_Click(object sender, EventArgs e)
        {
            if (cN45.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN45.BackColor == Color.Transparent)
                board.AddMoves(-4, 5);
            else
                board.MovePiece(-4, 5);
        }

        private void cN40_Click(object sender, EventArgs e)
        {
            if (cN40.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN40.BackColor == Color.Transparent)
                board.AddMoves(-4, 0);
            else
                board.MovePiece(-4, 0);
        }

        private void cN41_Click(object sender, EventArgs e)
        {
            if (cN41.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN41.BackColor == Color.Transparent)
                board.AddMoves(-4, 1);
            else
                board.MovePiece(-4, 1);
        }

        private void cN42_Click(object sender, EventArgs e)
        {
            if (cN42.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN42.BackColor == Color.Transparent)
                board.AddMoves(-4, 2);
            else
                board.MovePiece(-4, 2);
        }

        private void cN44_Click(object sender, EventArgs e)
        {
            if (cN44.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN44.BackColor == Color.Transparent)
                board.AddMoves(-4, 4);
            else
                board.MovePiece(-4, 4);
        }

        private void c3N2_Click(object sender, EventArgs e)
        {
            if (c3N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c3N2.BackColor == Color.Transparent)
                board.AddMoves(3, -2);
            else
                board.MovePiece(3, -2);
        }

        private void c30_Click(object sender, EventArgs e)
        {
            if (c30.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c30.BackColor == Color.Transparent)
                board.AddMoves(3, 0);
            else
                board.MovePiece(3, 0);
        }

        private void c31_Click(object sender, EventArgs e)
        {
            if (c31.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c31.BackColor == Color.Transparent)
                board.AddMoves(3, 1);
            else
                board.MovePiece(3, 1);
        }

        private void c3N3_Click(object sender, EventArgs e)
        {
            if (c3N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c3N3.BackColor == Color.Transparent)
                board.AddMoves(3, -3);
            else
                board.MovePiece(3, -3);
        }

        private void c3N1_Click(object sender, EventArgs e)
        {
            if (c3N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c3N1.BackColor == Color.Transparent)
                board.AddMoves(3, -1);
            else
                board.MovePiece(3, -1);
        }

        private void c4N4_Click(object sender, EventArgs e)
        {
            if (c4N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c4N4.BackColor == Color.Transparent)
                board.AddMoves(4, -4);
            else
                board.MovePiece(4, -4);
        }

        private void c41_Click(object sender, EventArgs e)
        {
            if (c41.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c41.BackColor == Color.Transparent)
                board.AddMoves(4, 1);
            else
                board.MovePiece(4, 1);
        }

        private void c40_Click(object sender, EventArgs e)
        {
            if (c40.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c40.BackColor == Color.Transparent)
                board.AddMoves(4, 0);
            else
                board.MovePiece(4, 0);
        }

        private void c4N3_Click(object sender, EventArgs e)
        {
            if (c4N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c4N3.BackColor == Color.Transparent)
                board.AddMoves(4, -3);
            else
                board.MovePiece(4, -3);
        }

        private void c4N2_Click(object sender, EventArgs e)
        {
            if (c4N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c4N2.BackColor == Color.Transparent)
                board.AddMoves(4, -2);
            else
                board.MovePiece(4, -2);
        }

        private void c4N1_Click(object sender, EventArgs e)
        {
            if (c4N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c4N1.BackColor == Color.Transparent)
                board.AddMoves(4, -1);
            else
                board.MovePiece(4, -1);
        }

        private void c04_Click(object sender, EventArgs e)
        {
            if (c04.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c04.BackColor == Color.Transparent)
                board.AddMoves(0, 4);
            else
                board.MovePiece(0, 4);
        }

        private void c12_Click(object sender, EventArgs e)
        {
            if (c12.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c12.BackColor == Color.Transparent)
                board.AddMoves(1, 2);
            else
                board.MovePiece(1, 2);
        }

        private void c02_Click(object sender, EventArgs e)
        {
            if (c02.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c02.BackColor == Color.Transparent)
                board.AddMoves(0, 2);
            else
                board.MovePiece(0, 2);
        }

        private void cN14_Click(object sender, EventArgs e)
        {
            if (cN14.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN14.BackColor == Color.Transparent)
                board.AddMoves(-1, 4);
            else
                board.MovePiece(-1, 4);
        }

        private void cN24_Click(object sender, EventArgs e)
        {
            if (cN24.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN24.BackColor == Color.Transparent)
                board.AddMoves(-2, 4);
            else
                board.MovePiece(-2, 4);
        }

        private void cN13_Click(object sender, EventArgs e)
        {
            if (cN13.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN13.BackColor == Color.Transparent)
                board.AddMoves(-1, 3);
            else
                board.MovePiece(-1, 3);
        }

        private void c22_Click(object sender, EventArgs e)
        {
            if (c22.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c22.BackColor == Color.Transparent)
                board.AddMoves(2, 2);
            else
                board.MovePiece(2, 2);
        }

        private void c13_Click(object sender, EventArgs e)
        {
            if (c13.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c13.BackColor == Color.Transparent)
                board.AddMoves(1, 3);
            else
                board.MovePiece(1, 3);
        }

        private void c03_Click(object sender, EventArgs e)
        {
            if (c03.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c03.BackColor == Color.Transparent)
                board.AddMoves(0, 3);
            else
                board.MovePiece(0, 3);
        }

        private void c05_Click(object sender, EventArgs e)
        {
            if (c05.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c05.BackColor == Color.Transparent)
                board.AddMoves(0, 5);
            else
                board.MovePiece(0, 5);
        }

        private void cN50_Click(object sender, EventArgs e)
        {
            if (cN50.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN50.BackColor == Color.Transparent)
                board.AddMoves(-5, 0);
            else
                board.MovePiece(-5, 0);
        }

        private void cN54_Click(object sender, EventArgs e)
        {
            if (cN54.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN54.BackColor == Color.Transparent)
                board.AddMoves(-5, 4);
            else
                board.MovePiece(-5, 4);
        }

        private void cN52_Click(object sender, EventArgs e)
        {
            if (cN52.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN52.BackColor == Color.Transparent)
                board.AddMoves(-5, 2);
            else
                board.MovePiece(-5, 2);
        }

        private void cN55_Click(object sender, EventArgs e)
        {
            if (cN55.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN55.BackColor == Color.Transparent)
                board.AddMoves(-5, 5);
            else
                board.MovePiece(-5, 5);
        }

        private void cN51_Click(object sender, EventArgs e)
        {
            if (cN51.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN51.BackColor == Color.Transparent)
                board.AddMoves(-5, 1);
            else
                board.MovePiece(-5, 1);
        }

        private void cN53_Click(object sender, EventArgs e)
        {
            if (cN53.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN53.BackColor == Color.Transparent)
                board.AddMoves(-5, 3);
            else
                board.MovePiece(-5, 3);
        }

        private void c5N3_Click(object sender, EventArgs e)
        {
            if (c5N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c5N3.BackColor == Color.Transparent)
                board.AddMoves(5, -3);
            else
                board.MovePiece(5, -3);
        }

        private void c5N5_Click(object sender, EventArgs e)
        {
            if (c5N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c5N5.BackColor == Color.Transparent)
                board.AddMoves(5, -5);
            else
                board.MovePiece(5, -5);
        }

        private void c5N1_Click(object sender, EventArgs e)
        {
            if (c5N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c5N1.BackColor == Color.Transparent)
                board.AddMoves(5, -1);
            else
                board.MovePiece(5, -1);
        }

        private void c50_Click(object sender, EventArgs e)
        {
            if (c50.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c50.BackColor == Color.Transparent)
                board.AddMoves(5, 0);
            else
                board.MovePiece(5, 0);
        }

        private void c5N4_Click(object sender, EventArgs e)
        {
            if (c5N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c5N4.BackColor == Color.Transparent)
                board.AddMoves(5, -4);
            else
                board.MovePiece(5, -4);
        }

        private void c5N2_Click(object sender, EventArgs e)
        {
            if (c5N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c5N2.BackColor == Color.Transparent)
                board.AddMoves(5, -2);
            else
                board.MovePiece(5, -2);
        }

        private void c32_Click(object sender, EventArgs e)
        {
            if (c32.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c32.BackColor == Color.Transparent)
                board.AddMoves(3, 2);
            else
                board.MovePiece(3, 2);
        }

        private void cN35_Click(object sender, EventArgs e)
        {
            if (cN35.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN35.BackColor == Color.Transparent)
                board.AddMoves(-3, 5);
            else
                board.MovePiece(-3, 5);
        }

        private void cN15_Click(object sender, EventArgs e)
        {
            if (cN15.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN15.BackColor == Color.Transparent)
                board.AddMoves(-1, 5);
            else
                board.MovePiece(-1, 5);
        }

        private void c23_Click(object sender, EventArgs e)
        {
            if (c23.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c23.BackColor == Color.Transparent)
                board.AddMoves(2, 3);
            else
                board.MovePiece(2, 3);
        }

        private void cN25_Click(object sender, EventArgs e)
        {
            if (cN25.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN25.BackColor == Color.Transparent)
                board.AddMoves(-2, 5);
            else
                board.MovePiece(-2, 5);
        }

        private void c14_Click(object sender, EventArgs e)
        {
            if (c14.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c14.BackColor == Color.Transparent)
                board.AddMoves(1, 4);
            else
                board.MovePiece(1, 4);
        }

        private void cN2N1_Click(object sender, EventArgs e)
        {
            if (cN2N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN2N1.BackColor == Color.Transparent)
                board.AddMoves(-2, -1);
            else
                board.MovePiece(-2, -1);
        }

        private void c1N2_Click(object sender, EventArgs e)
        {
            if (c1N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N2.BackColor == Color.Transparent)
                board.AddMoves(1, -2);
            else
                board.MovePiece(1, -2);
        }

        private void c2N3_Click(object sender, EventArgs e)
        {
            if (c2N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c2N3.BackColor == Color.Transparent)
                board.AddMoves(2, -3);
            else
                board.MovePiece(2, -3);
        }

        private void c3N4_Click(object sender, EventArgs e)
        {
            if (c3N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c3N4.BackColor == Color.Transparent)
                board.AddMoves(3, -4);
            else
                board.MovePiece(3, -4);
        }

        private void c4N5_Click(object sender, EventArgs e)
        {
            if (c4N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c4N5.BackColor == Color.Transparent)
                board.AddMoves(4, -5);
            else
                board.MovePiece(4, -5);
        }

        private void cN1N1_Click(object sender, EventArgs e)
        {
            if (cN1N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN1N1.BackColor == Color.Transparent)
                board.AddMoves(-1, -1);
            else
                board.MovePiece(-1, -1);
        }

        private void cN3N1_Click(object sender, EventArgs e)
        {
            if (cN3N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN3N1.BackColor == Color.Transparent)
                board.AddMoves(-3, -1);
            else
                board.MovePiece(-3, -1);
        }

        private void cN4N1_Click(object sender, EventArgs e)
        {
            if (cN4N1.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN4N1.BackColor == Color.Transparent)
                board.AddMoves(-4, -1);
            else
                board.MovePiece(-4, -1);
        }

        private void c0N2_Click(object sender, EventArgs e)
        {
            if (c0N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c0N2.BackColor == Color.Transparent)
                board.AddMoves(0, -2);
            else
                board.MovePiece(0, -2);
        }

        private void cN1N2_Click(object sender, EventArgs e)
        {
            if (cN1N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN1N2.BackColor == Color.Transparent)
                board.AddMoves(-1, -2);
            else
                board.MovePiece(-1, -2);
        }

        private void cN2N2_Click(object sender, EventArgs e)
        {
            if (cN2N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN2N2.BackColor == Color.Transparent)
                board.AddMoves(-2, -2);
            else
                board.MovePiece(-2, -2);
        }

        private void cN3N2_Click(object sender, EventArgs e)
        {
            if (cN3N2.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN3N2.BackColor == Color.Transparent)
                board.AddMoves(-3, -2);
            else
                board.MovePiece(-3, -2);
        }

        private void cN2N3_Click(object sender, EventArgs e)
        {
            if (cN2N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN2N3.BackColor == Color.Transparent)
                board.AddMoves(-2, -3);
            else
                board.MovePiece(-2, -3);
        }

        private void cN1N4_Click(object sender, EventArgs e)
        {
            if (cN1N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && cN1N4.BackColor == Color.Transparent)
                board.AddMoves(-1, -4);
            else
                board.MovePiece(-1, -4);
        }

        private void c0N5_Click(object sender, EventArgs e)
        {
            if (c0N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c0N5.BackColor == Color.Transparent)
                board.AddMoves(0, -5);
            else
                board.MovePiece(0, -5);
        }

        private void c1N5_Click(object sender, EventArgs e)
        {
            if (c1N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N5.BackColor == Color.Transparent)
                board.AddMoves(1, -5);
            else
                board.MovePiece(1, -5);
        }

        private void c2N5_Click(object sender, EventArgs e)
        {
            if (c2N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c2N5.BackColor == Color.Transparent)
                board.AddMoves(2, -5);
            else
                board.MovePiece(2, -5);
        }

        private void c3N5_Click(object sender, EventArgs e)
        {
            if (c3N5.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c3N5.BackColor == Color.Transparent)
                board.AddMoves(3, -5);
            else
                board.MovePiece(3, -5);
        }

        private void c2N4_Click(object sender, EventArgs e)
        {
            if (c2N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c2N4.BackColor == Color.Transparent)
                board.AddMoves(2, -4);
            else
                board.MovePiece(2, -4);
        }

        private void c1N3_Click(object sender, EventArgs e)
        {
            if (c1N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N3.BackColor == Color.Transparent)
                board.AddMoves(1, -3);
            else
                board.MovePiece(1, -3);
        }

        private void c1N4_Click(object sender, EventArgs e)
        {
            if (c1N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N4.BackColor == Color.Transparent)
                board.AddMoves(1, -4);
            else
                board.MovePiece(1, -4);
        }

        private void c0N4_Click(object sender, EventArgs e)
        {
            if (c0N4.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c0N4.BackColor == Color.Transparent)
                board.AddMoves(0, -4);
            else
                board.MovePiece(0, -4);
        }

        private void cN1N3_Click(object sender, EventArgs e)
        {
            if (cN1N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c1N3.BackColor == Color.Transparent)
                board.AddMoves(-1, -3);
            else
                board.MovePiece(-1, -3);
        }

        private void c0N3_Click(object sender, EventArgs e)
        {
            if (c0N3.BackgroundImage.HorizontalResolution != Resources.point.HorizontalResolution && c0N3.BackColor == Color.Transparent)
                board.AddMoves(0, -3);
            else
                board.MovePiece(0, -3);
        }
    }
}