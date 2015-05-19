<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FcuotaComunidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FcuotaComunidad))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBComunidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBImporte = New System.Windows.Forms.TextBox()
        Me.TBFechaAlta = New System.Windows.Forms.TextBox()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CalendarioMes = New System.Windows.Forms.MonthCalendar()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGrabar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Comunidad:"
        '
        'TBComunidad
        '
        Me.TBComunidad.BackColor = System.Drawing.Color.White
        Me.TBComunidad.Enabled = False
        Me.TBComunidad.Location = New System.Drawing.Point(166, 68)
        Me.TBComunidad.Name = "TBComunidad"
        Me.TBComunidad.Size = New System.Drawing.Size(211, 20)
        Me.TBComunidad.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Importe (Euros):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Alta:"
        '
        'TBImporte
        '
        Me.TBImporte.BackColor = System.Drawing.Color.White
        Me.TBImporte.Location = New System.Drawing.Point(166, 120)
        Me.TBImporte.Name = "TBImporte"
        Me.TBImporte.Size = New System.Drawing.Size(130, 20)
        Me.TBImporte.TabIndex = 7
        '
        'TBFechaAlta
        '
        Me.TBFechaAlta.BackColor = System.Drawing.Color.White
        Me.TBFechaAlta.Enabled = False
        Me.TBFechaAlta.Location = New System.Drawing.Point(166, 174)
        Me.TBFechaAlta.Name = "TBFechaAlta"
        Me.TBFechaAlta.Size = New System.Drawing.Size(113, 20)
        Me.TBFechaAlta.TabIndex = 8
        '
        'BtVolver
        '
        Me.BtVolver.Location = New System.Drawing.Point(185, 321)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(133, 25)
        Me.BtVolver.TabIndex = 9
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(281, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'CalendarioMes
        '
        Me.CalendarioMes.Location = New System.Drawing.Point(300, 95)
        Me.CalendarioMes.Name = "CalendarioMes"
        Me.CalendarioMes.TabIndex = 27
        Me.CalendarioMes.Visible = False
        '
        'BModificar
        '
        Me.BModificar.Location = New System.Drawing.Point(114, 264)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(132, 26)
        Me.BModificar.TabIndex = 28
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BGrabar
        '
        Me.BGrabar.Location = New System.Drawing.Point(281, 264)
        Me.BGrabar.Name = "BGrabar"
        Me.BGrabar.Size = New System.Drawing.Size(132, 26)
        Me.BGrabar.TabIndex = 29
        Me.BGrabar.Text = "Grabar"
        Me.BGrabar.UseVisualStyleBackColor = True
        '
        'FcuotaComunidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 371)
        Me.Controls.Add(Me.BGrabar)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.CalendarioMes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtVolver)
        Me.Controls.Add(Me.TBFechaAlta)
        Me.Controls.Add(Me.TBImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBComunidad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FcuotaComunidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUOTA COMUNIDAD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBComunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBImporte As System.Windows.Forms.TextBox
    Friend WithEvents TBFechaAlta As System.Windows.Forms.TextBox
    Friend WithEvents BtVolver As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarioMes As System.Windows.Forms.MonthCalendar
    Friend WithEvents BModificar As System.Windows.Forms.Button
    Friend WithEvents BGrabar As System.Windows.Forms.Button
End Class
