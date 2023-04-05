using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long input_value;
            string output_value ="";
            Stack<char> values = new Stack<char>();
            if (long.TryParse(textBox1.Text, out input_value))
            {
                if (input_value<0)
                {
                    textBox2.Text = "Please enter a positive number or zero";
                    return;
                }
                while (input_value>0)
                {
                    if ((input_value % Convert.ToInt64(comboBox1.Text))>9)
                    {
                        values.Push(Convert.ToChar((input_value % Convert.ToInt64(comboBox1.Text))+55));
                    }
                    else
                    {
                        values.Push(Convert.ToChar((input_value % Convert.ToInt64(comboBox1.Text)) + 48));
                    }
                    input_value /= Convert.ToInt32(comboBox1.Text);
                }
                foreach (var i in values)
                {
                    output_value += i;
                }

                textBox2.Text = output_value;

            }
            else
            {
                textBox2.Text = "TextBox does not contain an integer";
                return;
            }

        }
    }
}
