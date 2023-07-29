using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NumberChars = "0123456789";
            var random = new Random();
            List<char> passwords = new List<char>();
            List<string> p = new List<string>();
            for (int h = 0; h < textBox1.Text.Length; h++)
            {
                for (int i = 0; i < 8; i++)
                {
                    passwords[i] = NumberChars[random.Next(NumberChars.Length)];
                }
            p.Add(passwords.ToString());
                MessageBox.Show(p[0]);
                MessageBox.Show(p[1]);
            }
            
        }
    }
}
