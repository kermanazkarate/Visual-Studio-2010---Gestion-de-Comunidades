﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c1, c2 As String

        Me.Enabled = True

        ConectarBD()

        ' Se habilita el combobox con la lista de todas las comunidades de vecions que estan dadas de alta en la aplicacion
        For i = 0 To MaxRows - 1
            c1 = CStr(ds.Tables("comunidad").Rows(i).Item("calle"))
            c2 = CStr(ds.Tables("comunidad").Rows(i).Item("numero"))
            CBComunidad.Items.Add(c1 & " " & c2)
        Next

    End Sub
    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Application.Exit()
    End Sub

    Private Sub BABMCV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BABMCV.Click
        Dim frm As New Form2()
        Me.Enabled = False
        frm.Show()
    End Sub

    Private Sub BEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEntrar.Click
        Dim frm As New Form3()
        Me.Enabled = False
        frm.Show()
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