using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class BlueRulls : Rulls
    {
        private BackgammonBoard board;

        internal override bool IsValidMoveForFinish(int cube)
        {
            throw new NotImplementedException();
        }

        internal override bool IsValidMoveForOut(int cube)
        {
            throw new NotImplementedException();
        }

        internal override bool IsValidMoveForStart(int cube)
        {
            board = BackgammonBoard.Instance;
            bool isValid = false;
            for (int i = 23; i > -1; i--)
            {
                if (board.Board[i].CheckersColor == Color.Blue)
                {
                    if ((i - cube) > -1)
                    {
                        if ((board.Board[i - cube].CheckersColor == Color.Blue) || (board.Board[i - cube].CheckersColor == Color.Transparent)
                            || ((board.Board[i - cube].CheckersColor == Color.Red) && (board.Board[i - cube].Checkers < 2)))
                        {
                            isValid = true;
                            break;
                        }
                    }
                }
            }
            return isValid;
        }

        internal override bool IsFinishStatus()
        {
            bool isFinish = true;
            for (int i = 6; i < 24; i++)
            {
                if (board.Board[i].CheckersColor == Color.Blue)
                {
                    isFinish = false;
                    break;
                }
            }
            return isFinish;
        }

        internal override bool IsOutStatus()
        {
            bool isOut = false;
            if (board.Out.BlueSum > 0)
            {
                isOut = true;
            }
            return isOut;
        }
    }
}
