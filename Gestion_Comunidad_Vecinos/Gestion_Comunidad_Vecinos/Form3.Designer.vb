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
        Me.BProveedores = New System.Windows.Forms.Button()
        Me.BIngresos = New System.Windows.Forms.Button()
        Me.BGastos = New System.Windows.Forms.Button()
        Me.BVecinos = New System.Windows.Forms.Button()
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
        Me.BtCuotaComunidad.Location = New System.Drawing.Point(74, 31)
        Me.BtCuotaComunidad.Name = "BtCuotaComunidad"
        Me.BtCuotaComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtCuotaComunidad.TabIndex = 2
        Me.BtCuotaComunidad.Text = "Cuota de la comunidad"
        Me.BtCuotaComunidad.UseVisualStyleBackColor = True
        '
        'BtAdminComunidad
        '
        Me.BtAdminComunidad.Location = New System.Drawing.Point(74, 66)
        Me.BtAdminComunidad.Name = "BtAdminComunidad"
        Me.BtAdminComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtAdminComunidad.TabIndex = 3
        Me.BtAdminComunidad.Text = "Administrador de la comunidad"
        Me.BtAdminComunidad.UseVisualStyleBackColor = True
        '
        'BtVecinosComunidad
        '
        Me.BtVecinosComunidad.Location = New System.Drawing.Point(74, 101)
        Me.BtVecinosComunidad.Name = "BtVecinosComunidad"
        Me.BtVecinosComunidad.Size = New System.Drawing.Size(456, 24)
        Me.BtVecinosComunidad.TabIndex = 4
        Me.BtVecinosComunidad.Text = "Vecinos de la comunidad"
        Me.BtVecinosComunidad.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(74, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(456, 25)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Nuevo Proveedor"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtAnadirGasto
        '
        Me.BtAnadirGasto.Location = New System.Drawing.Point(74, 33)
        Me.BtAnadirGasto.Name = "BtAnadirGasto"
        Me.BtAnadirGasto.Size = New System.Drawing.Size(456, 25)
        Me.BtAnadirGasto.TabIndex = 6
        Me.BtAnadirGasto.Text = "Añadir Gastos"
        Me.BtAnadirGasto.UseVisualStyleBackColor = True
        '
        'BtAnadirIngreso
        '
        Me.BtAnadirIngreso.Location = New System.Drawing.Point(73, 69)
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
        Me.GroupBox1.Location = New System.Drawing.Point(121, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 111)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asientos Contables"
        '
        'BtVolver
        '
        Me.BtVolver.Location = New System.Drawing.Point(347, 607)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(133, 23)
        Me.BtVolver.TabIndex = 12
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BProveedores)
        Me.GroupBox2.Controls.Add(Me.BIngresos)
        Me.GroupBox2.Controls.Add(Me.BGastos)
        Me.GroupBox2.Controls.Add(Me.BVecinos)
        Me.GroupBox2.Location = New System.Drawing.Point(121, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 178)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listados"
        '
        'BProveedores
        '
        Me.BProveedores.Location = New System.Drawing.Point(73, 61)
        Me.BProveedores.Name = "BProveedores"
        Me.BProveedores.Size = New System.Drawing.Size(457, 26)
        Me.BProveedores.TabIndex = 9
        Me.BProveedores.Text = "Listado de Proveedores"
        Me.BProveedores.UseVisualStyleBackColor = True
        '
        'BIngresos
        '
        Me.BIngresos.Location = New System.Drawing.Point(73, 135)
        Me.BIngresos.Name = "BIngresos"
        Me.BIngresos.Size = New System.Drawing.Size(457, 26)
        Me.BIngresos.TabIndex = 11
        Me.BIngresos.Text = "Listado de Ingresos"
        Me.BIngresos.UseVisualStyleBackColor = True
        '
        'BGastos
        '
        Me.BGastos.Location = New System.Drawing.Point(73, 98)
        Me.BGastos.Name = "BGastos"
        Me.BGastos.Size = New System.Drawing.Size(457, 26)
        Me.BGastos.TabIndex = 10
        Me.BGastos.Text = "Listado de Gastos"
        Me.BGastos.UseVisualStyleBackColor = True
        '
        'BVecinos
        '
        Me.BVecinos.Location = New System.Drawing.Point(73, 25)
        Me.BVecinos.Name = "BVecinos"
        Me.BVecinos.Size = New System.Drawing.Size(457, 25)
        Me.BVecinos.TabIndex = 8
        Me.BVecinos.Text = "Listado de Vecinos"
        Me.BVecinos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.BtVecinosComunidad)
        Me.GroupBox3.Controls.Add(Me.BtAdminComunidad)
        Me.GroupBox3.Controls.Add(Me.BtCuotaComunidad)
        Me.GroupBox3.Location = New System.Drawing.Point(121, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(589, 186)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comunidad"
        '
        'FMenuCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 652)
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
    Friend WithEvents BIngresos As System.Windows.Forms.Button
    Friend WithEvents BGastos As System.Windows.Forms.Button
    Friend WithEvents BVecinos As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BProveedores As System.Windows.Forms.Button
End Class
