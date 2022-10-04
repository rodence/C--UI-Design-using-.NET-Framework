using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ite314_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a + b).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Operation");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Search;
            Search =int.Parse(textBox4.Text);

            if (Search == 1)
            {
                textBox5.Text = ("Juan Dela Cruz");
            }
            else if (Search == 2)
            {
                textBox5.Text = ("Ava Chua");
            }
            else if (Search == 3)
            {
                textBox5.Text = ("Hatdog");
            }
            else if (Search == 4)
            {
                textBox5.Text = ("Ham");
            }
            else if (Search == 5)
            {
                textBox5.Text = ("Egg");
            }
            else
            {
                textBox5.Text = ("Nothing to Show");
            }
        }
    }
}
