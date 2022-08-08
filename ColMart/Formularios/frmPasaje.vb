Public Class frmPasaje

    Dim contreg, idlocal, iddpto, idprov, contprov, contdpto, id, cpreal, cplegal As Integer
    Dim codigo, localidad, dpto, provincia, matricula As String
    Private Sub frmPasaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        contreg = 0

        DesconectarMySql()

        detmsg = "PROCESO TERMINADO...!!!"
        tipomsg = "info"
        btnmsg = 1
        frmMsgBox.ShowDialog()

    End Sub

    Private Sub ProcesarCtasCtes()

        Try
            comando.CommandText = "SELECT * FROM ctasctes ORDER BY NroCC, FechaCC"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows


                comando = New MySqlCommand("INSERT INTO ventas VALUES(@id, @fecha, @tipo, @cpbte, @item, @detalle, @periodo, @debe, @haber, @saldo, @estado)", conexion)
                comando.Parameters.AddWithValue("@id", 0)
                comando.Parameters.AddWithValue("@fecha", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@tipo", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@cpbte", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@item", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@detalle", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@periodo", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@debe", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@haber", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@saldo", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@estado", CStr(row("id_Prov")))
                comando.Parameters.AddWithValue("@nombre", provincia)
                comando.ExecuteNonQuery()

                codigo = 0
                senial = 0
                contreg = contreg + 1
                txtMsg.Text = "PROCESANDO REGISTRO: " & CStr(contreg)
                txtMsg.Refresh()

                idlocal = CStr(row("id_CodPos"))
                codigo = CStr(row("NroCodPos"))
                localidad = CStr(row("LocalCodPos"))
                dpto = CStr(row("DptoCodPos"))
                provincia = CStr(row("ProvCodPos"))

                txtMsg1.Text = "PROCESANDO CÓDIGOS POSTALES: " & CStr(idlocal) & " " & CStr(codigo) & " " & localidad & " " & dpto & " " & provincia
                txtMsg.Refresh()

                '****** BUSCO PROVINCIA ************
                BuscarProv()

                '****** BUSCO DPTO *****************
                BuscarDpto()

                '****** BUSCO LOCALIDAD ************
                BuscarLocal()

            Next

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub
    Private Sub BuscarProv()

        comando.CommandText = "SELECT * FROM provincia WHERE NombreProv = '" & provincia & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            idprov = CStr(row("id_Prov"))
            senial = 1
        Else
            contprov = contprov + 1
            comando = New MySqlCommand("INSERT INTO provincia VALUES(@id, @nombre)", conexion)
            comando.Parameters.AddWithValue("@id", contprov)
            comando.Parameters.AddWithValue("@nombre", provincia)
            comando.ExecuteNonQuery()
        End If

    End Sub

    Private Sub BuscarDpto()

        comando.CommandText = "SELECT * FROM departamento WHERE NombreDpto = '" & dpto & "'"
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            iddpto = CStr(row("id_Dpto"))
            senial = 1
        Else
            contdpto = contdpto + 1
            comando = New MySqlCommand("INSERT INTO departamento VALUES(@id, @fk, @nombre)", conexion)
            comando.Parameters.AddWithValue("@id", contdpto)
            If senial = 0 Then
                comando.Parameters.AddWithValue("@fk", contprov)
            Else
                comando.Parameters.AddWithValue("@fk", idprov)
            End If
            comando.Parameters.AddWithValue("@nombre", dpto)
            comando.ExecuteNonQuery()
            senial = 0
        End If

    End Sub

    Private Sub BuscarLocal()

        comando = New MySqlCommand("INSERT INTO localidad VALUES(@id, @fk, @codigo, @nombre)", conexion)
        comando.Parameters.AddWithValue("@id", idlocal)
        If senial = 0 Then
            comando.Parameters.AddWithValue("@fk", contdpto)
        Else
            comando.Parameters.AddWithValue("@fk", iddpto)
        End If
        comando.Parameters.AddWithValue("@codigo", codigo)
        comando.Parameters.AddWithValue("@nombre", localidad)
        comando.ExecuteNonQuery()
        senial = 0

    End Sub

    Private Sub ProcesarMatri()

        Try
            comando.CommandText = "SELECT * FROM matriculados ORDER BY NroMatri"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            codigo = 0
            iddpto = 0
            idlocal = 0
            idprov = 0

            For Each row In dt.Rows

                codigo = 0
                senial = 0
                contreg = contreg + 1
                txtMsg.Text = "PROCESANDO MATRICULADOS: " & CStr(contreg)
                txtMsg.Refresh()

                matricula = CStr(row("NroMatri"))
                codigo = CStr(row("CPRealMatri"))

                txtMsg1.Text = "PROCESANDO MATRICULADO: " & CStr(matricula) & CStr(codigo)
                txtMsg.Refresh()

                '****** BUSCO LOCALIDAD *****************
                LeerLocal()

                '****** BUSCO DPTO *****************
                LeerDpto()

                '****** BUSCO LOCALIDAD ************
                LeerProv()

                codigo = CStr(row("CPLegalMatri"))
                senial = 1

                txtMsg1.Text = "PROCESANDO MATRICULADO: " & CStr(matricula) & CStr(codigo)
                txtMsg.Refresh()

                '****** BUSCO LOCALIDAD *****************
                LeerLocal()

                '****** BUSCO DPTO *****************
                LeerDpto()

                '****** BUSCO LOCALIDAD ************
                LeerProv()


            Next

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub LeerLocal()

        comando = New MySqlCommand("SELECT * FROM localidad WHERE Id_Local = '" & codigo & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                idlocal = dr(0).ToString
                iddpto = dr(1).ToString
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub LeerDpto()

        comando = New MySqlCommand("SELECT * FROM departamento WHERE Id_Dpto = '" & iddpto & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                iddpto = dr(0).ToString
                idprov = dr(1).ToString
            End While
        End If

        dr.Close()
        dr.Dispose()

    End Sub

    Private Sub LeerProv()

        comando = New MySqlCommand("SELECT * FROM provincia WHERE Id_Prov = '" & idprov & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                idprov = dr(0).ToString
            End While
        End If

        dr.Close()
        dr.Dispose()

        If senial = 0 Then
            comando = New MySqlCommand("UPDATE matriculados SET IdLocalRMatri = '" & idlocal & "', IdDptoRMatri = '" & iddpto & "', IdProvRMatri = '" & idprov & "' WHERE NroMatri = '" & matricula & "' ", conexion)
            comando.ExecuteNonQuery()
        Else
            comando = New MySqlCommand("UPDATE matriculados SET IdLocalLMatri = '" & idlocal & "', IdDptoLMatri = '" & iddpto & "', IdProvLMatri = '" & idprov & "' WHERE NroMatri = '" & matricula & "' ", conexion)
            comando.ExecuteNonQuery()
        End If

    End Sub

End Class