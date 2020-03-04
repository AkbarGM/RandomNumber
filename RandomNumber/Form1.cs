using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        int RandomNumber;
        int N = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            RandomNumber = rnd.Next(1, 100);
            button1.Text = Convert.ToString(N);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            
            if (num == RandomNumber)
                label1.Text = "Congratulations!!!";
            else
            {
                N--;
                button1.Text = Convert.ToString(N);
                if (num < RandomNumber)
                    label1.Text = "Greater";
                else if (num > RandomNumber)
                    label1.Text = "Less";
                if(N==0)
                    label1.Text = "You Lost!!!";

            }
            if (N < 4)
                button1.BackColor = Color.Red;

        }
    }
}
