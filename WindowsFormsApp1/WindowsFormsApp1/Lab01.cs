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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 form1 = new Lab01_Bai01();
            form1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 form2 = new Lab01_Bai02();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 form4 = new Lab1_Bai4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 form3 = new Lab1_Bai3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 form5 = new Lab1_Bai5();
            form5.Show();
        }
    }
}
