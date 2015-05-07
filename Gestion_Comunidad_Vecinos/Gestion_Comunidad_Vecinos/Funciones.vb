'Hay que importar estas librerias para poder utilizar la función Directory.GetCurrentDirectory()
Imports System
Imports System.IO

Module Funciones

    'Variable que indica la comunidad que selecciono
    Public miComunidad As String
    Public miNum As Integer
    Public codComunidad As Integer

    'para crear la conexión
    Public dbProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"

    'para saber donde está la BD
    Public DirectorioTrabajo As String = Directory.GetCurrentDirectory()  'Devuelve el directorio de trabajo


    'Public dbSource As String = "Data Source=D:\VBNet\UD_3\Proyecto_Final\Gestion_Comunidad_Vecinos\Comunidad_Vecinos.mdb"
    Public dbSource As String = "Data Source=" & DirectorioTrabajo & "\Comunidad_Vecinos.mdb"


    'para guardar donde se establece la conexión
    Public con As New OleDb.OleDbConnection

    'para crear el adaptador
    Public sql As String
    Public da As OleDb.OleDbDataAdapter

    'para crear el conjunto de datos, el DataSet
    Public ds As New DataSet
    'Dim ds As New DataTable()

    'para acceder a las filas en la tabla
    Public MaxRows As Integer     ' Variable que indica en nº maximo de registros o lineas
    Public inc As Integer         ' variable que indica en que registro estamos

    Public ultimoNreg As Integer   'variable que guarda el valor mayor del campo codcomundad de la BD

    'Conecto con la base de datos y saco todos los valores de una tabla
    Public Sub ConectarComunidad()

        Dim sql As String

        Try
            'conecto y abro de nuevo la base de datos
            con.ConnectionString = dbProvider & dbSource
            con.Open()

            'Solo muestros las comunidades que estan activas y no se han dado de baja
            sql = "SELECT * FROM comunidad WHERE fbaja is null  ORDER BY codcomunidad"

            da = New OleDb.OleDbDataAdapter(sql, con)

            'Llenamos el DataSet con la informacion de la tabla comunidad
            da.Fill(ds, "comunidad")  'ds es el DataSet. da es TableAdapter
            con.Close()

            'recojo el nro de filas actuales en la tabla
            MaxRows = ds.Tables("comunidad").Rows.Count

            'preparo el índice que indica en que Posición estoy
            inc = 0  ' Los registros de la base de datos empiezan en el registro 0

        Catch ex As Exception
            MsgBox("Excepción: " & ex.Message)
        End Try

        'MostrarRegistros(inc)
    End Sub

    'Me conecto a la base de datos y busco el último codcomunidad guardado
    Public Function BuscarUltimoCdComunidad() As Integer

        Dim codigo As Integer
        Dim valor As Integer

        Dim sql As String

        Try
            'conecto con la base de datos
            con.ConnectionString = dbProvider & dbSource

            'abro la base de datos
            con.Open()

            sql = "SELECT * FROM comunidad"

            da = New OleDb.OleDbDataAdapter(sql, con)

            'Llenamos el DataSet con la informacion de la tabla comunidad
            da.Fill(ds, "comunidad")  'ds es el DataSet. da es TableAdapter
            'cierro la conexión con la base de datos
            con.Close()

            'recojo el nro de filas actuales en la tabla
            MaxRows = ds.Tables("comunidad").Rows.Count

            'guardo el valor del codcomunidad mas alto que hay en la base de datos
            valor = CInt(ds.Tables("comunidad").Rows(MaxRows - 1).Item("codcomunidad"))

            ds.Clear()

        Catch ex As Exception
            MsgBox("Excepción: " & ex.Message)
        End Try

        Return codigo

    End Function


    'Me conecto a la base de datos y busco el último codcomunidad guardado
    Public Function BuscarUltimoCdVecinos() As Integer

        Dim codigo As Integer

        'para guardar donde se establece la conexión
        Dim conn As New OleDb.OleDbConnection

        'para crear el adaptador
        Dim sqll As String
        Dim daa As OleDb.OleDbDataAdapter

        'para crear el conjunto de datos, el DataSet
        Dim dss As New DataSet


        Try
            'conecto con la base de datos
            con.ConnectionString = dbProvider & dbSource

            'abro la base de datos
            conn.Open()

            sqll = "SELECT * FROM vecinos"

            daa = New OleDb.OleDbDataAdapter(sqll, conn)

            'Llenamos el DataSet con la informacion de la tabla comunidad
            daa.Fill(dss, "vecinos")  'ds es el DataSet. da es TableAdapter
            'cierro la conexión con la base de datos
            conn.Close()

            'recojo el nro de filas actuales en la tabla
            MaxRows = dss.Tables("vecinos").Rows.Count

            'preparo el índice que indica en que Posición estoy
            inc = 0  ' Los registros de la base de datos empiezan en el registro 0

        Catch ex As Exception
            MsgBox("Excepción: " & ex.Message)
        End Try

        Return codigo

    End Function

    Public Sub ConectarVecinos(ByVal comuni As String)


        'para guardar donde se establece la conexión
        Dim conn As New OleDb.OleDbConnection

        'para crear el adaptador
        Dim sqll As String
        Dim daa As OleDb.OleDbDataAdapter

        'para crear el conjunto de datos, el DataSet
        Dim dss As New DataSet


        Try
            'conecto con la base de datos
            con.ConnectionString = dbProvider & dbSource

            'abro la base de datos
            conn.Open()

            sqll = "SELECT * FROM vecinos WHERE ccomunidad = " & comuni & " ORDER BY codvecino "

            daa = New OleDb.OleDbDataAdapter(sqll, conn)

            'Llenamos el DataSet con la informacion de la tabla comunidad
            daa.Fill(dss, "vecinos")  'ds es el DataSet. da es TableAdapter
            'cierro la conexión con la base de datos
            conn.Close()

            'recojo el nro de filas actuales en la tabla
            MaxRows = dss.Tables("vecinos").Rows.Count

            'preparo el índice que indica en que Posición estoy
            inc = 0  ' Los registros de la base de datos empiezan en el registro 0

        Catch ex As Exception
            MsgBox("Excepción: " & ex.Message)
        End Try

    End Sub

    'indica si un caracter es solo de tipo número
    Public Function CaracterSoloNumeros(ByVal caracter As Char) As Boolean

        Dim rtdo As Boolean
        Dim enAscii As Integer

        enAscii = Asc(caracter)  'Asc devuelve el nº ascii de un caracter

        If enAscii < 48 Or enAscii > 57 Then  'los numeros en ascii estan entre el 48 y 57
            rtdo = False
        Else
            rtdo = True
        End If

        Return rtdo

    End Function
    ' indica si un caracter es solo de tipo letra
    Public Function CaracterSoloLetras(ByVal caracter As Char) As Boolean

        Dim rtdo As Boolean
        Dim enAscii As Integer

        enAscii = Asc(caracter) 'Asc devuelve el nº ascii de un caracter

        If (enAscii <= 65 Or enAscii >= 90) And (enAscii <= 97 Or enAscii >= 122) Then  'Letras Mayusculas: Nº 65-90 en Ascii. Minusculas: Nº 97-122 en Ascii
            rtdo = False
        Else
            rtdo = True
        End If

        Return rtdo

    End Function

    'indica si una cadena string esta formada únicamente por letras
    Public Function TextoSoloLetras(ByRef cadena As String) As Boolean

        Dim esTexto As Boolean
        Dim iLen As Integer
        Dim iCtr As Integer
        Dim sChar As String

        esTexto = False

        iLen = Len(cadena) 'guarda el nº de caracteres de un string

        If iLen > 0 Then
            For iCtr = 1 To iLen

                sChar = Mid(cadena, iCtr, 1)
                MsgBox("sChar = Mid(cadena, iCtr, 1): " & sChar)

                If Not sChar Like "[A-Za-z]" Then
                    esTexto = False
                    Exit For
                Else
                    esTexto = True
                End If

            Next

        End If

        Return esTexto

    End Function

    'Indica si una cadena string esta formada únicamente por números
    Public Function TextoSoloNumeros(ByVal cadena As String) As Boolean

        Dim esNumero As Boolean
        Dim iLen As Integer
        Dim iCtr As Integer
        Dim sChar As String

        esNumero = False

        iLen = Len(cadena) 'guarda el nº de caracteres de un string

        If iLen > 0 Then
            For iCtr = 1 To iLen

                sChar = Mid(cadena, iCtr, 1)  'guarda el caracter de la posicion ICtr en el String

                If Not sChar Like "[0-9]" Then
                    esNumero = False
                    Exit For
                Else
                    esNumero = True
                End If

            Next

        End If

        Return esNumero

    End Function

    'Indica si una cadena de tipo string está formada únicamente por letras y números
    Public Function TextoSoloLetrasyNumeros(ByVal cadena As String) As Boolean

        Dim esLetraNumero As Boolean
        Dim iLen As Integer
        Dim iCtr As Integer
        Dim sChar As String

        esLetraNumero = False

        iLen = Len(cadena)

        If iLen > 0 Then
            For iCtr = 1 To iLen
                sChar = Mid(cadena, iCtr, 1)

                If Not sChar Like "[0-9A-Za-z]" Then
                    esLetraNumero = False
                    Exit For

                Else
                    esLetraNumero = True
                End If

            Next


        End If

        Return esLetraNumero

    End Function

End Module
