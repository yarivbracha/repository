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
            bool isValid = false;
            for (int i = 5; i > 0; i--)
            {
                if ((i - cube) < 0)
                {
                    isValid = true;
                }
                else if (board.Board[i].CheckersColor == Color.Blue)
                {
                    if ((board.Board[i + cube].CheckersColor == Color.Blue) || (board.Board[i + cube].CheckersColor == Color.Transparent))
                    {
                        isValid = true;
                    }
                    else if (board.Board[i + cube].Checkers == 1)
                    {
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        internal override bool IsValidMoveForOut(int cube)
        {
            bool isValid = false;
            if((board.Board[24 - cube].CheckersColor == Color.Blue) || (board.Board[24 - cube].CheckersColor == Color.Transparent))
            {
                isValid = true;
            }
            else if (board.Board[24 - cube].Checkers == 1)
            {
                isValid = true;
            }
            return isValid;
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
            if (board.Out.BlueSum > 0)
            {
                isFinish = false;
            }
            else
            {
                for (int i = 6; i < 24; i++)
                {
                    if (board.Board[i].CheckersColor == Color.Blue)
                    {
                        isFinish = false;
                        break;
                    }
                }
            }
            return isFinish;
        }

        internal override bool IsOutStatus()
        {
            board = BackgammonBoard.Instance;
            bool isOut = false;
            if (board.Out.BlueSum > 0)
            {
                isOut = true;
            }
            return isOut;
        }
    }
}
