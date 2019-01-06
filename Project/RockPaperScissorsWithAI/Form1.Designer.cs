namespace RockPaperScissorsWithAI
{
    partial class RockPaperScissors
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonStartReset = new System.Windows.Forms.Button();
            this.EndRoundPicture = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PlayerScoreText = new System.Windows.Forms.Label();
            this.PlayerScorePanel = new System.Windows.Forms.Panel();
            this.ComputerScorePanel = new System.Windows.Forms.Panel();
            this.ComputerScoreText = new System.Windows.Forms.Label();
            this.HumanScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundCounterPanel = new System.Windows.Forms.Panel();
            this.RoundCounter = new System.Windows.Forms.Label();
            this.RoundCounterText = new System.Windows.Forms.Label();
            this.EndGamePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndRoundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.PlayerScorePanel.SuspendLayout();
            this.ComputerScorePanel.SuspendLayout();
            this.RoundCounterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGamePicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayerPictureBox.Location = new System.Drawing.Point(16, 85);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(220, 192);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox.TabIndex = 0;
            this.PlayerPictureBox.TabStop = false;
            // 
            // ButtonStartReset
            // 
            this.ButtonStartReset.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartReset.Location = new System.Drawing.Point(230, 12);
            this.ButtonStartReset.Name = "ButtonStartReset";
            this.ButtonStartReset.Size = new System.Drawing.Size(117, 39);
            this.ButtonStartReset.TabIndex = 1;
            this.ButtonStartReset.Text = "START";
            this.ButtonStartReset.UseVisualStyleBackColor = true;
            // 
            // EndRoundPicture
            // 
            this.EndRoundPicture.BackColor = System.Drawing.Color.Transparent;
            this.EndRoundPicture.Location = new System.Drawing.Point(105, 114);
            this.EndRoundPicture.Name = "EndRoundPicture";
            this.EndRoundPicture.Size = new System.Drawing.Size(362, 135);
            this.EndRoundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndRoundPicture.TabIndex = 3;
            this.EndRoundPicture.TabStop = false;
            this.EndRoundPicture.Visible = false;
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(12, 361);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(72, 77);
            this.Rock.TabIndex = 4;
            this.Rock.Text = "ROCK";
            this.Rock.UseVisualStyleBackColor = true;
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(91, 361);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(72, 77);
            this.Paper.TabIndex = 5;
            this.Paper.Text = "PAPER";
            this.Paper.UseVisualStyleBackColor = true;
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(170, 361);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(70, 77);
            this.Scissors.TabIndex = 6;
            this.Scissors.Text = "SCISSORS";
            this.Scissors.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(220, 192);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // PlayerScoreText
            // 
            this.PlayerScoreText.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScoreText.Location = new System.Drawing.Point(3, 14);
            this.PlayerScoreText.Name = "PlayerScoreText";
            this.PlayerScoreText.Size = new System.Drawing.Size(130, 25);
            this.PlayerScoreText.TabIndex = 8;
            this.PlayerScoreText.Text = "PLAYER SCORE:";
            this.PlayerScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerScorePanel
            // 
            this.PlayerScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerScorePanel.Controls.Add(this.HumanScore);
            this.PlayerScorePanel.Controls.Add(this.PlayerScoreText);
            this.PlayerScorePanel.Location = new System.Drawing.Point(15, 301);
            this.PlayerScorePanel.Name = "PlayerScorePanel";
            this.PlayerScorePanel.Size = new System.Drawing.Size(225, 54);
            this.PlayerScorePanel.TabIndex = 9;
            // 
            // ComputerScorePanel
            // 
            this.ComputerScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerScorePanel.Controls.Add(this.label1);
            this.ComputerScorePanel.Controls.Add(this.ComputerScoreText);
            this.ComputerScorePanel.Location = new System.Drawing.Point(341, 301);
            this.ComputerScorePanel.Name = "ComputerScorePanel";
            this.ComputerScorePanel.Size = new System.Drawing.Size(225, 54);
            this.ComputerScorePanel.TabIndex = 10;
            // 
            // ComputerScoreText
            // 
            this.ComputerScoreText.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScoreText.Location = new System.Drawing.Point(3, 11);
            this.ComputerScoreText.Name = "ComputerScoreText";
            this.ComputerScoreText.Size = new System.Drawing.Size(158, 30);
            this.ComputerScoreText.TabIndex = 8;
            this.ComputerScoreText.Text = "COMPUTER SCORE:";
            this.ComputerScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumanScore
            // 
            this.HumanScore.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanScore.Location = new System.Drawing.Point(129, 11);
            this.HumanScore.Name = "HumanScore";
            this.HumanScore.Size = new System.Drawing.Size(29, 30);
            this.HumanScore.TabIndex = 9;
            this.HumanScore.Text = "0";
            this.HumanScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HumanScore.Click += new System.EventHandler(this.HumanScore_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundCounterPanel
            // 
            this.RoundCounterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoundCounterPanel.Controls.Add(this.RoundCounter);
            this.RoundCounterPanel.Controls.Add(this.RoundCounterText);
            this.RoundCounterPanel.Location = new System.Drawing.Point(341, 361);
            this.RoundCounterPanel.Name = "RoundCounterPanel";
            this.RoundCounterPanel.Size = new System.Drawing.Size(225, 54);
            this.RoundCounterPanel.TabIndex = 11;
            this.RoundCounterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundCounterPanel_Paint);
            // 
            // RoundCounter
            // 
            this.RoundCounter.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundCounter.Location = new System.Drawing.Point(81, 11);
            this.RoundCounter.Name = "RoundCounter";
            this.RoundCounter.Size = new System.Drawing.Size(29, 30);
            this.RoundCounter.TabIndex = 10;
            this.RoundCounter.Text = "0";
            this.RoundCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundCounterText
            // 
            this.RoundCounterText.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundCounterText.Location = new System.Drawing.Point(7, 13);
            this.RoundCounterText.Name = "RoundCounterText";
            this.RoundCounterText.Size = new System.Drawing.Size(80, 28);
            this.RoundCounterText.TabIndex = 8;
            this.RoundCounterText.Text = "ROUND:";
            this.RoundCounterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndGamePicture
            // 
            this.EndGamePicture.BackColor = System.Drawing.Color.Transparent;
            this.EndGamePicture.Location = new System.Drawing.Point(70, 95);
            this.EndGamePicture.Name = "EndGamePicture";
            this.EndGamePicture.Size = new System.Drawing.Size(433, 172);
            this.EndGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGamePicture.TabIndex = 12;
            this.EndGamePicture.TabStop = false;
            this.EndGamePicture.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 200);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(341, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 200);
            this.panel2.TabIndex = 11;
            // 
            // RockPaperScissors
            // 
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.EndRoundPicture);
            this.Controls.Add(this.EndGamePicture);
            this.Controls.Add(this.RoundCounterPanel);
            this.Controls.Add(this.ComputerScorePanel);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.ButtonStartReset);
            this.Controls.Add(this.PlayerPictureBox);
            this.Controls.Add(this.PlayerScorePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "RockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndRoundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.PlayerScorePanel.ResumeLayout(false);
            this.ComputerScorePanel.ResumeLayout(false);
            this.RoundCounterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndGamePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.Button ButtonStartReset;
        private System.Windows.Forms.PictureBox EndRoundPicture;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label PlayerScoreText;
        private System.Windows.Forms.Panel PlayerScorePanel;
        private System.Windows.Forms.Label HumanScore;
        private System.Windows.Forms.Panel ComputerScorePanel;
        private System.Windows.Forms.Label ComputerScoreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RoundCounterPanel;
        private System.Windows.Forms.Label RoundCounter;
        private System.Windows.Forms.Label RoundCounterText;
        private System.Windows.Forms.PictureBox EndGamePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

