
Public Class FAltaCV

    Public nuevoReg As Boolean = False  'variable que indica si estamos en un nuevo registro en la tabla comunidad
    Public accion As String = "nada"  'esta variable tiene 4 valores: nada, alta, baja, modifica
    Public botCalendario As Integer = 0  'este variable controla que boton del calendario se pulsa
    Public estoyNreg As Integer = 0    'variable que indica cuando doy de alta, desde que nº de registro salto, para luego poder volver a es registro si cancelo



    Private Sub BVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVolver.Click
        'FInicio.BringToFront()
        FInicio.Enabled = True
        Me.Close()
    End Sub

    Private Sub FAltaCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        accion = "nada"
        MostrarSituacionInicial()
        ds.Clear()

        'BuscarUltimoCdComunidad()
        ConectarComunidad()

        If MaxRows > 0 Then
            MostrarRegistros(inc)
        Else

            'Deshabilito los botones de recorrer los registros
            habilitarAlanteAtras()

            MsgBox("No hay ninguna Comunidad de Vecinos dados de Alta en la Base de Datos", CType(0, MsgBoxStyle), "Atención!!!") 'mensaje con ventana solo ok

        End If

        TopMost = True
        FInicio.Enabled = False

    End Sub

    Private Sub BModificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificaciones.Click

        'muetro botones Aceptar y Cancelar
        mostrarAceptarCancelar()

        'Deshabilito los botones de recorrer los registros
        deshabilitarAlanteAtras()

        'habilito los campos de texto
        habilitarCamposTexto()

        'Pongo el foco del cursor en el campo calle
        Textcalle.Focus()

        'Deshabilito botones de Altas y Bajas y modificaciones
        deshabilitarAltaBajaModi()

        accion = "modifica"


    End Sub

    Private Sub Bbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBaja.Click

        'muetro botones Aceptar y Cancelar
        mostrarAceptarCancelar()

        'Deshabilito botones de Altas y Bajas y modificaciones
        deshabilitarAltaBajaModi()

        'Deshabilito los botones de recorrer los registros
        deshabilitarAlanteAtras()

        accion = "baja"

        'Habilita campo Fecha de Baja y su boton asociado
        habilitarFechaBaja()

        TBbaja.Focus()

    End Sub

    Private Sub BAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAlta.Click

        estoyNreg = inc

        'Busco el valor del último codigo de comunidad guardado en la tabla para sumarle 1 
        Textcod.Text = CStr(BuscarUltimoCdComunidad() + 1)

        ConectarComunidad()

        'muetro botones Aceptar y Cancelar
        mostrarAceptarCancelar()

        'Deshabilito botones de Altas y Bajas y modificaciones
        deshabilitarAltaBajaModi()

        'Deshabilito los botones de recorrer los registros
        deshabilitarAlanteAtras()

        'Habilito los campos de texto
        habilitarCamposTexto()

        accion = "alta"

        limpiarCamposForm2()

        'Textcod.Text = CStr(ultimoNreg + 1)

        'Textcod.Text = CStr(MaxRows + 1)
        Textnreg.Text = CStr(MaxRows + 1)

    End Sub

    Private Sub BCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click

        Select Case accion
            Case "modifica"
                'Deshabilito los campos de texto
                deshabilitarCamposTexto()

            Case "alta"

                ds.Clear()
                ConectarComunidad()

                inc = estoyNreg
                If MaxRows > 0 Then
                    MostrarRegistros(inc)
                Else

                    'Habilito los botones de recorrer los registros
                    habilitarAlanteAtras()

                    MsgBox("No hay ninguna Comunidad de Vecinos dados de Alta en la Base de Datos", CType(0, MsgBoxStyle), "Atención!!!") 'mensaje con ventana solo ok

                End If

            Case "baja"
                TBbaja.Text = ""
                'Deshabilito los campos de texto
                deshabilitarCamposTexto()

                'Habilito los botones de recorrer los registros
                habilitarAlanteAtras()
        End Select

        'botones Cancelar y Aceptar  no visibles y no habilitados
        ocultarAceptarCancelar()

        'Habilito botones de Altas y Bajas y modificaciones
        habilitarAltaBajaModi()

        'Habilito los botones de recorrer los registros
        habilitarAlanteAtras()

        accion = "nada"

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click

        Select Case accion
            Case "modifica"
                modificarDatos()
            Case "alta"
                DarDeAltaDatos()
            Case "baja"
                DarDeBajaDatos()
        End Select

        'Habilito los botones de Alta, bajas y Modificaciones
        habilitarAltaBajaModi()

        'Habilito los botones de recorrer los registros
        habilitarAlanteAtras()


        If accion = "nada" Or accion = "modifica" Then
            'botones Cancelar y Aceptar  no visibles y no habilitados
            ocultarAceptarCancelar()
        End If


    End Sub

    Private Sub modificarDatos()

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        Try
            ds.Tables("comunidad").Rows(inc).Item("codcomunidad") = CInt(Textcod.Text)
            ds.Tables("comunidad").Rows(inc).Item("calle") = Textcalle.Text
            ds.Tables("comunidad").Rows(inc).Item("numero") = CInt(Textnum.Text)
            ds.Tables("comunidad").Rows(inc).Item("nplantas") = CInt(Textnplantas.Text)
            ds.Tables("comunidad").Rows(inc).Item("vecinosplanta") = CInt(Textvplanta.Text)
            ds.Tables("comunidad").Rows(inc).Item("totalvecinos") = CInt(Texttvecinos.Text)
            ds.Tables("comunidad").Rows(inc).Item("falta") = CDate(TBalta.Text)

            da.Update(ds, "comunidad")

            MsgBox("Datos actualizados correctamente?", CType(0, MsgBoxStyle), "Aviso")

        Catch ex As Exception
            MsgBox("Error Modificación: " & ex.Message)
        End Try

    End Sub

    Private Sub DarDeAltaDatos()

        Dim cb As New OleDb.OleDbCommandBuilder(da)

        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("comunidad").NewRow

        If Textcod.Text = "" Or Textcalle.Text = "" Or Textnum.Text = "" Or Textnplantas.Text = "" Or Textvplanta.Text = "" Or Texttvecinos.Text = "" Or TBalta.Text = "" Then

            MsgBox("Debe rellenar todos los campos. No puede haber un campo vacio", CType(0, MsgBoxStyle), "Atención")

        Else

            Try
                dsNewRow.Item("codcomunidad") = CInt(Textcod.Text)
                dsNewRow.Item("calle") = CStr(Textcalle.Text)
                dsNewRow.Item("numero") = CInt(Textnum.Text)
                dsNewRow.Item("nplantas") = CInt(Textnplantas.Text)
                dsNewRow.Item("vecinosplanta") = CInt(Textvplanta.Text)
                dsNewRow.Item("totalvecinos") = CInt(Texttvecinos.Text)
                dsNewRow.Item("falta") = CDate(TBalta.Text)
                'dsNewRow.Item("fbaja") = CDate(TBbaja.Text)

                ds.Tables("comunidad").Rows.Add(dsNewRow)
                da.Update(ds, "comunidad")

                MaxRows = ds.Tables("comunidad").Rows.Count

                inc = MaxRows - 1
                Textnreg.Text = CStr(inc + 1) & " / " & CStr(MaxRows)

                MsgBox("Nuevo registro añadido a la base de datos")

            Catch ex As Exception
                MsgBox("Error Alta: " & ex.Message)
            End Try

            'Variable accion a nada para volver a ser utilizada
            accion = "nada"

            'ocultos botones Aceptar y Cancelar
            ocultarAceptarCancelar()

            'Habilito los botones de recorrer los registros
            habilitarAlanteAtras()

            'Deshabilito los campos de texto
            deshabilitarCamposTexto()


            '---CREAR VECINOS---
            'Creamos los datos de los vecinos con los datos de la nueva comunidad introducidos
            'Pasamos como parametros el Nº de plantas, Nº de vecinos por planta y Total vecinos
            CrearVecinos(CInt(Textcod.Text), CInt(Textnplantas.Text), CInt(Textvplanta.Text), CInt(Texttvecinos.Text))

        End If

    End Sub

    Private Sub DarDeBajaDatos()

        ' Dar de baja significa poner una fecha de baja y no mostrar los registros con fecha de baja

        Dim cb As New OleDb.OleDbCommandBuilder(da) ' Es obligatorio para luego usar da.Update(ds, "comunidad")

        If TBbaja.Text = "" Then

            MsgBox("Hay que introducir una fecha de baja", CType(0, MsgBoxStyle), "Atención")
            TBbaja.Focus()

        Else
            'Actualizo en ese registro la fecha de baja
            ds.Tables("comunidad").Rows(inc).Item("fbaja") = CDate(TBbaja.Text)

            da.Update(ds, "comunidad")

            MsgBox("Registro Borrado de la base de datos")

            accion = "nada"

            MostrarSituacionInicial()

            ds.Clear()

            ConectarComunidad()

            MsgBox(inc)

            MostrarRegistros(inc)

        End If

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
        BAlta.Enabled = True
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

        BAlta.Enabled = True
        BBaja.Enabled = True

    End Sub

    Private Sub Bfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bfin.Click

        If inc < MaxRows - 1 Then
            inc = MaxRows - 1
            MostrarRegistros(inc)
        End If

    End Sub

    Private Sub MostrarRegistros(ByVal p1 As Integer)

        Textnreg.Text = CStr(p1 + 1) & " / " & CStr(MaxRows)

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

    End Sub

    Private Sub limpiarCamposForm2()

        'Textcod.Text = ""
        Textcalle.Text = ""
        Textnum.Text = ""
        Texttvecinos.Text = ""
        Textnplantas.Text = ""
        Textvplanta.Text = ""
        TBalta.Text = ""
        TBbaja.Text = ""
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

        botCalendario = 1

        If CalendarioMes.Visible = True Then
            CalendarioMes.Visible = False
        Else
            CalendarioMes.Visible = True
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        botCalendario = 2

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
    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Cursor = Cursors.Arrow
    End Sub

    Private Sub CalendarioMes_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes.DateChanged

        If botCalendario = 1 Then
            TBalta.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))
        Else
            TBbaja.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))
        End If

    End Sub

    Private Sub CalendarioMes_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioMes.DateSelected
        If botCalendario = 1 Then
            TBalta.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))
        Else
            TBbaja.Text = CStr(CDate(CalendarioMes.SelectionRange.Start))
        End If
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

    Private Sub MostrarSituacionInicial()

        'botones Cancelar y Aceptar no visibles y no habilitados
        ocultarAceptarCancelar()

        'Deshabilita los campos de texto del formulario
        deshabilitarCamposTexto()

        Textnreg.Enabled = False  'muestra el nº de registro que se esta mostrando

        'Habilito los botones de recorrer los registros
        habilitarAlanteAtras()

        'Habilito botones de Altas y Bajas y modificaciones
        habilitarAltaBajaModi()

        'Limpiar campo fecha de baja
        TBbaja.Text = ""

    End Sub

    Private Sub deshabilitarCamposTexto()
        'Campos que se habilitan
        Textcod.Enabled = False
        Textcalle.Enabled = False
        Textnum.Enabled = False
        Textnplantas.Enabled = False
        Textvplanta.Enabled = False
        Texttvecinos.Enabled = False
        TBalta.Enabled = False
        PictureBox1.Enabled = False
        TBbaja.Enabled = False
        PictureBox2.Enabled = False
    End Sub

    Private Sub habilitarCamposTexto()
        'Campos que se habilitan
        Textcod.Enabled = False
        Textcalle.Enabled = True
        Textnum.Enabled = True
        Textnplantas.Enabled = True
        Textvplanta.Enabled = True
        Texttvecinos.Enabled = True

        TBalta.Enabled = False

        PictureBox1.Enabled = True
        TBbaja.Enabled = False
        PictureBox2.Enabled = False

        ' El foco lo pongo en el campo calle
        Textcalle.Focus()

    End Sub

    Private Sub deshabilitarAltaBajaModi()

        'Deshabilito botones de Altas y Bajas y modificaciones
        BAlta.Enabled = False
        BBaja.Enabled = False
        BModificaciones.Enabled = False
    End Sub

    Private Sub habilitarAltaBajaModi()

        'Deshabilito botones de Altas y Bajas y modificaciones
        BAlta.Enabled = True
        BBaja.Enabled = True
        BModificaciones.Enabled = True
    End Sub

    Private Sub mostrarAceptarCancelar()
        'botones Cancelar y Aceptar  no visibles y no habilitados
        BAceptar.Visible = True
        BAceptar.Enabled = True

        BCancelar.Visible = True
        BCancelar.Enabled = True

    End Sub

    Private Sub ocultarAceptarCancelar()
        'botones Cancelar y Aceptar  no visibles y no habilitados
        BAceptar.Visible = False
        BAceptar.Enabled = False

        BCancelar.Visible = False
        BCancelar.Enabled = False

    End Sub

    Private Sub habilitarAlanteAtras()
        'Se deshabilitan los botones para moverse entre los registros
        Binicio.Enabled = True
        Batras.Enabled = True
        Badelante.Enabled = True
        Bfin.Enabled = True

    End Sub

    Private Sub deshabilitarAlanteAtras()
        'Se deshabilitan los botones para moverse entre los registros
        Binicio.Enabled = False
        Batras.Enabled = False
        Badelante.Enabled = False
        Bfin.Enabled = False

    End Sub

    Private Sub habilitarFechaBaja()
        'Habilita campo de fecha de bajo y boton asociado
        TBbaja.Enabled = False
        PictureBox2.Enabled = True

    End Sub

    Private Sub deshabilitarFechaBaja()
        'Habilita campo de fecha de bajo y boton asociado
        TBbaja.Enabled = False
        PictureBox2.Enabled = True

    End Sub

End Class