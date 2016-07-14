using System;
using System.Drawing;

namespace LogicBackgammon
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, Color color) : base(name, color)
        {}

        public override void DoMove()
        {
            throw new NotImplementedException();
        }
    }
}
