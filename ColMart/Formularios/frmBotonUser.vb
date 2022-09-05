'*******************************************************************************
'* CARGA LOS DIFERENTES USUARIOS PARA LOS BOTONES DEL MENÚ PARA ACCEDER        *
'*******************************************************************************
Public Class frmBotonUser
    Dim boton, detalle As String

    Private Sub frmBotonUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        CargarUsuario()
        cmbUsuarioBU.Focus()

    End Sub

    Private Sub BotonuserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BotonuserBindingNavigatorSaveItem.Click

        Validate()
        BotonuserBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub

    Private Sub CargarUsuario()

        comando = New MySqlCommand("SELECT DISTINCT UserUsuario FROM usuarios ORDER BY UserUsuario ASC", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                cmbUsuarioBU.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub cmbUsuarioBU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuarioBU.SelectedIndexChanged

        ActualizarBotones()
        dr.Close()
        dr.Dispose()
        CargarDGV()

    End Sub

    Private Sub ActualizarBotones()

        comando.CommandText = "SELECT * FROM botones "
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows

            boton = CStr(row("NombreBtn"))
            detalle = CStr(row("DetalleBtn"))

            comando = New MySqlCommand("SELECT * FROM botonuser WHERE UsuarioBU = '" & cmbUsuarioBU.Text & "' AND BotonBU = '" & boton & "' ", conexion)
            dr = comando.ExecuteReader

            If dr.HasRows Then
                dr.Close()
                comando = New MySqlCommand("UPDATE botonuser SET DetalleBU = '" & detalle & "' WHERE BotonBU = '" & boton & "' ", conexion)
                comando.ExecuteNonQuery()
            Else
                dr.Close()
                comando = New MySqlCommand("INSERT INTO botonuser VALUES(@id, @usuario, @boton, @detalle, @acceso)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@usuario", cmbUsuarioBU.Text)
                comando.Parameters.AddWithValue("@boton", boton)
                comando.Parameters.AddWithValue("@detalle", detalle)
                comando.Parameters.AddWithValue("@acceso", False)
                comando.ExecuteNonQuery()
            End If

        Next

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If dgvBotones.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgvBotones.Rows
                If Fila.Cells(4).Value = True Then
                    comando = New MySqlCommand("UPDATE botonuser SET AccedeBU = True " _
                                     & " WHERE UsuarioBU = '" & cmbUsuarioBU.Text & "' AND id_BU = '" & Fila.Cells(0).Value & "' ", conexion)
                    comando.ExecuteNonQuery()
                Else
                    comando = New MySqlCommand("UPDATE botonuser SET AccedeBU = False " _
                                     & " WHERE UsuarioBU = '" & cmbUsuarioBU.Text & "' AND id_BU = '" & Fila.Cells(0).Value & "' ", conexion)
                    comando.ExecuteNonQuery()
                End If
            Next
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub CargarDGV()

        comando.CommandText = "SELECT * FROM botonuser WHERE UsuarioBU = '" & cmbUsuarioBU.Text & "' ORDER BY BotonBU"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvBotones.DataSource = dt
        dgvBotones.Refresh()

    End Sub

End Class