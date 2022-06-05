using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_The_Dice
{
    public partial class DiceRoller : Form
    {
        public int x;

        public int num;

        public DiceRoller()
        {
            InitializeComponent();
            WarningText.Text = "";
            InputField.Text = "0";
            flipResult.Text = "";
        }

        public bool IsValid()
        {
            if (InputField.Text == "" || InputField.Text == "0")
                return false;
            else 
                return true;
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(InputField.Text, out x);
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                RollDice();
                WarningText.Text = "";
            }
            else
                WarningText.Text = "Please enter a valid / another number!";
        }

        public void RollDice()
        {
            Random rand = new Random();

            num = rand.Next(1, x + 1);

            NumberDisplay.Text = "You have rolled a " + num.ToString();

            AddPreviousRoll(num);
        }

        public void HeadOrTail()
        {
            Random rand = new Random();

            num = rand.Next(0, 2);

            if (num == 0)
                flipResult.Text = "The Coin has landed on " + "\n" + "Heads";
            else
                flipResult.Text = "The Coin has landed on " + "\n" + "Tails";
        }

        public void AddPreviousRoll(int num)
        {
            listView.Items.Add(num.ToString());
        }

        private void InputField_Click(object sender, EventArgs e)
        {
            InputField.Text = "";
        }

        private void HeadTail_Click(object sender, EventArgs e)
        {
            HeadOrTail();
        }
    }
}
