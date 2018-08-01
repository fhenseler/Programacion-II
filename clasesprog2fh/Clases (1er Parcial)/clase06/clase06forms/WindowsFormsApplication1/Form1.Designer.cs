namespace WindowsFormsApplication1
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
            this.btnMuestra = new System.Windows.Forms.Button();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.chkMuestra = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMuestra
            // 
            this.btnMuestra.BackColor = System.Drawing.SystemColors.Control;
            this.btnMuestra.Location = new System.Drawing.Point(215, 224);
            this.btnMuestra.Name = "btnMuestra";
            this.btnMuestra.Size = new System.Drawing.Size(78, 35);
            this.btnMuestra.TabIndex = 0;
            this.btnMuestra.Text = "Continuar";
            this.btnMuestra.UseVisualStyleBackColor = false;
            this.btnMuestra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(12, 32);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(149, 20);
            this.txtMuestra.TabIndex = 1;
            this.txtMuestra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkMuestra
            // 
            this.chkMuestra.AutoSize = true;
            this.chkMuestra.Checked = true;
            this.chkMuestra.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkMuestra.Location = new System.Drawing.Point(12, 234);
            this.chkMuestra.Name = "chkMuestra";
            this.chkMuestra.Size = new System.Drawing.Size(68, 17);
            this.chkMuestra.TabIndex = 2;
            this.chkMuestra.Text = "Activado";
            this.chkMuestra.ThreeState = true;
            this.chkMuestra.UseVisualStyleBackColor = true;
            this.chkMuestra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(44, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "M";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMuestra);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.btnMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMuestra;
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.CheckBox chkMuestra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

