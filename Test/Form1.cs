using System;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        int ldkskflskn;
        double a, b;
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Неккоректно введено чило");
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Неккоректно введено чило");
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Неккоректно введено чило");
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op =3;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Неккоректно введено чило");
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch(op)
            {
                case 1:
                    textBox1.Text = Convert.ToString(a + b);
                    break;
                case 2:
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case 3:
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case 4:
                    if(b==0)
                    {
                        MessageBox.Show("Деление на 0!!!");
                        break;
                    }
                    textBox1.Text = Convert.ToString(a / b);
                    break;
            }
        }

    }
}
