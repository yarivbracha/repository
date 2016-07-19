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
        IHumenMove move;

        public HumenPlayer(string name, Color color) : base(name, color)
        {
            if(color == Color.Red)
            {
                move = new HumenRedMove();
            }
            else
            {
                move = new HumenBlueMove();
            }
        }

        public override bool DoMove(int panel, int steps)
        {
            int sum;
            BackgammonBoard board = BackgammonBoard.Instance;
            bool isMoved = false;
            if (this.Status == GameStatus.Start)
            {
                isMoved = move.StartMove(panel, steps, out sum);
            }
            else if(this.Status == GameStatus.Out)
            {
                isMoved = move.OutMove(panel, steps, out sum);
            }
            else
            {
                isMoved = move.FinishMove(panel, steps, out sum);
            }
            Status = Rull.CheckStatus();
            UpdateSum(sum);
            return isMoved;
        }
    }
}