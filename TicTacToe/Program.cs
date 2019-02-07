using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome :D let's play a Tictactoe game!!!!!");
            string[,] TicTacToeBoard = new string[3, 3];
            TicTacToeGameEngine tictacToeGameEngine = new TicTacToeGameEngine();
            tictacToeGameEngine.SatartGame(TicTacToeBoard);
            Console.WriteLine("Thank you for the game ;)");
            Console.ReadKey();
        }

        
    }
}
