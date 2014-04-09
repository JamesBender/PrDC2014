using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class GameEngine
    {
        public string GetGameWinner(string[,] _board)
        {
            return _board[0,0];
        }
    }
}
