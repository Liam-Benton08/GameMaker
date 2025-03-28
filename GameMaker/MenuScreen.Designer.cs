namespace GameMaker
{
    partial class MenuScreen
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
            this.gameNameShadowLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameNameShadowLabel
            // 
            this.gameNameShadowLabel.Font = new System.Drawing.Font("MS Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameShadowLabel.ForeColor = System.Drawing.Color.Black;
            this.gameNameShadowLabel.Location = new System.Drawing.Point(220, 25);
            this.gameNameShadowLabel.Name = "gameNameShadowLabel";
            this.gameNameShadowLabel.Size = new System.Drawing.Size(310, 70);
            this.gameNameShadowLabel.TabIndex = 0;
            this.gameNameShadowLabel.Text = "PAC MAN";
            this.gameNameShadowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Font = new System.Drawing.Font("MS Gothic", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.gameNameLabel.Location = new System.Drawing.Point(220, 25);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(310, 70);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.Text = "PAC MAN";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.Font = new System.Drawing.Font("MS Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(295, 430);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 70);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.gameNameShadowLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(750, 550);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MenuScreen_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameNameShadowLabel;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button exitButton;
    }
}
