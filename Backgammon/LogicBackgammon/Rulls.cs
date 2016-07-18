using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    public abstract class Rulls
    {
        public bool IsValidMoves(int cube, Player.GameStatus status)
        {
            bool isValid;
            if (status == Player.GameStatus.Start)
            {
                isValid = IsValidMoveForStart(cube);
            }
            else if (status == Player.GameStatus.Out)
            {
                isValid = IsValidMoveForOut(cube);
            }
            else
            {
                isValid = IsValidMoveForFinish(cube);
            }
            return isValid;
        }

        internal abstract bool IsValidMoveForFinish(int cube);
        internal abstract bool IsValidMoveForOut(int cube);
        internal abstract bool IsValidMoveForStart(int cube);
    }
}