using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    public interface IMove
    {
        bool StartMove(int from, int steps, out int sum);
        bool OutMove(int from, int steps, out int sum);
        bool FinishMove(int from, int steps, out int sum); 
    }
}
