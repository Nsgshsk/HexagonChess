using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonChess.HexChessClasses
{
    internal class HexChessBoard
    {
        private Dictionary<string, Button> cells;

        public HexChessBoard(HexChessClient tmp)
        {
            Cells = new Dictionary<string, Button>
            {
                //
                { "0;0", tmp.c00 },
                //
                { "0;-5", tmp.c0N5 },
                { "0;-4", tmp.c0N4 },
                { "0;-3", tmp.c0N3 },
                { "0;-2", tmp.c0N2 },
                { "0;-1", tmp.c0N1 },

                { "0;1", tmp.c01 },
                { "0;2", tmp.c02 },
                { "0;3", tmp.c03 },
                { "0;4", tmp.c04 },
                { "0;5", tmp.c05 },
                //
                { "-5;0", tmp.cN50 },
                { "-4;0", tmp.cN40 },
                { "-3;0", tmp.cN30 },
                { "-2;0", tmp.cN20 },
                { "-1;0", tmp.cN10 },

                { "1;0", tmp.c10 },
                { "2;0", tmp.c20 },
                { "3;0", tmp.c30 },
                { "4;0", tmp.c40 },
                { "5;0", tmp.c50 },
                //
                { "1;-5", tmp.c1N5 },
                { "1;-4", tmp.c1N4 },
                { "1;-3", tmp.c1N3 },
                { "1;-2", tmp.c1N2 },
                { "1;-1", tmp.c1N1 },

                { "1;1", tmp.c11 },
                { "1;2", tmp.c12 },
                { "1;3", tmp.c13 },
                { "1;4", tmp.c14 },
                //
                { "-5;1", tmp.cN51 },
                { "-4;1", tmp.cN41 },
                { "-3;1", tmp.cN31 },
                { "-2;1", tmp.cN21 },
                { "-1;1", tmp.cN11 },

                { "2;1", tmp.c21 },
                { "3;1", tmp.c31 },
                { "4;1", tmp.c41 },
                //
                { "2;-5", tmp.c2N5 },
                { "2;-4", tmp.c2N4 },
                { "2;-3", tmp.c2N3 },
                { "2;-2", tmp.c2N2 },
                { "2;-1", tmp.c2N1 },

                { "2;2", tmp.c22 },
                { "2;3", tmp.c23 },
                //
                { "-5;2", tmp.cN52 },
                { "-4;2", tmp.cN42 },
                { "-3;2", tmp.cN32 },
                { "-2;2", tmp.cN22 },
                { "-1;2", tmp.cN12 },

                { "3;2", tmp.c32 },
                //
                { "3;-5", tmp.c3N5 },
                { "3;-4", tmp.c3N4 },
                { "3;-3", tmp.c3N3 },
                { "3;-2", tmp.c3N2 },
                { "3;-1", tmp.c3N1 },
                //
                { "-5;3", tmp.cN53 },
                { "-4;3", tmp.cN43 },
                { "-3;3", tmp.cN33 },
                { "-2;3", tmp.cN23 },
                { "-1;3", tmp.cN13 },
                //
                { "4;-5", tmp.c4N5 },
                { "4;-4", tmp.c4N4 },
                { "4;-3", tmp.c4N3 },
                { "4;-2", tmp.c4N2 },
                { "4;-1", tmp.c4N1 },
                //
                { "-5;4", tmp.cN54 },
                { "-4;4", tmp.cN44 },
                { "-3;4", tmp.cN34 },
                { "-2;4", tmp.cN24 },
                { "-1;4", tmp.cN14 },
                //
                { "5;-5", tmp.c5N5 },
                { "5;-4", tmp.c5N4 },
                { "5;-3", tmp.c5N3 },
                { "5;-2", tmp.c5N2 },
                { "5;-1", tmp.c5N1 },
                //
                { "-5;5", tmp.cN55 },
                { "-4;5", tmp.cN45 },
                { "-3;5", tmp.cN35 },
                { "-2;5", tmp.cN25 },
                { "-1;5", tmp.cN15 },
                //
                { "-1;-1", tmp.cN1N1 },
                { "-1;-2", tmp.cN1N2 },
                { "-1;-3", tmp.cN1N3 },
                { "-1;-4", tmp.cN1N4 },
                //
                { "-2;-3", tmp.cN2N3 },
                { "-2;-2", tmp.cN2N2 },
                { "-2;-1", tmp.cN2N1 },
                //
                { "-3;-2", tmp.cN3N2 },
                { "-3;-1", tmp.cN3N1 },
                //
                { "-4;-1", tmp.cN4N1 }
            };
        }

        public Dictionary<string, Button> Cells { get => cells; set => cells = value; }
    }
}
