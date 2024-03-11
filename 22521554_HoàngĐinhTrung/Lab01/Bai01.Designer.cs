namespace Lab01
{
    partial class Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.So1 = new System.Windows.Forms.TextBox();
            this.So2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Ketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(123, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(288, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(123, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // So1
            // 
            this.So1.BackColor = System.Drawing.Color.LightYellow;
            this.So1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.So1.Location = new System.Drawing.Point(270, 126);
            this.So1.Name = "So1";
            this.So1.Size = new System.Drawing.Size(141, 20);
            this.So1.TabIndex = 3;
            this.So1.TextChanged += new System.EventHandler(this.So1_TextChanged);
            // 
            // So2
            // 
            this.So2.BackColor = System.Drawing.SystemColors.Info;
            this.So2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.So2.Location = new System.Drawing.Point(270, 190);
            this.So2.Name = "So2";
            this.So2.Size = new System.Drawing.Size(141, 20);
            this.So2.TabIndex = 4;
            this.So2.TextChanged += new System.EventHandler(this.So2_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(121, 255);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(290, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Tính";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng";
            // 
            // Ketqua
            // 
            this.Ketqua.BackColor = System.Drawing.SystemColors.Info;
            this.Ketqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ketqua.Location = new System.Drawing.Point(227, 313);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(109, 20);
            this.Ketqua.TabIndex = 7;
            this.Ketqua.TextChanged += new System.EventHandler(this.Ketqua_TextChanged);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.So2);
            this.Controls.Add(this.So1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox So1;
        private System.Windows.Forms.TextBox So2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ketqua;
    }
}