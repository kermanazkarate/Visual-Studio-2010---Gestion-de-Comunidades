Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TBcomunidad.Text = miComunidad

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form1.BringToFront()
        Form1.Enabled = True
        Close()
    End Sub
End Class