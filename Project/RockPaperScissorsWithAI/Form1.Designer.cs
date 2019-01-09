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
            this.StartButton = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.PlayerScoreText = new System.Windows.Forms.Label();
            this.PlayerScorePanel = new System.Windows.Forms.Panel();
            this.HumanScore = new System.Windows.Forms.Label();
            this.ComputerScorePanel = new System.Windows.Forms.Panel();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.ComputerScoreText = new System.Windows.Forms.Label();
            this.RoundCounterPanel = new System.Windows.Forms.Panel();
            this.RoundCounter = new System.Windows.Forms.Label();
            this.RoundCounterText = new System.Windows.Forms.Label();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.ComputerPanel = new System.Windows.Forms.Panel();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.PlayerScorePanel.SuspendLayout();
            this.ComputerScorePanel.SuspendLayout();
            this.RoundCounterPanel.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            this.ComputerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(230, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // RockButton
            // 
            this.RockButton.Enabled = false;
            this.RockButton.Location = new System.Drawing.Point(12, 361);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(72, 77);
            this.RockButton.TabIndex = 4;
            this.RockButton.Text = "ROCK";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Enabled = false;
            this.PaperButton.Location = new System.Drawing.Point(91, 361);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(72, 77);
            this.PaperButton.TabIndex = 5;
            this.PaperButton.Text = "PAPER";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Enabled = false;
            this.ScissorsButton.Location = new System.Drawing.Point(170, 361);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(70, 77);
            this.ScissorsButton.TabIndex = 6;
            this.ScissorsButton.Text = "SCISSORS";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
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
            // HumanScore
            // 
            this.HumanScore.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanScore.Location = new System.Drawing.Point(129, 11);
            this.HumanScore.Name = "HumanScore";
            this.HumanScore.Size = new System.Drawing.Size(29, 30);
            this.HumanScore.TabIndex = 9;
            this.HumanScore.Text = "0";
            this.HumanScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerScorePanel
            // 
            this.ComputerScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerScorePanel.Controls.Add(this.ComputerScore);
            this.ComputerScorePanel.Controls.Add(this.ComputerScoreText);
            this.ComputerScorePanel.Location = new System.Drawing.Point(341, 301);
            this.ComputerScorePanel.Name = "ComputerScorePanel";
            this.ComputerScorePanel.Size = new System.Drawing.Size(225, 54);
            this.ComputerScorePanel.TabIndex = 10;
            // 
            // ComputerScore
            // 
            this.ComputerScore.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScore.Location = new System.Drawing.Point(157, 11);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(29, 30);
            this.ComputerScore.TabIndex = 10;
            this.ComputerScore.Text = "0";
            this.ComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // RoundCounterPanel
            // 
            this.RoundCounterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoundCounterPanel.Controls.Add(this.RoundCounter);
            this.RoundCounterPanel.Controls.Add(this.RoundCounterText);
            this.RoundCounterPanel.Location = new System.Drawing.Point(341, 361);
            this.RoundCounterPanel.Name = "RoundCounterPanel";
            this.RoundCounterPanel.Size = new System.Drawing.Size(225, 54);
            this.RoundCounterPanel.TabIndex = 11;
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
            // PlayerPanel
            // 
            this.PlayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerPanel.Controls.Add(this.PlayerPictureBox);
            this.PlayerPanel.Location = new System.Drawing.Point(12, 81);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(228, 200);
            this.PlayerPanel.TabIndex = 10;
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(220, 192);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox.TabIndex = 0;
            this.PlayerPictureBox.TabStop = false;
            // 
            // ComputerPanel
            // 
            this.ComputerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerPanel.Controls.Add(this.ComputerPictureBox);
            this.ComputerPanel.Location = new System.Drawing.Point(341, 81);
            this.ComputerPanel.Name = "ComputerPanel";
            this.ComputerPanel.Size = new System.Drawing.Size(228, 200);
            this.ComputerPanel.TabIndex = 11;
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ComputerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(220, 192);
            this.ComputerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerPictureBox.TabIndex = 7;
            this.ComputerPictureBox.TabStop = false;
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestart.Location = new System.Drawing.Point(230, 12);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(117, 39);
            this.ButtonRestart.TabIndex = 12;
            this.ButtonRestart.Text = "RESTART";
            this.ButtonRestart.UseVisualStyleBackColor = true;
            this.ButtonRestart.Visible = false;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // RockPaperScissors
            // 
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.RoundCounterPanel);
            this.Controls.Add(this.ComputerScorePanel);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PlayerScorePanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.ComputerPanel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "RockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.PlayerScorePanel.ResumeLayout(false);
            this.ComputerScorePanel.ResumeLayout(false);
            this.RoundCounterPanel.ResumeLayout(false);
            this.PlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            this.ComputerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
                
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.Label PlayerScoreText;
        private System.Windows.Forms.Panel PlayerScorePanel;
        private System.Windows.Forms.Label HumanScore;
        private System.Windows.Forms.Panel ComputerScorePanel;
        private System.Windows.Forms.Label ComputerScoreText;
        private System.Windows.Forms.Label ComputerScore;
        private System.Windows.Forms.Panel RoundCounterPanel;
        private System.Windows.Forms.Label RoundCounter;
        private System.Windows.Forms.Label RoundCounterText;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Panel ComputerPanel;
        private System.Windows.Forms.Button ButtonRestart;
    }
}

