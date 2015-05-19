Public Class FProvComunidad

    Private Sub FProvComunidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TBComunidad.Text = miComunidad

    End Sub

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click

        Me.Close()

    End Sub


End Class