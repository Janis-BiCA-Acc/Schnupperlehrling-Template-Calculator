namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtn_Plus = new System.Windows.Forms.RadioButton();
            this.rbtn_Minus = new System.Windows.Forms.RadioButton();
            this.rbtn_Mal = new System.Windows.Forms.RadioButton();
            this.rbtn_geteilt = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // rbtn_Plus
            // 
            this.rbtn_Plus.AutoSize = true;
            this.rbtn_Plus.Location = new System.Drawing.Point(335, 83);
            this.rbtn_Plus.Name = "rbtn_Plus";
            this.rbtn_Plus.Size = new System.Drawing.Size(31, 17);
            this.rbtn_Plus.TabIndex = 11;
            this.rbtn_Plus.TabStop = true;
            this.rbtn_Plus.Text = "+";
            this.rbtn_Plus.UseVisualStyleBackColor = true;
            // 
            // rbtn_Minus
            // 
            this.rbtn_Minus.AutoSize = true;
            this.rbtn_Minus.Location = new System.Drawing.Point(338, 143);
            this.rbtn_Minus.Name = "rbtn_Minus";
            this.rbtn_Minus.Size = new System.Drawing.Size(28, 17);
            this.rbtn_Minus.TabIndex = 12;
            this.rbtn_Minus.TabStop = true;
            this.rbtn_Minus.Text = "-";
            this.rbtn_Minus.UseVisualStyleBackColor = true;
            // 
            // rbtn_Mal
            // 
            this.rbtn_Mal.AutoSize = true;
            this.rbtn_Mal.Location = new System.Drawing.Point(338, 201);
            this.rbtn_Mal.Name = "rbtn_Mal";
            this.rbtn_Mal.Size = new System.Drawing.Size(29, 17);
            this.rbtn_Mal.TabIndex = 13;
            this.rbtn_Mal.TabStop = true;
            this.rbtn_Mal.Text = "*";
            this.rbtn_Mal.UseVisualStyleBackColor = true;
            // 
            // rbtn_geteilt
            // 
            this.rbtn_geteilt.AutoSize = true;
            this.rbtn_geteilt.Location = new System.Drawing.Point(338, 256);
            this.rbtn_geteilt.Name = "rbtn_geteilt";
            this.rbtn_geteilt.Size = new System.Drawing.Size(30, 17);
            this.rbtn_geteilt.TabIndex = 14;
            this.rbtn_geteilt.TabStop = true;
            this.rbtn_geteilt.Text = "/";
            this.rbtn_geteilt.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 82);
            this.button1.TabIndex = 17;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Leeren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Abrechen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 379);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rbtn_geteilt);
            this.Controls.Add(this.rbtn_Mal);
            this.Controls.Add(this.rbtn_Minus);
            this.Controls.Add(this.rbtn_Plus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtn_Plus;
        private System.Windows.Forms.RadioButton rbtn_Minus;
        private System.Windows.Forms.RadioButton rbtn_Mal;
        private System.Windows.Forms.RadioButton rbtn_geteilt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

