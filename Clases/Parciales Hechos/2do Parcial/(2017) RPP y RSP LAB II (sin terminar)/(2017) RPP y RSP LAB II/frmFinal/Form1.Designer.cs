namespace Entidades
{
    partial class frmFinal
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
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnEspecialista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(11, 12);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(256, 89);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Atender Médico General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            // 
            // btnEspecialista
            // 
            this.btnEspecialista.Location = new System.Drawing.Point(11, 109);
            this.btnEspecialista.Name = "btnEspecialista";
            this.btnEspecialista.Size = new System.Drawing.Size(255, 89);
            this.btnEspecialista.TabIndex = 1;
            this.btnEspecialista.Text = "Atender Médico Especialista";
            this.btnEspecialista.UseVisualStyleBackColor = true;
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 210);
            this.Controls.Add(this.btnEspecialista);
            this.Controls.Add(this.btnGeneral);
            this.Name = "frmFinal";
            this.Text = "frmFinal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnEspecialista;
    }
}