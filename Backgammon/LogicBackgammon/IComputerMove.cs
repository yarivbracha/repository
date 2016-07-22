using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
     interface  IComputerMove : IMove
    {
        int OneMoveForStart(int cube);
        int OneMoveForOut(int cube);
        int OneMoveForFinish(int cube);
        bool IsInFinishMode();
    }
}
