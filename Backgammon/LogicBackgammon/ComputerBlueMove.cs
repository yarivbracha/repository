using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class ComputerBlueMove : IComputerMove
    {
        public  bool FinishMove(int from, int steps, out int sum)
        {
            throw new NotImplementedException();
        }

        public bool IsInBiggerTriangle(int triangle)
        {
            throw new NotImplementedException();
        }

        public bool OutMove(int from, int steps, out int sum)
        {
            throw new NotImplementedException();
        }

        public bool StartMove(int firstCube, int secondCube, out int sum)
        {
            bool isMoved = false;
            sum = 0;
            return isMoved;
        }
    }
}
