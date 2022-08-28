Public Class frmPasaje

    Dim contreg, periodo As Integer
    Dim detalle, apellido, telefono As String
    Private Sub frmPasaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        contreg = 0

        ProcesarCtasCtes()

        DesconectarMySql()

        detmsg = "PROCESO TERMINADO...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()

    End Sub

    Private Sub ProcesarCtasCtes()

        Try
            comando.CommandText = "SELECT * FROM ctasctes WHERE TipoCbteCC = 'LIQ' ORDER BY NroCC, FechaCC"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                comando = New MySqlCommand("SELECT * FROM matriculados WHERE NroMatri = '" & CStr(row("NroCC")) & "'", conexion)
                dr = comando.ExecuteReader

                If dr.HasRows Then
                    While dr.Read
                        apellido = dr(2).ToString
                        telefono = dr(22).ToString + " * " + dr(23).ToString
                    End While
                End If

                dr.Close()
                dr.Dispose()

                detalle = CStr(row("DetalleCC"))
                fechajob = CStr(row("FechaCC"))
                ProcesarFecha()

                periodo = yyyy + mm

                comando = New MySqlCommand("INSERT INTO ventas VALUES(@id, @fecha, @tipo, @cpbte, @item, @detalle, @periodo, @neto, @total)", conexion)
                comando.Parameters.AddWithValue("@id", CStr(row("id_CC")))
                comando.Parameters.AddWithValue("@fecha", fechadb)
                comando.Parameters.AddWithValue("@tipo", CStr(row("TipoCbteCC")))
                comando.Parameters.AddWithValue("@cpbte", CStr(row("NroCbteCC")))
                comando.Parameters.AddWithValue("@item", CStr(row("ItemCC")))
                comando.Parameters.AddWithValue("@detalle", CStr(row("DetalleCC")))
                comando.Parameters.AddWithValue("@periodo", periodo)
                comando.Parameters.AddWithValue("@neto", CStr(row("DebeCC")))
                comando.Parameters.AddWithValue("@total", 0)
                comando.ExecuteNonQuery()

                If detalle = "Fianza" Then
                    comando = New MySqlCommand("INSERT INTO fianzas VALUES(@id, @matri, @fecpago, @user, @firma1, @user1, @firma2, @user2, @fecvto, @docum, @nombre, " _
                                                   & "@calle, @tel, @estado, @obs, @apellido, @telefmatri)", conexion)
                    comando.Parameters.AddWithValue("@id", 0)
                    comando.Parameters.AddWithValue("@matri", CStr(row("NroCC")))
                    comando.Parameters.AddWithValue("@fecpago", fechadb)
                    comando.Parameters.AddWithValue("@user", user)
                    comando.Parameters.AddWithValue("@firma1", DBNull.Value)
                    comando.Parameters.AddWithValue("@user1", "")
                    comando.Parameters.AddWithValue("@Firma2", DBNull.Value)
                    comando.Parameters.AddWithValue("@user2", "")
                    comando.Parameters.AddWithValue("@fecvto", DBNull.Value)
                    comando.Parameters.AddWithValue("@docum", "")
                    comando.Parameters.AddWithValue("@nombre", "")
                    comando.Parameters.AddWithValue("@calle", "")
                    comando.Parameters.AddWithValue("@tel", "")
                    comando.Parameters.AddWithValue("@estado", "INCOMPLETA")
                    comando.Parameters.AddWithValue("@obs", "CIC Nro.: " & CStr(row("NroCbteCC")))
                    comando.Parameters.AddWithValue("@apellido", apellido)
                    comando.Parameters.AddWithValue("@telefmatri", telefono)
                    comando.ExecuteNonQuery()

                End If

                contreg = contreg + 1
                txtMsg.Text = "PROCESANDO REGISTRO: " & CStr(contreg)
                txtMsg.Refresh()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class