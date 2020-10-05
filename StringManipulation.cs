using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reverseLabel_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            DoIt(inputTextbox.Text);

        }
        private void DoIt(string inputText)
        {
            if (inputText == string.Empty)
            {
                //MessageBox.Show("Go Fuck yourself")
                MessageBox.Show("Jwow sucks eggs", "Stinky icky eggs");
            }
            backwardsLabel.Text = DoBackwardsText(inputText);
            capsLabel.Text = DoCaps(inputText);
            charLabel.Text = DoChars(inputText);
        }

        private string DoBackwardsText(string inputText)
        {
            char[] charArray = inputText.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            
        }
        private String DoCaps(String input)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            foreach (char c in input)
            {
                sb.Append(random.Next(1, 5000) % 2 == 0 ? c.ToString().ToLower() : c.ToString().ToUpper());
            }
            return sb.ToString();
        }
        private String DoChars(string input)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            foreach (char c in input)
            {
                //sb.Append(random.Next(1, 5000) % 2 == 0 ? c.ToString().ToLower() : c.ToString().ToUpper());
                sb.Append(((int)c).ToString());
            }
            return sb.ToString();
        }
    }
    }
