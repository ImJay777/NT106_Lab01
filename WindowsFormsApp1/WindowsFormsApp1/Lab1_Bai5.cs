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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }
        private void Lab1_Bai5_Load(object sender, EventArgs e)
        {
            lbS1.Text = "S1 = 1 + ... + A = ";
            lbS2.Text = "S2 = 1 + ... + B = ";
            lbS3.Text = "S3 = A^1 + ... + A^B =";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAfactorial_TextChanged(object sender, EventArgs e)
        {

        }
        //Tính giai thừa
        static int cal_factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * cal_factorial(num - 1);
        }
        // Tính S3
        static long cal_S3(int nA, int nB)
        {
            long S3 = 0;
            for (int i = 1; i <= nB; i++)
                S3 += (int)Math.Pow((double)nA,(double)i);
            return S3;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int nA, nB;
            bool checkA = uint.TryParse(tbA.Text.Trim(), out uint valueA);
            bool checkB = uint.TryParse(tbB.Text.Trim(), out uint valueB);
            if (!checkA || !checkB)
            {
                string message = "Hãy nhập số nguyên lớn hơn 0 (giai thừa không âm).";
                string title = "Lỗi";
                MessageBox.Show(message, title);
            }
            else
            {
                nA = Int32.Parse(tbA.Text.Trim());
                nB = Int32.Parse(tbB.Text.Trim());
                //Tính A!, B!, S1, S2
                tbAfactorial.Text =  cal_factorial(nA).ToString();
                tbBfactorial.Text = cal_factorial(nB).ToString();
                tbS1.Text = (((1 + nA) * nA) / 2).ToString();
                tbS2.Text = (((1 + nB) * nB) / 2).ToString();
                tbS3.Text = cal_S3(nA, nB).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAfactorial_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbS1.Clear();
            tbS2.Clear();
            tbS3.Clear();
            tbA.Clear();
            tbB.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
