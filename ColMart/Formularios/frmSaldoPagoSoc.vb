Public Class frmSaldoPagoSoc
    Dim titulo As String
    Private da As New MySqlDataAdapter

    Private Sub frmSaldoPagoSoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        titulo = "Listado de Saldo de Sociedades "

        comando = New MySqlCommand("DELETE FROM debehaber ", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        comando.CommandText = "SELECT * FROM ctasctes INNER JOIN sociedades ON ctasctes.NroCC = sociedades.NroSociedad " _
                                & "WHERE ctasctes.EstadoCC = 'PENDIENTE' ORDER BY NroSociedad"

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows
            comando = New MySqlCommand("INSERT INTO debehaber VALUES(@matricula, @apelnomb, @estado, @detalle, @periodo, @debe, @haber, @saldo, @total)", conexion)
            comando.Parameters.AddWithValue("@matricula", CStr(row("NroSociedad")))
            comando.Parameters.AddWithValue("@apelnomb", CStr(row("NombSociedad")))
            comando.Parameters.AddWithValue("@estado", CStr(row("EstadoSociedad")))
            comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleCC")))
            comando.Parameters.AddWithValue("@periodo", CStr(row("PeriodoCC")))
            comando.Parameters.AddWithValue("@debe", row("DebeCC"))
            comando.Parameters.AddWithValue("@haber", 0)
            comando.Parameters.AddWithValue("@saldo", 0)
            comando.Parameters.AddWithValue("@total", 0)
            comando.ExecuteNonQuery()
        Next

        Dim frm As New frmInforme
        frm.txtDetalle.Text = titulo
        frm.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Close()

    End Sub


End Class