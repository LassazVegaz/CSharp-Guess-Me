namespace GuessMe
{
    partial class MainWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.label1 = new System.Windows.Forms.Label();
            this.CMessage_LBL = new System.Windows.Forms.Label();
            this.CHeading_LBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRemainingGuesses_LBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRestartGame_BTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CComputerGuess_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPlayerInput_TXT = new Rater.NumericalTextbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Guess";
            // 
            // CMessage_LBL
            // 
            this.CMessage_LBL.BackColor = System.Drawing.Color.Black;
            this.CMessage_LBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMessage_LBL.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMessage_LBL.ForeColor = System.Drawing.Color.White;
            this.CMessage_LBL.Location = new System.Drawing.Point(0, 0);
            this.CMessage_LBL.Name = "CMessage_LBL";
            this.CMessage_LBL.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.CMessage_LBL.Size = new System.Drawing.Size(529, 40);
            this.CMessage_LBL.TabIndex = 2;
            // 
            // CHeading_LBL
            // 
            this.CHeading_LBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.CHeading_LBL.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHeading_LBL.Location = new System.Drawing.Point(0, 0);
            this.CHeading_LBL.Name = "CHeading_LBL";
            this.CHeading_LBL.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.CHeading_LBL.Size = new System.Drawing.Size(663, 47);
            this.CHeading_LBL.TabIndex = 3;
            this.CHeading_LBL.Text = "Guess a Number Between 0 and 101";
            this.CHeading_LBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.CRemainingGuesses_LBL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 50);
            this.panel1.TabIndex = 4;
            // 
            // CRemainingGuesses_LBL
            // 
            this.CRemainingGuesses_LBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.CRemainingGuesses_LBL.Location = new System.Drawing.Point(139, 0);
            this.CRemainingGuesses_LBL.Name = "CRemainingGuesses_LBL";
            this.CRemainingGuesses_LBL.Size = new System.Drawing.Size(42, 50);
            this.CRemainingGuesses_LBL.TabIndex = 2;
            this.CRemainingGuesses_LBL.Text = "6";
            this.CRemainingGuesses_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remaining Guesses :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CRestartGame_BTN
            // 
            this.CRestartGame_BTN.BackColor = System.Drawing.Color.Black;
            this.CRestartGame_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CRestartGame_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CRestartGame_BTN.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRestartGame_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CRestartGame_BTN.Location = new System.Drawing.Point(529, 0);
            this.CRestartGame_BTN.Name = "CRestartGame_BTN";
            this.CRestartGame_BTN.Size = new System.Drawing.Size(134, 40);
            this.CRestartGame_BTN.TabIndex = 5;
            this.CRestartGame_BTN.Text = "Restart Game";
            this.CRestartGame_BTN.UseVisualStyleBackColor = false;
            this.CRestartGame_BTN.Click += new System.EventHandler(this.CRestartGame_BTN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CMessage_LBL);
            this.panel2.Controls.Add(this.CRestartGame_BTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 40);
            this.panel2.TabIndex = 6;
            // 
            // CComputerGuess_TXT
            // 
            this.CComputerGuess_TXT.AcceptsReturn = true;
            this.CComputerGuess_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CComputerGuess_TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CComputerGuess_TXT.Location = new System.Drawing.Point(494, 94);
            this.CComputerGuess_TXT.Name = "CComputerGuess_TXT";
            this.CComputerGuess_TXT.ReadOnly = true;
            this.CComputerGuess_TXT.Size = new System.Drawing.Size(157, 27);
            this.CComputerGuess_TXT.TabIndex = 8;
            this.CComputerGuess_TXT.Text = "50";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer Guess";
            // 
            // CPlayerInput_TXT
            // 
            this.CPlayerInput_TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.CPlayerInput_TXT.Location = new System.Drawing.Point(123, 94);
            this.CPlayerInput_TXT.Name = "CPlayerInput_TXT";
            this.CPlayerInput_TXT.Size = new System.Drawing.Size(157, 27);
            this.CPlayerInput_TXT.TabIndex = 9;
            this.CPlayerInput_TXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CPlayerInput_TXT_KeyUp);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(663, 312);
            this.Controls.Add(this.CPlayerInput_TXT);
            this.Controls.Add(this.CComputerGuess_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CHeading_LBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "Guess Me";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CMessage_LBL;
        private System.Windows.Forms.Label CHeading_LBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CRemainingGuesses_LBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CRestartGame_BTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CComputerGuess_TXT;
        private System.Windows.Forms.Label label3;
        private Rater.NumericalTextbox CPlayerInput_TXT;
    }
}

