Public Class FcuotaComunidad
    '
    Private Sub FcuotaComunidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Hay que acceder a la base de datos y obtener la ultima cuota de comunidad guardada
        'Si no hay cuota (por ser la primera vez), se accede a esta ventana en modo grabar
        'sale una ventana antes para indicar que se meta la primera cuota de comunidad


        TBComunidad.Text = miComunidad

        MostrarInicial()

    End Sub


    Private Sub BtVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtVolver.Click

        'FMenuCV.Enabled = True
        Me.Close()
    End Sub

   
    Private Sub TBImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBImporte.KeyPress
        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox("El campo Importe solo admite un valor numérico", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        'botCalendario = 1

        If CalendarioMes.Visible = True Then
            CalendarioMes.Visible = False
        Else
            CalendarioMes.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Cursor = Cursors.Arrow
    End Sub

    Private Sub CalendarioMes_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes.DateChanged

        TBFechaAlta.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))

    End Sub

    Private Sub CalendarioMes_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes.DateSelected

        TBFechaAlta.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))

        CalendarioMes.Visible = False
        CalendarioMes.Cursor = Cursors.Arrow
    End Sub

    Private Sub CalendarioMes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes.MouseEnter
        CalendarioMes.Visible = True
        CalendarioMes.Cursor = Cursors.Hand
    End Sub

    Private Sub CalendarioMes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes.MouseLeave
        CalendarioMes.Visible = False
        CalendarioMes.Cursor = Cursors.Arrow
    End Sub

    Private Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificar.Click

        MostrarModificdar()

    End Sub

    Private Sub BGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGrabar.Click

        MostrarInicial()

    End Sub

    Private Sub MostrarInicial()

        TBComunidad.Enabled = False
        TBImporte.Enabled = False
        TBFechaAlta.Enabled = False
        PictureBox1.Enabled = False

        CalendarioMes.Visible = False

        BModificar.Enabled = True
        BGrabar.Enabled = False

    End Sub

    Private Sub MostrarModificdar()

        TBComunidad.Enabled = False
        TBImporte.Enabled = True
        TBFechaAlta.Enabled = False
        PictureBox1.Enabled = True

        CalendarioMes.Visible = False

        BModificar.Enabled = False
        BGrabar.Enabled = True

    End Sub



End Class