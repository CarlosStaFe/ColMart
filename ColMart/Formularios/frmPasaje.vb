Public Class frmPasaje

    Dim contreg, periodo As Integer
    Dim detalle, apellido, telefono As String
    Dim fecha1, fecha2, fecha3, fecha4 As String
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
            comando.CommandText = "SELECT * FROM colegiados ORDER BY NroMatri"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            For Each row In dt.Rows

                comando = New MySqlCommand("INSERT INTO matriculados VALUES(@id, @nromat, @nommatri, @apelmat, @fecnac, @lugar, @nacion, @tipo, @doc, " _
                                                                         & "@sexo, @civil, @cuit, @fecjur, @categ, @estado, @fecest, " _
                                                                         & "@caller, @idlocalr, @iddptor, @idprovr, @mail, @celur, @fijor, " _
                                                                         & "@callel, @idlocall, @iddptol, @idprovl, @celul, @fijol, " _
                                                                         & "@fianza, @docfza, @nomfza, @callefza, @telfza, @obs, @tomo, @folio)", conexion)
                comando.Parameters.AddWithValue("@id", CStr(row("id_Matri")))
                comando.Parameters.AddWithValue("@nromat", CStr(row("NroMatri")))
                comando.Parameters.AddWithValue("@nommatri", CStr(row("ApelNombMatri")))
                comando.Parameters.AddWithValue("@apelmat", CStr(row("ApelMatMatri")))
                'fechajob = CStr(row("FecNacMatri"))
                'ProcesarFecha()
                'fecha1 = fechadb

                comando.Parameters.AddWithValue("@fecnac", CStr(row("FecNacMatri")))
                comando.Parameters.AddWithValue("@lugar", CStr(row("LugarNacMatri")))
                comando.Parameters.AddWithValue("@nacion", CStr(row("NacionNacMatri")))
                comando.Parameters.AddWithValue("@tipo", CStr(row("TipodocMatri")))
                comando.Parameters.AddWithValue("@doc", CStr(row("NroDocMatri")))
                comando.Parameters.AddWithValue("@sexo", CStr(row("SexoMatri")))
                comando.Parameters.AddWithValue("@civil", CStr(row("EstCivilMatri")))
                comando.Parameters.AddWithValue("@cuit", CStr(row("CuitMatri")))
                'fechajob = CStr(row("FecJurMatri"))
                'ProcesarFecha()
                'fecha2 = fechadb

                comando.Parameters.AddWithValue("@fecjur", CStr(row("FecJurMatri")))
                comando.Parameters.AddWithValue("@categ", CStr(row("CatAporteMatri")))
                comando.Parameters.AddWithValue("@estado", CStr(row("EstadoMatri")))
                'fechajob = CStr(row("FecEstadoMatri"))
                'ProcesarFecha()
                'fecha3 = fechadb

                comando.Parameters.AddWithValue("@fecest", CStr(row("FecEstadoMatri")))
                comando.Parameters.AddWithValue("@caller", CStr(row("CalleRealMatri")))
                comando.Parameters.AddWithValue("@idlocalr", CStr(row("idLocalRMatri")))
                comando.Parameters.AddWithValue("@iddptor", CStr(row("idDptoRMatri")))
                comando.Parameters.AddWithValue("@idprovr", CStr(row("idProvRMatri")))
                comando.Parameters.AddWithValue("@mail", CStr(row("EmailMatri")))
                comando.Parameters.AddWithValue("@celur", CStr(row("CeluRealMatri")))
                comando.Parameters.AddWithValue("@fijor", CStr(row("FijoRealMatri")))
                comando.Parameters.AddWithValue("@callel", CStr(row("CalleLegalMatri")))
                comando.Parameters.AddWithValue("@idlocall", CStr(row("idLocalLMatri")))
                comando.Parameters.AddWithValue("@iddptol", CStr(row("idDptoLMatri")))
                comando.Parameters.AddWithValue("@idprovl", CStr(row("idProvLMatri")))
                comando.Parameters.AddWithValue("@celul", CStr(row("CeluLegalMatri")))
                comando.Parameters.AddWithValue("@fijol", CStr(row("FijoLegalMatri")))
                'fechajob = CStr(row("FianzaMatri"))
                'ProcesarFecha()
                'fecha4 = fechadb

                comando.Parameters.AddWithValue("@fianza", CStr(row("FianzaMatri")))
                comando.Parameters.AddWithValue("@docfza", CStr(row("DocFiadorMatri")))
                comando.Parameters.AddWithValue("@nomfza", CStr(row("FiadorMatri")))
                comando.Parameters.AddWithValue("@callefza", CStr(row("CalleFiadorMatri")))
                comando.Parameters.AddWithValue("@telfza", CStr(row("TelFiadorMatri")))
                comando.Parameters.AddWithValue("@obs", CStr(row("ObsMatri")))
                comando.Parameters.AddWithValue("@tomo", "")
                comando.Parameters.AddWithValue("@folio", "")
                comando.ExecuteNonQuery()


                contreg = contreg + 1
                txtMsg.Text = "PROCESANDO REGISTRO: " & CStr(contreg) & " * " & CStr(row("NroMatri"))
                txtMsg.Refresh()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class