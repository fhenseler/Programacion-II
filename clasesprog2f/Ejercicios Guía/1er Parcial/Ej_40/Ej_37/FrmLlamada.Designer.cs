namespace Ej_40
{
    partial class FrmLlamada
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
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(12, 70);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(353, 20);
            this.txtDuracion.TabIndex = 1;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(12, 119);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(353, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(12, 163);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(353, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(12, 217);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "ACEPTAR";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(258, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 24);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(353, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // FrmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtDuracion);
            this.Name = "FrmLlamada";
            this.Text = "FrmLlamada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}