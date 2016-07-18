using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class HumenPlayer : Player
    {
        public HumenPlayer(string name, Color color) : base(name, color)
        { }

        public override bool DoMove(int panel, int steps)
        {
            BackgammonBoard board = BackgammonBoard.Instance;
            bool isMoved = false;
            if (this.Status == GameStatus.Start)
            {
                if (board.Board[panel].CheckersColor != this.PlayerColor)
                {
                    isMoved = false;
                }

            }
            return isMoved;
        }
    }
}