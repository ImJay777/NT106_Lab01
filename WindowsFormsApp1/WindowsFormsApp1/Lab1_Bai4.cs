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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }
        double USD = 22772;
        double EUR = 28132;
        double GBP = 31538;
        double SGD = 17286;
        double JPY = 214;

        private void txtCMoney_Click(object sender, EventArgs e)
        {
        
        }

        private void cbxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            bool check = double.TryParse(tbMoney.Text.Trim(), out double value);
            if (!check)
            {
                string message = "Nhập vào số thực.";
                MessageBox.Show(message);
            }
            else
            {
                double money = double.Parse(tbMoney.Text.Trim());
                if (cbxCurrency.Text == "USD")
                {
                    tbCMoney.Text = System.Convert.ToString(money * USD);
                }
                else if (cbxCurrency.Text == "EUR")
                {
                    tbCMoney.Text = System.Convert.ToString(money * EUR);
                }
                else if (cbxCurrency.Text == "GBP")
                {
                    tbCMoney.Text = System.Convert.ToString(money * GBP);
                }
                else if (cbxCurrency.Text == "SGD")
                {
                    tbCMoney.Text = System.Convert.ToString(money * SGD);
                }
                else if (cbxCurrency.Text == "JPY")
                {
                    tbCMoney.Text = System.Convert.ToString(money * JPY);
                }
            }
        }

        private void tbCMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab1_Bai4_Load(object sender, EventArgs e)
        {
            cbxCurrency.Text = "Chọn";
            cbxCurrency.Items.Add("USD");
            cbxCurrency.Items.Add("EUR");
            cbxCurrency.Items.Add("GBP");
            cbxCurrency.Items.Add("SGD");
            cbxCurrency.Items.Add("JPY");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCMoney.Clear();
            tbMoney.Clear();
        }
    }
}
