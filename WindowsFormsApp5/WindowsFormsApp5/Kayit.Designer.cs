namespace WindowsFormsApp5
{
    partial class Kayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adres :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 25);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 25);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyisim :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ana Menüye Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 25);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 25);
            this.textBox4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Müşteri Numarası :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 335);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}