using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    interface IHumenMove : IMove
    {
         bool IsInBiggerTriangle(int triangle, int steps);
    }
}
