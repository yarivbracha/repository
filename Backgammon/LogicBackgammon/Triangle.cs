﻿using System;
using System.Drawing;

namespace LogicBackgammon
{
    public class Triangle
    {
        private int sum;
        private Color color;

        public Triangle()
        {
            sum = 0;
            color = Color.Transparent;
        }

        public Triangle(int sumCheckers, Color CheckersColor)
        {
            this.sum = sumCheckers;
            this.CheckersColor = CheckersColor;
        }

        public int Checkers
        {
            get
            {
                return sum;
            }
        }

        public Color CheckersColor
        {
            get { return color; }
            set { this.color = value; }
        }
        
        public void AddChecker()
        {
            sum++;
        }

        public void RemoveChecker()
        {
            if (sum > 0)
            {
                sum--;
                if(sum == 0)
                {
                    CheckersColor = Color.Transparent;
                }
            }
            else
            {
                throw new Exception("There is no checkers in the triangle!");
            }
        }
    }
}
