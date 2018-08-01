<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLlamadas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(12, 25)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(260, 21)
        Me.cmbTipo.TabIndex = 0
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(13, 63)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(259, 20)
        Me.txtDuracion.TabIndex = 1
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(13, 109)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(259, 20)
        Me.txtOrigen.TabIndex = 2
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(13, 152)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(259, 20)
        Me.txtDestino.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 179)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 51)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(139, 179)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 51)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmLlamadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.cmbTipo)
        Me.Name = "frmLlamadas"
        Me.Text = "Llamadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

End Class
