using System;
using System.Drawing;


namespace LogicBackgammon
{
    public class OutBar
    {
        private int blueSum;
        private int redSum;
        private int newUpdateblue;
        private int newUpdateRed;
        private bool isNewBlueInBar;
        private bool isNewRedInbBar;

        public OutBar()
        {
            this.blueSum = 0;
            this.redSum = 0;
        }

        public int BlueSum
        {
            get { return this.blueSum; }
        }

        public int RedSum
        {
            get { return this.redSum; }
        }

        public int UpdateRed
        {
            get { return newUpdateRed; }
        }

        public int UpdateBlue
        {
            get { return newUpdateblue; }
        }

        public bool IsNewBlue
        {
            get { return isNewBlueInBar; }
        }

        public bool IsNewRed
        {
            get { return isNewRedInbBar; }
        }

        public void ResetNewBool(Color color)
        {
            if(color == Color.Red)
            {
                isNewRedInbBar = false;
                newUpdateRed = 0;
            }
            else
            {
                isNewBlueInBar = false;
                newUpdateblue = 0;
            }
        }

        public void Add(Color color, int place)
        {
            if (color == Color.Blue)
            {
                newUpdateblue += -1 * place;
                isNewBlueInBar = true;
                this.blueSum++;
            }
            else
            {
                newUpdateRed += -1 * place;
                isNewRedInbBar = true;
                this.redSum++;
            }
        }

        public void Reduce(Color color)
        {
            if (color == Color.Blue)
            {
                if (blueSum >= 1)
                {
                    this.blueSum--;
                }
                else
                {
                    throw new Exception("You can't remove more blue from bar because there is no more blue in bar!");
                }
            }
            else
            {
                if (redSum >= 1)
                {
                    this.redSum--;
                }
                else
                {
                    throw new Exception("You can't remove more red from bar because there is no more red in bar!");
                }
            }
        }

    }
}
