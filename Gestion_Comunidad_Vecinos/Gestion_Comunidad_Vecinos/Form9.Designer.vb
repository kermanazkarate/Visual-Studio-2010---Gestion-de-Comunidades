<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAnadirIngresos
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
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.TBComunidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtVolver
        '
        Me.BtVolver.Location = New System.Drawing.Point(155, 268)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(128, 22)
        Me.BtVolver.TabIndex = 31
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = True
        '
        'TBComunidad
        '
        Me.TBComunidad.BackColor = System.Drawing.Color.White
        Me.TBComunidad.Enabled = False
        Me.TBComunidad.Location = New System.Drawing.Point(170, 35)
        Me.TBComunidad.Name = "TBComunidad"
        Me.TBComunidad.Size = New System.Drawing.Size(211, 20)
        Me.TBComunidad.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Comunidad:"
        '
        'FAnadirIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 314)
        Me.Controls.Add(Me.TBComunidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtVolver)
        Me.Name = "FAnadirIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AÑADIR INGRESOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtVolver As System.Windows.Forms.Button
    Friend WithEvents TBComunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
