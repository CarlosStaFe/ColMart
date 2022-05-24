Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmListaSaldoPago
    Dim matricula, apelnomb, estado, detalle, fechades, fechahas, dd, mm, yyyy, titulo As String
    Dim pos1, pos2 As Integer
    Dim debe, haber, saldo As Double
    Private da As New MySqlDataAdapter

    Private Sub frmListaSaldoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        rbtnSaldos.Checked = True
        cmbEstado.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0
        CargarCombo()
        cmbConcepto.SelectedIndex = 0

    End Sub

    Private Sub rbtnSaldos_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbtnSaldos.CheckedChanged

        If rbtnSaldos.Checked = True Then
            dtpDesde.Enabled = False
        Else
            dtpDesde.Enabled = True
        End If

    End Sub

    Private Sub btnFiltrar_Click_1(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        titulo = "Listado de Matriculados - "

        comando = New MySqlCommand("DELETE FROM debehaber ", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        If rbtnPagos.Checked Then
            fechades = dtpDesde.Text
            pos1 = InStr(1, fechades, "/")
            pos2 = InStr(pos1 + 1, fechades, "/")
            If pos1 > 0 Then
                dd = Mid(fechades, 1, pos1 - 1)
                mm = Mid(fechades, pos1 + 1, ((pos2 - 1) - pos1))
                yyyy = Mid(fechades, pos2 + 1, 4)
            End If
            fechades = yyyy & "-" & mm & "-" & dd
        Else
            fechades = "2021-06-30"
        End If

        fechahas = dtpHasta.Text
        pos1 = InStr(1, fechahas, "/")
        pos2 = InStr(pos1 + 1, fechahas, "/")
        If pos1 > 0 Then
            dd = Mid(fechahas, 1, pos1 - 1)
            mm = Mid(fechahas, pos1 + 1, ((pos2 - 1) - pos1))
            yyyy = Mid(fechahas, pos2 + 1, 4)
        End If
        fechahas = yyyy & "-" & mm & "-" & dd

        If rbtnSaldos.Checked Then
            comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                    & "WHERE ctasctes.EstadoCC = 'PENDIENTE' "
            titulo = titulo & "SALDOS * "
            If cmbEstado.Text <> "TODOS" Then
                comando.CommandText = comando.CommandText & " AND matriculados.EstadoMatri = '" & cmbEstado.Text & "' "
                titulo = titulo & "Estado " & cmbEstado.Text & " * "
            Else
                titulo = titulo & "Estado: TODOS * "
            End If
            comando.CommandText = comando.CommandText & " AND ctasctes.FecPagoCC <= '" & fechahas & "' "
            titulo = titulo & "Hasta: " & dtpHasta.Text & " * "
            If cmbConcepto.Text <> "TODOS" Then
                comando.CommandText = comando.CommandText & " AND ctasctes.DetalleCC = '" & cmbConcepto.Text & "' "
            Else
                titulo = titulo & "Concepto: TODOS * "
            End If
            If cmbOrden.Text = "MATRICULA" Then
                comando.CommandText = comando.CommandText & " ORDER BY ctasctes.NroCC "
                titulo = titulo & "Orden: MATRÍCULA * "
            Else
                comando.CommandText = comando.CommandText & " ORDER BY matriculados.ApelNombMatri"
                titulo = titulo & "Orden: APELLIDO * "
            End If
        End If

        If rbtnPagos.Checked Then
            comando.CommandText = "SELECT * FROM ctasctes INNER JOIN matriculados ON ctasctes.NroCC = matriculados.NroMatri " _
                                    & "WHERE ctasctes.EstadoCC <> 'PENDIENTE' "
            titulo = titulo & "PAGOS * "
            If cmbEstado.Text <> "TODOS" Then
                comando.CommandText = comando.CommandText & " AND matriculados.EstadoMatri = '" & cmbEstado.Text & "' "
                titulo = titulo & "Estado " & cmbEstado.Text & " * "
            Else
                titulo = titulo & "Estado: TODOS * "
            End If
            comando.CommandText = comando.CommandText & "AND ctasctes.FecPagoCC >= '" & fechades & "' AND ctasctes.FecPagoCC <= '" & fechahas & "' "
            titulo = titulo & "Desde: " & dtpDesde.Text & " * " & "Hasta: " & dtpHasta.Text & " * "
            If cmbConcepto.Text <> "TODOS" Then
                comando.CommandText = comando.CommandText & " AND ctasctes.DetalleCC = '" & cmbConcepto.Text & "' "
            Else
                titulo = titulo & "Concepto: TODOS * "
            End If
            If cmbOrden.Text = "MATRICULA" Then
                comando.CommandText = comando.CommandText & " ORDER BY ctasctes.NroCC "
                titulo = titulo & "Orden: MATRÍCULA * "
            Else
                comando.CommandText = comando.CommandText & " ORDER BY matriculados.ApelNombMatri "
                titulo = titulo & "Orden: APELLIDO * "
            End If
        End If

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows
            comando = New MySqlCommand("INSERT INTO debehaber VALUES(@matricula, @apelnomb, @estado, @detalle, @periodo, @debe, @haber, @saldo, @total)", conexion)
            comando.Parameters.AddWithValue("@matricula", CStr(row("NroMatri")))
            comando.Parameters.AddWithValue("@apelnomb", CStr(row("ApelNombMatri")))
            comando.Parameters.AddWithValue("@estado", CStr(row("EstadoMatri")))
            comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleCC")))
            comando.Parameters.AddWithValue("@periodo", CStr(row("PeriodoCC")))
            If rbtnSaldos.Checked Then
                comando.Parameters.AddWithValue("@debe", row("RestoCC"))
            Else
                comando.Parameters.AddWithValue("@debe", 0)
            End If
            If rbtnPagos.Checked Then
                comando.Parameters.AddWithValue("@haber", row("HaberCC"))
            Else
                comando.Parameters.AddWithValue("@haber", 0)
            End If
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@total", 0)
            comando.ExecuteNonQuery()
        Next

        Dim frm As New frmDetallado
        frm.txtDetalle.Text = titulo
        frm.ShowDialog()

    End Sub

    Private Sub CargarCombo()

        comando = New MySqlCommand("SELECT DISTINCT DetalleCodDeb FROM CodDebito ORDER BY DetalleCodDeb ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            cmbConcepto.Items.Add("TODOS")
            While dr.Read
                cmbConcepto.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class