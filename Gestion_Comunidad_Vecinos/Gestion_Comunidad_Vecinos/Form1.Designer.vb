<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.BABMCV = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BEntrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBComunidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(139, 41)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(369, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "GESTION DE COMUNIDADES DE VECINOS"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BABMCV
        '
        Me.BABMCV.Location = New System.Drawing.Point(131, 110)
        Me.BABMCV.Name = "BABMCV"
        Me.BABMCV.Size = New System.Drawing.Size(387, 28)
        Me.BABMCV.TabIndex = 1
        Me.BABMCV.Text = "Altas - Bajas - Modificaciones de Comunidad de Vecinos"
        Me.BABMCV.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(223, 387)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(194, 28)
        Me.BSalir.TabIndex = 4
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BEntrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBComunidad)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 186)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de la Comunidad de Vecinos"
        '
        'BEntrar
        '
        Me.BEntrar.Location = New System.Drawing.Point(188, 137)
        Me.BEntrar.Name = "BEntrar"
        Me.BEntrar.Size = New System.Drawing.Size(194, 28)
        Me.BEntrar.TabIndex = 2
        Me.BEntrar.Text = "Entrar"
        Me.BEntrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calle:"
        '
        'CBComunidad
        '
        Me.CBComunidad.FormattingEnabled = True
        Me.CBComunidad.Location = New System.Drawing.Point(96, 55)
        Me.CBComunidad.Name = "CBComunidad"
        Me.CBComunidad.Size = New System.Drawing.Size(486, 21)
        Me.CBComunidad.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 433)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BABMCV)
        Me.Controls.Add(Me.LTitulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PANTALLA INICIAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTitulo As System.Windows.Forms.Label
    Friend WithEvents BABMCV As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BEntrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBComunidad As System.Windows.Forms.ComboBox

End Class
