using System;
using System.Drawing;

namespace LogicBackgammon
{
    public  class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, Color color) : base(name, color)
        {}

        public override bool DoMove(int panel, int steps)
        {
            throw new NotImplementedException();
        }
    }
}
