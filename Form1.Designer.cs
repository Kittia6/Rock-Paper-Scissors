namespace Rock_Paper_Scissors
{
    partial class PaperScissorsRock
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblOpponentWins = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.lblPlayerWinsNum = new System.Windows.Forms.Label();
            this.lblTieNum = new System.Windows.Forms.Label();
            this.lblOpponentWinsNum = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(223, 92);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(89, 32);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(724, 92);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(137, 32);
            this.lblOpponent.TabIndex = 3;
            this.lblOpponent.Text = "Opponent";
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.Location = new System.Drawing.Point(157, 410);
            this.grpPlayerChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPlayerChoice.Size = new System.Drawing.Size(200, 121);
            this.grpPlayerChoice.TabIndex = 4;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Players Choice";
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.Location = new System.Drawing.Point(53, 86);
            this.radScissors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(84, 26);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.Location = new System.Drawing.Point(53, 54);
            this.radPaper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(72, 26);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.Location = new System.Drawing.Point(53, 22);
            this.radRock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(66, 26);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources.tv_colour_bars;
            this.imgPlayer.Location = new System.Drawing.Point(145, 150);
            this.imgPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(243, 225);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Rock_Paper_Scissors.Properties.Resources.tv_colour_bars;
            this.imgOpponent.Location = new System.Drawing.Point(671, 150);
            this.imgOpponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(243, 225);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Maroon;
            this.btnPlay.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(457, 449);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(153, 73);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResult.Location = new System.Drawing.Point(417, 92);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(236, 46);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.ForeColor = System.Drawing.Color.Green;
            this.lblPlayerWins.Location = new System.Drawing.Point(39, 23);
            this.lblPlayerWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(65, 17);
            this.lblPlayerWins.TabIndex = 7;
            this.lblPlayerWins.Text = "Wins";
            // 
            // lblOpponentWins
            // 
            this.lblOpponentWins.AutoSize = true;
            this.lblOpponentWins.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentWins.ForeColor = System.Drawing.Color.Firebrick;
            this.lblOpponentWins.Location = new System.Drawing.Point(943, 23);
            this.lblOpponentWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpponentWins.Name = "lblOpponentWins";
            this.lblOpponentWins.Size = new System.Drawing.Size(65, 17);
            this.lblOpponentWins.TabIndex = 8;
            this.lblOpponentWins.Text = "Wins";
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.lblTie.Location = new System.Drawing.Point(507, 23);
            this.lblTie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(57, 17);
            this.lblTie.TabIndex = 9;
            this.lblTie.Text = "Ties";
            // 
            // lblPlayerWinsNum
            // 
            this.lblPlayerWinsNum.AutoSize = true;
            this.lblPlayerWinsNum.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinsNum.ForeColor = System.Drawing.Color.Green;
            this.lblPlayerWinsNum.Location = new System.Drawing.Point(60, 52);
            this.lblPlayerWinsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerWinsNum.Name = "lblPlayerWinsNum";
            this.lblPlayerWinsNum.Size = new System.Drawing.Size(19, 17);
            this.lblPlayerWinsNum.TabIndex = 10;
            this.lblPlayerWinsNum.Text = "0";
            // 
            // lblTieNum
            // 
            this.lblTieNum.AutoSize = true;
            this.lblTieNum.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.lblTieNum.Location = new System.Drawing.Point(527, 52);
            this.lblTieNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieNum.Name = "lblTieNum";
            this.lblTieNum.Size = new System.Drawing.Size(19, 17);
            this.lblTieNum.TabIndex = 11;
            this.lblTieNum.Text = "0";
            // 
            // lblOpponentWinsNum
            // 
            this.lblOpponentWinsNum.AutoSize = true;
            this.lblOpponentWinsNum.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentWinsNum.ForeColor = System.Drawing.Color.Firebrick;
            this.lblOpponentWinsNum.Location = new System.Drawing.Point(967, 52);
            this.lblOpponentWinsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpponentWinsNum.Name = "lblOpponentWinsNum";
            this.lblOpponentWinsNum.Size = new System.Drawing.Size(19, 17);
            this.lblOpponentWinsNum.TabIndex = 12;
            this.lblOpponentWinsNum.Text = "0";
            // 
            // PaperScissorsRock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblOpponentWinsNum);
            this.Controls.Add(this.lblTieNum);
            this.Controls.Add(this.lblPlayerWinsNum);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblOpponentWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaperScissorsRock";
            this.Text = "Paper Scissors Rock";
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblOpponentWins;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.Label lblPlayerWinsNum;
        private System.Windows.Forms.Label lblTieNum;
        private System.Windows.Forms.Label lblOpponentWinsNum;
    }
}

