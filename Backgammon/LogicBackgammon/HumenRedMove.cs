using System.Drawing;

namespace LogicBackgammon
{
    class HumenRedMove : IHumenMove
    {
        BackgammonBoard board;

        public  bool FinishMove(int from, int steps, out int sum)
        {
            bool isMoved;
            if((from <= 23) && (from >= 18))
            {
                if (24 - from == steps)
                {
                    isMoved = true;
                    sum = steps;
                    board.Board[from].RemoveChecker();
                }
                else if (24 - from > steps)
                {
                    if ((board.Board[from + steps].CheckersColor == Color.Red) || (board.Board[from + steps].CheckersColor == Color.Transparent))
                    {
                        isMoved = true;
                        sum = steps;
                        board.Board[from].RemoveChecker();
                        board.Board[from + steps].CheckersColor = Color.Red;
                        board.Board[from + steps].AddChecker();
                     }
                     else if(board.Board[from + steps].Checkers == 1)
                     {
                        isMoved = true;
                        board.Board[from].RemoveChecker();
                        board.Board[from + steps].RemoveChecker();
                        board.Out.Add(Color.Blue, from + steps);
                        board.Board[from + steps].CheckersColor = Color.Red;
                        board.Board[from + steps].AddChecker();
                        sum = steps;
                     }
                     else
                     {
                        sum = 0;
                        isMoved = false;
                     }
                }
                else
                {
                    if(IsInBiggerTriangle(from,steps))
                    {
                        sum = 0;
                        isMoved = false;
                    }
                    else
                    {
                        isMoved = true;
                        sum = 24 - (from + 1);
                        board.Board[from].RemoveChecker();
                    }
                }
            }
            else
            {
                sum = 0;
                isMoved = false;
            }
            return isMoved;
        }

        public bool IsInBiggerTriangle(int triangle, int steps)
        {
            bool isInBiggerTriangle = false;
            for(int i = 18; i < triangle; i++)
            {
                if(board.Board[i].CheckersColor == Color.Red)
                {
                    if ((i + steps) < 24)
                    {
                        if (((board.Board[i + steps].CheckersColor == Color.Red) || (board.Board[i + steps].CheckersColor == Color.Transparent))
                            || ((board.Board[i + steps].CheckersColor == Color.Blue) && (board.Board[i + steps].Checkers == 1)))
                        {
                            isInBiggerTriangle = true;
                            break;
                        }
                    }
                    else
                    {
                        isInBiggerTriangle = true;
                        break;
                    }
                }
            }
            return isInBiggerTriangle;
        }

        public  bool OutMove(int from, int steps, out int sum)
        {
            bool isMoved;
            if (from == -1)
            {
                if((board.Board[steps].CheckersColor == Color.Red) || (board.Board[steps].CheckersColor == Color.Transparent))
                {
                    isMoved = true;
                    board.Out.Reduce(Color.Red);
                    sum = steps;
                    board.Board[steps].CheckersColor = Color.Red;
                    board.Board[steps].AddChecker();
                }
                else if(board.Board[steps].Checkers == 1)
                {
                    isMoved = true;
                    board.Out.Reduce(Color.Red);
                    board.Board[steps].CheckersColor = Color.Red;
                    board.Board[steps].AddChecker();
                    board.Out.Add(Color.Blue, 24 - steps);
                    sum = steps;
                }
                else
                {
                    sum = 0;
                    isMoved = false;
                }
            }
            else
            {
                sum = 0;
                isMoved = false;
            }
            return isMoved;
        }

        public bool StartMove(int from, int steps, out int sum)
        {
            board = BackgammonBoard.Instance;
            bool isMoved;
            if((from + steps) < 24)
            {
                if((board.Board[from+steps].CheckersColor == Color.Red) || (board.Board[from + steps].CheckersColor == Color.Transparent))
                {
                    isMoved = true;
                    board.Board[from].RemoveChecker();
                    board.Board[from + steps].CheckersColor = Color.Red;
                    board.Board[from + steps].AddChecker();
                    sum = steps;
                }
                else if(board.Board[from + steps].Checkers == 1)
                {
                    isMoved = true;
                    board.Board[from].RemoveChecker();
                    board.Out.Add(Color.Blue, 24 - (from + steps));
                    board.Board[from + steps].RemoveChecker();
                    board.Board[from + steps].CheckersColor = Color.Red;
                    board.Board[from + steps].AddChecker();
                    sum = steps;
                }
                else
                {
                    sum = 0;
                    isMoved = false;
                }
            }
            else
            {
                sum = 0;
                isMoved = false;
            }
            return isMoved;
        }
    }
}
