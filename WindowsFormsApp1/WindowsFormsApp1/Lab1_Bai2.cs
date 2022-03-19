using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, max, min;
            // Check float
            bool c1 = float.TryParse(textBox1.Text.Trim(), out float value1);
            bool c2 = float.TryParse(textBox2.Text.Trim(), out float value2);
            bool c3 = float.TryParse(textBox1.Text.Trim(), out float value3);
            if (!c1 || !c2 || !c3)
            {
                string message = "Đây không phải là số thực.";
                string title = "Lỗi";
                MessageBox.Show(message, title);
            }
            else
            {
                n1 = float.Parse(textBox1.Text.Trim());
                n2 = float.Parse(textBox2.Text.Trim());
                n3 = float.Parse(textBox3.Text.Trim());
                //So sanh n1,n2
                if (n1 >= n2)
                {
                    max = n1;
                    min = n2;
                }
                else
                {
                    min = n1;
                    max = n2;
                }
                //So sanh n3
                if (n3 >= max)
                    max = n3;
                else if (n3 <= min)
                    min = n3;
                //Min, max vao textbox
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
