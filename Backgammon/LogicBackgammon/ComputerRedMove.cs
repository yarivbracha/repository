using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class ComputerRedMove : IComputerMove
    {
        BackgammonBoard board;

        public bool FinishMove(int firstCube, int secondCube, out int sum)
        {
            bool isMovedFirst = true;
            bool isMovedSecond = true;
            int firstSum = 0;
            int secondSum = 0;
            if (firstCube != secondCube)
            {
                firstSum = OneMoveForFinish(firstCube);
                if (firstSum == 0)
                {
                    isMovedFirst = false;
                }
                secondSum = OneMoveForFinish(secondCube);
                if (secondSum == 0)
                {
                    isMovedSecond = false;
                }
                sum = firstSum + secondSum;
            }
            else
            {
                sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += OneMoveForFinish(firstCube);
                    if (sum == 0)
                    {
                        return false;
                    }
                }
            }
            return (isMovedFirst || isMovedSecond);
        }

        public bool IsInFinishMode()
        {
            bool isInFinish = true;
            if (board.Out.RedSum > 0)
            {
                isInFinish = false;
            }
            else
            {
                for (int i = 0; i < 18; i++)
                {
                    if(board.Board[i].CheckersColor == Color.Red)
                    {
                        isInFinish = false;
                        break;
                    }
                }
            }
            return isInFinish;
        }

        public int OneMoveForFinish(int cube)
        {
            int sum = 0;
            for(int i = 18; i < 24; i++)
            {
                if (board.Board[i].CheckersColor == Color.Red)
                {
                    if (i + cube < 24)
                    {
                        if ((board.Board[i + cube].CheckersColor == Color.Red) || (board.Board[i + cube].CheckersColor == Color.Transparent))
                        {
                            board.Board[i].RemoveChecker();
                            board.Board[i + cube].CheckersColor = Color.Red;
                            board.Board[i + cube].AddChecker();
                            sum = cube;
                            break;
                        }
                        else if (board.Board[i + cube].Checkers == 1)
                        {
                            board.Board[i].RemoveChecker();
                            board.Board[i + cube].RemoveChecker();
                            board.Board[i + cube].CheckersColor = Color.Red;
                            board.Board[i + cube].AddChecker();
                            board.Out.Add(Color.Blue, i + cube);
                            sum = cube;
                            break;
                        }
                    }
                    else
                    {
                        board.Board[i].RemoveChecker();
                        sum = 24 - i;
                        break;
                    }
                }
            }
            return sum;
        }

        public int OneMoveForOut(int cube)
        {
            int sum = 0;
            if ((board.Board[cube - 1].CheckersColor == Color.Red) || (board.Board[cube - 1].CheckersColor == Color.Transparent))
            {
                board.Out.Reduce(Color.Red);
                board.Board[cube - 1].CheckersColor = Color.Red;
                board.Board[cube - 1].AddChecker();
                sum = cube;
            }
            else if (board.Board[cube - 1].Checkers == 1)
            {
                board.Out.Reduce(Color.Red);
                board.Board[cube - 1].RemoveChecker();
                board.Board[cube - 1].CheckersColor = Color.Red;
                board.Board[cube - 1].AddChecker();
                board.Out.Add(Color.Blue, 25 - cube);
                sum = cube;
            }
            return sum;
        }

        public int OneMoveForStart(int cube)
        {
            int sum = 0;
            for (int i = 0; i < 24; i++)
            {
                if (i + cube < 24)
                {
                    if (board.Board[i].CheckersColor == Color.Red)
                    {
                        if ((board.Board[i + cube].CheckersColor == Color.Red) || (board.Board[i + cube].CheckersColor == Color.Transparent))
                        {
                            board.Board[i].RemoveChecker();
                            board.Board[i + cube].CheckersColor = Color.Red;
                            board.Board[i + cube].AddChecker();
                            sum = cube;
                            break;
                        }
                        else if (board.Board[i + cube].Checkers == 1)
                        {
                            board.Board[i].RemoveChecker();
                            board.Out.Add(Color.Blue, 24 - (i + cube));
                            board.Board[i + cube].RemoveChecker();
                            board.Board[i + cube].CheckersColor = Color.Red;
                            board.Board[i + cube].AddChecker();
                            sum = cube;
                            break;
                        }
                    }
                }
            }
            return sum;
        }

        public bool OutMove(int firstCube, int secondCube, out int sum)
        {
            bool isMovedFirst = true;
            bool isMovedSecond = true;
            int firstSum = 0;
            int secondSum = 0;
            if (firstCube != secondCube)
            {
                firstSum = OneMoveForOut(firstCube);
                if (firstSum == 0)
                {
                    isMovedFirst = false;
                }
                else if (board.Out.RedSum == 0)
                {
                    secondSum = OneMoveForStart(secondCube);
                    sum = firstSum + secondSum;
                    return true;
                }
                secondSum = OneMoveForOut(secondCube);
                if (secondSum == 0)
                {
                    isMovedSecond = false;
                }
                if ((secondSum != 0) && (!isMovedFirst))
                {
                    if (board.Out.RedSum == 0)
                    {
                        firstSum = OneMoveForStart(firstCube);
                    }
                }
                sum = firstSum + secondSum;
            }
            else
            {
                sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (board.Out.RedSum > 0)
                    {
                        sum += OneMoveForOut(firstCube);
                        if (sum == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        sum += OneMoveForStart(firstCube);
                    }
                }
            }
            return (isMovedFirst || isMovedSecond);
        }

        public bool StartMove(int firstCube, int secondCube, out int sum)
        {
            bool isMovedFirst = true;
            bool isMovedSecond = true;
            int firstSum;
            int secondSum;
            board = BackgammonBoard.Instance;
            if (firstCube != secondCube)
            {
                firstSum = OneMoveForStart(firstCube);
                if (firstSum == 0)
                {
                    isMovedFirst = false;
                }
                else if (IsInFinishMode())
                {
                    secondSum = OneMoveForFinish(secondCube);
                    sum = firstSum + secondSum;
                    return true;
                }
                secondSum = OneMoveForStart(secondCube);
                if (secondSum == 0)
                {
                    isMovedSecond = false;
                }
                if ((!isMovedFirst) && (secondSum != 0))
                {
                    sum = OneMoveForStart(firstCube);
                }
                sum = firstSum + secondSum;
            }
            else
            {
                sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (!IsInFinishMode())
                    {
                        sum += OneMoveForStart(firstCube);
                        if (sum == 0)
                        {
                            isMovedFirst = false;
                            isMovedSecond = false;
                            break;
                        }
                        else
                        {
                            isMovedFirst = true;
                        }
                    }
                    else
                    {
                        sum += OneMoveForFinish(firstCube);
                    }
                }
            }
            return (isMovedFirst || isMovedSecond);
        }
    }
}
