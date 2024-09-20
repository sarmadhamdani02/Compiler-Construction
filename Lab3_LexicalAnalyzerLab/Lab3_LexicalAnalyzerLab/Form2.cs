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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void analyze_btn_Click(object sender, EventArgs e)

        {
            richTextBox2.Clear();

            string input = richTextBox1.Text;
            string[] words = input.Split(' ');

            // Regex for floating-point numbers <= 6
            Regex regex1 = new Regex(@"^[0-9]{1,6}(\.[0-9]{1,6})?$");
            // Regex for scientific notation numbers
            Regex regex2 = new Regex(@"^[0-9]+[eE][+-]?[0-9]+$");
            // Regex for words starting with 't' or 'm'
            Regex regex3 = new Regex(@"\b[tTmM]\w*");

            foreach (var word in words)
            {
                if (regex1.IsMatch(word))
                {
                    richTextBox2.AppendText(word + " is a valid floating-point number.\n");
                }
                else if (regex2.IsMatch(word))
                {
                    richTextBox2.AppendText(word + " is a valid scientific notation number.\n");
                }
                else if (regex3.IsMatch(word))
                {
                    richTextBox2.AppendText(word + " starts with 't' or 'm'.\n");
                }
                else
                {
                    richTextBox2.AppendText(word + " is not valid.\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Create an instance of Form2
            form1.Show();               // Show Form2 as a new window
            this.Hide();
        }
    }


}
