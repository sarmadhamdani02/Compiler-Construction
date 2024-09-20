using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_LexicalAnalyzerLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();

            string input = richTextBox1.Text;
            string[] words = input.Split(' ');

            Regex regex1 = new Regex("^[0-9]{1,6}(\\.[0-9]{1,6})?$\r\n");

            foreach (string word in words) {
                if (regex1.IsMatch(word))
                {
                    // If it matches, add it to the output richTextBox2
                    richTextBox2.AppendText(word + " is a valid floating-point number.\n");
                }
                else
                {
                    // If it doesn't match, display an invalid message
                    richTextBox2.AppendText(word + " is not valid.\n");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Create an instance of Form2
            form2.Show();               // Show Form2 as a new window
            this.Hide();
        }
    }
}
