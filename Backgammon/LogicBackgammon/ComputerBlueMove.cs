using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class ComputerBlueMove : IComputerMove
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
                for(int i = 0; i < 4; i++)
                {
                    sum += OneMoveForFinish(firstCube);
                    if(sum == 0)
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
            if (board.Out.BlueSum > 0)
            {
                isInFinish = false;
            }
            else
            {
                for (int i = 23; i > 5; i--)
                {
                    if (board.Board[i].CheckersColor == Color.Blue)
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
            for (int i = 5; i > -1; i--)
            {
                if(board.Board[i].CheckersColor == Color.Blue)
                {
                    if(i - cube >= 0)
                    {
                        if((board.Board[i-cube].CheckersColor == Color.Blue) || (board.Board[i-cube].CheckersColor == Color.Transparent))
                        {
                            sum = cube;
                            board.Board[i].RemoveChecker();
                            board.Board[i - cube].CheckersColor = Color.Blue;
                            board.Board[i - cube].AddChecker();
                            break;
                        }
                        else if (board.Board[i - cube].Checkers == 1)
                        {
                            board.Board[i].RemoveChecker();
                            board.Board[i - cube].RemoveChecker();
                            board.Out.Add(Color.Red, (i - cube));
                            board.Board[i - cube].CheckersColor = Color.Blue;
                            board.Board[i - cube].AddChecker();
                            sum = cube;
                            break;
                        }
                    }
                    else
                    {
                        board.Board[i].RemoveChecker();
                        sum = i + 1;
                        break;
                    }
                }
            }
            return sum;
                
        }


        public int OneMoveForOut(int cube)
        {
            int sum = 0;
            if ((board.Board[24 - cube].CheckersColor == Color.Blue) || (board.Board[24 - cube].CheckersColor == Color.Transparent))
            {
                sum = cube;
                board.Out.Reduce(Color.Blue);
                board.Board[24 - cube].CheckersColor = Color.Blue;
                board.Board[24 - cube].AddChecker();
            }
            else if (board.Board[24 - cube].Checkers == 1)
            {
                sum = cube;
                board.Out.Reduce(Color.Blue);
                board.Board[24 - cube].RemoveChecker();
                board.Board[24 - cube].CheckersColor = Color.Blue;
                board.Board[24 - cube].AddChecker();
                board.Out.Add(Color.Red, 24 - cube);
            }
            return sum;
        }

        public int OneMoveForStart(int cube)
        {
            int sum = 0;
            for (int i = 23; i > -1; i--)
            {
                if (i - cube > -1)
                {
                    if (board.Board[i].CheckersColor == Color.Blue)
                    {
                        if ((board.Board[i - cube].CheckersColor == Color.Blue) || (board.Board[i - cube].CheckersColor == Color.Transparent))
                        {
                            board.Board[i].RemoveChecker();
                            board.Board[i - cube].CheckersColor = Color.Blue;
                            board.Board[i - cube].AddChecker();
                            sum = cube;
                            break;
                        }
                        else if (board.Board[i - cube].Checkers == 1)
                        {
                            board.Board[i].RemoveChecker();
                            board.Out.Add(Color.Red, 24 - (i - cube));
                            board.Board[i - cube].RemoveChecker();
                            board.Board[i - cube].CheckersColor = Color.Blue;
                            board.Board[i - cube].AddChecker();
                            sum = cube;
                            break;
                        }
                    }
                }
                else
                {
                    break;
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
                else if (board.Out.BlueSum == 0)
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
                    if (board.Out.BlueSum == 0)
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
                    if (board.Out.BlueSum > 0)
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
                for(int i = 0; i < 4; i++)
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
