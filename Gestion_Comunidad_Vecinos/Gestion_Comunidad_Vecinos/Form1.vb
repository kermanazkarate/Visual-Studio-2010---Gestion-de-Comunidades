Public Class FInicio

    Private Sub FInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c1, c2 As String

        Me.Enabled = True

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

        frm.ShowDialog()

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

            If miComunidad.Equals(crtdo) Then
                codComunidad = CInt(ds.Tables("comunidad").Rows(i).Item("codcomunidad"))
                ' MsgBox("codComunidad: " & codComunidad)
            End If

        Next


    End Sub

End Class
