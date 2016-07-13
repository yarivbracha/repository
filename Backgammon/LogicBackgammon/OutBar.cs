using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    class OutBar
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

        public void AddWhite()
        {
            this.whiteSum++;
        }

        public void AddBlack()
        {
            this.blackSum++;
        }

        public void ReduceWhite()
        {
            this.whiteSum--;
        }

        public void ReduceBlack()
        {
            this.blackSum--;

        }
    }
}
