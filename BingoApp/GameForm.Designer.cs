namespace BingoApp
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStop = new Button();
            btnStart = new Button();
            lbxDrawnNumbers = new ListBox();
            lblNumber = new Label();
            timer = new System.Windows.Forms.Timer(components);
            tbxMaxNumber = new TextBox();
            label1 = new Label();
            btnLoadGame = new Button();
            btnStopAndSaveGame = new Button();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI", 9F);
            btnStop.Location = new Point(8, 251);
            btnStop.Margin = new Padding(1, 1, 1, 1);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(186, 20);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop the bingo";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 9F);
            btnStart.Location = new Point(185, 196);
            btnStart.Margin = new Padding(1, 1, 1, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 20);
            btnStart.TabIndex = 10;
            btnStart.Text = "Start the bingo";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbxDrawnNumbers
            // 
            lbxDrawnNumbers.Font = new Font("Segoe UI", 9F);
            lbxDrawnNumbers.FormattingEnabled = true;
            lbxDrawnNumbers.ItemHeight = 15;
            lbxDrawnNumbers.Location = new Point(255, 5);
            lbxDrawnNumbers.Margin = new Padding(1, 1, 1, 1);
            lbxDrawnNumbers.Name = "lbxDrawnNumbers";
            lbxDrawnNumbers.Size = new Size(137, 184);
            lbxDrawnNumbers.TabIndex = 9;
            // 
            // lblNumber
            // 
            lblNumber.Font = new Font("Microsoft Sans Serif", 70F, FontStyle.Bold);
            lblNumber.Location = new Point(8, 5);
            lblNumber.Margin = new Padding(1, 0, 1, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(244, 182);
            lblNumber.TabIndex = 8;
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            // 
            // tbxMaxNumber
            // 
            tbxMaxNumber.Font = new Font("Segoe UI", 9F);
            tbxMaxNumber.Location = new Point(137, 198);
            tbxMaxNumber.Margin = new Padding(1, 1, 1, 1);
            tbxMaxNumber.Name = "tbxMaxNumber";
            tbxMaxNumber.Size = new Size(46, 23);
            tbxMaxNumber.TabIndex = 15;
            tbxMaxNumber.Text = "99";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(10, 202);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 13);
            label1.TabIndex = 14;
            label1.Text = "With numbers from 1 -";
            // 
            // btnLoadGame
            // 
            btnLoadGame.Font = new Font("Segoe UI", 9F);
            btnLoadGame.Location = new Point(8, 229);
            btnLoadGame.Margin = new Padding(1, 1, 1, 1);
            btnLoadGame.Name = "btnLoadGame";
            btnLoadGame.Size = new Size(383, 20);
            btnLoadGame.TabIndex = 13;
            btnLoadGame.Text = "Load saved game";
            btnLoadGame.UseVisualStyleBackColor = true;
            btnLoadGame.Click += btnLoadGame_Click;
            // 
            // btnStopAndSaveGame
            // 
            btnStopAndSaveGame.Enabled = false;
            btnStopAndSaveGame.Font = new Font("Segoe UI", 9F);
            btnStopAndSaveGame.Location = new Point(204, 251);
            btnStopAndSaveGame.Margin = new Padding(1, 1, 1, 1);
            btnStopAndSaveGame.Name = "btnStopAndSaveGame";
            btnStopAndSaveGame.Size = new Size(186, 20);
            btnStopAndSaveGame.TabIndex = 12;
            btnStopAndSaveGame.Text = "Stop and save current game";
            btnStopAndSaveGame.UseVisualStyleBackColor = true;
            btnStopAndSaveGame.Click += btnStopAndSaveGame_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 276);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lbxDrawnNumbers);
            Controls.Add(lblNumber);
            Controls.Add(tbxMaxNumber);
            Controls.Add(label1);
            Controls.Add(btnLoadGame);
            Controls.Add(btnStopAndSaveGame);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Let's play Bingo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStop;
        private Button btnStart;
        private ListBox lbxDrawnNumbers;
        private Label lblNumber;
        private System.Windows.Forms.Timer timer;
        private TextBox tbxMaxNumber;
        private Label label1;
        private Button btnLoadGame;
        private Button btnStopAndSaveGame;
    }
}
