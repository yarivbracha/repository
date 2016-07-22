using System.Drawing;

namespace LogicBackgammon
{
    class HumenBlueMove : IHumenMove
    {
        BackgammonBoard board;

        public  bool FinishMove(int from, int steps, out int sum)
        {
            bool isMoved;
            if ((from <= 5) && (from >= 0))
            {
                if (from + 1 == steps)
                {
                    isMoved = true;
                    sum = steps;
                    board.Board[from].RemoveChecker();
                }
                else if (from + 1 > steps)
                {
                    if ((board.Board[from - steps].CheckersColor == Color.Blue) || (board.Board[from - steps].CheckersColor == Color.Transparent))
                    {
                        isMoved = true;
                        sum = steps;
                        board.Board[from].RemoveChecker();
                        board.Board[from - steps].CheckersColor = Color.Blue;
                        board.Board[from - steps].AddChecker();
                    }
                    else if (board.Board[from - steps].Checkers == 1)
                    {
                        isMoved = true;
                        board.Board[from].RemoveChecker();
                        board.Board[from - steps].RemoveChecker();
                        board.Out.Add(Color.Red,  24 - (from - steps));
                        board.Board[from - steps].CheckersColor = Color.Blue;
                        board.Board[from - steps].AddChecker();
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
                    if (IsInBiggerTriangle(from, steps))
                    {
                        sum = 0;
                        isMoved = false;
                    }
                    else
                    {
                        isMoved = true;
                        sum = from + 1;
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
            for (int i = 5; i > triangle; i--)
            {
                if (board.Board[i].CheckersColor == Color.Blue)
                {
                    if ((i - steps) > 0)
                    {
                        if (((board.Board[i - steps].CheckersColor == Color.Blue) || (board.Board[i - steps].CheckersColor == Color.Transparent))
                            || ((board.Board[i - steps].CheckersColor == Color.Red) && (board.Board[i - steps].Checkers == 1)))
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

        public bool OutMove(int from, int steps, out int sum)
        {
            bool isMoved;
            if (from == -1)
            {
                if ((board.Board[24 - steps].CheckersColor == Color.Blue) || (board.Board[24 - steps].CheckersColor == Color.Transparent))
                {
                    isMoved = true;
                    sum = steps;
                    board.Out.Reduce(Color.Blue);
                    board.Board[24 - steps].CheckersColor = Color.Blue;
                    board.Board[24 - steps].AddChecker();
                }
                else if (board.Board[24 - steps].Checkers == 1)
                {
                    isMoved = true;
                    sum = steps;
                    board.Out.Reduce(Color.Blue);
                    board.Board[24 - steps].RemoveChecker();
                    board.Board[24 - steps].CheckersColor = Color.Blue;
                    board.Board[24 - steps].AddChecker();
                    board.Out.Add(Color.Red, 24 - steps);
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
            if ((from - steps) > -1)
            {
                if ((board.Board[from - steps].CheckersColor == Color.Blue) || (board.Board[from - steps].CheckersColor == Color.Transparent))
                {
                    isMoved = true;
                    sum = steps;
                    board.Board[from].RemoveChecker();
                    board.Board[from - steps].CheckersColor = Color.Blue;
                    board.Board[from - steps].AddChecker();
                }
                else if (board.Board[from - steps].Checkers == 1)
                {
                    isMoved = true;
                    sum = steps;
                    board.Board[from].RemoveChecker();
                    board.Out.Add(Color.Red, (from - steps) + 1);
                    board.Board[from - steps].RemoveChecker();
                    board.Board[from - steps].CheckersColor = Color.Blue;
                    board.Board[from - steps].AddChecker();
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
