using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a location.");
            }

            int location = Convert.ToInt32(textBox1.Text);

            if (location <= 28 && location >= 1)
            {
                if (location <= 4 && location >= 1)
                {
                    textBox2.Text = "3";
                    textBox6.Text = "2";
                }
                else if (location >= 5 && location <= 28)
                {
                    textBox2.Text = "5";
                    if (location == 5 || location == 10 || location == 11 || location == 16 || location == 17 || location == 22 || location == 23 || location == 28)
                    {
                        textBox6.Text = "3";
                    }
                    else
                    {
                        textBox6.Text = "4";
                    }
                }
                textBox3.Text = "21";
                textBox4.Text = "7";
                textBox5.Text = "14";
            }
            else if (location <= 48 && location >= 29)
            {
                if (location == 29 || location == 34 || location == 39 || location == 44)
                {
                    textBox6.Text = "3";
                }
                else
                {
                    textBox6.Text = "6";
                }
                textBox2.Text = "8";
                textBox3.Text = "23";
                textBox4.Text = "9";
                textBox5.Text = "14";
            }
            else if (location <= 60 && location >= 49)
            {
                textBox2.Text = "8";
                textBox3.Text = "25";
                textBox4.Text = "11";
                textBox5.Text = "14";
                textBox6.Text = "8";

            }
            else if (location <= 64 && location >= 61)
            {
                textBox2.Text = "8";
                textBox3.Text = "27";
                textBox4.Text = "13";
                textBox5.Text = "14";
                textBox6.Text = "8";
            }
            else
            {
                textBox2.Text = "Invalid Input";
                textBox3.Text = "Invalid Input";
                textBox4.Text = "Invalid Input";
                textBox5.Text = "Invalid Input";
                textBox6.Text = "Invalid Input";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
