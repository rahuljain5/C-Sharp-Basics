using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberPuzzleApplication
{
    public class PuzzleControl
    {
        #region Fields of the class
        Random rnd = new Random();
        #endregion

        /// <summary>
        /// Method to generate a random number
        /// </summary>
        /// <returns></returns>
        private int GetRandomNumber()
        {
            return rnd.Next();
        }

        /// <summary>
        /// Method to change the value of the button when clicked
        /// </summary>
        /// <param name="emptyButton"></param>
        /// <param name="clicked"></param>
        private void SwapButton(Button emptyButton, Button clicked)
        {
            emptyButton.Text = clicked.Text;
            clicked.Text = "";
        }

        /// <summary>
        /// Method to get an array of integers for the buttons on the grid
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        private int[] GetIntegerArrayOfButtonIds(Button[] buttons)
        {
            int[] buttonIds = new int[16];
            int id;
            for (int i = 0; i < 16; ++i)
            {
                if (int.TryParse(buttons[i].Text, out id))
                    buttonIds[i] = id;
                else
                    buttonIds[i] = 16;
            }
            return buttonIds;
        }


        //----------------------Public Methods to be filled by the participant------------


        /// <summary>
        /// Method to get random numbers to be displayed on the grid
        /// </summary>
        /// <returns></returns>
        public int[] GetRandomNumbersForGrid()
        {
            int[] arr = new int[16]; 

            int temp = 0;
            for (int i = 0; i < 15; i++)
            {
                bool flag = false;
                while (!flag)
                {
                    temp = GetRandomNumber();
                    if (temp % 16 != 0)
                    {
                        if ((!arr.Contains(temp % 16)))
                        {
                            arr[i + 1] = temp % 16;
                            flag = true;
                        }
                    }
                }
            }
            return arr;
        }

    /// <summary>
    /// Method to swap the buttons when a number is clicked on the grid
    /// </summary>
    /// <param name="emptyCellId"></param>
    /// <param name="buttonClicked"></param>
    /// <param name="buttons"></param>
    /// <returns></returns>
    public int HandleButtonClicked(int emptyCellId, Button buttonClicked, Button[] buttons)
    {
            //Logic to be filled by the participant
            int clickedButton;
            clickedButton = Array.IndexOf(buttons, buttonClicked);
            if(emptyCellId > 3 || emptyCellId <12) { 
            if(emptyCellId + 1 % 4 == 0 || emptyCellId < 12)
            {
                if(clickedButton == (emptyCellId + 4) || clickedButton == (emptyCellId - 1))
                {
                    SwapButton(buttons[emptyCellId], buttonClicked);
                    emptyCellId = clickedButton;
                }
            }
            else if(emptyCellId+1 % 4 == 1)
            {
                if (clickedButton == (emptyCellId + 4) || clickedButton == (emptyCellId + 1))
                {
                    SwapButton(buttons[emptyCellId], buttonClicked);
                    emptyCellId = clickedButton;
                }
            }
            else
            {
                if(clickedButton == (emptyCellId - 4) || clickedButton == (emptyCellId + 1) || clickedButton == (emptyCellId - 1))
                {
                    SwapButton(buttons[emptyCellId], buttonClicked);
                    emptyCellId = clickedButton;
                }
            }
            }
            if (emptyCellId >= 12 || emptyCellId < 12)
            {
                if (emptyCellId + 1 % 4 == 0)
                {
                    if (clickedButton == (emptyCellId - 4) || clickedButton == (emptyCellId - 1))
                    {
                        SwapButton(buttons[emptyCellId], buttonClicked);
                        emptyCellId = clickedButton;
                    }
                }
                else if (emptyCellId + 1 % 4 == 1)
                {
                    if (clickedButton == (emptyCellId - 4) || clickedButton == (emptyCellId + 1))
                    {
                        SwapButton(buttons[emptyCellId], buttonClicked);
                        emptyCellId = clickedButton;
                    }
                }
                else
                {
                    if (clickedButton == (emptyCellId - 4) || clickedButton == (emptyCellId + 1) || clickedButton == (emptyCellId - 1))
                    {
                        SwapButton(buttons[emptyCellId], buttonClicked);
                        emptyCellId = clickedButton;
                    }
                }
            }

            return emptyCellId;
    }

    /// <summary>
    /// Method to check for a winner of the game
    /// </summary>
    /// <param name="buttons"></param>
    /// <returns></returns>
    public bool CheckForWinner(Button[] buttons)
    {
        bool winner = true;
            int[] Buttonids = GetIntegerArrayOfButtonIds(buttons);
            for(int i=1; i<=15; i++)
            {
                if (Buttonids[i - 1] != i) winner = false; 
            }
                //Logic to be filled by the participant
                return winner;
    }
}
}
