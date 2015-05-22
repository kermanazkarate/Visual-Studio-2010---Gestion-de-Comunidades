Public Class FListados

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds.Clear()

        TBComunidad.Text = miComunidad
        Select Case listado
            Case "vecinos"
                TabControl1.SelectedIndex = 0
                CargarVecinosDataGridView()
            Case "proveedor"
                TabControl1.SelectedIndex = 1
            Case "gastos"
                TabControl1.SelectedIndex = 2
            Case "ingresos"
                TabControl1.SelectedIndex = 3
            Case Else
                TabControl1.SelectedIndex = 0
        End Select
    End Sub

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        FInicio.Enabled = True
        Close()
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected

        Select Case TabControl1.SelectedIndex
            Case 0  ' Vecinos
                CargarVecinos()
            Case 1   'Proveedores
                CargarProveedores()
            Case 2  ' Gastos
                CargarGastos()
            Case 3  ' Ingresos
                CargarIngresos()
            Case Else
                'MsgBox("Error")
        End Select
    End Sub

    Private Sub CargarVecinos()
        'MsgBox("VECINOS")
    End Sub

    Private Sub CargarProveedores()
        'MsgBox("PROVEEDORES")
    End Sub

    Private Sub CargarGastos()
        'MsgBox("GASTOS")
    End Sub

    Private Sub CargarIngresos()
        'MsgBox("INGRESOS")
    End Sub

    Private Sub CargarVecinosDataGridView()

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Dim sql As String
        Dim Maxfilas As Integer
        Dim A, B, C, D, E, F, G As String

        Try
            'conecto y abro de nuevo la base de datos
            con.ConnectionString = dbProvider & dbSource
            con.Open()

            'Solo muestros las comunidades que estan activas y no se han dado de baja
            sql = "SELECT * FROM vecinos WHERE ccomunidad = " & codComunidad & " ORDER BY codvecino"

            da = New OleDb.OleDbDataAdapter(sql, con)

            'Llenamos el DataSet con la informacion de la tabla comunidad
            da.Fill(ds, "vecinos")  'ds es el DataSet. da es TableAdapter
            con.Close()

            'recojo el nro de filas actuales en la tabla
            Maxfilas = ds.Tables("vecinos").Rows.Count

        Catch ex As Exception
            MsgBox("Excepción Conectar con Vecinos: " & ex.Message)
        End Try



        For i = 0 To Maxfilas - 1

            A = CStr(ds.Tables("vecinos").Rows(i).Item("codvecino"))
            B = CStr(ds.Tables("vecinos").Rows(i).Item("piso"))
            C = CStr(ds.Tables("vecinos").Rows(i).Item("letra"))
            'D = CStr(ds.Tables("vecinos").Rows(i).Item("nombre"))
            'E = CStr(ds.Tables("vecinos").Rows(i).Item("tel1"))
            'F = CStr(ds.Tables("vecinos").Rows(i).Item("tel2"))
            G = CStr(ds.Tables("vecinos").Rows(i).Item("ccomunidad"))

            DataGridViewVecinos.Rows.Add(A, B, C, D, E, F, G)

        Next


        'DataGridViewVecinos.Rows.Add(12, 1, "A", "Kerman Azkarate", "615736000", "", 4)
    End Sub

End Class