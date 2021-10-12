using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NumberGuessFlowchartTemplate
{
    public partial class form1 : Form
    {
        string userName;
        Random randGen = new Random();
        int randomNumber;
        int guess;

        public form1()
        {
            InitializeComponent();
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            nameInput.Text = userName;
            outputLabel.Text = $"Welcome, {userName}!";
            Thread.Sleep(1000);
            Refresh();
            outputLabel.Text = "Do you want to play a number guessing game?";

            yesButton.Visible = true;
            yesButton.Enabled = true;

            noButton.Visible = true;
            noButton.Enabled = true;

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            randomNumber = randGen.Next(1,101);
            outputLabel.Text = $"{randomNumber}";

            yesButton.Visible = false;
            yesButton.Enabled = false;

            noButton.Visible = false;
            noButton.Enabled = false;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guessBox_TextChanged(object sender, EventArgs e)
        {
            guess = Convert.ToInt32(guessBox.Text);
            outputLabel.Text = $"{randomNumber}";
            try 
            {
                guess = randomNumber;
                outputLabel.Text = $"Congratulations, you guessed right! Press exit to close the program.";
                exitButton.Visible = true;
            }
            catch
            {
                outputLabel.Text = $"That's not it. Try again";

            }
        }
    }
}
