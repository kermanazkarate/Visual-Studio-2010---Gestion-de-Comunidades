
Public Class FAltaCV

    Public nuevoReg As Boolean = False  'variable que indica si estamos en un nuevo registro en la tabla comunidad

    Private Sub BVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVolver.Click
        FInicio.BringToFront()
        FInicio.Enabled = True
        Close()
    End Sub

    Private Sub FAltaCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds.Clear()

        ConectarBD()

        If MaxRows > 0 Then
            MostrarRegistros(inc)
        Else
            BNuevo.Enabled = False
            BBaja.Enabled = False
            Binicio.Enabled = False
            Batras.Enabled = False
            Badelante.Enabled = False
            Bfin.Enabled = False

            MsgBox("No hay ninguna Comunidad de Vecinos dados de Alta en la Base de Datos", CType(0, MsgBoxStyle), "Atención!!!") 'mensaje con ventana solo ok

        End If

        TopMost = True
        FInicio.Enabled = False

    End Sub

    'Borrar significa poner el campo estadoAlta con Valor No. No quiero borrar ningun registro. Quiero que la tabla comunidad sea  una tabla histórica
    Private Sub Bbajar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBaja.Click

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Dim respuesta As MsgBoxResult

        'Habilito el campo fecha de baja para meter la fecha y deshabilito el resto de campos
        Textcod.Enabled = False
        Textcalle.Enabled = False
        Textnum.Enabled = False
        Textnplantas.Enabled = False
        Textvplanta.Enabled = False
        Texttvecinos.Enabled = False
        TBalta.Enabled = False
        TBbaja.Enabled = True
        TBbaja.Focus()

        'deshabilito los botones de Alta y Baja
        BNuevo.Enabled = False
        BBaja.Enabled = False

        BGuardar.Text = "Aceptar"

        'dsNewRow.Item("fbaja") = CDate(TBbaja.Text)

        If TBbaja.Text <> "" Then

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

        Else
            MsgBox("Hay que introducir una fecha de baja", CType(0, MsgBoxStyle), "Atención!!!")
            TBbaja.Focus()

        End If



    End Sub


    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click

        Dim respuesta As MsgBoxResult
        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Dim dsNewRow As DataRow

        Dim BGuardarTexto As String

        BGuardarTexto = BGuardar.Text

        Select Case BGuardarTexto
            Case "Guardar"  'Despues de ejecutar el botón Nueva Comunidad, se pone en  Guardar para dar de alta el registro introducido. 
                dsNewRow = ds.Tables("comunidad").NewRow

                'No se puede guardar hasta que no se completen todos los campos 
                If Textcod.Text = "" Or Textcalle.Text = "" Or Textnum.Text = "" Or Textnplantas.Text = "" Or Textvplanta.Text = "" Or Texttvecinos.Text = "" Then
                    MsgBox("Hay que rellenar todos los campos", CType(0, MsgBoxStyle), "Atención!!!") ' ventana de ok
                Else
                    Try
                        dsNewRow.Item("codcomunidad") = CInt(Textcod.Text)
                        dsNewRow.Item("calle") = Textcalle.Text
                        dsNewRow.Item("numero") = CInt(Textnum.Text)
                        dsNewRow.Item("nplantas") = CInt(Textnplantas.Text)
                        dsNewRow.Item("vecinosplanta") = CInt(Textvplanta.Text)
                        dsNewRow.Item("totalvecinos") = CInt(Texttvecinos.Text)
                        dsNewRow.Item("falta") = CDate(TBalta.Text)
                        'dsNewRow.Item("fbaja") = CDate(TBbaja.Text)

                        respuesta = MsgBox("Se guardará el registro (y cambios efectuados). ¿Desea continuar?", CType(4, MsgBoxStyle), "Cuidado!!!") 'ventada de si/no

                        If respuesta = MsgBoxResult.Yes Then  'si la respuesta es si

                            'Se añade la nueva fila creada al dataset
                            ds.Tables("comunidad").Rows.Add(dsNewRow)

                            'Se actualiza el dataset
                            da.Update(ds, "comunidad")

                            'Se calcula el nº de filas que tiene ahora el dataset
                            MaxRows = ds.Tables("comunidad").Rows.Count

                            MostrarRegistros(inc)

                        Else

                            MostrarRegistros(inc)

                        End If

                        BNuevo.Enabled = True
                        BBaja.Enabled = True

                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    End Try

                    nuevoReg = False

                End If
            Case "Guardar Modificaciones"  ' Valor Guardar Modificaciones cuando se cambia el valor de algún campo. No se ejecuta los botones de Alta ni de Baja

            Case "Aceptar"  'Despues de ejecutar el botón Baja Comunidad, se pone a Aceptar para borrar el registro en curso. 

            Case Else
                'mmm
        End Select

        BGuardar.Text = "Guardar Modificaciones"

    End Sub


    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click

        nuevoReg = True


        limpiarCamposForm2()
        TBalta.Text = DateTime.Now.ToString("dd/MM/yyyy")  'calculo la fecha del sistema

        TBalta.Enabled = False
        TBbaja.Enabled = False
        BGuardar.Text = "Guardar"

        inc = MaxRows

        Textnreg.Text = CStr(inc + 1) & " / " & CStr(MaxRows + 1)

        Textcod.Text = CStr(CInt(ds.Tables("comunidad").Rows(MaxRows - 1).Item("codcomunidad").ToString) + 1)
        Textcalle.Focus()

        BNuevo.Enabled = False
        BBaja.Enabled = False

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
        BBaja.Enabled = True

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
        BBaja.Enabled = True

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
        TBalta.Text = CStr(CDate(ds.Tables("comunidad").Rows(p1).Item("falta").ToString))

        If ds.Tables("comunidad").Rows(p1).Item("fbaja").ToString <> "" Then
            TBbaja.Text = CStr(CDate(ds.Tables("comunidad").Rows(p1).Item("fbaja").ToString))
        End If

        BGuardar.Text = "Guardar Modificaciones"
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

        If CalendarioMes1.Visible = True Then
            CalendarioMes1.Visible = False
        Else
            CalendarioMes1.Visible = True
        End If

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        If CalendarioMes2.Visible = True Then
            CalendarioMes2.Visible = False
        Else
            CalendarioMes2.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Cursor = Cursors.Arrow
    End Sub
    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Cursor = Cursors.Arrow
    End Sub

    Private Sub CalendarioMes1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes1.DateChanged
        TBalta.Text = CStr(CDate(CalendarioMes1.SelectionRange.Start))
    End Sub

    Private Sub CalendarioMes1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes1.DateSelected
        CalendarioMes1.Visible = False
    End Sub

    Private Sub CalendarioMes1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes1.MouseEnter
        CalendarioMes1.Visible = True
    End Sub

    Private Sub CalendarioMes1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes1.MouseLeave
        CalendarioMes1.Visible = False
    End Sub

    Private Sub CalendarioMes2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes2.DateChanged
        TBbaja.Text = CStr(CDate(CalendarioMes2.SelectionRange.Start))
    End Sub

    Private Sub CalendarioMes2_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes2.DateSelected
        CalendarioMes2.Visible = False
    End Sub

    Private Sub CalendarioMes2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes2.MouseEnter
        CalendarioMes2.Visible = True
    End Sub

    Private Sub CalendarioMes2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioMes2.MouseLeave
        CalendarioMes2.Visible = False
    End Sub


End Class