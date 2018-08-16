using System.Windows.Forms;
namespace NumberPuzzleApplication
{
    partial class PuzzleUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttons = new  System.Windows.Forms.Button[16];
            for (int i = 0; i < 16; i++)
            {
                buttons[i] = new System.Windows.Forms.Button();
                buttons[i].Click += new System.EventHandler(PuzzleUI_Click);
            }
            //this.button1 = new System.Windows.Forms.Button();
            //this.button2 = new System.Windows.Forms.Button();
            //this.button3 = new System.Windows.Forms.Button();
            //this.button4 = new System.Windows.Forms.Button();
            //this.button5 = new System.Windows.Forms.Button();
            //this.button6 = new System.Windows.Forms.Button();
            //this.button7 = new System.Windows.Forms.Button();
            //this.button8 = new System.Windows.Forms.Button();
            //this.button9 = new System.Windows.Forms.Button();
            //this.button10 = new System.Windows.Forms.Button();
            //this.button11 = new System.Windows.Forms.Button();
            //this.button12 = new System.Windows.Forms.Button();
            //this.button13 = new System.Windows.Forms.Button();
            //this.button14 = new System.Windows.Forms.Button();
            //this.button15 = new System.Windows.Forms.Button();
            //this.button16 = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buttons[0].Location = new System.Drawing.Point(40, 34);
            this.buttons[0].Name = "button1";
            this.buttons[0].Size = new System.Drawing.Size(75, 52);
            this.buttons[0].TabIndex = 0;
            //this.buttons[0].Text = "1";
            this.buttons[0].UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buttons[1].Location = new System.Drawing.Point(121, 34);
            this.buttons[1].Name = "button2";
            this.buttons[1].Size = new System.Drawing.Size(75, 52);
            this.buttons[1].TabIndex = 1;
            //this.buttons[1].Text = "2";
            this.buttons[1].UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.buttons[2].Location = new System.Drawing.Point(202, 34);
            this.buttons[2].Name = "button3";
            this.buttons[2].Size = new System.Drawing.Size(75, 52);
            this.buttons[2].TabIndex = 2;
           // this.buttons[2].Text = "3";
            this.buttons[2].UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.buttons[3].Location = new System.Drawing.Point(283, 34);
            this.buttons[3].Name = "button4";
            this.buttons[3].Size = new System.Drawing.Size(75, 52);
            this.buttons[3].TabIndex = 3;
            //this.buttons[3].Text = "4";
            this.buttons[3].UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.buttons[4].Location = new System.Drawing.Point(40, 92);
            this.buttons[4].Name = "button5";
            this.buttons[4].Size = new System.Drawing.Size(75, 52);
            this.buttons[4].TabIndex = 4;
            //this.buttons[4].Text = "5";
            this.buttons[4].UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.buttons[5].Location = new System.Drawing.Point(121, 92);
            this.buttons[5].Name = "button6";
            this.buttons[5].Size = new System.Drawing.Size(75, 52);
            this.buttons[5].TabIndex = 5;
            //this.buttons[5].Text = "6";
            this.buttons[5].UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.buttons[6].Location = new System.Drawing.Point(202, 92);
            this.buttons[6].Name = "button7";
            this.buttons[6].Size = new System.Drawing.Size(75, 52);
            this.buttons[6].TabIndex = 6;
            //this.buttons[6].Text = "7";
            this.buttons[6].UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.buttons[7].Location = new System.Drawing.Point(283, 92);
            this.buttons[7].Name = "button8";
            this.buttons[7].Size = new System.Drawing.Size(75, 52);
            this.buttons[7].TabIndex = 7;
            //this.buttons[7].Text = "8";
            this.buttons[7].UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.buttons[8].Location = new System.Drawing.Point(40, 150);
            this.buttons[8].Name = "button9";
            this.buttons[8].Size = new System.Drawing.Size(75, 52);
            this.buttons[8].TabIndex = 8;
            //this.buttons[8].Text = "9";
            this.buttons[8].UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.buttons[9].Location = new System.Drawing.Point(121, 150);
            this.buttons[9].Name = "button10";
            this.buttons[9].Size = new System.Drawing.Size(75, 52);
            this.buttons[9].TabIndex = 9;
            //this.buttons[9].Text = "10";
            this.buttons[9].UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.buttons[10].Location = new System.Drawing.Point(202, 150);
            this.buttons[10].Name = "button11";
            this.buttons[10].Size = new System.Drawing.Size(75, 52);
            this.buttons[10].TabIndex = 10;
            //this.buttons[10].Text = "11";
            this.buttons[10].UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.buttons[11].Location = new System.Drawing.Point(283, 150);
            this.buttons[11].Name = "button12";
            this.buttons[11].Size = new System.Drawing.Size(75, 52);
            this.buttons[11].TabIndex = 11;
            //this.buttons[11].Text = "12";
            this.buttons[11].UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.buttons[12].Location = new System.Drawing.Point(40, 208);
            this.buttons[12].Name = "button13";
            this.buttons[12].Size = new System.Drawing.Size(75, 52);
            this.buttons[12].TabIndex = 12;
           // this.buttons[12].Text = "13";
            this.buttons[12].UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.buttons[13].Location = new System.Drawing.Point(121, 208);
            this.buttons[13].Name = "button14";
            this.buttons[13].Size = new System.Drawing.Size(75, 52);
            this.buttons[13].TabIndex = 13;
            //this.buttons[13].Text = "14";
            this.buttons[13].UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.buttons[14].Location = new System.Drawing.Point(202, 208);
            this.buttons[14].Name = "button15";
            this.buttons[14].Size = new System.Drawing.Size(75, 52);
            this.buttons[14].TabIndex = 14;
            //this.buttons[14].Text = "15";
            this.buttons[14].UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.buttons[15].Location = new System.Drawing.Point(283, 208);
            this.buttons[15].Name = "button16";
            this.buttons[15].Size = new System.Drawing.Size(75, 52);
            this.buttons[15].TabIndex = 15;
            //this.buttons[15].Text = "16";
            this.buttons[15].UseVisualStyleBackColor = true;
            //this.buttons[15].Visible = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(40, 293);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(156, 31);
            this.btnShuffle.TabIndex = 16;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(202, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 31);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PuzzleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 413);



            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShuffle);
            for (int i = 0; i < 16; i++)
            {
                this.Controls.Add(this.buttons[i]);
            }
            //this.Controls.Add(this.button16);
            //this.Controls.Add(this.button15);
            //this.Controls.Add(this.button14);
            //this.Controls.Add(this.button13);
            //this.Controls.Add(this.button12);
            //this.Controls.Add(this.button11);
            //this.Controls.Add(this.button10);
            //this.Controls.Add(this.button9);
            //this.Controls.Add(this.button8);
            //this.Controls.Add(this.button7);
            //this.Controls.Add(this.button6);
            //this.Controls.Add(this.button5);
            //this.Controls.Add(this.button4);
            //this.Controls.Add(this.button3);
            //this.Controls.Add(this.button2);
            //this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "PuzzleUI";
            this.Text = "Number Puzzle Game";
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Button[] buttons;// = new  System.Windows.Forms.Button[16];
        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.Button button5;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.Button button7;
        //private System.Windows.Forms.Button button8;
        //private System.Windows.Forms.Button button9;
        //private System.Windows.Forms.Button button10;
        //private System.Windows.Forms.Button button11;
        //private System.Windows.Forms.Button button12;
        //private System.Windows.Forms.Button button13;
        //private System.Windows.Forms.Button button14;
        //private System.Windows.Forms.Button button15;
        //private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnExit;
    }
}

