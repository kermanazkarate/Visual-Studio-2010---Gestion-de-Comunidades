Public Class FAdminComunidad


    Private Sub FAdminComunidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Hay que meter en el comonbox CBAdministrador el listado de todos los vecinos de la comunidad de vecinos seleccionada
        ' En el comonbox se muestra juntos los siguientes campos de la base de datos: Piso, Letra, Nombre

        TBComunidad.Text = miComunidad

    End Sub
    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        Me.Close()

    End Sub


End Class