namespace WindowsFormsApp1
{
    partial class Lab1_Bai5
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbAfactorial = new System.Windows.Forms.Label();
            this.tbAfactorial = new System.Windows.Forms.TextBox();
            this.tbBfactorial = new System.Windows.Forms.TextBox();
            this.tbS1 = new System.Windows.Forms.TextBox();
            this.lbBfactorial = new System.Windows.Forms.Label();
            this.lbS1 = new System.Windows.Forms.Label();
            this.tbS2 = new System.Windows.Forms.TextBox();
            this.lbS2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbS3 = new System.Windows.Forms.Label();
            this.tbS3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(89, 36);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(83, 25);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Nhập A";
            this.lbA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(89, 93);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(83, 25);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "Nhập B";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(380, 36);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(172, 31);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(380, 90);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(172, 31);
            this.tbB.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(66, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(172, 91);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Tính giá trị";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbAfactorial
            // 
            this.lbAfactorial.AutoSize = true;
            this.lbAfactorial.Location = new System.Drawing.Point(89, 283);
            this.lbAfactorial.Name = "lbAfactorial";
            this.lbAfactorial.Size = new System.Drawing.Size(50, 25);
            this.lbAfactorial.TabIndex = 5;
            this.lbAfactorial.Text = "A! =";
            this.lbAfactorial.Click += new System.EventHandler(this.lbAfactorial_Click);
            // 
            // tbAfactorial
            // 
            this.tbAfactorial.Location = new System.Drawing.Point(380, 277);
            this.tbAfactorial.Name = "tbAfactorial";
            this.tbAfactorial.ReadOnly = true;
            this.tbAfactorial.Size = new System.Drawing.Size(172, 31);
            this.tbAfactorial.TabIndex = 6;
            this.tbAfactorial.TextChanged += new System.EventHandler(this.tbAfactorial_TextChanged);
            // 
            // tbBfactorial
            // 
            this.tbBfactorial.Location = new System.Drawing.Point(380, 326);
            this.tbBfactorial.Name = "tbBfactorial";
            this.tbBfactorial.ReadOnly = true;
            this.tbBfactorial.Size = new System.Drawing.Size(172, 31);
            this.tbBfactorial.TabIndex = 8;
            // 
            // tbS1
            // 
            this.tbS1.Location = new System.Drawing.Point(380, 378);
            this.tbS1.Name = "tbS1";
            this.tbS1.ReadOnly = true;
            this.tbS1.Size = new System.Drawing.Size(172, 31);
            this.tbS1.TabIndex = 10;
            this.tbS1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbBfactorial
            // 
            this.lbBfactorial.AutoSize = true;
            this.lbBfactorial.Location = new System.Drawing.Point(89, 329);
            this.lbBfactorial.Name = "lbBfactorial";
            this.lbBfactorial.Size = new System.Drawing.Size(50, 25);
            this.lbBfactorial.TabIndex = 11;
            this.lbBfactorial.Text = "B! =";
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Location = new System.Drawing.Point(89, 378);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(56, 25);
            this.lbS1.TabIndex = 12;
            this.lbS1.Text = "S1 =";
            // 
            // tbS2
            // 
            this.tbS2.Location = new System.Drawing.Point(380, 436);
            this.tbS2.Name = "tbS2";
            this.tbS2.ReadOnly = true;
            this.tbS2.Size = new System.Drawing.Size(172, 31);
            this.tbS2.TabIndex = 13;
            // 
            // lbS2
            // 
            this.lbS2.AutoSize = true;
            this.lbS2.Location = new System.Drawing.Point(89, 436);
            this.lbS2.Name = "lbS2";
            this.lbS2.Size = new System.Drawing.Size(56, 25);
            this.lbS2.TabIndex = 14;
            this.lbS2.Text = "S2 =";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(244, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 91);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Xoá";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(453, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 91);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbS3
            // 
            this.lbS3.AutoSize = true;
            this.lbS3.Location = new System.Drawing.Point(89, 490);
            this.lbS3.Name = "lbS3";
            this.lbS3.Size = new System.Drawing.Size(56, 25);
            this.lbS3.TabIndex = 18;
            this.lbS3.Text = "S3 =";
            // 
            // tbS3
            // 
            this.tbS3.Location = new System.Drawing.Point(380, 490);
            this.tbS3.Name = "tbS3";
            this.tbS3.ReadOnly = true;
            this.tbS3.Size = new System.Drawing.Size(172, 31);
            this.tbS3.TabIndex = 17;
            // 
            // Lab1_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 544);
            this.Controls.Add(this.lbS3);
            this.Controls.Add(this.tbS3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbS2);
            this.Controls.Add(this.tbS2);
            this.Controls.Add(this.lbS1);
            this.Controls.Add(this.lbBfactorial);
            this.Controls.Add(this.tbS1);
            this.Controls.Add(this.tbBfactorial);
            this.Controls.Add(this.tbAfactorial);
            this.Controls.Add(this.lbAfactorial);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "Lab1_Bai5";
            this.Text = "Lab1_Bai5";
            this.Load += new System.EventHandler(this.Lab1_Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbAfactorial;
        private System.Windows.Forms.TextBox tbAfactorial;
        private System.Windows.Forms.TextBox tbBfactorial;
        private System.Windows.Forms.TextBox tbS1;
        private System.Windows.Forms.Label lbBfactorial;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.TextBox tbS2;
        private System.Windows.Forms.Label lbS2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbS3;
        private System.Windows.Forms.TextBox tbS3;
    }
}