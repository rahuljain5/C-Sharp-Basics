using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EightQueensGame
{
	public partial class ChessBoard : Form
	{
		Label[] labels = new Label[64];
		GameStrategy game = new GameStrategy();
		int numOfQueens = 0;

		public ChessBoard()
		{
			InitializeComponent();
			ChessBoardInit();
		}

		private void ChessBoardInit()
		{
			// Create the board
			int id;
			bool isCellWhite = true;
			Color color = Color.White;
			for (int i = 0; i < 64; ++i)
			{
				labels[i] = new Label();
				labels[i].AutoSize = true;
				if (isCellWhite)
				{
					color = Color.White;
				}
				else
				{
					color = Color.Black;
				}
				isCellWhite = !isCellWhite;
				labels[i].BackColor = color;
				labels[i].Dock = System.Windows.Forms.DockStyle.Fill;
				labels[i].Location = new System.Drawing.Point(3, 0);
				labels[i].Name = "label" + Convert.ToString(i);
				labels[i].Size = new System.Drawing.Size(69, 58);
				labels[i].TabIndex = 0;
				labels[i].Text = "";
				labels[i].Margin = new System.Windows.Forms.Padding(0);
				tableLayoutPanel1.Controls.Add(labels[i]);
				labels[i].Click += new EventHandler(Cell_Click);
				id = i + 1;
				labels[i].Tag = (object)id;
				if ((i+1)%8 == 0)
					isCellWhite = !isCellWhite;
			}
		}

		void Cell_Click(object sender, EventArgs e)
		{
			Label cell = (Label)sender;
			if (cell.Image != null)
			{
				cell.Image = null;
				if (numOfQueens-- < 0)
					numOfQueens = 0;
				game.UnplaceQueen((int)cell.Tag);
				return;
			}

			try 
			{
				if(game.isValidPostion((int)cell.Tag))
				{
					InsertQueen(cell);
					if(numOfQueens==8)
					{
						MessageBox.Show("Success! You are the winner!");
					}
				}
				else
				{
					Color temp = cell.BackColor;
					for (int i = 0; i < 3; ++i)
					{
						cell.BackColor = Color.Red;
						cell.Refresh();
						System.Threading.Thread.Sleep(50);
						cell.BackColor = Color.Yellow;
						cell.Refresh();
						System.Threading.Thread.Sleep(50);
					}
					cell.BackColor = temp;
				}
		
			}
			catch (GameOverException) 
			{
				MessageBox.Show("WINNER!!!!!!!!!!!!");
			}			
		}

		private void InsertQueen(Label cell)
		{
			Image img = null;
			if (cell.BackColor == Color.White)
				img = Image.FromFile("D:\\TRAINING\\PRATIAN\\CONTENT\\DOTNET\\PROJECTS\\EightQueensGame\\VS2008\\EightQueensApplication\\EightQueensGame\\queens-crown-white.jpg");
			else
                img = Image.FromFile("D:\\TRAINING\\PRATIAN\\CONTENT\\DOTNET\\PROJECTS\\EightQueensGame\\VS2008\\EightQueensApplication\\EightQueensGame\\queens-crown-black.jpg");
			cell.Image = img;
			numOfQueens++;
		}
	}
}
