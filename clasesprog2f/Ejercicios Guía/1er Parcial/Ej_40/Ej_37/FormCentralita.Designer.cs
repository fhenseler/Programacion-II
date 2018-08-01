namespace Ej_40
{
    partial class FormCentralita
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
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lstbLlamadas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(13, 13);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(301, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // lstbLlamadas
            // 
            this.lstbLlamadas.FormattingEnabled = true;
            this.lstbLlamadas.Location = new System.Drawing.Point(13, 56);
            this.lstbLlamadas.Name = "lstbLlamadas";
            this.lstbLlamadas.Size = new System.Drawing.Size(120, 95);
            this.lstbLlamadas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(201, 92);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(13, 170);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Location = new System.Drawing.Point(12, 205);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(0, 13);
            this.lblGanancia.TabIndex = 4;
            this.lblGanancia.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(201, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // FormCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 286);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstbLlamadas);
            this.Controls.Add(this.txtRazonSocial);
            this.Name = "FormCentralita";
            this.Text = "FormCentralita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.ListBox lstbLlamadas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Button btnCalcular;
    }
}