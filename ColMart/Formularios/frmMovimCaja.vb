'*******************************************************************************
'* PANTALLA DE MOVIMIENTOS DE CAJA CHICA                                       *
'*******************************************************************************
Imports System.Drawing

Public Class frmMovimCaja
    Dim fechacaja, NombreArchivo As String
    Dim linea, contador, flag As Integer

    Private Sub frmMovimCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CajaTableAdapter.Fill(DbcolmartDataSet.caja)
        dgvMovim.DataSource = Nothing
        ControlApertura()
        contador = 0
        flag = 0
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
            txtDetalle.Visible = True
            txtDetalle.Text = "*** APERTURA DE CAJA ***"
            cmbTipoMovim.Enabled = False
            cmbTipoMovim.Text = "INGRESO"
            cmbFormaMov.Enabled = False
            cmbFormaMov.Text = "EFECTIVO"
            txtImporte.Focus()
            btnAgregar.Visible = True
            btnLimpiar.Visible = True
            lblDetalle.Visible = True
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

        If cmbTipoMovim.Text = "DEPOSITO" Then
            GrabarDeposito()
        End If

        If flag = 0 Then
            comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfer ,@obs, @estado)", conexion)
            comando.Parameters.AddWithValue("@fecha", fechacaja)
            If cmbTipoMovim.Text = "DEPOSITO" Then
                txtDetalle.Text = "DEPOSITO BANCO NRO. " + txtNroDeposito.Text
                comando.Parameters.AddWithValue("@detalle", txtDetalle.Text)
            Else
                comando.Parameters.AddWithValue("@detalle", txtDetalle.Text)
            End If
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

        End If

        CalcularSaldo()
        LimpiarIngresos()
        flag = 0

    End Sub

    Private Sub GrabarDeposito()

        comando = New MySqlCommand("SELECT * FROM depositos WHERE NroDepo = '" & txtNroDeposito.Text & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows = 0 Then
            dr.Close()
            dr.Dispose()
            comando = New MySqlCommand("INSERT INTO depositos VALUES(@id, @nrodeposito, @importe, @fecha)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@nrodeposito", txtNroDeposito.Text)
            comando.Parameters.AddWithValue("@importe", txtImporte.Text)
            comando.Parameters.AddWithValue("@fecha", fechacaja)
            comando.ExecuteNonQuery()
        Else
            detmsg = "DEPÓSITO EXISTENTE...!!! Cargado el --> " + fechacaja
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            flag = 1
            dr.Close()
            dr.Dispose()
        End If

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

            If dgvMovim.Rows.Count > 0 Then
                For Each Fila As DataGridViewRow In dgvMovim.Rows
                    If Fila.Cells(4).Value > 0 Then
                        Fila.DefaultCellStyle.ForeColor = Color.Bisque
                    End If
                    If Fila.Cells(3).Value < 0 Then
                        Fila.DefaultCellStyle.ForeColor = Color.Aqua
                    End If
                Next
            End If

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
        txtDetalle.Visible = False
        lblDetalle.Visible = False
        txtImporte.Text = ""
        txtObs.Text = ""
        cmbTipoMovim.Text = ""
        cmbFormaMov.Text = ""
        txtNroDeposito.Text = ""
        txtNroDeposito.Visible = False
        lblNroDeposito.Visible = False
        cmbTipoMovim.Enabled = True
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
            comando = New MySqlCommand("DELETE FROM caja WHERE DetalleCaja = '" & dgvMovim.CurrentRow.Cells(2).Value & "'", conexion)
            comando.ExecuteNonQuery()
        Else
            dgvMovim.CurrentRow.Cells(0).Value = ""
            dgvMovim.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
        CalcularSaldo()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        archivoBackup = "E:\DBColMart\Backup\dbcolmart.sql" & "_" & Today.Date.ToString("dd-MM-yyyy") & "_" & TimeOfDay.ToString("hhmm") & "_(A).sql"

        ProcesoBackup()

        frmPrintCaja.ShowDialog()

        comando = New MySqlCommand("UPDATE caja SET EstadoCaja = 'CERRADA'", conexion)
        comando.ExecuteNonQuery()

        Try
            comando = New MySqlCommand("DELETE FROM caja", conexion)
            dr = comando.ExecuteReader
            dr.Close()

            AbrirCaja()

            archivoBackup = "E:\DBColMart\Backup\dbcolmart.sql" & "_" & Today.Date.ToString("dd-MM-yyyy") & "_" & TimeOfDay.ToString("hhmm") & "_(D).sql"

            ProcesoBackup()

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

    Private Sub cmbTipoMovim_LostFocus(sender As Object, e As EventArgs) Handles cmbTipoMovim.LostFocus

        If cmbTipoMovim.Text = "DEPOSITO" Then
            txtDetalle.Visible = False
            lblDetalle.Visible = False
            txtDetalle.Enabled = False
            txtNroDeposito.Visible = True
            lblNroDeposito.Visible = True
            txtNroDeposito.Enabled = True
            cmbFormaMov.Text = "EFECTIVO"
            txtNroDeposito.Focus()
        Else
            txtDetalle.Visible = True
            lblDetalle.Visible = True
            txtDetalle.Enabled = True
            txtNroDeposito.Visible = False
            lblNroDeposito.Visible = False
            txtNroDeposito.Enabled = False
            txtDetalle.Focus()
        End If
    End Sub

    Private Sub AbrirCaja()

        comando = New MySqlCommand("INSERT INTO caja VALUES(@fecha, @detalle, @debe, @haber, @saldo, @efectivo, @tarjeta, @transfer ,@obs, @estado)", conexion)

        comando.Parameters.AddWithValue("@fecha", fechacaja)
        comando.Parameters.AddWithValue("@detalle", "*** APERTURA DE CAJA ***")
        comando.Parameters.AddWithValue("@debe", 0)
        comando.Parameters.AddWithValue("@haber", txtImporte.Text)
        comando.Parameters.AddWithValue("@saldo", txtImporte.Text)
        comando.Parameters.AddWithValue("@efectivo", txtImporte.Text)
        comando.Parameters.AddWithValue("@tarjeta", 0)
        comando.Parameters.AddWithValue("@transfer", 0)
        comando.Parameters.AddWithValue("@obs", "*** CIERRE DEL DÍA: " + txtFechaHoy.Text + " ***")
        comando.Parameters.AddWithValue("@estado", "ABIERTA")

        comando.ExecuteNonQuery()

    End Sub

End Class