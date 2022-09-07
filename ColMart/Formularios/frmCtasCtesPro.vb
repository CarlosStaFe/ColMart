'*******************************************************************************
'* VISUALIZACIÓN DE CUENTAS CORRIENTES DE PROVEEDORES                          *
'*******************************************************************************
Imports System.Drawing

Public Class frmCtasCtesPro
    Dim debe, haber, saldo, saldoant, pagado, resto As Decimal
    Dim detalle, comprobante, estado, id, obs, fecpago, fechaaux As String

    Private Sub frmCtasCtesPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CtacteproTableAdapter.Fill(DbcolmartDataSet.ctactepro)
        dgvCtasCtes.DataSource = Nothing
        txtProveedor.Focus()

        If nivel < "4" Then
            btnActualizar.Enabled = True
        End If

    End Sub

    Private Sub CalcularCtaCte()

        comando.CommandText = "SELECT * FROM ctactepro WHERE NroCCPro = " & txtProveedor.Text & " ORDER BY FechaCCPro"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasCtes.DataSource = dt

        dgvCtasCtes.Sort(dgvCtasCtes.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(8).Value
                    haber = Fila.Cells(9).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(10).Value = saldo
                    saldoant = saldo
                    id = Fila.Cells(0).Value
                    comando.CommandText = "UPDATE ctactepro SET SaldoCCPro = '" & saldo & "' WHERE Id_CCPro = '" & id & "' AND NroCCPro = '" & txtProveedor.Text & "' "
                    comando.ExecuteNonQuery()
                    If Fila.Cells(11).Value = "PENDIENTE" Then
                        Fila.DefaultCellStyle.ForeColor = Color.Orange
                    End If
                    If Fila.Cells(5).Value > 1 Then
                        Fila.Cells(2).Value = DBNull.Value
                        Fila.Cells(3).Value = ""
                        Fila.Cells(4).Value = DBNull.Value
                        Fila.Cells(7).Value = DBNull.Value
                    End If
                End If
            Next
            dgvCtasCtes.FirstDisplayedScrollingRowIndex = dgvCtasCtes.RowCount - 1
            dgvCtasCtes.Rows(dgvCtasCtes.RowCount - 1).Selected = True
        Else
            detmsg = "No posee movimientos en la Cuenta Corriente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

        txtSaldo.Text = saldo
        FormatoMoneda(txtSaldo)
        dgvCtasCtes.Refresh()

    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 2
            Dim frmProv2 As New frmConsProveedores
            AddOwnedForm(frmProv2)
            frmProv2.ShowDialog()
            senial = 0
        End If

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerProveedores()
        End If

    End Sub

    Private Sub txtProveedor_MouseHover(sender As Object, e As EventArgs) Handles txtProveedor.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Proveedor."
        ToolTipMsg.SetToolTip(txtProveedor, "Presione F1 para buscar el proveedor.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub LeerProveedores()

        comando.CommandText = "SELECT * FROM proveedores WHERE NroProv = " & txtProveedor.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtNombProveedor.Text = CStr(row("RazonSocialProv"))
        Else
            txtNombProveedor.Text = ""
        End If

        CalcularCtaCte()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtProveedor.Text = ""
        txtNombProveedor.Text = ""
        txtSaldo.Text = ""
        dgvCtasCtes.DataSource = Nothing

        txtProveedor.Focus()

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        For i As Integer = 0 To dgvCtasCtes.Rows.Count - 1

            id = dgvCtasCtes.Rows(i).Cells(0).Value()
            debe = dgvCtasCtes.Rows(i).Cells(8).Value()
            haber = dgvCtasCtes.Rows(i).Cells(9).Value()
            saldo = dgvCtasCtes.Rows(i).Cells(10).Value()
            estado = dgvCtasCtes.Rows(i).Cells(11).Value()
            pagado = dgvCtasCtes.Rows(i).Cells(12).Value()
            If estado = "PENDIENTE" Then
                fecpago = "1900-01-01"
            Else
                fecpago = dgvCtasCtes.Rows(i).Cells(13).Value()
                fechajob = fecpago
                ProcesarFecha()
                fecpago = fechadb
            End If
            resto = dgvCtasCtes.Rows(i).Cells(14).Value()
            obs = dgvCtasCtes.Rows(i).Cells(15).Value()

            comando.CommandText = "UPDATE ctasctes SET DebeCC = '" & debe & "', HaberCC = '" & haber & "', SaldoCC = '" & saldo & "', EstadoCC = '" & estado & "'," _
                                  & " PagadoCC = '" & pagado & "', FecPagoCC = '" & fecpago & "', RestoCC = '" & resto & "', ObsCC = '" & obs & "'" _
                                  & " WHERE id_CC = '" & id & "' AND NroCC = '" & txtProveedor.Text & "' "
            comando.ExecuteNonQuery()

        Next

        txtProveedor.Text = ""
        txtNombProveedor.Text = ""
        txtSaldo.Text = ""
        dgvCtasCtes.DataSource = Nothing
        txtProveedor.Focus()

    End Sub

End Class