Public Class FListados

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case listado
            Case "vecinos"
                TabControl1.SelectedIndex = 0
            Case "gastos"
                TabControl1.SelectedIndex = 1
            Case "ingresos"
                TabControl1.SelectedIndex = 2
            Case Else
                TabControl1.SelectedIndex = 0
        End Select
    End Sub

    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click
        FInicio.Enabled = True
        Close()
    End Sub

    Private Sub TabControl1_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected

        Select Case TabControl1.SelectedIndex
            Case 0  ' Vecinos
                CargarVecinos()
            Case 1  ' Gastos
                CargarGastos()
            Case 2  ' Ingresos
                CargarIngresos()
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    Private Sub CargarVecinos()
        MsgBox("VECINOS")
    End Sub

    Private Sub CargarGastos()
        MsgBox("GASTOS")
    End Sub

    Private Sub CargarIngresos()
        MsgBox("INGRESOS")
    End Sub

End Class