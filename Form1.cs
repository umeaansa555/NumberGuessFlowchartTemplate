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
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
