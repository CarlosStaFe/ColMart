Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmCtasCtesMat
    Dim debe, haber, saldo, saldoant, pagado, resto As Decimal
    Dim detalle, comprobante, estado, id, obs, fecpago, fechaaux As String
    Dim pos1, pos2, longitud, cantidad As Integer
    Dim yyyy, mm, dd, ceros As String

    Private Sub frmCtasCtesMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.ctasctes' Puede moverla o quitarla según sea necesario.
        CtasctesTableAdapter.Fill(DbcolmartDataSet.ctasctes)
        dgvCtasctes2.DataSource = Nothing

        ConectarMySql()
        txtMatricula.Focus()

    End Sub

    Private Sub txtMatricula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatricula.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 7
            Dim frmMat7 As New frmConsMatri
            AddOwnedForm(frmMat7)
            frmMat7.ShowDialog()
            senial = 0
            LeerMatriculado()
        End If
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerMatriculado()
        End If

    End Sub

    Private Sub LeerMatriculado()

        comando.CommandText = "SELECT * FROM matriculados WHERE NroMatri = " & txtMatricula.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtApelyNomb.Text = CStr(row("ApelNombMatri"))
        Else
            txtApelyNomb.Text = ""
        End If

        SaldoCtaCte()

    End Sub

    Private Sub SaldoCtaCte()

        comando.CommandText = "SELECT * FROM ctasctes WHERE NroCC = " & txtMatricula.Text & " ORDER BY FechaCC, ItemCC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasctes2.DataSource = dt

        dgvCtasctes2.Sort(dgvCtasctes2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0
        comprobante = ""

        If dgvCtasctes2.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasctes2.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(8).Value
                    haber = Fila.Cells(9).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(10).Value = saldo
                    saldoant = saldo
                    detalle = Fila.Cells(6).Value
                    comando.CommandText = "UPDATE ctasctes SET SaldoCC = '" & saldo & "' WHERE DetalleCC = '" & detalle & "' AND NroCC = '" & txtMatricula.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(11).Value = "PENDIENTE" Or Fila.Cells(11).Value = "LIQUIDADA" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Orange
                        'Fila.Cells(11).Style.ForeColor = Color.Red
                        'Fila.Cells(11).Style.ForeColor = Color.Orange
                    End If
                    If Fila.Cells(5).Value > 1 Then
                        Fila.Cells(2).Value = DBNull.Value
                        Fila.Cells(3).Value = ""
                        Fila.Cells(4).Value = DBNull.Value
                        Fila.Cells(7).Value = DBNull.Value
                    End If
                    If Fila.Cells(13).Value = "1900-01-01" Then
                        Fila.Cells(13).Value = DBNull.Value
                    End If
                End If
            Next
        Else
            detmsg = "No posee movimientos en la Cuenta Corriente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        txtSaldo.Text = saldo
        FormatoMoneda(txtSaldo)
        dgvCtasctes2.Refresh()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        For i As Integer = 0 To dgvCtasctes2.Rows.Count - 1

            id = dgvCtasctes2.Rows(i).Cells(0).Value()
            debe = dgvCtasctes2.Rows(i).Cells(8).Value()
            haber = dgvCtasctes2.Rows(i).Cells(9).Value()
            saldo = dgvCtasctes2.Rows(i).Cells(10).Value()
            estado = dgvCtasctes2.Rows(i).Cells(11).Value()
            pagado = dgvCtasctes2.Rows(i).Cells(12).Value()
            If estado = "PENDIENTE" Then
                fecpago = "1900-01-01"
            Else
                fecpago = dgvCtasctes2.Rows(i).Cells(13).Value()
                fechaaux = fecpago
                MoverFecha()
                fecpago = yyyy + "-" + mm + "-" + dd
            End If
            resto = dgvCtasctes2.Rows(i).Cells(14).Value()
            obs = dgvCtasctes2.Rows(i).Cells(15).Value()

            comando.CommandText = "UPDATE ctasctes SET DebeCC = '" & debe & "', HaberCC = '" & haber & "', SaldoCC = '" & saldo & "', EstadoCC = '" & estado & "'," _
                                  & " PagadoCC = '" & pagado & "', FecPagoCC = '" & fecpago & "', RestoCC = '" & resto & "', ObsCC = '" & obs & "'" _
                                  & " WHERE id_CC = '" & id & "' AND NroCC = '" & txtMatricula.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtMatricula.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes2.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtMatricula.Text = ""
        txtApelyNomb.Text = ""
        txtSaldo.Text = ""
        dgvCtasctes2.DataSource = Nothing
        txtMatricula.Focus()

    End Sub

    Private Sub MoverFecha()

        pos1 = InStr(1, fechaaux, "/")
        pos2 = InStr(pos1 + 1, fechaaux, "/")
        If pos1 > 0 Then
            dd = Mid(fechaaux, 1, pos1 - 1)
            mm = Mid(fechaaux, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechaaux, pos2 + 1, 4)
        End If

        ceros = ""

        longitud = Len(dd)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            dd = ceros & dd
        End If

        ceros = ""

        longitud = Len(mm)
        If longitud < 2 Then
            cantidad = 2 - longitud
            For j = 1 To cantidad
                ceros = ceros & "0"
            Next j
            mm = ceros & mm
        End If

    End Sub

End Class