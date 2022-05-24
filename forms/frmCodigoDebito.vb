Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmCodigoDebito
    Dim importe As Double

    Private Sub frmCodigoDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        'TODO: esta línea de código carga datos en la tabla 'DbcolmartDataSet.coddebito' Puede moverla o quitarla según sea necesario.
        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        BtnGrabar.Visible = False
        txtDetalleCodDeb.Focus()

    End Sub

    Private Sub NroCodDebTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroCodDeb.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim frmDeb As New frmConsCodDebito
            AddOwnedForm(frmDeb)
            frmDeb.ShowDialog()
            txtDetalleCodDeb.Focus()
        End If

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        txtNroCodDeb.Focus()
        CoddebitoBindingSource.AddNew()
        BtnAgregar.Visible = False
        BtnGrabar.Visible = True
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnBuscar.Visible = False
        BtnActualizar.Visible = True
        BtnPrimer.Visible = False
        BtnAnterior.Visible = False
        BtnSiguiente.Visible = False
        BtnUltimo.Visible = False

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                'CoddebitoBindingSource.EndEdit()
                comando = New MySqlCommand("INSERT INTO coddebito (NroCodDeb, DetalleCodDeb, ImporteCodDeb, KgCodDeb, CategCodDeb, ObsCodDeb) " _
                                           & "VALUES('" & txtNroCodDeb.Text & "', '" & txtDetalleCodDeb.Text & "', '" & txtImporteCodDeb.Text & "', " _
                                           & " '" & txtKgCodDeb.Text & "', '" & txtCategCodDeb.Text & "', '" & txtObsCodDeb.Text & "')", conexion)
                comando.ExecuteNonQuery()
                detmsg = "Registro guardado correctamente...!!!"
                tipomsg = "ok"
                btnmsg = 1
                frmMsgBox.ShowDialog()
            End If
        Catch ex As Exception
            detmsg = "Grabación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End Try

        txtNroCodDeb.Focus()
        'NivelesBindingSource.AddNew()
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True
        CoddebitoTableAdapter.Fill(Me.DbcolmartDataSet.coddebito)

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            'CoddebitoBindingSource.EndEdit()
            comando = New MySqlCommand("UPDATE coddebito SET NroCodDeb = '" & txtNroCodDeb.Text & "', DetalleCodDeb = '" & txtDetalleCodDeb.Text & "', ImporteCodDeb = '" & txtImporteCodDeb.Text & "', " _
                                    & "KgCodDeb = '" & txtKgCodDeb.Text & "', CategCodDeb = '" & txtCategCodDeb.Text & "', ObsCodDeb = '" & txtObsCodDeb.Text & "' " _
                                    & " WHERE id_CodDeb = " & txtId_CodDeb.Text & " AND  NroCodDeb = " & txtNroCodDeb.Text & "", conexion)
            comando.ExecuteNonQuery()
            comando = New MySqlCommand("UPDATE debitomatri SET DetDebMat = '" & txtDetalleCodDeb.Text & "', ImpDebMat = '" & Val(txtImporteCodDeb.Text) & "'" _
                                    & " WHERE CodDebMat = " & txtNroCodDeb.Text & " ", conexion)
            comando.ExecuteNonQuery()

            detmsg = "Registro actualizado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Edición cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM coddebito WHERE id_CodDeb = " & txtId_CodDeb.Text & " AND  NroCodDeb = " & txtNroCodDeb.Text & ""), conexion)
            comando.ExecuteNonQuery()
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        End If

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 2
        Dim frmDeb As New frmConsCodDebito
        AddOwnedForm(frmDeb)
        frmDeb.ShowDialog()
        senial = 0
        txtDetalleCodDeb.Focus()

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        CoddebitoTableAdapter.Fill(DbcolmartDataSet.coddebito)
        BtnAgregar.Visible = True
        BtnGrabar.Visible = False
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnBuscar.Visible = True
        BtnActualizar.Visible = True
        BtnPrimer.Visible = True
        BtnAnterior.Visible = True
        BtnSiguiente.Visible = True
        BtnUltimo.Visible = True

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        CoddebitoBindingSource.MoveFirst()

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        CoddebitoBindingSource.MovePrevious()

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        CoddebitoBindingSource.MoveNext()

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        CoddebitoBindingSource.MoveLast()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub txtImporteCodDeb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteCodDeb.KeyPress

        'SoloNumeros(txtImporteCodDeb, e)

    End Sub

    Private Sub txtImporteCodDeb_LostFocus(sender As Object, e As EventArgs) Handles txtImporteCodDeb.LostFocus

        'FormatoMoneda(txtImporteCodDeb)

    End Sub
End Class