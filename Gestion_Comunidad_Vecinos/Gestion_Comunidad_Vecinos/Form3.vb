Public Class FMenuCV


    Private Sub FMenuCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TBcomunidad.Text = miComunidad

        'Selecciono el primer botón de la lista en pantalla, por defecto
        BtCuotaComunidad.Select()

    End Sub

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        FInicio.Enabled = True
        Close()
    End Sub

    Private Sub BtCuotaComunidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCuotaComunidad.Click
        'forma modal de abrir un formulario
        Dim frm As New FcuotaComunidad()

        frm.ShowDialog()

    End Sub

    Private Sub BtAdminComunidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAdminComunidad.Click

        'forma modal de abrir un formulario
        Dim frm As New FAdminComunidad()

        frm.ShowDialog()

    End Sub

    Private Sub BtVecinosComunidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVecinosComunidad.Click

        'forma modal de abrir un formulario
        Dim frm As New FVecinosComunidad()

        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'forma modal de abrir un formulario
        Dim frm As New FProvComunidad()

        frm.ShowDialog()

    End Sub

    Private Sub BtAnadirGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnadirGasto.Click
        'forma modal de abrir un formulario
        Dim frm As New FAnadirGastos()

        frm.ShowDialog()

    End Sub

    Private Sub BtAnadirIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnadirIngreso.Click
        'forma modal de abrir un formulario
        Dim frm As New FAnadirIngresos()

        frm.ShowDialog()
    End Sub

    Private Sub BVecinos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVecinos.Click
        'forma modal de abrir un formulario
        Dim frm As New FListados()

        listado = "vecinos"

        frm.ShowDialog()
    End Sub

    Private Sub BGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGastos.Click
        'forma modal de abrir un formulario
        Dim frm As New FListados()

        listado = "gastos"

        frm.ShowDialog()
    End Sub

    Private Sub BIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIngresos.Click
        'forma modal de abrir un formulario
        Dim frm As New FListados()

        listado = "ingresos"

        frm.ShowDialog()
    End Sub

    Private Sub BProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BProveedores.Click
        'forma modal de abrir un formulario
        Dim frm As New FListados()

        listado = "proveedor"

        frm.ShowDialog()
    End Sub
End Class