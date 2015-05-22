Public Class FInicio

    Private Sub FInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c1, c2 As String

        'MsgBox("Evento Load formulario 1")

        Me.Enabled = True

        ds.Clear()

        ConectarComunidad()

        ' Se habilita el combobox con la lista de todas las comunidades de vecions que estan dadas de alta en la aplicacion
        For i = 0 To MaxRows - 1
            c1 = CStr(ds.Tables("comunidad").Rows(i).Item("calle"))
            c2 = CStr(ds.Tables("comunidad").Rows(i).Item("numero"))
            CBComunidad.Items.Add("C/ " & c1 & " " & c2)
        Next

        CBComunidad.Text = "Seleccionar una comunidad de vecinos"

    End Sub
    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Application.Exit()
    End Sub

    Private Sub BABMCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BABMCV.Click
        'forma modal de abrir un formulario
        Dim frm As New FAltaCV


        'Me.Close()

        frm.ShowDialog()

        'frm.Show()


    End Sub

    Private Sub BEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEntrar.Click

        'forma modal de abrir un formulario
        Dim frm As New FMenuCV()

        If CBComunidad.Text = "Seleccionar una comunidad de vecinos" Then
            MsgBox("Debe seleccionar una Comunidad de Vecinos", CType(0, MsgBoxStyle), "Atención!!!")
        Else
            frm.ShowDialog()
        End If

    End Sub

    Private Sub CBComunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBComunidad.SelectedIndexChanged

        Dim c1, c2, crtdo As String

        miComunidad = Me.CBComunidad.SelectedItem.ToString

        For i = 0 To MaxRows - 1

            c1 = CStr(ds.Tables("comunidad").Rows(i).Item("calle"))
            c2 = CStr(ds.Tables("comunidad").Rows(i).Item("numero"))

            crtdo = c1 & " " & c2

            'MsgBox(miComunidad & " = " & crtdo)

            If miComunidad = "C/ " & crtdo Then
                codComunidad = CInt(ds.Tables("comunidad").Rows(i).Item("codcomunidad"))
                'MsgBox("codComunidad: " & codComunidad)
            End If

        Next


    End Sub

    'Private Sub FInicio_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged

    '    '    Dim ll As Integer
    '    Dim c1, c2 As String


    '    MsgBox("Estado de Formulario 1: " & Me.Enabled)

    '    '    Me.Enabled = True

    '    '    ds.Clear()

    '    '    ll = ds.Tables("comunidad").Rows.Count
    '    '    'MsgBox("Nº filas comunidad: " & ll)
    '    MaxRows = ds.Tables("comunidad").Rows.Count
    '    MsgBox("Nº Filas: " & MaxRows)

    '    If Me.Enabled = True Then
    '        '        ConectarComunidad()

    '        ' Se habilita el combobox con la lista de todas las comunidades de vecions que estan dadas de alta en la aplicacion
    '        For i = 0 To MaxRows - 1
    '            c1 = CStr(ds.Tables("comunidad").Rows(i).Item("calle"))
    '            c2 = CStr(ds.Tables("comunidad").Rows(i).Item("numero"))
    '            CBComunidad.Items.Add("C/ " & c1 & " " & c2)
    '        Next

    '        CBComunidad.Text = "Seleccionar una comunidad de vecinos"
    '    End If


    'End Sub

    'Private Sub FInicio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
    '    MsgBox("Formulario 1 Activo")
    'End Sub

    'Private Sub FInicio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
    '    MsgBox("Abandono Formulario 1 ")
    'End Sub

    'Private Sub FInicio_AutoValidateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.AutoValidateChanged
    '    MsgBox("cambia la propiedad AutoValidateChange de Formulario 1 ")
    'End Sub

    'Private Sub FInicio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
    '    MsgBox("Formulario 1 ya no es activo")
    'End Sub

    'Private Sub FInicio_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    MsgBox("Formulario 1 Activado")
    'End Sub

    'Private Sub FInicio_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
    '    MsgBox("Formulario 1 Deshactivado")
    'End Sub
End Class
