using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    public class Cubes
    {
        private int firstNumber;
        private int secondNumber;

        public int FirstCube
        {
            get { return firstNumber; }
        }

        public int SecondCube
        {
            get { return secondNumber; }
        }

        public void RollCube()
        {
            Random random = new Random();
            firstNumber = random.Next(1, 7);
            secondNumber = random.Next(1, 7);
        }
    }
}
