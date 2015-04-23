Public Class FMenuCV

    Private Sub FMenuCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TBcomunidad.Text = miComunidad

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FInicio.BringToFront()
        FInicio.Enabled = True
        Close()
    End Sub

End Class