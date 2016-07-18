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
            int sum;
            BackgammonBoard board = BackgammonBoard.Instance;
            bool isMoved = false;
            if (this.Status == GameStatus.Start)
            {
                isMoved = this.Move.StartMove(panel, steps, out sum);
            }
            else if(this.Status == GameStatus.Out)
            {
                isMoved = this.Move.OutMove(panel, steps, out sum);
            }
            else
            {
                isMoved = this.Move.FinishMove(panel, steps, out sum);
            }
            UpdateSum(sum);
            return isMoved;
        }
    }
}