Public Class FAnadirIngresos

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        Me.Close()
    End Sub

    Private Sub FAnadirIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBComunidad.Text = miComunidad
    End Sub
End Class