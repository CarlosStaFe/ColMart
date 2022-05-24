Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmCtasCtesSoc
    Dim debe, haber, saldo, saldoant As Decimal
    Dim detalle As String

    Private Sub frmCtasCtesMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.ctactesoc' Puede moverla o quitarla según sea necesario.
        CtactesocTableAdapter.Fill(DbcolmartDataSet.ctactesoc)
        dgvCtasCtes.DataSource = Nothing
        txtSociedad.Focus()

    End Sub

    Private Sub CalcularCtaCte()

        comando.CommandText = "SELECT * FROM ctactesoc WHERE NroCCSoc = " & txtSociedad.Text & " ORDER BY FechaCCSoc ASC"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvCtasCtes.DataSource = dt

        dgvCtasCtes.Sort(dgvCtasCtes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        debe = 0
        haber = 0
        saldo = 0
        saldoant = 0

        If dgvCtasCtes.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvCtasCtes.Rows
                If Not Fila Is Nothing Then
                    debe = Fila.Cells(3).Value
                    haber = Fila.Cells(4).Value
                    saldo = saldoant + debe - haber
                    Fila.Cells(5).Value = saldo
                    saldoant = saldo
                    detalle = Fila.Cells(2).Value

                    comando.CommandText = "UPDATE ctactesoc SET SaldoCCSoc = '" & saldo & "' WHERE DetCCSoc = '" & detalle & "'"
                    comando.ExecuteNonQuery()

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
        dgvCtasCtes.Refresh()

    End Sub

    Private Sub txtSociedad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSociedad.KeyDown

        If e.KeyCode = Keys.F1 Then
            senial = 4
            Dim frmSoc4 As New frmConsSociedad
            AddOwnedForm(frmSoc4)
            frmSoc4.ShowDialog()
            senial = 0
        End If

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerSociedades()
        End If

    End Sub

    Private Sub LeerSociedades()

        comando.CommandText = "SELECT * FROM sociedades WHERE NroSociedad = " & txtSociedad.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtNombSociedad.Text = CStr(row("NombSociedad"))
        Else
            txtNombSociedad.Text = ""
        End If

        CalcularCtaCte()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtSociedad.Text = ""
        txtNombSociedad.Text = ""
        txtSaldo.Text = ""
        dgvCtasCtes.DataSource = Nothing

        txtSociedad.Focus()

    End Sub

End Class