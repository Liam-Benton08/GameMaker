namespace GameMaker
{
    partial class SelectModeScreen
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
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.p1UsernameLabel = new System.Windows.Forms.Label();
            this.p1ColorLabel = new System.Windows.Forms.Label();
            this.p1DiffLabel = new System.Windows.Forms.Label();
            this.p1UsernameInput = new System.Windows.Forms.TextBox();
            this.p1EasyButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.p1MediumButton = new System.Windows.Forms.Button();
            this.p1HardButton = new System.Windows.Forms.Button();
            this.p1RedButton = new System.Windows.Forms.Button();
            this.p1BlueButton = new System.Windows.Forms.Button();
            this.p1GreenButton = new System.Windows.Forms.Button();
            this.p1PurpleButton = new System.Windows.Forms.Button();
            this.p1CyanButton = new System.Windows.Forms.Button();
            this.p1PinkButton = new System.Windows.Forms.Button();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Font = new System.Drawing.Font("MS Gothic", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.gameNameLabel.Location = new System.Drawing.Point(44, 16);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(310, 70);
            this.gameNameLabel.TabIndex = 2;
            this.gameNameLabel.Text = "PAC MAN";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.Font = new System.Drawing.Font("MS Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(587, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 70);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // p1UsernameLabel
            // 
            this.p1UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1UsernameLabel.ForeColor = System.Drawing.Color.Gold;
            this.p1UsernameLabel.Location = new System.Drawing.Point(50, 160);
            this.p1UsernameLabel.Name = "p1UsernameLabel";
            this.p1UsernameLabel.Size = new System.Drawing.Size(160, 50);
            this.p1UsernameLabel.TabIndex = 4;
            this.p1UsernameLabel.Text = "Username:";
            this.p1UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p1ColorLabel
            // 
            this.p1ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ColorLabel.ForeColor = System.Drawing.Color.Gold;
            this.p1ColorLabel.Location = new System.Drawing.Point(50, 260);
            this.p1ColorLabel.Name = "p1ColorLabel";
            this.p1ColorLabel.Size = new System.Drawing.Size(160, 50);
            this.p1ColorLabel.TabIndex = 5;
            this.p1ColorLabel.Text = "Color:";
            this.p1ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p1DiffLabel
            // 
            this.p1DiffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1DiffLabel.ForeColor = System.Drawing.Color.Gold;
            this.p1DiffLabel.Location = new System.Drawing.Point(50, 360);
            this.p1DiffLabel.Name = "p1DiffLabel";
            this.p1DiffLabel.Size = new System.Drawing.Size(160, 50);
            this.p1DiffLabel.TabIndex = 6;
            this.p1DiffLabel.Text = "Diffuculty:";
            this.p1DiffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p1UsernameInput
            // 
            this.p1UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1UsernameInput.Location = new System.Drawing.Point(200, 173);
            this.p1UsernameInput.Name = "p1UsernameInput";
            this.p1UsernameInput.Size = new System.Drawing.Size(145, 30);
            this.p1UsernameInput.TabIndex = 8;
            // 
            // p1EasyButton
            // 
            this.p1EasyButton.BackColor = System.Drawing.Color.Indigo;
            this.p1EasyButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1EasyButton.ForeColor = System.Drawing.Color.White;
            this.p1EasyButton.Location = new System.Drawing.Point(189, 368);
            this.p1EasyButton.Name = "p1EasyButton";
            this.p1EasyButton.Size = new System.Drawing.Size(60, 40);
            this.p1EasyButton.TabIndex = 10;
            this.p1EasyButton.Text = "E";
            this.p1EasyButton.UseVisualStyleBackColor = false;
            this.p1EasyButton.Click += new System.EventHandler(this.p1EasyButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.White;
            this.startGameButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(265, 451);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(205, 60);
            this.startGameButton.TabIndex = 22;
            this.startGameButton.Text = "READY";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // p1MediumButton
            // 
            this.p1MediumButton.BackColor = System.Drawing.Color.SlateBlue;
            this.p1MediumButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1MediumButton.ForeColor = System.Drawing.Color.White;
            this.p1MediumButton.Location = new System.Drawing.Point(255, 368);
            this.p1MediumButton.Name = "p1MediumButton";
            this.p1MediumButton.Size = new System.Drawing.Size(60, 40);
            this.p1MediumButton.TabIndex = 23;
            this.p1MediumButton.Text = "M";
            this.p1MediumButton.UseVisualStyleBackColor = false;
            this.p1MediumButton.Click += new System.EventHandler(this.p1MediumButton_Click);
            // 
            // p1HardButton
            // 
            this.p1HardButton.BackColor = System.Drawing.Color.SlateBlue;
            this.p1HardButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1HardButton.ForeColor = System.Drawing.Color.White;
            this.p1HardButton.Location = new System.Drawing.Point(321, 368);
            this.p1HardButton.Name = "p1HardButton";
            this.p1HardButton.Size = new System.Drawing.Size(60, 40);
            this.p1HardButton.TabIndex = 24;
            this.p1HardButton.Text = "H";
            this.p1HardButton.UseVisualStyleBackColor = false;
            this.p1HardButton.Click += new System.EventHandler(this.p1HardButton_Click);
            // 
            // p1RedButton
            // 
            this.p1RedButton.BackColor = System.Drawing.Color.Red;
            this.p1RedButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1RedButton.FlatAppearance.BorderSize = 3;
            this.p1RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1RedButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1RedButton.ForeColor = System.Drawing.Color.White;
            this.p1RedButton.Location = new System.Drawing.Point(180, 267);
            this.p1RedButton.Name = "p1RedButton";
            this.p1RedButton.Size = new System.Drawing.Size(40, 40);
            this.p1RedButton.TabIndex = 25;
            this.p1RedButton.UseVisualStyleBackColor = false;
            this.p1RedButton.Click += new System.EventHandler(this.p1RedButton_Click);
            // 
            // p1BlueButton
            // 
            this.p1BlueButton.BackColor = System.Drawing.Color.Blue;
            this.p1BlueButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1BlueButton.FlatAppearance.BorderSize = 3;
            this.p1BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1BlueButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1BlueButton.ForeColor = System.Drawing.Color.White;
            this.p1BlueButton.Location = new System.Drawing.Point(135, 267);
            this.p1BlueButton.Name = "p1BlueButton";
            this.p1BlueButton.Size = new System.Drawing.Size(40, 40);
            this.p1BlueButton.TabIndex = 26;
            this.p1BlueButton.UseVisualStyleBackColor = false;
            this.p1BlueButton.Click += new System.EventHandler(this.p1BlueButton_Click);
            // 
            // p1GreenButton
            // 
            this.p1GreenButton.BackColor = System.Drawing.Color.Green;
            this.p1GreenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1GreenButton.FlatAppearance.BorderSize = 3;
            this.p1GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1GreenButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1GreenButton.ForeColor = System.Drawing.Color.White;
            this.p1GreenButton.Location = new System.Drawing.Point(225, 267);
            this.p1GreenButton.Name = "p1GreenButton";
            this.p1GreenButton.Size = new System.Drawing.Size(40, 40);
            this.p1GreenButton.TabIndex = 27;
            this.p1GreenButton.UseVisualStyleBackColor = false;
            this.p1GreenButton.Click += new System.EventHandler(this.p1GreenButton_Click);
            // 
            // p1PurpleButton
            // 
            this.p1PurpleButton.BackColor = System.Drawing.Color.Purple;
            this.p1PurpleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1PurpleButton.FlatAppearance.BorderSize = 3;
            this.p1PurpleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1PurpleButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1PurpleButton.ForeColor = System.Drawing.Color.White;
            this.p1PurpleButton.Location = new System.Drawing.Point(315, 267);
            this.p1PurpleButton.Name = "p1PurpleButton";
            this.p1PurpleButton.Size = new System.Drawing.Size(40, 40);
            this.p1PurpleButton.TabIndex = 28;
            this.p1PurpleButton.UseVisualStyleBackColor = false;
            this.p1PurpleButton.Click += new System.EventHandler(this.p1PurpleButton_Click);
            // 
            // p1CyanButton
            // 
            this.p1CyanButton.BackColor = System.Drawing.Color.Cyan;
            this.p1CyanButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1CyanButton.FlatAppearance.BorderSize = 3;
            this.p1CyanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1CyanButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1CyanButton.ForeColor = System.Drawing.Color.White;
            this.p1CyanButton.Location = new System.Drawing.Point(270, 267);
            this.p1CyanButton.Name = "p1CyanButton";
            this.p1CyanButton.Size = new System.Drawing.Size(40, 40);
            this.p1CyanButton.TabIndex = 29;
            this.p1CyanButton.UseVisualStyleBackColor = false;
            this.p1CyanButton.Click += new System.EventHandler(this.p1CyanButton_Click);
            // 
            // p1PinkButton
            // 
            this.p1PinkButton.BackColor = System.Drawing.Color.Pink;
            this.p1PinkButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.p1PinkButton.FlatAppearance.BorderSize = 3;
            this.p1PinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p1PinkButton.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1PinkButton.ForeColor = System.Drawing.Color.White;
            this.p1PinkButton.Location = new System.Drawing.Point(360, 267);
            this.p1PinkButton.Name = "p1PinkButton";
            this.p1PinkButton.Size = new System.Drawing.Size(40, 40);
            this.p1PinkButton.TabIndex = 30;
            this.p1PinkButton.UseVisualStyleBackColor = false;
            this.p1PinkButton.Click += new System.EventHandler(this.p1PinkButton_Click);
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.usernameErrorLabel.Location = new System.Drawing.Point(50, 210);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(325, 50);
            this.usernameErrorLabel.TabIndex = 31;
            this.usernameErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectModeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.usernameErrorLabel);
            this.Controls.Add(this.p1PinkButton);
            this.Controls.Add(this.p1CyanButton);
            this.Controls.Add(this.p1PurpleButton);
            this.Controls.Add(this.p1GreenButton);
            this.Controls.Add(this.p1BlueButton);
            this.Controls.Add(this.p1RedButton);
            this.Controls.Add(this.p1HardButton);
            this.Controls.Add(this.p1MediumButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.p1EasyButton);
            this.Controls.Add(this.p1UsernameInput);
            this.Controls.Add(this.p1DiffLabel);
            this.Controls.Add(this.p1ColorLabel);
            this.Controls.Add(this.p1UsernameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameNameLabel);
            this.Name = "SelectModeScreen";
            this.Size = new System.Drawing.Size(750, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label p1UsernameLabel;
        private System.Windows.Forms.Label p1ColorLabel;
        private System.Windows.Forms.Label p1DiffLabel;
        private System.Windows.Forms.TextBox p1UsernameInput;
        private System.Windows.Forms.Button p1EasyButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button p1MediumButton;
        private System.Windows.Forms.Button p1HardButton;
        private System.Windows.Forms.Button p1RedButton;
        private System.Windows.Forms.Button p1BlueButton;
        private System.Windows.Forms.Button p1GreenButton;
        private System.Windows.Forms.Button p1PurpleButton;
        private System.Windows.Forms.Button p1CyanButton;
        private System.Windows.Forms.Button p1PinkButton;
        private System.Windows.Forms.Label usernameErrorLabel;
    }
}
