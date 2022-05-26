Public Class frmListaPadron
    Dim localidad, departamento, provincia As String
    Dim meses, leer, codigo As Integer
    Dim senial, idlocal, iddpto, idprov, contador As Integer
    Dim detalle, fechafianza, matricula As String

    Private Sub frmListaPadron_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()

        detalle = "Listado de Matriculados - Estado : TODOS * Sexo: TODOS * Categoría: TODOS * Ordenado por MATRÍCULA *"
        cmbEstado.SelectedIndex = 0
        cmbSexo.SelectedIndex = 0
        cmbCategoria.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0
        txtAFecha.Text = Format(Now, "dd/MM/yyyy")
        txtFecha.Text = txtAFecha.Text

        ActualizarCodPos()

        CargarLocal()
        cmbLocal.SelectedIndex = 0
        CargarDpto()
        cmbDpto.SelectedIndex = 0
        CargarProv()
        cmbProv.SelectedIndex = 0

    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        comando = New MySqlCommand("DELETE FROM padron", conexion)
        dr = comando.ExecuteReader
        dr.Close()

        contador = 0
        leer = 0
        senial = 0
        detalle = "Listado de Matriculados - "

        comando.CommandText = "SELECT * FROM matriculados "

        '********** ESTADOS **********
        If cmbEstado.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Estado: TODOS * "
        Else
            comando.CommandText = comando.CommandText & " WHERE EstadoMatri = '" & cmbEstado.Text & "' "
            detalle = detalle & "Estado: " & cmbEstado.Text & " * "
            senial = 1
        End If

        '********** SEXOS **********
        If cmbSexo.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Sexo: TODOS * "
        Else
            detalle = detalle & "Sexo: " & cmbSexo.Text & " * "
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE SexoMatri = '" & cmbSexo.Text & "' "
                senial = 1
            Else
                comando.CommandText = comando.CommandText & "AND SexoMatri = '" & cmbSexo.Text & "' "
            End If
        End If

        '********** CATEGORIA **********
        If cmbCategoria.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
            detalle = detalle & "Categoría: TODOS * "
        Else
            detalle = detalle & "Categoría: " & cmbCategoria.Text & " * "
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE CatAporteMatri = '" & cmbCategoria.Text & "' "
                senial = 1
            Else
                comando.CommandText = comando.CommandText & "AND CatAporteMatri = '" & cmbCategoria.Text & "' "
            End If
        End If

        '********** ANTIGUEDAD **********
        If txtAFecha.Text = txtFecha.Text Then
            comando.CommandText = comando.CommandText
        Else
            detalle = detalle & "Fecha: " & txtAFecha.Text & " * "
            fechajob = txtFecha.Text
            ProcesarFecha()
            If senial = 0 Then
                comando.CommandText = comando.CommandText & "WHERE FecJurMatri <= '" & fechadb & "' "
                senial = 1
            Else
                comando.CommandText = comando.CommandText & "AND FecJurMatri <= '" & fechadb & "' "
            End If
        End If

        '********** LOCALIDAD-DPTO-PROVINCIA **********
        If cmbLocal.Text = "TODOS" And cmbDpto.Text = "TODOS" And cmbProv.Text = "TODOS" Then
            comando.CommandText = comando.CommandText
        Else
            If cmbLocal.Text <> "TODOS" Then

                If senial = 0 Then
                    comando.CommandText = comando.CommandText & "WHERE idLocalRMatri = '" & idlocal & "' "
                    senial = 1
                Else
                    comando.CommandText = comando.CommandText & "AND idLocalRMatri = '" & idlocal & "' "
                End If

            End If
            If cmbDpto.Text <> "TODOS" Then

                If senial = 0 Then
                    comando.CommandText = comando.CommandText & "WHERE idDptoRMatri = '" & iddpto & "' "
                    senial = 1
                Else
                    comando.CommandText = comando.CommandText & "AND idDptoRMatri = '" & iddpto & "' "
                End If

            End If
            If cmbProv.Text <> "TODOS" Then

                If senial = 0 Then
                    comando.CommandText = comando.CommandText & "WHERE idProvRMatri = '" & idprov & "' "
                    senial = 1
                Else
                    comando.CommandText = comando.CommandText & "AND idProvRMatri = '" & idprov & "' "
                End If

            End If
        End If

        If senial = 0 Then
            comando.CommandText = comando.CommandText & "WHERE NroMatri < '50000' "
        Else
            comando.CommandText = comando.CommandText & " AND NroMatri < '50000' "
        End If

        '********** ORDENADOS POR **********
        If cmbOrden.Text = "APELLIDO" Then
            comando.CommandText = comando.CommandText & "ORDER BY ApelNombMatri "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        Else
            comando.CommandText = comando.CommandText & "ORDER BY NroMatri "
            detalle = detalle & "Ordenado por " & cmbOrden.Text & " * "
        End If
        '**********

        Procesar()

        Dim frm As New frmPadronMatri
        frm.detalle = detalle
        frm.ShowDialog()

        Limpiar()

    End Sub

    Private Sub btnFiltrar_MouseHover(sender As Object, e As EventArgs) Handles btnFiltrar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Filtrar."
        ToolTipMsg.SetToolTip(btnFiltrar, "Presione para imprimir el listado deseado.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnFiltrar, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtFecha_Leave(sender As Object, e As EventArgs) Handles txtFecha.Leave

        fechajob = txtFecha.Text
        If txtFecha.Text <> "" Then
            ControlFecha(fechajob)
            If senial = 1 Then
                txtFecha.Text = ""
                txtFecha.Focus()
                senial = 0
            Else
                ProcesarFecha()
                txtFecha.Text = fechajob
                txtFecha.Refresh()
            End If
        End If

    End Sub

    Private Sub cmbEstado_LostFocus(sender As Object, e As EventArgs) Handles cmbEstado.LostFocus

        If cmbEstado.Text = "ACTIVO" Then
            NUDyyyy.Enabled = True
            NUDmm.Enabled = True
            txtAFecha.Enabled = True
            txtFecha.Enabled = False
            cmbLocal.Enabled = True
            cmbDpto.Enabled = True
            cmbProv.Enabled = True
        Else
            NUDyyyy.Enabled = False
            NUDmm.Enabled = False
            txtAFecha.Enabled = False
            txtFecha.Enabled = False
            cmbLocal.Enabled = False
            cmbDpto.Enabled = False
            cmbProv.Enabled = False
        End If

    End Sub

    Private Sub NUDyyyy_LostFocus(sender As Object, e As EventArgs) Handles NUDyyyy.LostFocus

        meses = 0
        meses = (NUDyyyy.Value * 12) * -1
        txtFecha.Text = DateAdd("m", meses, txtAFecha.Text)
        txtFecha.Refresh()

    End Sub

    Private Sub NUDmm_LostFocus(sender As Object, e As EventArgs) Handles NUDmm.LostFocus

        meses = (NUDmm.Value * -1) + (NUDyyyy.Value * 12) * -1
        txtFecha.Text = DateAdd("m", meses, txtAFecha.Text)
        txtFecha.Refresh()

    End Sub

    Private Sub CargarLocal()

        comando = New MySqlCommand("SELECT DISTINCT NombreLocal FROM localidad ORDER BY NombreLocal ASC", conexion)
        dr = comando.ExecuteReader

        cmbLocal.Items.Add("TODOS")

        If dr.HasRows Then
            While dr.Read
                cmbLocal.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub CargarDpto()

        comando = New MySqlCommand("SELECT DISTINCT NombreDpto FROM departamento ORDER BY NombreDpto ASC", conexion)
        dr = comando.ExecuteReader

        cmbDpto.Items.Add("TODOS")

        If dr.HasRows Then
            While dr.Read
                cmbDpto.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub CargarProv()

        comando = New MySqlCommand("SELECT DISTINCT NombreProv FROM provincia ORDER BY NombreProv ASC", conexion)
        dr = comando.ExecuteReader

        cmbProv.Items.Add("TODOS")

        If dr.HasRows Then
            While dr.Read
                cmbProv.Items.Add(dr(0).ToString)
            End While
        End If
        dr.Close()

    End Sub

    Private Sub cmbLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocal.SelectedIndexChanged

        If cmbLocal.Text <> "TODOS" Then
            cmbDpto.Text = "TODOS"
            cmbProv.Text = "TODOS"
        End If
        LeerLocal()
        cmbDpto.Focus()

    End Sub

    Private Sub cmbDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDpto.SelectedIndexChanged

        If cmbDpto.Text <> "TODOS" Then
            cmbLocal.Text = "TODOS"
            cmbProv.Text = "TODOS"
        End If
        LeerDpto()
        cmbProv.Focus()

    End Sub

    Private Sub cmbProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProv.SelectedIndexChanged

        If cmbProv.Text <> "TODOS" Then
            cmbLocal.Text = "TODOS"
            cmbDpto.Text = "TODOS"
        End If
        LeerProv()
        btnFiltrar.Focus()

    End Sub

    Private Sub LeerLocal()

        If leer = 0 Then
            comando = New MySqlCommand("SELECT * FROM localidad WHERE NombreLocal = '" & cmbLocal.Text & "' ", conexion)
            dr = comando.ExecuteReader
        Else
            comando = New MySqlCommand("SELECT * FROM localidad WHERE id_Local = '" & idlocal & "' ", conexion)
            dr = comando.ExecuteReader
        End If

        If dr.HasRows Then
            While dr.Read
                idlocal = dr(0).ToString
                localidad = dr(3).ToString
            End While
        End If
        dr.Close()

    End Sub

    Private Sub LeerDpto()

        If leer = 0 Then
            comando = New MySqlCommand("SELECT * FROM departamento WHERE NombreDpto = '" & cmbDpto.Text & "' ", conexion)
            dr = comando.ExecuteReader
        Else
            comando = New MySqlCommand("SELECT * FROM departamento WHERE id_Dpto = '" & iddpto & "' ", conexion)
            dr = comando.ExecuteReader
        End If

        If dr.HasRows Then
            While dr.Read
                iddpto = dr(0).ToString
                departamento = dr(2).ToString
            End While
        End If
        dr.Close()

    End Sub

    Private Sub LeerProv()

        If leer = 0 Then
            comando = New MySqlCommand("SELECT * FROM provincia WHERE NombreProv = '" & cmbProv.Text & "' ", conexion)
            dr = comando.ExecuteReader
        Else
            comando = New MySqlCommand("SELECT * FROM provincia WHERE id_Prov = '" & idprov & "' ", conexion)
            dr = comando.ExecuteReader
        End If

        If dr.HasRows Then
            While dr.Read
                idprov = dr(0).ToString
                provincia = dr(1).ToString
            End While
        End If
        dr.Close()

    End Sub

    Private Sub Procesar()

        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)
        Dim row As DataRow = dt.Rows(0)

        For Each row In dt.Rows

            leer = 1

            idlocal = CStr(row("idLocalRMatri"))
            LeerLocal()
            iddpto = CStr(row("idDptoRMatri"))
            LeerDpto()
            idprov = CStr(row("idProvRMatri"))
            LeerProv()

            contador = contador + 1
            comando = New MySqlCommand("INSERT INTO padron VALUES(@id, @matricula, @nombre, @domicilio, @local, @dpto, @prov, @jur, @fianza)", conexion)
            comando.Parameters.AddWithValue("@id", contador)
            comando.Parameters.AddWithValue("@matricula", CStr(row("NroMatri")))
            comando.Parameters.AddWithValue("@nombre", CStr(row("ApelNombMatri")))
            comando.Parameters.AddWithValue("@domicilio", CStr(row("CalleRealMatri")))
            comando.Parameters.AddWithValue("@local", localidad)
            comando.Parameters.AddWithValue("@dpto", departamento)
            comando.Parameters.AddWithValue("@prov", provincia)
            comando.Parameters.AddWithValue("@jur", CStr(row("FecJurMatri")))
            fechajob = CStr(row("FianzaMatri"))

            ProcesarFecha()

            meses = 24
            fechafianza = DateAdd("m", meses, fechajob)

            If (DateTime.Compare(fechafianza, txtAFecha.Text) < 0) Then
                comando.Parameters.AddWithValue("@fianza", CStr(row("FianzaMatri")))
            Else
                comando.Parameters.AddWithValue("@fianza", Nothing)
            End If
            comando.ExecuteNonQuery()
        Next

    End Sub

    Private Sub Limpiar()

        detalle = "Listado de Matriculados - Estado : TODOS * Sexo: TODOS * Categoría: TODOS * Ordenado por MATRÍCULA *"
        cmbEstado.SelectedIndex = 0
        cmbSexo.SelectedIndex = 0
        cmbCategoria.SelectedIndex = 0
        cmbOrden.SelectedIndex = 0
        cmbLocal.SelectedIndex = 0
        cmbDpto.SelectedIndex = 0
        cmbProv.SelectedIndex = 0
        txtAFecha.Text = Format(Now, "dd/MM/yyyy")
        txtFecha.Text = txtAFecha.Text

        cmbLocal.Text = "TODOS"
        cmbDpto.Text = "TODOS"
        cmbProv.Text = "TODOS"

        localidad = ""
        departamento = ""
        provincia = ""
        idlocal = 0
        iddpto = 0
        idprov = 0
        leer = 0

    End Sub

    Private Sub ActualizarCodPos()

        Try
            comando.CommandText = "SELECT * FROM matriculados ORDER BY NroMatri"
            dt = New DataTable
            da = New MySqlDataAdapter(comando)
            da.Fill(dt)
            Dim row As DataRow = dt.Rows(0)

            iddpto = 0
            idlocal = 0
            idprov = 0

            For Each row In dt.Rows

                matricula = CStr(row("NroMatri"))

                senial = 0
                idlocal = CStr(row("CPRealMatri"))
                '****** BUSCO LOCALIDAD ************
                BuscarLocal()
                '****** BUSCO DPTO *****************
                BuscarDpto()
                '****** BUSCO PROVINCIA ************
                BuscarProv()

                senial = 1
                idlocal = CStr(row("CPLegalMatri"))
                '****** BUSCO LOCALIDAD ************
                BuscarLocal()
                '****** BUSCO DPTO *****************
                BuscarDpto()
                '****** BUSCO PROVINCIA ************
                BuscarProv()
            Next
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención")
            detmsg = "Conexión errónea"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

    End Sub

    Private Sub BuscarLocal()

        comando = New MySqlCommand("SELECT * FROM localidad WHERE Id_Local = '" & idlocal & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                iddpto = dr(1).ToString
            End While
        End If

        dr.Close()

    End Sub

    Private Sub BuscarDpto()

        comando = New MySqlCommand("SELECT * FROM departamento WHERE Id_Dpto = '" & iddpto & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                idprov = dr(1).ToString
            End While
        End If

        dr.Close()

    End Sub

    Private Sub BuscarProv()

        comando = New MySqlCommand("SELECT * FROM provincia WHERE Id_Prov = '" & idprov & "'", conexion)
        dr = comando.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                idprov = dr(0).ToString
            End While
        End If

        dr.Close()

        If senial = 0 Then
            comando = New MySqlCommand("UPDATE matriculados SET IdLocalRMatri = '" & idlocal & "', IdDptoRMatri = '" & iddpto & "', IdProvRMatri = '" & idprov & "' WHERE NroMatri = '" & matricula & "' ", conexion)
            comando.ExecuteNonQuery()
        Else
            comando = New MySqlCommand("UPDATE matriculados SET IdLocalLMatri = '" & idlocal & "', IdDptoLMatri = '" & iddpto & "', IdProvLMatri = '" & idprov & "' WHERE NroMatri = '" & matricula & "' ", conexion)
            comando.ExecuteNonQuery()
        End If

    End Sub


End Class