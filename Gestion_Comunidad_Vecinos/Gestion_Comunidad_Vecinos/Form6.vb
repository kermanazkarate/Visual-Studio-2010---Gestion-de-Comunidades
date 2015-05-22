Public Class FVecinosComunidad

    Dim regActual As Integer

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click

        Me.Close()

    End Sub

    Private Sub FVecinosComunidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim c1, c2 As String
        Dim cod1 As Integer

        ds.Clear()

        TBComunidad.Text = miComunidad
        Textnreg.Enabled = False

        ocultarAceptarCancelar()
        DeshabilitarCampos()

        Me.Enabled = True

        'MsgBox("codComunidad: " & codComunidad)
        BuscarVecinosPorComunidad(codComunidad)

        ' Se habilita el combobox con la lista de todas las comunidades de vecions que estan dadas de alta en la aplicacion
        For i = 0 To MaxRows - 1
            c1 = CStr(ds.Tables("vecinos").Rows(i).Item("piso"))
            c2 = CStr(ds.Tables("vecinos").Rows(i).Item("letra"))
            CBvecinos.Items.Add("Piso: " & c1 & " - " & c2)

            If i = 0 Then
                cod1 = CInt(ds.Tables("vecinos").Rows(i).Item("ccomunidad"))
                CBvecinos.Text = CStr(CBvecinos.Items(i))
            End If
        Next

        regActual = 0
        CargarVecinoPorCod(regActual)

    End Sub

    Private Sub CargarVecinoPorCod(ByVal num As Integer)

        'Dim leer As String

        'MsgBox("num: " & num)

        TBcodigo.Text = CStr(ds.Tables("vecinos").Rows(num).Item("codvecino"))
        TBpiso.Text = CStr(ds.Tables("vecinos").Rows(num).Item("piso"))
        TBletra.Text = CStr(ds.Tables("vecinos").Rows(num).Item("letra"))

        'leer = CStr(ds.Tables("vecinos").Rows(num).Item("nombre"))

        'If (leer = Nothing) Then
        '    MsgBox("Nombre vacio")
        'End If
        'TBnombre.Text = CStr(ds.Tables("vecinos").Rows(num).Item("nombre"))

        'TBtel1.Text = CStr(ds.Tables("vecinos").Rows(num).Item("tel1"))
        'TBtel2.Text = CStr(ds.Tables("vecinos").Rows(num).Item("tel2"))

        Textnreg.Text = num + 1 & " / " & CStr(MaxRows)


    End Sub

    Private Sub ocultarAceptarCancelar()

        BAceptar.Visible = False
        BCancelar.Visible = False

    End Sub

    Private Sub verAceptarCancelar()

        BAceptar.Visible = True
        BCancelar.Visible = True

    End Sub

    Private Sub Bmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmodificar.Click

        verAceptarCancelar()
        habilitarCampos()

        Bmodificar.Enabled = False


    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click

        Bmodificar.Enabled = True
        MsgBox("Cambios no guardados", CType(0, MsgBoxStyle), "Aviso")
        ocultarAceptarCancelar()
        DeshabilitarCampos()

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click

        GuardarModificacion()
        ocultarAceptarCancelar()
        DeshabilitarCampos()
        Bmodificar.Enabled = True
    End Sub

    Private Sub Binicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Binicio.Click

        If regActual > 0 Then
            regActual = 0
            CargarVecinoPorCod(regActual)
            CBvecinos.Text = CStr(CBvecinos.Items(regActual))
        End If

    End Sub

    Private Sub Bfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfin.Click

        If regActual < MaxRows Then
            regActual = MaxRows - 1
            CargarVecinoPorCod(regActual)
            CBvecinos.Text = CStr(CBvecinos.Items(regActual))
        End If

    End Sub

    Private Sub Batras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Batras.Click

        If regActual > 0 Then
            regActual = regActual - 1
            CargarVecinoPorCod(regActual)
            CBvecinos.Text = CStr(CBvecinos.Items(regActual))
        End If

    End Sub

    Private Sub Badelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badelante.Click

        If regActual < MaxRows - 1 Then
            regActual = regActual + 1
            CargarVecinoPorCod(regActual)
            CBvecinos.Text = CStr(CBvecinos.Items(regActual))
        End If

    End Sub

    Private Sub GuardarModificacion()

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Try
            ds.Tables("vecinos").Rows(inc).Item("codvecino") = CInt(TBcodigo.Text)
            ds.Tables("vecinos").Rows(inc).Item("piso") = CInt(TBpiso.Text)
            ds.Tables("vecinos").Rows(inc).Item("letra") = CStr(TBletra.Text)
            ds.Tables("vecinos").Rows(inc).Item("nombre") = CStr(TBnombre.Text)
            ds.Tables("vecinos").Rows(inc).Item("tel1") = CStr(TBtel1.Text)
            ds.Tables("vecinos").Rows(inc).Item("tel2") = CStr(TBtel2.Text)
            ds.Tables("vecinos").Rows(inc).Item("ccomunidad") = CInt(codComunidad)

            da.Update(ds, "vecinos")

            MsgBox("Datos actualizados correctamente", CType(0, MsgBoxStyle), "Aviso")

        Catch ex As Exception
            MsgBox("Error Modificación: " & ex.Message)
        End Try

    End Sub

    Private Sub DeshabilitarCampos()
        TBcodigo.Enabled = False
        TBpiso.Enabled = False
        TBletra.Enabled = False
        TBnombre.Enabled = False
        TBtel1.Enabled = False
        TBtel2.Enabled = False

    End Sub

    Private Sub habilitarCampos()
        'TBcodigo.Enabled = True
        'TBpiso.Enabled = True
        'TBletra.Enabled = True
        TBnombre.Enabled = True
        TBtel1.Enabled = True
        TBtel2.Enabled = True

    End Sub

    
End Class