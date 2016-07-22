using System;
using System.Collections.Generic;
using System.Drawing;

namespace LogicBackgammon
{
    public class BackgammonManager
    {
        public enum GameMode
        {
            Computer,
            Friend,
            TwoComputers,
        };

        private Player firstPlayer;
        private Player secondPlayer;
        private Player currentPlayer;
        private Cubes cubes;
        private GameMode mode;

        public BackgammonManager(GameMode gameMode, string firstPlayerName, string secondPlayerName)
        {
            this.mode = gameMode;
            InitPlayers(gameMode, firstPlayerName, secondPlayerName);
            cubes = new Cubes();
        }

        public Player FirstPlayer
        {
            get { return firstPlayer; }
        }

        public Player SecondPlayer
        {
            get { return secondPlayer; }
        }

        public Player CurrentPlayer
        {
            get { return currentPlayer; }
        }

        public Cubes GameCubes
        {
            get { return cubes; }
        }

        private void InitPlayers(GameMode gameMode, string firstPlayerName, string secondPlayerName)
        {
            if(gameMode == GameMode.Friend)
            {
                firstPlayer = new HumenPlayer(firstPlayerName, Color.Blue);
                secondPlayer = new HumenPlayer(secondPlayerName, Color.Red);
            }
            else if(gameMode == GameMode.Computer)
            {
                firstPlayer = new HumenPlayer(firstPlayerName, Color.Blue);
                secondPlayer = new ComputerPlayer("Computer", Color.Red);
            }
            else
            {
                firstPlayer = new ComputerPlayer("First Computer", Color.Blue);
                secondPlayer = new ComputerPlayer("Second Computer", Color.Red);
            }
        }

        public string StartGame()
        {
            cubes.RollCube();
            while(cubes.FirstCube == cubes.SecondCube)
            {
                cubes.RollCube();
            }
            if(cubes.FirstCube > cubes.SecondCube)
            {
                currentPlayer = firstPlayer;
            }
            else
            {
                currentPlayer = secondPlayer;
            }
            return CurrentPlayer.Name;
        }

        public bool PlayComputerMove()
        {
            return currentPlayer.DoMove(cubes.FirstCube,cubes.SecondCube);
        }

        public void SwitchPlayer()
        {
            if(CurrentPlayer == firstPlayer)
            {
                currentPlayer = secondPlayer;
            }
            else
            {
                currentPlayer = firstPlayer;
            }
        }

        //public bool IsWinner(Color color)
        //{
        //    bool isWinner = true;
        //    BackgammonBoard board = BackgammonBoard.Instance;
        //    if(color == Color.Red)
        //    {
        //        if(board.Out.RedSum > 0)
        //        {
        //            isWinner = false;
        //        }
        //        else if(board.Out.BlueSum > 0)
        //        {
        //            isWinner = false;
        //        }
        //    }
        //    else
        //    {
        //        for(int i = 0; i < 24; i++)
        //        {
        //            if(board.Board[i].CheckersColor == Color.Red)
        //            {
        //                isWinner = false;
        //                break;
        //            }
        //        }
        //    }
        //    return isWinner;
        //}

        public bool IsWinner()
        {
            if (CurrentPlayer.Sum < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
