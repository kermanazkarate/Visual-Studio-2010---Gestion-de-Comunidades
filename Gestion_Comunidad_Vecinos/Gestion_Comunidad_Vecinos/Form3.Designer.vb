<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenuCV
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
        Me.BtCuotaComunidad = New System.Windows.Forms.Button()
        Me.BtAdminComunidad = New System.Windows.Forms.Button()
        Me.BtVecinosComunidad = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtAnadirGasto = New System.Windows.Forms.Button()
        Me.BtAnadirIngreso = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comunidad:"
        '
        'TBcomunidad
        '
        Me.TBcomunidad.BackColor = System.Drawing.Color.White
        Me.TBcomunidad.Enabled = False
        Me.TBcomunidad.Location = New System.Drawing.Point(195, 33)
        Me.TBcomunidad.Name = "TBcomunidad"
        Me.TBcomunidad.Size = New System.Drawing.Size(457, 20)
        Me.TBcomunidad.TabIndex = 1
        '
        'BtCuotaComunidad
        '
        Me.BtCuotaComunidad.Location = New System.Drawing.Point(48, 27)
        Me.BtCuotaComunidad.Name = "BtCuotaComunidad"
        Me.BtCuotaComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtCuotaComunidad.TabIndex = 2
        Me.BtCuotaComunidad.Text = "Cuota de la comunidad"
        Me.BtCuotaComunidad.UseVisualStyleBackColor = True
        '
        'BtAdminComunidad
        '
        Me.BtAdminComunidad.Location = New System.Drawing.Point(48, 65)
        Me.BtAdminComunidad.Name = "BtAdminComunidad"
        Me.BtAdminComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtAdminComunidad.TabIndex = 3
        Me.BtAdminComunidad.Text = "Administrador de la comunidad"
        Me.BtAdminComunidad.UseVisualStyleBackColor = True
        '
        'BtVecinosComunidad
        '
        Me.BtVecinosComunidad.Location = New System.Drawing.Point(48, 103)
        Me.BtVecinosComunidad.Name = "BtVecinosComunidad"
        Me.BtVecinosComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtVecinosComunidad.TabIndex = 4
        Me.BtVecinosComunidad.Text = "Vecinos de la comunidad"
        Me.BtVecinosComunidad.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(48, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(456, 25)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Proveedores de la comunidad"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtAnadirGasto
        '
        Me.BtAnadirGasto.Location = New System.Drawing.Point(52, 29)
        Me.BtAnadirGasto.Name = "BtAnadirGasto"
        Me.BtAnadirGasto.Size = New System.Drawing.Size(456, 25)
        Me.BtAnadirGasto.TabIndex = 6
        Me.BtAnadirGasto.Text = "Añadir Gastos"
        Me.BtAnadirGasto.UseVisualStyleBackColor = True
        '
        'BtAnadirIngreso
        '
        Me.BtAnadirIngreso.Location = New System.Drawing.Point(51, 65)
        Me.BtAnadirIngreso.Name = "BtAnadirIngreso"
        Me.BtAnadirIngreso.Size = New System.Drawing.Size(457, 26)
        Me.BtAnadirIngreso.TabIndex = 7
        Me.BtAnadirIngreso.Text = "Añadir Ingresos"
        Me.BtAnadirIngreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtAnadirIngreso)
        Me.GroupBox1.Controls.Add(Me.BtAnadirGasto)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 111)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asientos Contables"
        '
        'BtVolver
        '
        Me.BtVolver.Location = New System.Drawing.Point(347, 548)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(133, 23)
        Me.BtVolver.TabIndex = 9
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Location = New System.Drawing.Point(143, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 129)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listados"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(47, 91)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(457, 26)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Listado de Ingresos"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(47, 55)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(457, 26)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Listado de Gastos"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(48, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(456, 25)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Listado de Vecinos"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.BtVecinosComunidad)
        Me.GroupBox3.Controls.Add(Me.BtAdminComunidad)
        Me.GroupBox3.Controls.Add(Me.BtCuotaComunidad)
        Me.GroupBox3.Location = New System.Drawing.Point(143, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(550, 186)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comunidad"
        '
        'FMenuCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 580)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TBcomunidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FMenuCV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " GESTION COMUNIDAD DE VECINOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBcomunidad As System.Windows.Forms.TextBox
    Friend WithEvents BtCuotaComunidad As System.Windows.Forms.Button
    Friend WithEvents BtAdminComunidad As System.Windows.Forms.Button
    Friend WithEvents BtVecinosComunidad As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BtAnadirGasto As System.Windows.Forms.Button
    Friend WithEvents BtAnadirIngreso As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
