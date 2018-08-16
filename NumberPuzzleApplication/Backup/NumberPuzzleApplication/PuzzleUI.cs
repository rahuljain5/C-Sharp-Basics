using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberPuzzleApplication
{
    public partial class PuzzleUI : Form
    {
        #region Methods which implement UI logic and also calls the PuzzleControl methods
        /// <summary>
        /// Fields of the class
        /// </summary>
        private PuzzleControl control;
        private int emptyCellId;
        private Button emptyButton;

        /// <summary>
        /// Constructor - Called when object is instantiated
        /// </summary>
        public PuzzleUI()
        {
            InitializeComponent();
            control = new PuzzleControl();
            ShuffleButtons();
        }

        /// <summary>
        /// Method to exit the application when Exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Would you like to exit game?","Application Exit",MessageBoxButtons.YesNo))==DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Method to shuffle the grid when the shuffle button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ShuffleButtons();
        }

        /// <summary>
        /// Method to swap the numbers once clicked on a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PuzzleUI_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = sender as Button;
            
            buttons[emptyCellId].Visible = true;
            emptyCellId = control.HandleButtonClicked(emptyCellId, clickedButton, buttons);
            buttons[emptyCellId].Visible = false;

            if (control.CheckForWinner(buttons))
            {
                MessageBox.Show("Congratulations...!!!");
            }
        }

        /// <summary>
        /// Method to shuffle the buttons
        /// </summary>
        private void ShuffleButtons()
        {
            int[] arr = control.GetRandomNumbersForGrid();

            for (int i = 0; i < 16; ++i)
            {
                buttons[i].Text = arr[i].ToString();

                if (buttons[i].Text == "16")
                {
                    buttons[i].Visible = false;
                    emptyCellId=i;
    
                    emptyButton = buttons[i];
                }
                else
                {
                    buttons[i].Visible = true;
                }
            }


        }
        
        #endregion
    }
}
