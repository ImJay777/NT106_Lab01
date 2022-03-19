using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nhập sô nguyên
            int n1, n2 = 0;
            long sum = 0;
            bool check_number_1 = int.TryParse(textBox1.Text.Trim(), out int value);
            bool check_number_2 = int.TryParse(textBox2.Text.Trim(), out int temp);
            
            // Check so nguyen
            if (!check_number_1 || !check_number_2)
            {
                string message = "Đây không phải là số nguyên.";
                string title = "Lỗi";
                MessageBox.Show(message, title);
            }
            // Tinh SUM
            else
            {
                n1 = Int32.Parse(textBox1.Text.Trim());
                n2 = Int32.Parse(textBox2.Text.Trim());
                sum = n1 + n2;
                textBox3.Text = sum.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
