'*******************************************************************************
'* ACTUALIZA LOS CÓDIGOS POSTALES                                              *
'*******************************************************************************
Public Class frmCodPostal
    Dim idprov, iddpto, idlocal As Integer

    Private Sub frmCodPostal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CodpostalTableAdapter.Fill(DbcolmartDataSet.codpostal)

        txtNroCodPos.Focus()

    End Sub

    Private Sub CodpostalBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CodpostalBindingNavigatorSaveItem.Click

        Validate()
        BuscarProv()
        BuscarDpto()
        BuscarLocal()
        CodpostalBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)
        CodpostalTableAdapter.Fill(DbcolmartDataSet.codpostal)

    End Sub

    Private Sub txtNroCodPos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroCodPos.KeyDown

        If e.KeyCode = Keys.F1 Then

            senial = 0
            Dim frm As New frmConsCodPos
            AddOwnedForm(frm)
            frm.ShowDialog()
            txtLocalCodPos.Focus()

        End If

    End Sub

    Private Sub txtNroCodPos_MouseHover(sender As Object, e As EventArgs) Handles txtNroCodPos.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Código Postal."
        ToolTipMsg.SetToolTip(txtNroCodPos, "Presione F1 para buscar en la tabla el Código Postal.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BuscarProv()

        comando.CommandText = "SELECT * FROM provincia WHERE NombreProv = '" & txtProvCodPos.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            idprov = CStr(row("id_Prov"))
        Else
            comando = New MySqlCommand("INSERT INTO provincia VALUES(@id, @nombre)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@nombre", txtProvCodPos.Text)
            comando.ExecuteNonQuery()

            comando.CommandText = "SELECT * FROM provincia WHERE NombreProv = '" & txtProvCodPos.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                idprov = CStr(row("id_Prov"))
            End If

        End If

    End Sub

    Private Sub BuscarDpto()

        comando.CommandText = "SELECT * FROM departamento WHERE NombreDpto = '" & txtDptoCodPos.Text & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            iddpto = CStr(row("id_Dpto"))
        Else
            comando = New MySqlCommand("INSERT INTO departamento VALUES(@id, @fk, @nombre)", conexion)
            comando.Parameters.AddWithValue("@id", 0)
            comando.Parameters.AddWithValue("@fk", idprov)
            comando.Parameters.AddWithValue("@nombre", txtDptoCodPos.Text)
            comando.ExecuteNonQuery()

            comando.CommandText = "SELECT * FROM departamento WHERE NombreDpto = '" & txtDptoCodPos.Text & "'"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                iddpto = CStr(row("id_Dpto"))
            End If

        End If

    End Sub

    Private Sub BuscarLocal()

        comando = New MySqlCommand("INSERT INTO localidad VALUES(@id, @fk, @codigo, @nombre)", conexion)
        comando.Parameters.AddWithValue("@id", idlocal)
        comando.Parameters.AddWithValue("@fk", iddpto)
        comando.Parameters.AddWithValue("@codigo", txtNroCodPos.Text)
        comando.Parameters.AddWithValue("@nombre", txtLocalCodPos.Text)
        comando.ExecuteNonQuery()

    End Sub

End Class