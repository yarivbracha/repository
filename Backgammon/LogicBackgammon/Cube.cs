using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class Cube
    {
        private int number;

        public int Number
        {
            get { return number; }
        }

        public int RollCube()
        {
            Random random = new Random();
            number = random.Next(1, 7);
            return number;
        }
    }
}
