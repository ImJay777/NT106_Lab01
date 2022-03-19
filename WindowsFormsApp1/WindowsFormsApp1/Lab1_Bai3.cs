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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab1_Bai3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool check = int.TryParse(tbInt.Text.Trim(), out int value);
            if (!check)
            {
                string message = "Số tự nhiên gì kì vậy.";
                string title = "Lỗi";
                MessageBox.Show(message, title);
            }
            else
            {
                num = Int32.Parse(tbInt.Text.Trim());
                if (num < 0 || num > 9)
                {
                    string message = "Nhập số từ 1 đến 9.";
                    string title = "Lỗi.";
                    MessageBox.Show(message, title);

                }
                else
                {
                    switch (num)
                    {
                        case 1: tbResult.Text = "Một";
                            break;
                        case 2:
                            tbResult.Text = "Hai";
                            break;
                        case 3:
                            tbResult.Text = "Ba";
                            break;
                        case 4:
                            tbResult.Text = "Bốn";
                            break;
                        case 5:
                            tbResult.Text = "Năm";
                            break;
                        case 6:
                            tbResult.Text = "Sáu";
                            break;
                        case 7:
                            tbResult.Text = "Bảy";
                            break;
                        case 8:
                            tbResult.Text = "Tám";
                            break;
                        case 9:
                            tbResult.Text = "Chín";
                            break;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInt.Clear();
        }
    }
}
