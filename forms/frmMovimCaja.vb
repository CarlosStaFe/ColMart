Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Microsoft.Reporting.WinForms

Public Class frmMovimCaja
    Dim fechacaja, NombreArchivo As String
    Dim linea, contador As Integer

    Private Sub frmMovimCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.caja' Puede moverla o quitarla según sea necesario.
        Me.CajaTableAdapter.Fill(Me.DbcolmartDataSet.caja)
        dgvMovim.DataSource = Nothing
        ControlApertura()
        contador = 0
        NombreArchivo = "Caja"

    End Sub

    Private Sub ControlApertura()

        txtFechaHoy.Text = Today.Date.ToString("dd-MM-yyyy")
        fechacaja = Today.Date.ToString("yyyy-MM-dd")

        comando = New MySqlCommand("SELECT * FROM caja WHERE EstadoCaja = 'ABIERTA' ", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows = False Then
            detmsg = "CAJA NO ABIERTA para esta fecha, ABRIRLA...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            txtDetalle.Enabled = False
            txtDetalle.Text = "*** APERTURA DE CAJA ***"
            cmbTipoMovim.Enabled = False
            cmbTipoMovim.Text = "INGRESO"
            cmbFormaMov.Enabled = False
            cmbFormaMov.Text = "EFECTIVO"
            txtImporte.Focus()
            btnAgregar.Visible = True
            btnLimpiar.Visible = True
        Else
            cmbTipoMovim.Enabled = True
            txtDetalle.Enabled = True
            cmbFormaMov.Enabled = True
            btnAgregar.Visible = True
            btnLimpiar.Visible = True
            btnCerrar.Visible = True
            CalcularSaldo()
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfer ,@obs, @estado)", conexion)
        comando.Parameters.AddWithValue("@fecha", fechacaja)
        comando.Parameters.AddWithValue("@detalle", txtDetalle.Text)
        If cmbTipoMovim.Text = "INGRESO" Then
            comando.Parameters.AddWithValue("@haber", txtImporte.Text)
            comando.Parameters.AddWithValue("@debe", 0)
        Else
            txtImporte.Text = txtImporte.Text * -1
            comando.Parameters.AddWithValue("@debe", txtImporte.Text)
            comando.Parameters.AddWithValue("@haber", 0)
        End If
        comando.Parameters.AddWithValue("@saldo", txtImporte.Text)
        If cmbFormaMov.Text = "EFECTIVO" Then
            comando.Parameters.AddWithValue("@efectivo", txtImporte.Text)
            comando.Parameters.AddWithValue("@tarjeta", 0)
            comando.Parameters.AddWithValue("@transfer", 0)
        End If
        If cmbFormaMov.Text = "TARJETA" Then
            comando.Parameters.AddWithValue("@tarjeta", txtImporte.Text)
            comando.Parameters.AddWithValue("@efectivo", 0)
            comando.Parameters.AddWithValue("@transfer", 0)
        End If
        If cmbFormaMov.Text = "TRANSFERENCIA" Then
            comando.Parameters.AddWithValue("@transfer", txtImporte.Text)
            comando.Parameters.AddWithValue("@tarjeta", 0)
            comando.Parameters.AddWithValue("@efectivo", 0)
        End If
        comando.Parameters.AddWithValue("@obs", txtObs.Text)
        comando.Parameters.AddWithValue("@estado", "ABIERTA")

        comando.ExecuteNonQuery()

        CalcularSaldo()
        LimpiarIngresos()

    End Sub

    Private Sub CalcularSaldo()

        dr.Close()
        dr.Dispose()
        linea = 0

        comando.CommandText = "SELECT * FROM caja WHERE EstadoCaja = 'ABIERTA' "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        dgvMovim.DataSource = dt

        If dgvMovim.Rows.Count > 0 Then
            txtSaldo.Text = "0"
            txtEfectivo.Text = "0"
            txtTarjeta.Text = "0"
            txtTransfer.Text = "0"
            linea = 0
            For Each Fila As DataGridViewRow In dgvMovim.Rows
                If linea = 0 Then
                    txtSaldo.Text = Fila.Cells(4).Value
                    dgvMovim.CurrentRow.Cells(5).Value = txtSaldo.Text
                Else
                    txtSaldo.Text = txtSaldo.Text + Fila.Cells(3).Value + Fila.Cells(4).Value
                    dgvMovim.CurrentRow.Cells(5).Value = txtSaldo.Text
                End If
                comando = New MySqlCommand("UPDATE caja SET SaldoCaja = '" & txtSaldo.Text & "' WHERE DetalleCaja = '" & Fila.Cells(2).Value & "'", conexion)
                comando.ExecuteNonQuery()
                linea = linea + 1
                txtEfectivo.Text = txtEfectivo.Text + Fila.Cells(6).Value
                txtTarjeta.Text = txtTarjeta.Text + Fila.Cells(7).Value
                txtTransfer.Text = txtTransfer.Text + Fila.Cells(8).Value
            Next
            dr.Close()
            dr.Dispose()

            dgvMovim.DataSource = Nothing
            comando.CommandText = "SELECT * FROM caja WHERE EstadoCaja = 'ABIERTA' "
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            dgvMovim.DataSource = dt
            dgvMovim.Columns(0).ReadOnly = False
            FormatoMoneda(txtSaldo)
            FormatoMoneda(txtEfectivo)
            FormatoMoneda(txtTarjeta)
            FormatoMoneda(txtTransfer)
            dgvMovim.Refresh()

        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub LimpiarIngresos()

        txtDetalle.Text = ""
        txtImporte.Text = ""
        txtObs.Text = ""
        cmbTipoMovim.Text = ""
        cmbFormaMov.Text = ""
        cmbTipoMovim.Enabled = True
        txtDetalle.Enabled = True
        cmbFormaMov.Enabled = True
        btnAgregar.Visible = True
        btnLimpiar.Visible = True
        btnCerrar.Visible = True
        cmbTipoMovim.Focus()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarIngresos()

    End Sub

    Private Sub dgvMovim_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovim.CellDoubleClick

        If dgvMovim.CurrentRow.Cells(0).Value = "" Then
            dgvMovim.CurrentRow.Cells(0).Value = "X"
            dgvMovim.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Orange
        End If

        detmsg = "ATENCIÓN...!!! DESEA ELIMINAR ESTE MOVIMIENTO?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            'comando = New MySqlCommand("DELETE FROM caja WHERE FechaCaja = '" & fechacaja & "' AND DetalleCaja = '" & dgvMovim.CurrentRow.Cells(2).Value & "'", conexion)
            comando = New MySqlCommand("DELETE FROM caja WHERE DetalleCaja = '" & dgvMovim.CurrentRow.Cells(2).Value & "'", conexion)
            comando.ExecuteNonQuery()
        Else
            dgvMovim.CurrentRow.Cells(0).Value = ""
            dgvMovim.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
        CalcularSaldo()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        frmPrintCaja.ShowDialog()

        comando = New MySqlCommand("UPDATE caja SET EstadoCaja = 'CERRADA'", conexion)
        comando.ExecuteNonQuery()

        Try
            comando = New MySqlCommand("DELETE FROM caja", conexion)
            dr = comando.ExecuteReader
            dr.Close()

            detmsg = "Cierre Exitoso...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

        dgvMovim.DataSource = Nothing
        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class