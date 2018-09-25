namespace AssignmentCalculator
{
    partial class Form1
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
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(121, 92);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(177, 28);
            this.Number1.TabIndex = 0;
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(121, 138);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(177, 28);
            this.Number2.TabIndex = 1;
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.Operation.Location = new System.Drawing.Point(121, 42);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(177, 30);
            this.Operation.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hasil
            // 
            this.Hasil.Location = new System.Drawing.Point(121, 183);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(177, 28);
            this.Hasil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operasi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Calculator Sederhana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Hasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

