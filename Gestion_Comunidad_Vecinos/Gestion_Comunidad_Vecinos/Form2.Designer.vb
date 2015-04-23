<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAltaCV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAltaCV))
        Me.BVolver = New System.Windows.Forms.Button()
        Me.Binicio = New System.Windows.Forms.Button()
        Me.Bfin = New System.Windows.Forms.Button()
        Me.Batras = New System.Windows.Forms.Button()
        Me.Badelante = New System.Windows.Forms.Button()
        Me.Textnreg = New System.Windows.Forms.TextBox()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BBaja = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.CalendarioMes1 = New System.Windows.Forms.MonthCalendar()
        Me.CalendarioMes2 = New System.Windows.Forms.MonthCalendar()
        Me.Textcod = New System.Windows.Forms.TextBox()
        Me.Textnum = New System.Windows.Forms.TextBox()
        Me.Texttvecinos = New System.Windows.Forms.TextBox()
        Me.Textcalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textnplantas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textvplanta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBalta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBbaja = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.Location = New System.Drawing.Point(328, 592)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(146, 27)
        Me.BVolver.TabIndex = 1
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'Binicio
        '
        Me.Binicio.Location = New System.Drawing.Point(236, 418)
        Me.Binicio.Name = "Binicio"
        Me.Binicio.Size = New System.Drawing.Size(50, 23)
        Me.Binicio.TabIndex = 12
        Me.Binicio.Text = "<<"
        Me.Binicio.UseVisualStyleBackColor = True
        '
        'Bfin
        '
        Me.Bfin.Location = New System.Drawing.Point(515, 420)
        Me.Bfin.Name = "Bfin"
        Me.Bfin.Size = New System.Drawing.Size(50, 23)
        Me.Bfin.TabIndex = 15
        Me.Bfin.Text = ">>"
        Me.Bfin.UseVisualStyleBackColor = True
        '
        'Batras
        '
        Me.Batras.Location = New System.Drawing.Point(302, 418)
        Me.Batras.Name = "Batras"
        Me.Batras.Size = New System.Drawing.Size(38, 23)
        Me.Batras.TabIndex = 13
        Me.Batras.Text = "<"
        Me.Batras.UseVisualStyleBackColor = True
        '
        'Badelante
        '
        Me.Badelante.Location = New System.Drawing.Point(463, 420)
        Me.Badelante.Name = "Badelante"
        Me.Badelante.Size = New System.Drawing.Size(38, 23)
        Me.Badelante.TabIndex = 14
        Me.Badelante.Text = ">"
        Me.Badelante.UseVisualStyleBackColor = True
        '
        'Textnreg
        '
        Me.Textnreg.BackColor = System.Drawing.Color.White
        Me.Textnreg.Enabled = False
        Me.Textnreg.Location = New System.Drawing.Point(364, 420)
        Me.Textnreg.Name = "Textnreg"
        Me.Textnreg.ReadOnly = True
        Me.Textnreg.Size = New System.Drawing.Size(75, 20)
        Me.Textnreg.TabIndex = 19
        Me.Textnreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(148, 499)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(146, 27)
        Me.BNuevo.TabIndex = 8
        Me.BNuevo.Text = "Alta - Nueva Comunidad"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BBaja
        '
        Me.BBaja.Location = New System.Drawing.Point(328, 499)
        Me.BBaja.Name = "BBaja"
        Me.BBaja.Size = New System.Drawing.Size(146, 27)
        Me.BBaja.TabIndex = 9
        Me.BBaja.Text = "Baja - Comunidad"
        Me.BBaja.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(508, 499)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(145, 27)
        Me.BGuardar.TabIndex = 10
        Me.BGuardar.Text = "Guardar Modificaciones"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'CalendarioMes1
        '
        Me.CalendarioMes1.Location = New System.Drawing.Point(329, 182)
        Me.CalendarioMes1.Name = "CalendarioMes1"
        Me.CalendarioMes1.TabIndex = 24
        Me.CalendarioMes1.Visible = False
        '
        'CalendarioMes2
        '
        Me.CalendarioMes2.Location = New System.Drawing.Point(329, 182)
        Me.CalendarioMes2.Name = "CalendarioMes2"
        Me.CalendarioMes2.TabIndex = 26
        Me.CalendarioMes2.Visible = False
        '
        'Textcod
        '
        Me.Textcod.BackColor = System.Drawing.Color.White
        Me.Textcod.Enabled = False
        Me.Textcod.Location = New System.Drawing.Point(229, 45)
        Me.Textcod.Name = "Textcod"
        Me.Textcod.Size = New System.Drawing.Size(70, 20)
        Me.Textcod.TabIndex = 11
        '
        'Textnum
        '
        Me.Textnum.Location = New System.Drawing.Point(435, 92)
        Me.Textnum.Name = "Textnum"
        Me.Textnum.Size = New System.Drawing.Size(44, 20)
        Me.Textnum.TabIndex = 3
        '
        'Texttvecinos
        '
        Me.Texttvecinos.Location = New System.Drawing.Point(420, 157)
        Me.Texttvecinos.Name = "Texttvecinos"
        Me.Texttvecinos.Size = New System.Drawing.Size(59, 20)
        Me.Texttvecinos.TabIndex = 6
        '
        'Textcalle
        '
        Me.Textcalle.Location = New System.Drawing.Point(55, 93)
        Me.Textcalle.Name = "Textcalle"
        Me.Textcalle.Size = New System.Drawing.Size(318, 20)
        Me.Textcalle.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha Alta:"
        '
        'Textnplantas
        '
        Me.Textnplantas.Location = New System.Drawing.Point(82, 156)
        Me.Textnplantas.Name = "Textnplantas"
        Me.Textnplantas.Size = New System.Drawing.Size(56, 20)
        Me.Textnplantas.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Vecinos/Planta:"
        '
        'Textvplanta
        '
        Me.Textvplanta.Location = New System.Drawing.Point(266, 155)
        Me.Textvplanta.Name = "Textvplanta"
        Me.Textvplanta.Size = New System.Drawing.Size(44, 20)
        Me.Textvplanta.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nº Plantas:"
        '
        'TBalta
        '
        Me.TBalta.Location = New System.Drawing.Point(232, 227)
        Me.TBalta.Name = "TBalta"
        Me.TBalta.Size = New System.Drawing.Size(74, 20)
        Me.TBalta.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Vecinos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha Baja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº:"
        '
        'TBbaja
        '
        Me.TBbaja.Location = New System.Drawing.Point(232, 285)
        Me.TBbaja.Name = "TBbaja"
        Me.TBbaja.Size = New System.Drawing.Size(74, 20)
        Me.TBbaja.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calle:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(310, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(310, 286)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CalendarioMes1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CalendarioMes2)
        Me.GroupBox1.Controls.Add(Me.TBbaja)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBalta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Textvplanta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Textnplantas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Textcod)
        Me.GroupBox1.Controls.Add(Me.Textcalle)
        Me.GroupBox1.Controls.Add(Me.Textnum)
        Me.GroupBox1.Controls.Add(Me.Texttvecinos)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 346)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'FAltaCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BBaja)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.Textnreg)
        Me.Controls.Add(Me.Badelante)
        Me.Controls.Add(Me.Batras)
        Me.Controls.Add(Me.Bfin)
        Me.Controls.Add(Me.Binicio)
        Me.Controls.Add(Me.BVolver)
        Me.Name = "FAltaCV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATOS COMUNIDAD DE VECINOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents Binicio As System.Windows.Forms.Button
    Friend WithEvents Bfin As System.Windows.Forms.Button
    Friend WithEvents Batras As System.Windows.Forms.Button
    Friend WithEvents Badelante As System.Windows.Forms.Button
    Friend WithEvents Textnreg As System.Windows.Forms.TextBox
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents BBaja As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents CalendarioMes1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents CalendarioMes2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Textcod As System.Windows.Forms.TextBox
    Friend WithEvents Textnum As System.Windows.Forms.TextBox
    Friend WithEvents Texttvecinos As System.Windows.Forms.TextBox
    Friend WithEvents Textcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Textnplantas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textvplanta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBalta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBbaja As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
