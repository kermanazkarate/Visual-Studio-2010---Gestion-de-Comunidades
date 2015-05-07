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
        'FAnadirIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 314)
        Me.Controls.Add(Me.BtVolver)
        Me.Name = "FAnadirIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AÑADIR INGRESOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtVolver As System.Windows.Forms.Button
End Class
