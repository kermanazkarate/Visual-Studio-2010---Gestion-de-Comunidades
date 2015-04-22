
Public Class Form2

    Public nuevoReg As Boolean = False  'variable que indica si estamos en un nuevo registro en la tabla comunidad

    Private Sub BVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVolver.Click
        Form1.BringToFront()
        Form1.Enabled = True
        Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds.Clear()

        ConectarBD()

        If MaxRows > 0 Then
            MostrarRegistros(inc)
        Else
            BNuevo.Enabled = False
            BBorrar.Enabled = False
            Binicio.Enabled = False
            Batras.Enabled = False
            Badelante.Enabled = False
            Bfin.Enabled = False

            MsgBox("No hay ninguna Comunidad de Vecinos dados de Alta en la Base de Datos", CType(0, MsgBoxStyle), "Atención!!!") 'mensaje con ventana solo ok

        End If

        TopMost = True
        Form1.Enabled = False

    End Sub




    'Borrar significa poner el campo estadoAlta con Valor No. No quiero borrar ningun registro. Quiero que la tabla comunidad sea  una tabla histórica
    Private Sub BBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBorrar.Click

        Dim respuesta As MsgBoxResult

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        respuesta = MsgBox("Borrado de registro. ¿Desea continuar?", CType(4, MsgBoxStyle), "Cuidado!!!") ' mensaje con si/no

        If respuesta = MsgBoxResult.Yes Then
            'pongo el estado de ese registro a No (que es como borrarlo)
            ' ds.Tables("comunidad").Rows(inc).Item("falta") = "No"

            ' da.Update(ds, "comunidad")

            ' MsgBox("Registro Borrado de la base de datos")

            ' limpiarCamposForm2()
            '  ConectarBD()

            '  MostrarRegistros(inc)

        End If

    End Sub


    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click

        Dim respuesta As MsgBoxResult
        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Try
            ds.Tables("comunidad").Rows(inc).Item("codcomunidad") = CInt(Textcod.Text)
            ds.Tables("comunidad").Rows(inc).Item("calle") = Textcalle.Text
            ds.Tables("comunidad").Rows(inc).Item("numero") = CInt(Textnum.Text)
            ds.Tables("comunidad").Rows(inc).Item("nplantas") = CInt(Textnplantas.Text)
            ds.Tables("comunidad").Rows(inc).Item("vecinosplanta") = CInt(Textvplanta.Text)
            ds.Tables("comunidad").Rows(inc).Item("totalvecinos") = CInt(Texttvecinos.Text)
            ds.Tables("comunidad").Rows(inc).Item("falta") = CInt(TBalta.Text)
            'ds.Tables("comunidad").Rows(inc).Item("fbaja") = CInt(TBbaja.Text)

            respuesta = MsgBox("Se guardará el registro (y cambios efectuados). ¿Desea continuar?", CType(4, MsgBoxStyle), "Cuidado!!!") 'ventada de si/no


            ' MsgBox(rpt1)  'SI implica rpt1= 6  y NO implica rpt1 = 7

            If respuesta = MsgBoxResult.Yes Then

                da.Update(ds, "comunidad")
                MsgBox("Datos acutalizados")

                MsgBox("Registro guardado a la base de datos")

                MostrarRegistros(inc)

            Else

                MostrarRegistros(inc)

            End If

            BNuevo.Enabled = True
            BBorrar.Enabled = True

        Catch ex As Exception
            MsgBox("Hay que rellenar todos los campos antes de guardar el registro")
        End Try

    End Sub


    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click




        nuevoReg = True


        limpiarCamposForm2()
        TBalta.Text = DateTime.Now.ToString("dd/MM/yyyy")  'calculo la fecha del sistema

        TBalta.Enabled = False
        TBbaja.Enabled = False

        inc = MaxRows

        Textnreg.Text = CStr(inc + 1) & " / " & CStr(MaxRows + 1)

        Textcod.Text = CStr(CInt(ds.Tables("comunidad").Rows(MaxRows - 1).Item("codcomunidad").ToString) + 1)
        Textcalle.Focus()

        BNuevo.Enabled = False
        BBorrar.Enabled = False

    End Sub

    Private Sub Batras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Batras.Click

        Dim respuesta As MsgBoxResult

        If nuevoReg = True Then
            respuesta = MsgBox("El nuevo registro no se guarda y se pierde los datos introducidos. ¿Desea continuar?", CType(4, MsgBoxStyle), "Cuidado!!!") 'ventada de si/no

            If respuesta = MsgBoxResult.Yes Then
                If inc > 0 Then
                    inc = inc - 1
                End If

                MostrarRegistros(inc)
                nuevoReg = False
            End If

        Else
            If inc > 0 Then
                inc = inc - 1
            End If

            MostrarRegistros(inc)
        End If
        BNuevo.Enabled = True
        BBorrar.Enabled = True

    End Sub

    Private Sub Badelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badelante.Click

        ' MsgBox("inc3: " & inc)

        If inc < MaxRows - 1 Then
            inc = inc + 1
            MostrarRegistros(inc)
        End If

    End Sub

    Private Sub Binicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Binicio.Click

        Dim respuesta As MsgBoxResult

        If nuevoReg = True Then
            respuesta = MsgBox("El nuevo registro no se guarda y se pierde los datos introducidos. ¿Desea continuar?", CType(4, MsgBoxStyle), "Cuidado!!!") 'ventada de si/no

            If respuesta = MsgBoxResult.Yes Then
                inc = 0
                MostrarRegistros(inc)
                nuevoReg = False
            End If
        Else
                inc = 0
                MostrarRegistros(inc)
        End If

        BNuevo.Enabled = True
        BBorrar.Enabled = True

    End Sub

    Private Sub Bfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfin.Click

        If inc < MaxRows - 1 Then
            inc = MaxRows - 1
            MostrarRegistros(inc)
        End If

    End Sub

    Private Sub MostrarRegistros(ByVal p1 As Integer)

        Textnreg.Text = CStr(inc + 1) & " / " & CStr(MaxRows)

        Textcod.Text = ds.Tables("comunidad").Rows(p1).Item("codcomunidad").ToString
        Textcalle.Text = ds.Tables("comunidad").Rows(p1).Item("calle").ToString
        Textnum.Text = ds.Tables("comunidad").Rows(p1).Item("numero").ToString
        Texttvecinos.Text = ds.Tables("comunidad").Rows(p1).Item("totalvecinos").ToString
        Textnplantas.Text = ds.Tables("comunidad").Rows(p1).Item("nplantas").ToString
        Textvplanta.Text = ds.Tables("comunidad").Rows(p1).Item("vecinosplanta").ToString
        TBalta.Text = ds.Tables("comunidad").Rows(p1).Item("falta").ToString
        TBbaja.Text = ds.Tables("comunidad").Rows(p1).Item("fbaja").ToString

    End Sub

    Private Sub limpiarCamposForm2()

        Textcod.Text = ""
        Textcalle.Text = ""
        Textnum.Text = ""
        Texttvecinos.Text = ""
        Textnplantas.Text = ""
        Textvplanta.Text = ""
        TBalta.Text = ""
        Textnreg.Text = "0"

    End Sub

    Private Sub Textcod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textcod.KeyPress

        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox("Código: solo admite números", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If

    End Sub

    Private Sub Textnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textnum.KeyPress

        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox("Nº: solo admite números", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If

    End Sub

    Private Sub Texttvecinos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Texttvecinos.KeyPress

        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox("Total Vecinos: solo admite números", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If

    End Sub


    Private Sub Textnplantas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textnplantas.KeyPress

        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox("Nº Plantas: solo admite números", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If

    End Sub


    Private Sub Textvplanta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textvplanta.KeyPress

        Dim rtdo As Boolean

        rtdo = CaracterSoloNumeros(e.KeyChar) 'llamada a la función que comprueba si la tecla pulsada es un número

        If rtdo = False Then

            e.KeyChar = Nothing 'anulo la tecla pulsada por no ser un número
            MsgBox(" Nº Vecinos/Planta: solo admite números", CType(0, MsgBoxStyle), "Cuidado!!!") 'mensaje con ventana solo ok

        End If

    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        CalendarioMes1.Visible = True
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Cursor = Cursors.Arrow
    End Sub

    Private Sub CalendarioMes1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes1.DateChanged

    End Sub

    Private Sub CalendarioMes1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes1.MouseLeave
        CalendarioMes1.Visible
    End Sub
End Class