using System.Drawing;


namespace LogicBackgammon
{
    public class OutBar
    {
        private int whiteSum;
        private int blackSum;

        public OutBar()
        {
            this.whiteSum = 0;
            this.blackSum = 0;
        }

        public int WhiteSum
        {
            get { return this.whiteSum; }
        }

        public int BlackSum
        {
            get { return this.blackSum; }
        }

        public void Add(Color color)
        {
            if (color == Color.White)
            {
                this.whiteSum++;
            }
            else
            {
                this.blackSum++;
            }
        }

        public void Reduce(Color color)
        {
            if (color == Color.White)
            {
                this.whiteSum--;
            }
            else
            {
                this.blackSum--;
            }
        }

    }
}
