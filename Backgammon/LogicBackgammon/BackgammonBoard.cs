using System.Drawing;

namespace LogicBackgammon
{
    public class BackgammonBoard
    {
        private Triangle[] board;
        private OutBar outBar;

        public BackgammonBoard()
        {
            outBar = new OutBar();
            board = new Triangle[24];
            InitBoard();
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
            board[0] = new Triangle(2, Color.Black);
            board[5] = new Triangle(5, Color.White);
            board[7] = new Triangle(3, Color.White);
            board[11] = new Triangle(5, Color.Black);
            board[12] = new Triangle(5, Color.White);
            board[16] = new Triangle(3, Color.Black);
            board[18] = new Triangle(5, Color.Black);
            board[23] = new Triangle(2, Color.White);
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
