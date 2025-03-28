using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMaker
{
    public partial class SelectModeScreen : UserControl
    {
        public static string p1Userame;
        public static string p1Color = "Blue";
        public static string p1Difficulty = "Easy";

        public static int p1Lives;
        public static int p1Score = 0;


        public SelectModeScreen()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (p1UsernameInput.Text != "")
            {
                try
                {
                    p1Userame = p1UsernameInput.Text;
                    Form1.ChangeScreen(this, new GameScreen());
                }
                catch
                {
                    usernameErrorLabel.Text = "Please enter a valid username";
                }
            }
            else
            {
                usernameErrorLabel.Text = "Please enter a username";
            }
        }

        #region ColoredButtons
        #region P1
        private void p1RedButton_Click(object sender, EventArgs e)
        {
            p1Color = "Red";

            resetBorder();
            p1RedButton.FlatAppearance.BorderColor = Color.Black;
        }

        private void p1BlueButton_Click(object sender, EventArgs e)
        {
            p1Color = "Blue";

            resetBorder();
            p1BlueButton.FlatAppearance.BorderColor = Color.Black;
        }

        private void p1GreenButton_Click(object sender, EventArgs e)
        {
            p1Color = "Green";

            resetBorder();
            p1GreenButton.FlatAppearance.BorderColor = Color.Black;
        }

        private void p1CyanButton_Click(object sender, EventArgs e)
        {
            p1Color = "Cyan";

            resetBorder();
            p1CyanButton.FlatAppearance.BorderColor = Color.Black;
        }

        private void p1PurpleButton_Click(object sender, EventArgs e)
        {
            p1Color = "Purple";

            resetBorder();
            p1PurpleButton.FlatAppearance.BorderColor = Color.Black;
        }

        private void p1PinkButton_Click(object sender, EventArgs e)
        {
            p1Color = "Pink";

            resetBorder();
            p1PinkButton.FlatAppearance.BorderColor = Color.Black;
        }
        #endregion
        #endregion

        #region DifficultyButtons
        #region P1
        private void p1EasyButton_Click(object sender, EventArgs e)
        {
            p1Difficulty = "Easy";

            p1EasyButton.BackColor = Color.Indigo;
            p1MediumButton.BackColor = Color.SlateBlue;
            p1HardButton.BackColor = Color.SlateBlue;

            
        }

        private void p1MediumButton_Click(object sender, EventArgs e)
        {
            p1Difficulty = "Medium";

            p1EasyButton.BackColor = Color.SlateBlue;
            p1MediumButton.BackColor = Color.Indigo;
            p1HardButton.BackColor = Color.SlateBlue;
        }

        private void p1HardButton_Click(object sender, EventArgs e)
        {
            p1Difficulty = "Hard";

            p1EasyButton.BackColor = Color.SlateBlue;
            p1MediumButton.BackColor = Color.SlateBlue;
            p1HardButton.BackColor = Color.Indigo;
        }
        #endregion

        #endregion

        #region Player#

        #endregion

        private void resetBorder()
        {
            p1BlueButton.FlatAppearance.BorderColor = Color.White;
            p1RedButton.FlatAppearance.BorderColor = Color.White;
            p1GreenButton.FlatAppearance.BorderColor = Color.White;
            p1CyanButton.FlatAppearance.BorderColor = Color.White;
            p1PurpleButton.FlatAppearance.BorderColor = Color.White;
            p1PinkButton.FlatAppearance.BorderColor = Color.White;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
