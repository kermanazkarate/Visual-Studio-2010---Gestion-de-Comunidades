Public Class FAnadirGastos

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        Me.Close()
    End Sub

    Private Sub FAnadirGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBComunidad.Text = miComunidad
    End Sub
End Class