using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EightQueensGame
{
	class GameStrategy
	{
        /// <summary>
        /// Counter that keeps track of the number of Queens
        /// placed on the chess board
        /// </summary>
		private int numQueens = 0;

        /// <summary>
        /// The 8x8 2-D array that corresponds to the positions
        /// on the chess board
        /// </summary>
		private bool[,] placedQueens = new bool[8, 8];
        
        /// <summary>
        /// Method to compute and return the Column number
        /// as 0 through 7, given CellId
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
		private int getColumn(int cellId)
		{
			
			/*
                Logic to be written ....
             */
            return 0; // Just for the heck of it
		}

		
        /// <summary>
        /// Method to compute and return the Row number
        /// as 0 through 7, given CellId
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
        private int getRow(int cellId)
		{
			/*
                Logic to be written ....
             */
			return 0;// Just for the heck of it
		}

        /// <summary>
        /// Method to check if the Cell is a valid position 
        /// for placing the Queen
        /// </summary>
        /// <param name="cellId"></param>
        /// <returns></returns>
		public bool isValidPostion(int cellId)
		{
			bool isValid = true;

			if (numQueens == 8) throw new GameOverException();

			/*
             * 
             * Logic to be written to validate if there are
             * any Queens already present in the path of
             * the current cell
             * 
             * */

			return isValid;
		}

       
        /// <summary>
        /// Method to remove a Queen from the cell
        /// </summary>
        /// <param name="cellId"></param>
        public void UnplaceQueen(int cellId)
        {
            /*
             
             Logic to be written
             */

        }

        // Other helper methods, need not be touched
zz
		public bool check(int row, int col, int index, int condn, bool rows, bool isValid)
		{
			for (int j = index; j < condn && isValid; j++)
			{
				if (rows)
					isValid = !placedQueens[j, col];
				else
					isValid = !placedQueens[row, j];
			}
			return isValid;
		}

		public static void gameTest()
		{
			GameStrategy game = new GameStrategy();
			int[] cellId = { 5, 11, 17, 31, 34, 48, 54, 60, 52 };
			for (int i = 0; i < cellId.Length; i++)
			{
				try
				{
					MessageBox.Show(game.isValidPostion(5).ToString());
				}
				catch (GameOverException e)
				{
					MessageBox.Show("Game Over!!");
				}
			}
		}
	}
}

