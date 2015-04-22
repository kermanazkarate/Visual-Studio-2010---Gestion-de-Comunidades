<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBcomunidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calle: "
        '
        'TBcomunidad
        '
        Me.TBcomunidad.BackColor = System.Drawing.Color.White
        Me.TBcomunidad.Enabled = False
        Me.TBcomunidad.Location = New System.Drawing.Point(141, 33)
        Me.TBcomunidad.Name = "TBcomunidad"
        Me.TBcomunidad.Size = New System.Drawing.Size(457, 20)
        Me.TBcomunidad.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(456, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cuota de la comunidad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(456, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Administrador"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(141, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(456, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Vecinos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(141, 260)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(456, 25)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Proveedores"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(52, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(456, 25)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Gastos de la comunidad"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(51, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(457, 26)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Ingresos de la comunidad"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 165)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos e Ingresos"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(293, 498)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Volver"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 534)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBcomunidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " GESTION COMUNIDAD DE VECINOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBcomunidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
