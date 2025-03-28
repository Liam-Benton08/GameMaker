namespace GameMaker
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1ScoreTracker = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.p1LivesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1ScoreTracker
            // 
            this.p1ScoreTracker.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreTracker.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreTracker.ForeColor = System.Drawing.Color.White;
            this.p1ScoreTracker.Location = new System.Drawing.Point(375, 0);
            this.p1ScoreTracker.Name = "p1ScoreTracker";
            this.p1ScoreTracker.Size = new System.Drawing.Size(174, 23);
            this.p1ScoreTracker.TabIndex = 0;
            this.p1ScoreTracker.Text = "P1 Score :";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(205, 200);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(250, 130);
            this.gameOverLabel.TabIndex = 1;
            this.gameOverLabel.Text = "Press Space to Start";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverLabel.Visible = false;
            // 
            // p1LivesLabel
            // 
            this.p1LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1LivesLabel.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1LivesLabel.ForeColor = System.Drawing.Color.White;
            this.p1LivesLabel.Location = new System.Drawing.Point(555, 0);
            this.p1LivesLabel.Name = "p1LivesLabel";
            this.p1LivesLabel.Size = new System.Drawing.Size(181, 23);
            this.p1LivesLabel.TabIndex = 2;
            this.p1LivesLabel.Text = "Lives: 3";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("MS Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(273, 23);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.p1LivesLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.p1ScoreTracker);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(650, 450);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1ScoreTracker;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label p1LivesLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}
