<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FListados
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewVecinos = New System.Windows.Forms.DataGridView()
        Me.codvecino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.letra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccomunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewProveedor = New System.Windows.Forms.DataGridView()
        Me.codproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personacontacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poblacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridViewGastos = New System.Windows.Forms.DataGridView()
        Me.codgastos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importeg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conceptog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comunidadg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridViewIngresos = New System.Windows.Forms.DataGridView()
        Me.codingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conceptoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cvecino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.TBComunidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewVecinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(1, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1116, 480)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewVecinos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1108, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "De Vecinos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewVecinos
        '
        Me.DataGridViewVecinos.AllowUserToAddRows = False
        Me.DataGridViewVecinos.AllowUserToDeleteRows = False
        Me.DataGridViewVecinos.AllowUserToOrderColumns = True
        Me.DataGridViewVecinos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridViewVecinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVecinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codvecino, Me.piso, Me.letra, Me.nombrev, Me.tel1, Me.tel2, Me.ccomunidad})
        Me.DataGridViewVecinos.Location = New System.Drawing.Point(6, 50)
        Me.DataGridViewVecinos.Name = "DataGridViewVecinos"
        Me.DataGridViewVecinos.ReadOnly = True
        Me.DataGridViewVecinos.Size = New System.Drawing.Size(1096, 398)
        Me.DataGridViewVecinos.TabIndex = 14
        '
        'codvecino
        '
        Me.codvecino.Frozen = True
        Me.codvecino.HeaderText = "Código"
        Me.codvecino.Name = "codvecino"
        Me.codvecino.ReadOnly = True
        '
        'piso
        '
        Me.piso.Frozen = True
        Me.piso.HeaderText = "Piso"
        Me.piso.Name = "piso"
        Me.piso.ReadOnly = True
        '
        'letra
        '
        Me.letra.Frozen = True
        Me.letra.HeaderText = "Letra"
        Me.letra.Name = "letra"
        Me.letra.ReadOnly = True
        '
        'nombrev
        '
        Me.nombrev.Frozen = True
        Me.nombrev.HeaderText = "Nombre"
        Me.nombrev.Name = "nombrev"
        Me.nombrev.ReadOnly = True
        '
        'tel1
        '
        Me.tel1.Frozen = True
        Me.tel1.HeaderText = "Teléfono1"
        Me.tel1.Name = "tel1"
        Me.tel1.ReadOnly = True
        '
        'tel2
        '
        Me.tel2.Frozen = True
        Me.tel2.HeaderText = "Teléfono2"
        Me.tel2.Name = "tel2"
        Me.tel2.ReadOnly = True
        '
        'ccomunidad
        '
        Me.ccomunidad.Frozen = True
        Me.ccomunidad.HeaderText = "Cod Comunidad"
        Me.ccomunidad.Name = "ccomunidad"
        Me.ccomunidad.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewProveedor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1108, 454)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "De Proveedores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewProveedor
        '
        Me.DataGridViewProveedor.AllowUserToAddRows = False
        Me.DataGridViewProveedor.AllowUserToDeleteRows = False
        Me.DataGridViewProveedor.AllowUserToOrderColumns = True
        Me.DataGridViewProveedor.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codproveedor, Me.nombrep, Me.actividad, Me.personacontacto, Me.tel, Me.fax, Me.direccion, Me.poblacion, Me.provincia})
        Me.DataGridViewProveedor.Location = New System.Drawing.Point(6, 50)
        Me.DataGridViewProveedor.Name = "DataGridViewProveedor"
        Me.DataGridViewProveedor.ReadOnly = True
        Me.DataGridViewProveedor.Size = New System.Drawing.Size(1096, 398)
        Me.DataGridViewProveedor.TabIndex = 13
        '
        'codproveedor
        '
        Me.codproveedor.Frozen = True
        Me.codproveedor.HeaderText = "código"
        Me.codproveedor.Name = "codproveedor"
        Me.codproveedor.ReadOnly = True
        '
        'nombrep
        '
        Me.nombrep.Frozen = True
        Me.nombrep.HeaderText = "Nombre"
        Me.nombrep.Name = "nombrep"
        Me.nombrep.ReadOnly = True
        '
        'actividad
        '
        Me.actividad.Frozen = True
        Me.actividad.HeaderText = "Actividad"
        Me.actividad.Name = "actividad"
        Me.actividad.ReadOnly = True
        '
        'personacontacto
        '
        Me.personacontacto.Frozen = True
        Me.personacontacto.HeaderText = "P. Contacto"
        Me.personacontacto.Name = "personacontacto"
        Me.personacontacto.ReadOnly = True
        '
        'tel
        '
        Me.tel.Frozen = True
        Me.tel.HeaderText = "Teléfono"
        Me.tel.Name = "tel"
        Me.tel.ReadOnly = True
        '
        'fax
        '
        Me.fax.Frozen = True
        Me.fax.HeaderText = "Fax"
        Me.fax.Name = "fax"
        Me.fax.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.Frozen = True
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'poblacion
        '
        Me.poblacion.Frozen = True
        Me.poblacion.HeaderText = "Población"
        Me.poblacion.Name = "poblacion"
        Me.poblacion.ReadOnly = True
        '
        'provincia
        '
        Me.provincia.Frozen = True
        Me.provincia.HeaderText = "Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridViewGastos)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1108, 454)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "De Gastos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridViewGastos
        '
        Me.DataGridViewGastos.AllowUserToAddRows = False
        Me.DataGridViewGastos.AllowUserToDeleteRows = False
        Me.DataGridViewGastos.AllowUserToOrderColumns = True
        Me.DataGridViewGastos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridViewGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codgastos, Me.nfactura, Me.importeg, Me.conceptog, Me.fechag, Me.comunidadg, Me.cproveedor})
        Me.DataGridViewGastos.Location = New System.Drawing.Point(6, 50)
        Me.DataGridViewGastos.Name = "DataGridViewGastos"
        Me.DataGridViewGastos.ReadOnly = True
        Me.DataGridViewGastos.Size = New System.Drawing.Size(1096, 398)
        Me.DataGridViewGastos.TabIndex = 12
        '
        'codgastos
        '
        Me.codgastos.HeaderText = "Código"
        Me.codgastos.Name = "codgastos"
        Me.codgastos.ReadOnly = True
        '
        'nfactura
        '
        Me.nfactura.HeaderText = "Nº Factura"
        Me.nfactura.Name = "nfactura"
        Me.nfactura.ReadOnly = True
        '
        'importeg
        '
        Me.importeg.HeaderText = "Importe (€)"
        Me.importeg.Name = "importeg"
        Me.importeg.ReadOnly = True
        '
        'conceptog
        '
        Me.conceptog.HeaderText = "Concepto"
        Me.conceptog.Name = "conceptog"
        Me.conceptog.ReadOnly = True
        '
        'fechag
        '
        Me.fechag.HeaderText = "Fecha"
        Me.fechag.Name = "fechag"
        Me.fechag.ReadOnly = True
        '
        'comunidadg
        '
        Me.comunidadg.HeaderText = "Cod. Comunidad"
        Me.comunidadg.Name = "comunidadg"
        Me.comunidadg.ReadOnly = True
        '
        'cproveedor
        '
        Me.cproveedor.HeaderText = "Cod. Proveedor"
        Me.cproveedor.Name = "cproveedor"
        Me.cproveedor.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(651, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 22)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBox2.Location = New System.Drawing.Point(430, 22)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(190, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridViewIngresos)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.ComboBox3)
        Me.TabPage4.Controls.Add(Me.ComboBox4)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1108, 454)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "De Ingresos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridViewIngresos
        '
        Me.DataGridViewIngresos.AllowUserToAddRows = False
        Me.DataGridViewIngresos.AllowUserToDeleteRows = False
        Me.DataGridViewIngresos.AllowUserToOrderColumns = True
        Me.DataGridViewIngresos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridViewIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codingreso, Me.conceptoi, Me.importei, Me.fechai, Me.cvecino})
        Me.DataGridViewIngresos.Location = New System.Drawing.Point(6, 50)
        Me.DataGridViewIngresos.Name = "DataGridViewIngresos"
        Me.DataGridViewIngresos.ReadOnly = True
        Me.DataGridViewIngresos.Size = New System.Drawing.Size(1096, 398)
        Me.DataGridViewIngresos.TabIndex = 13
        '
        'codingreso
        '
        Me.codingreso.Frozen = True
        Me.codingreso.HeaderText = "Cod. Ingreso"
        Me.codingreso.Name = "codingreso"
        Me.codingreso.ReadOnly = True
        '
        'conceptoi
        '
        Me.conceptoi.Frozen = True
        Me.conceptoi.HeaderText = "Concepto"
        Me.conceptoi.Name = "conceptoi"
        Me.conceptoi.ReadOnly = True
        '
        'importei
        '
        Me.importei.Frozen = True
        Me.importei.HeaderText = "Importe (€)"
        Me.importei.Name = "importei"
        Me.importei.ReadOnly = True
        '
        'fechai
        '
        Me.fechai.Frozen = True
        Me.fechai.HeaderText = "Fecha"
        Me.fechai.Name = "fechai"
        Me.fechai.ReadOnly = True
        '
        'cvecino
        '
        Me.cvecino.Frozen = True
        Me.cvecino.HeaderText = "Cod. Vecino"
        Me.cvecino.Name = "cvecino"
        Me.cvecino.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 22)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBox3.Location = New System.Drawing.Point(430, 22)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox3.TabIndex = 7
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(190, 21)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox4.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Año:"
        '
        'BtVolver
        '
        Me.BtVolver.Location = New System.Drawing.Point(466, 555)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(133, 23)
        Me.BtVolver.TabIndex = 10
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = True
        '
        'TBComunidad
        '
        Me.TBComunidad.BackColor = System.Drawing.Color.White
        Me.TBComunidad.Enabled = False
        Me.TBComunidad.Location = New System.Drawing.Point(436, 18)
        Me.TBComunidad.Name = "TBComunidad"
        Me.TBComunidad.Size = New System.Drawing.Size(211, 20)
        Me.TBComunidad.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Comunidad:"
        '
        'FListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 590)
        Me.Controls.Add(Me.TBComunidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtVolver)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FListados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewVecinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents BtVolver As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TBComunidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewVecinos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewGastos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewIngresos As System.Windows.Forms.DataGridView
    Friend WithEvents codproveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombrep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents personacontacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents poblacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codvecino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents letra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombrev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccomunidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codgastos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nfactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importeg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conceptog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comunidadg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cproveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conceptoi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importei As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cvecino As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
