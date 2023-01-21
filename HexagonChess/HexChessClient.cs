using HexagonChess.HexChessClasses;

namespace HexagonChess
{
    public partial class HexChessClient : Form
    {
        private HexChessBoard test;
        public HexChessClient()
        {
            InitializeComponent();
            test = new HexChessBoard(this);
            foreach (var item in test.Cells.Values)
            {
                if (item.Enabled)
                item.BackColor = Color.Red;
            }
        }
    }
}