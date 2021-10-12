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
    public partial class yesButton : Form
    {
        string name;

        public yesButton()
        {
            InitializeComponent();
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            nameInput.Text = name;
            outputLabel.Text = $"Welcome, {name}!";
            Thread.Sleep;(1000)
            Refresh();
            outputLabel.Text = "Do you want to play a "number guessing game"?";

        }
    }
}
