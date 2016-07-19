using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    public class RedRulls : Rulls
    {
        private BackgammonBoard board;
        internal override bool IsValidMoveForStart(int cube)
        {
            board = BackgammonBoard.Instance;
            bool isValid = false;
            for(int i = 0; i < 24; i++)
            {
                if(board.Board[i].CheckersColor == Color.Red)
                {
                    if ((i + cube) < 24)
                    {
                        if ((board.Board[i + cube].CheckersColor == Color.Red) || (board.Board[i + cube].CheckersColor == Color.Transparent)
                            || ((board.Board[i + cube].CheckersColor == Color.Blue) && (board.Board[i + cube].Checkers < 2)))
                        {
                            isValid = true;
                            break;
                        }
                    }
                }
            }
            return isValid;
        }

        internal override bool IsValidMoveForFinish(int cube)
        {
            bool isValid = false;
            for(int i = 18; i < 24; i++)
            {
                if ((i + cube) > 23)
                {
                    isValid = true;
                }
                else if (board.Board[i].CheckersColor == Color.Red)
                {
                    if((board.Board[i + cube].CheckersColor == Color.Red) || (board.Board[i + cube].CheckersColor == Color.Transparent)) 
                    {
                        isValid = true;
                    }
                    else if(board.Board[i + cube].Checkers == 1)
                    {
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        internal override bool IsValidMoveForOut(int cube)
        {
            throw new NotImplementedException();
        }

        internal override bool IsFinishStatus()
        {
            bool isFinish = true;
            for(int i = 0; i < 18; i++)
            {
                if(board.Board[i].CheckersColor == Color.Red)
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
            if(board.Out.RedSum > 0)
            {
                isOut = true;
            }
            return isOut;
        }
    }
}
