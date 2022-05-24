Imports System.ComponentModel
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmCargarDebSoc

    Private Sub frmCargarDebSoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.debitomatri' Puede moverla o quitarla según sea necesario.
        Me.DebitosocTableAdapter.Fill(Me.DbcolmartDataSet.debitosoc)
        Limpiar()
        txtSociedad.Focus()

    End Sub

    Private Sub txtSociedad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSociedad.KeyDown

        'Busco sociedades por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 0
            Dim frmSoc0 As New frmConsSociedad
            AddOwnedForm(frmSoc0)
            frmSoc0.ShowDialog()
            CargarDgv()
            senial = 0
            txtSocDebSoc.Text = txtSociedad.Text
            txtCodDebSoc.Focus()
        End If

        'Busco sociedades por número de sociedad
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            LeerSociedades()
            CargarDgv()
            txtSocDebSoc.Text = txtSociedad.Text
            txtCodDebSoc.Focus()
        End If

        txtCodDebSoc.Text = ""
        txtDetDebSoc.Text = ""
        txtKgDebSoc.Text = ""
        txtCategDebSoc.Text = ""

    End Sub

    Private Sub CargarDgv()

        comando.CommandText = "SELECT * FROM debitosoc WHERE SocDebSoc = " & txtSociedad.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        dgvDebitoSoc.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtSocDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(0).Value.ToString
            txtCodDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(1).Value.ToString
            txtDetDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(2).Value.ToString
            txtKgDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(3).Value.ToString
            txtCategDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(4).Value.ToString
        Else
            txtCodDebSoc.Text = ""
            txtDetDebSoc.Text = ""
            txtKgDebSoc.Text = ""
            txtCategDebSoc.Text = ""
        End If

    End Sub

    Private Sub txtCodDebSoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodDebSoc.KeyDown

        'Busco códigos a debitar por consulta al presionar F1
        If e.KeyCode = Keys.F1 Then
            senial = 1
            Dim frmCod As New frmConsCodDebito
            AddOwnedForm(frmCod)
            frmCod.ShowDialog()
            LeerDebitos()
            senial = 0
            txtKgDebSoc.Focus()
            btnLimpiar.Visible = True
        ElseIf e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then         'Busco códigos a debitar por número de código
            LeerCodigos()
            LeerDebitos()
            txtKgDebSoc.Focus()
            btnLimpiar.Visible = True
        Else
            btnLimpiar.Visible = True
        End If

        'LeerDebitos()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand("INSERT INTO debitosoc VALUES(@txtSociedad, @txtCodDebSoc, @txtDetDebSoc, @txtKgDebSoc, @txtCategDebSoc)", conexion)
                comando.Parameters.AddWithValue("@txtSociedad", txtSociedad.Text)
                comando.Parameters.AddWithValue("@txtCodDebSoc", txtCodDebSoc.Text)
                comando.Parameters.AddWithValue("@txtDetDebSoc", txtDetDebSoc.Text)
                comando.Parameters.AddWithValue("@txtKgDebSoc", txtKgDebSoc.Text)
                comando.Parameters.AddWithValue("@txtCategDebSoc", txtCategDebSoc.Text)
                comando.ExecuteNonQuery()
                detmsg = "Registro guardado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        txtCodDebSoc.Text = ""
        txtDetDebSoc.Text = ""
        txtKgDebSoc.Text = ""
        txtCategDebSoc.Text = ""
        btnAgregar.Visible = False

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
            detmsg = "Sociedad no existente...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If

    End Sub

    Private Sub LeerCodigos()

        comando.CommandText = "SELECT * FROM coddebito WHERE NroCodDeb = " & txtCodDebSoc.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            txtDetDebSoc.Text = CStr(row("DetalleCodDeb"))
            txtKgDebSoc.Text = CStr(row("KgCodDeb"))
            txtCategDebSoc.Text = CStr(row("CategCodDeb"))
            txtKgDebSoc.Text = Format(Val(txtKgDebSoc.Text), "#.###,##")
        Else
            txtDetDebSoc.Text = ""
            txtKgDebSoc.Text = ""
            txtCategDebSoc.Text = ""
        End If

    End Sub

    Private Sub dgvDebitoSoc_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvDebitoSoc.MouseClick

        txtSocDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(0).Value.ToString
        txtCodDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(1).Value.ToString
        txtDetDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(2).Value.ToString
        txtKgDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(3).Value.ToString
        txtCategDebSoc.Text = dgvDebitoSoc.CurrentRow.Cells(4).Value.ToString

        btnEliminar.Visible = True
        btnActualizar.Visible = True
        btnAgregar.Visible = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            detmsg = "Desea Eliminar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("DELETE FROM debitosoc WHERE SocDebSoc = " & txtSociedad.Text & " AND  CodDebSoc = " & txtCodDebSoc.Text & ""), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro eliminado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        btnEliminar.Visible = False

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try
            detmsg = "Desea Actualizar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                comando = New MySqlCommand(("UPDATE debitosoc SET KgDebSoc = '" & txtKgDebSoc.Text & "' WHERE SocDebSoc = '" & txtSociedad.Text & "' AND  CodDebSoc = '" & txtCodDebSoc.Text & "'"), conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro actualizado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            detmsg = "Modificación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        CargarDgv()

        btnActualizar.Visible = False
        btnEliminar.Visible = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        Limpiar()

        txtSociedad.Focus()

    End Sub

    Private Sub Limpiar()

        txtSociedad.Text = ""
        txtNombSociedad.Text = ""
        txtCodDebSoc.Text = ""
        txtDetDebSoc.Text = ""
        txtKgDebSoc.Text = ""
        txtCategDebSoc.Text = ""

        comando.CommandText = "SELECT * FROM debitosoc WHERE SocDebSoc = " & txtSociedad.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)

        dgvDebitoSoc.DataSource = dt

        btnActualizar.Visible = False
        btnAgregar.Visible = False
        btnEliminar.Visible = False
        btnLimpiar.Visible = False

    End Sub

    Private Sub LeerDebitos()

        comando.CommandText = "SELECT * FROM debitosoc WHERE SocDebSoc = " & txtSociedad.Text & " AND CodDebSoc = " & txtCodDebSoc.Text & ""
        dt = New DataTable
        da = New MySqlDataAdapter(comando)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            btnActualizar.Visible = True
            btnEliminar.Visible = True
        Else
            btnAgregar.Visible = True
            btnActualizar.Visible = False
            btnEliminar.Visible = False
        End If

        txtKgDebSoc.Text = Format(Val(txtKgDebSoc.Text), "#.###,##")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class