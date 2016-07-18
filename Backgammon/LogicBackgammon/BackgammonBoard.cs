using System.Drawing;

namespace LogicBackgammon
{
    public class BackgammonBoard
    {
        private Triangle[] board;
        private OutBar outBar;

        private static BackgammonBoard instance;

        private BackgammonBoard()
        {
            outBar = new OutBar();
            board = new Triangle[24];
            InitBoard();
        }

        public static BackgammonBoard Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BackgammonBoard();
                }
                return instance;
            }
        }

        public Triangle[] Board
        {
            get { return board; }
        }

        public OutBar Out
        {
            get { return outBar; }
        }

        private void InitBoard()
        {
            board[0] = new Triangle(2, Color.Red);
            board[5] = new Triangle(5, Color.Blue);
            board[7] = new Triangle(3, Color.Blue);
            board[11] = new Triangle(5, Color.Red);
            board[12] = new Triangle(5, Color.Blue);
            board[16] = new Triangle(3, Color.Red);
            board[18] = new Triangle(5, Color.Red);
            board[23] = new Triangle(2, Color.Blue);
            board[6] = new Triangle();
            board[17] = new Triangle(); 
            InitTriangles(1, 5);
            InitTriangles(8, 11);
            InitTriangles(13, 16);
            InitTriangles(19, 23);
        }

        private void InitTriangles(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                board[i] = new Triangle();
            }
        }
    }
}
