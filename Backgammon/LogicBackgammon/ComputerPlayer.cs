using System;
using System.Drawing;

namespace LogicBackgammon
{
    public class ComputerPlayer : Player
    {
        IComputerMove move;
        public ComputerPlayer(string name, Color color) : base(name, color)
        {
            if(color == Color.Blue)
            {
                move = new ComputerBlueMove();
            }
            else
            {
                move = new ComputerRedMove();
            }
        }

        public override bool DoMove(int firstCube, int secondCube)
        {
            int sum;
            bool isMoved = false;
            if (this.Status == GameStatus.Start)
            {
                if ((!Rull.IsValidMoveForStart(firstCube)) && (!Rull.IsValidMoveForStart(secondCube)))
                {
                    isMoved = false;
                    sum = 0;
                }
                else
                {
                    isMoved = move.StartMove(firstCube, secondCube, out sum);
                }
            }
            else if (this.Status == GameStatus.Out)
            {
                if ((!Rull.IsValidMoveForOut(firstCube)) && (!Rull.IsValidMoveForOut(secondCube)))
                {
                    isMoved = false;
                    sum = 0;
                }
                else
                {
                    isMoved = move.OutMove(firstCube, secondCube, out sum);
                }
            }
            else
            {
                if ((!Rull.IsValidMoveForFinish(firstCube)) && (!Rull.IsValidMoveForFinish(secondCube)))
                {
                    isMoved = false;
                    sum = 0;
                }
                else
                {
                    isMoved = move.FinishMove(firstCube, secondCube, out sum);
                }
            }
            Status = Rull.CheckStatus();
            UpdateSum(sum);
            return isMoved;
        }
    }
}
