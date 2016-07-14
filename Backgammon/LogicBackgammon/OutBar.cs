using System.Drawing;


namespace LogicBackgammon
{
    public class OutBar
    {
        private int blueSum;
        private int redSum;

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

        public void Add(Color color)
        {
            if (color == Color.Blue)
            {
                this.blueSum++;
            }
            else
            {
                this.redSum++;
            }
        }

        public void Reduce(Color color)
        {
            if (color == Color.Blue)
            {
                this.blueSum--;
            }
            else
            {
                this.redSum--;
            }
        }

    }
}
