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

        public override bool DoMove(int panel, int steps)
        {
            throw new NotImplementedException();
        }
    }
}
