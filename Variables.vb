﻿Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Variables
    'Variables para usar en el sistema
    Public conexion As New MySqlConnection
    Public comando As New MySqlCommand
    Public CmdBuilder As MySqlCommandBuilder
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public estado As String
    Public consulta As String
    Public fila As String
    Public detmsg As String
    Public tipomsg As String
    Public btnmsg As Integer
    Public datos As Byte
    Public senial As String
    Public fecha As String
    'Variables para controlar niveles y usuarios
    Public nivel As Integer
    Public usuario As String
    'Variables para mostrar importes
    Public importe As Double
    Public TextoConn As String
    'Public Apunt As Integer = FreeFile()

    Public Sub ConectarMySql()

        ' Abrimos el archivo y lo recorremos hasta el final, línea por línea
        'FileOpen(Apunt, "E:/Proyectos/ColMart/colmart.txt", OpenMode.Input, OpenAccess.Read)
        'Do While Not EOF(1)
        'TextoConn = LineInput(1)
        'conexion.ConnectionString = TextoConn
        'Loop
        'FileClose(Apunt)

        TextoConn = My.Computer.FileSystem.ReadAllText("E:\Proyectos\ColMart\colmart.txt")
        conexion.ConnectionString = TextoConn

        'conexion.ConnectionString = "server=DESKTOP; database=dbcolmart; user id=martillero1; password=soporte; Convert Zero Datetime=True"

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                'MsgBox("Conexión correcta", MsgBoxStyle.Critical, "Información")
            Else
                conexion.Close()
                conexion.Open()
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                'MsgBox("Conexión correcta", MsgBoxStyle.Critical, "Información")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            MsgBox("Conexión errónea", MsgBoxStyle.Critical, "Atención")
        End Try

    End Sub

    Public Sub DesconectarMySql()

        conexion.Close()

    End Sub

    Public Sub SoloNumeros(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If

    End Sub

    Public Sub FormatoMoneda(txtImporte As TextBox)

        If txtImporte.Text = String.Empty Then
            Return
        Else
            Dim valor As Decimal
            valor = Convert.ToDecimal(txtImporte.Text)
            txtImporte.Text = valor.ToString("####0.00")
        End If

    End Sub

    Public Function ArmaCodigoBarra(ByVal matricula As String, ByVal MMperiodo As String, ByVal YYperiodo As String, ByVal importe As Double, ByVal dd As String, ByVal mm As String, ByVal yy As String)

        Dim CodigoArmado As Object
        Dim CodigoBarra, DataToPrint, StrImporte, DigitoVerifica, StartCode, StopCode, cto, vencimiento, ceros, periodo, CodigoAux As String
        Dim longitud, cantidad, j, factor, suma, numero, StringLength, CurrentCharNum As Integer
        Dim calculo As Double

        CodigoArmado = ""
        CodigoBarra = ""
        CodigoAux = ""
        longitud = 0
        DataToPrint = ""
        ceros = ""

        longitud = Len(matricula)
        If longitud < 5 Then
            cantidad = 5 - longitud
            ceros = ""
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            matricula = ceros & matricula
        End If

        cto = "03"
        ceros = ""

        longitud = Len(MMperiodo)
        If longitud < 2 Then
            cantidad = 2 - longitud
            ceros = ""
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            MMperiodo = ceros & MMperiodo
        End If

        periodo = YYperiodo & MMperiodo

        vencimiento = dd & mm & yy

        StrImporte = CStr(importe * 100)
        longitud = Len(StrImporte)
        If longitud < 10 Then
            cantidad = 10 - longitud
            ceros = ""
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            StrImporte = ceros & StrImporte
        End If

        'Calculo digito verificador
        CodigoBarra = "00004241" & "0000000" & matricula & cto & periodo & "0" & vencimiento & StrImporte
        factor = 1
        suma = 0
        For j = 1 To Len(CodigoBarra)
            numero = Val(Mid(CodigoBarra, j, 1))
            suma = suma + numero * factor
            If factor = 9 Then
                factor = 3
            Else
                factor = factor + 2
            End If
        Next j
        calculo = suma / 2
        suma = Int(calculo) Mod 10
        DigitoVerifica = CStr(suma)
        CodigoBarra = "00004241" & "0000000" & matricula & cto & periodo & "0" & vencimiento & StrImporte & DigitoVerifica

        'Assign start and stop codes
        StartCode = ChrW(40)
        StopCode = ChrW(41)
        StringLength = Len(CodigoBarra)
        For j = 1 To StringLength Step 2
            'Get the value of each number pair
            CurrentCharNum = Val((Mid(CodigoBarra, j, 2)))
            'Get the ASCII value of CurrentChar
            If CurrentCharNum <= 49 Then DataToPrint = DataToPrint & ChrW(CurrentCharNum + 48)
            If CurrentCharNum >= 50 Then DataToPrint = DataToPrint & ChrW(CurrentCharNum + 142)
        Next j

        CodigoAux = CodigoBarra
        CodigoBarra = StartCode + CodigoBarra + StopCode
        'Get Printable String
        '        CodigoArmado = StartCode + DataToPrint + StopCode
        CodigoArmado = StartCode + DataToPrint + StopCode + "*" + CodigoAux

        Return CodigoArmado

    End Function

    Public Function ControlFecha(ByVal fecha As String)

        senial = 0
        If Not IsDate(fecha) Then
            fecha = ""
            detmsg = "Fecha errónea...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            senial = 1
        Else
            senial = 0
        End If

        Return senial

    End Function

    Public Function ProcesoFecha(ByVal fechainput As String)
        Dim dd, mm, yyyy, fechaaux As String
        Dim pos1, pos2 As Integer
        fechaaux = ""
        fechaaux = fechainput
        pos1 = InStr(1, fechaaux, "/")
        pos2 = InStr(pos1 + 1, fechaaux, "/")
        If pos1 > 0 Then
            dd = Mid(fechaaux, 1, pos1 - 1)
            mm = Mid(fechaaux, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechaaux, pos2 + 1, 4)
        Else
            dd = Mid(fechaaux, 7, 2)
            mm = Mid(fechaaux, 5, 2)
            yyyy = Mid(fechaaux, 1, 4)
        End If
        fechaaux = dd & "/" & mm & "/" + yyyy

        Return fechaaux

    End Function

    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "," Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec & " - - - - - - - - -"
            Else
                Letras = palabras & " - - - - - - - - -"
            End If
        Else
            Letras = ""
        End If
    End Function

End Module
