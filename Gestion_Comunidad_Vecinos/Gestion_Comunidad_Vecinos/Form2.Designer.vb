<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textcod = New System.Windows.Forms.TextBox()
        Me.Textcalle = New System.Windows.Forms.TextBox()
        Me.Textnum = New System.Windows.Forms.TextBox()
        Me.Texttvecinos = New System.Windows.Forms.TextBox()
        Me.Textnplantas = New System.Windows.Forms.TextBox()
        Me.Textvplanta = New System.Windows.Forms.TextBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.Binicio = New System.Windows.Forms.Button()
        Me.Bfin = New System.Windows.Forms.Button()
        Me.Batras = New System.Windows.Forms.Button()
        Me.Badelante = New System.Windows.Forms.Button()
        Me.Textnreg = New System.Windows.Forms.TextBox()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.TBalta = New System.Windows.Forms.TextBox()
        Me.TBbaja = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CalendarioMes1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Vecinos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nº Plantas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Vecinos/Planta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha Alta:"
        '
        'Textcod
        '
        Me.Textcod.BackColor = System.Drawing.Color.White
        Me.Textcod.Enabled = False
        Me.Textcod.Location = New System.Drawing.Point(139, 56)
        Me.Textcod.Name = "Textcod"
        Me.Textcod.Size = New System.Drawing.Size(70, 20)
        Me.Textcod.TabIndex = 11
        '
        'Textcalle
        '
        Me.Textcalle.Location = New System.Drawing.Point(139, 96)
        Me.Textcalle.Name = "Textcalle"
        Me.Textcalle.Size = New System.Drawing.Size(318, 20)
        Me.Textcalle.TabIndex = 2
        '
        'Textnum
        '
        Me.Textnum.Location = New System.Drawing.Point(523, 96)
        Me.Textnum.Name = "Textnum"
        Me.Textnum.Size = New System.Drawing.Size(44, 20)
        Me.Textnum.TabIndex = 3
        '
        'Texttvecinos
        '
        Me.Texttvecinos.Location = New System.Drawing.Point(508, 149)
        Me.Texttvecinos.Name = "Texttvecinos"
        Me.Texttvecinos.Size = New System.Drawing.Size(59, 20)
        Me.Texttvecinos.TabIndex = 6
        '
        'Textnplantas
        '
        Me.Textnplantas.Location = New System.Drawing.Point(153, 150)
        Me.Textnplantas.Name = "Textnplantas"
        Me.Textnplantas.Size = New System.Drawing.Size(56, 20)
        Me.Textnplantas.TabIndex = 4
        '
        'Textvplanta
        '
        Me.Textvplanta.Location = New System.Drawing.Point(360, 150)
        Me.Textvplanta.Name = "Textvplanta"
        Me.Textvplanta.Size = New System.Drawing.Size(44, 20)
        Me.Textvplanta.TabIndex = 5
        '
        'BVolver
        '
        Me.BVolver.Location = New System.Drawing.Point(256, 403)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(146, 27)
        Me.BVolver.TabIndex = 1
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'Binicio
        '
        Me.Binicio.Location = New System.Drawing.Point(169, 257)
        Me.Binicio.Name = "Binicio"
        Me.Binicio.Size = New System.Drawing.Size(50, 24)
        Me.Binicio.TabIndex = 12
        Me.Binicio.Text = "<<"
        Me.Binicio.UseVisualStyleBackColor = True
        '
        'Bfin
        '
        Me.Bfin.Location = New System.Drawing.Point(405, 258)
        Me.Bfin.Name = "Bfin"
        Me.Bfin.Size = New System.Drawing.Size(50, 24)
        Me.Bfin.TabIndex = 15
        Me.Bfin.Text = ">>"
        Me.Bfin.UseVisualStyleBackColor = True
        '
        'Batras
        '
        Me.Batras.Location = New System.Drawing.Point(232, 258)
        Me.Batras.Name = "Batras"
        Me.Batras.Size = New System.Drawing.Size(38, 24)
        Me.Batras.TabIndex = 13
        Me.Batras.Text = "<"
        Me.Batras.UseVisualStyleBackColor = True
        '
        'Badelante
        '
        Me.Badelante.Location = New System.Drawing.Point(357, 258)
        Me.Badelante.Name = "Badelante"
        Me.Badelante.Size = New System.Drawing.Size(38, 24)
        Me.Badelante.TabIndex = 14
        Me.Badelante.Text = ">"
        Me.Badelante.UseVisualStyleBackColor = True
        '
        'Textnreg
        '
        Me.Textnreg.BackColor = System.Drawing.Color.White
        Me.Textnreg.Enabled = False
        Me.Textnreg.Location = New System.Drawing.Point(276, 261)
        Me.Textnreg.Name = "Textnreg"
        Me.Textnreg.ReadOnly = True
        Me.Textnreg.Size = New System.Drawing.Size(75, 20)
        Me.Textnreg.TabIndex = 19
        Me.Textnreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(83, 338)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(146, 27)
        Me.BNuevo.TabIndex = 8
        Me.BNuevo.Text = "Alta - Nueva Comunidad"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BBorrar
        '
        Me.BBorrar.Location = New System.Drawing.Point(256, 338)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(146, 27)
        Me.BBorrar.TabIndex = 9
        Me.BBorrar.Text = "Baja - Comunidad"
        Me.BBorrar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(421, 338)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 27)
        Me.BGuardar.TabIndex = 10
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'TBalta
        '
        Me.TBalta.Location = New System.Drawing.Point(153, 203)
        Me.TBalta.Name = "TBalta"
        Me.TBalta.Size = New System.Drawing.Size(74, 20)
        Me.TBalta.TabIndex = 20
        '
        'TBbaja
        '
        Me.TBbaja.Location = New System.Drawing.Point(470, 206)
        Me.TBbaja.Name = "TBbaja"
        Me.TBbaja.Size = New System.Drawing.Size(74, 20)
        Me.TBbaja.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha Baja:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(229, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'CalendarioMes1
        '
        Me.CalendarioMes1.Location = New System.Drawing.Point(352, 203)
        Me.CalendarioMes1.Name = "CalendarioMes1"
        Me.CalendarioMes1.TabIndex = 24
        Me.CalendarioMes1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 455)
        Me.Controls.Add(Me.CalendarioMes1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBbaja)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBalta)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BBorrar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.Textnreg)
        Me.Controls.Add(Me.Badelante)
        Me.Controls.Add(Me.Batras)
        Me.Controls.Add(Me.Bfin)
        Me.Controls.Add(Me.Binicio)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.Textvplanta)
        Me.Controls.Add(Me.Textnplantas)
        Me.Controls.Add(Me.Texttvecinos)
        Me.Controls.Add(Me.Textnum)
        Me.Controls.Add(Me.Textcalle)
        Me.Controls.Add(Me.Textcod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS COMUNIDAD DE VECINOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Textcod As System.Windows.Forms.TextBox
    Friend WithEvents Textcalle As System.Windows.Forms.TextBox
    Friend WithEvents Textnum As System.Windows.Forms.TextBox
    Friend WithEvents Texttvecinos As System.Windows.Forms.TextBox
    Friend WithEvents Textnplantas As System.Windows.Forms.TextBox
    Friend WithEvents Textvplanta As System.Windows.Forms.TextBox
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents Binicio As System.Windows.Forms.Button
    Friend WithEvents Bfin As System.Windows.Forms.Button
    Friend WithEvents Batras As System.Windows.Forms.Button
    Friend WithEvents Badelante As System.Windows.Forms.Button
    Friend WithEvents Textnreg As System.Windows.Forms.TextBox
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents BBorrar As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents TBalta As System.Windows.Forms.TextBox
    Friend WithEvents TBbaja As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarioMes1 As System.Windows.Forms.MonthCalendar
End Class
