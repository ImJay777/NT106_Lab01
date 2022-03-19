namespace WindowsFormsApp1
{
    partial class Lab1_Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lMoney = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.tbCMoney = new System.Windows.Forms.TextBox();
            this.lCMoney = new System.Windows.Forms.Label();
            this.cbxCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lMoney
            // 
            this.lMoney.AutoSize = true;
            this.lMoney.Location = new System.Drawing.Point(12, 24);
            this.lMoney.Name = "lMoney";
            this.lMoney.Size = new System.Drawing.Size(206, 25);
            this.lMoney.TabIndex = 0;
            this.lMoney.Text = "Tiền cần chuyển đổi";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(12, 52);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(220, 31);
            this.tbMoney.TabIndex = 1;
            this.tbMoney.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(12, 104);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(154, 47);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Chuyển đổi";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // tbCMoney
            // 
            this.tbCMoney.Location = new System.Drawing.Point(12, 182);
            this.tbCMoney.Name = "tbCMoney";
            this.tbCMoney.ReadOnly = true;
            this.tbCMoney.Size = new System.Drawing.Size(220, 31);
            this.tbCMoney.TabIndex = 3;
            this.tbCMoney.TextChanged += new System.EventHandler(this.tbCMoney_TextChanged);
            // 
            // lCMoney
            // 
            this.lCMoney.AutoSize = true;
            this.lCMoney.Location = new System.Drawing.Point(12, 154);
            this.lCMoney.Name = "lCMoney";
            this.lCMoney.Size = new System.Drawing.Size(206, 25);
            this.lCMoney.TabIndex = 4;
            this.lCMoney.Text = "Tiền cần chuyển đổi";
            this.lCMoney.Click += new System.EventHandler(this.txtCMoney_Click);
            // 
            // cbxCurrency
            // 
            this.cbxCurrency.FormattingEnabled = true;
            this.cbxCurrency.Location = new System.Drawing.Point(243, 52);
            this.cbxCurrency.Name = "cbxCurrency";
            this.cbxCurrency.Size = new System.Drawing.Size(121, 33);
            this.cbxCurrency.TabIndex = 5;
            this.cbxCurrency.SelectedIndexChanged += new System.EventHandler(this.cbxCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "VND";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lab1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCurrency);
            this.Controls.Add(this.lCMoney);
            this.Controls.Add(this.tbCMoney);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.lMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Lab1_Bai4";
            this.Text = "Quy đổi tiền tệ";
            this.Load += new System.EventHandler(this.Lab1_Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMoney;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox tbCMoney;
        private System.Windows.Forms.Label lCMoney;
        private System.Windows.Forms.ComboBox cbxCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}