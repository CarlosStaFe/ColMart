'*******************************************************************************
'* PANTALLA DE MOVIMIENTOS DE MESA DE ENTRADA                                  *
'*******************************************************************************
Public Class frmMesaEntrada
    Private Sub frmMesaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MesaentradaTableAdapter.Fill(DbcolmartDataSet.mesaentrada)
        BuscarImagen()

    End Sub

    Private Sub MesaentradaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles MesaentradaBindingNavigatorSaveItem.Click

        Validate()
        MesaentradaBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DbcolmartDataSet)

    End Sub

    Private Sub BtnPrimer_Click(sender As Object, e As EventArgs) Handles BtnPrimer.Click

        MesaentradaBindingSource.MoveFirst()

    End Sub

    Private Sub BtnPrimer_MouseHover(sender As Object, e As EventArgs) Handles BtnPrimer.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Primer."
        ToolTipMsg.SetToolTip(BtnPrimer, "Presione para ir al primer registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        MesaentradaBindingSource.MovePrevious()

    End Sub

    Private Sub BtnAnterior_MouseHover(sender As Object, e As EventArgs) Handles BtnAnterior.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Anterior."
        ToolTipMsg.SetToolTip(BtnAnterior, "Presione para ir al registro anterior del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click

        MesaentradaBindingSource.MoveNext()

    End Sub

    Private Sub BtnSiguiente_MouseHover(sender As Object, e As EventArgs) Handles BtnSiguiente.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Siguiente."
        ToolTipMsg.SetToolTip(BtnSiguiente, "Presione para ir al registro siguiente del actual.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click

        MesaentradaBindingSource.MoveLast()

    End Sub

    Private Sub BtnUltimo_MouseHover(sender As Object, e As EventArgs) Handles BtnUltimo.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Último."
        ToolTipMsg.SetToolTip(BtnUltimo, "Presione para ir al último registro del padrón.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(BtnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        MesaentradaBindingSource.AddNew()

    End Sub

    Private Sub BtnAgregar_MouseHover(sender As Object, e As EventArgs) Handles BtnAgregar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Agregar."
        ToolTipMsg.SetToolTip(BtnAgregar, "Presione para ingresar los datos del movimiento de la mesa de entradas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        Try
            detmsg = "Desea grabar este registro...?"
            tipomsg = "question"
            btnmsg = 2
            frmMsgBox.ShowDialog()

            If frmMsgBox.Tag = "SI" Then
                MesaentradaBindingSource.EndEdit()
                MesaentradaTableAdapter.Update(DbcolmartDataSet.mesaentrada)
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

    End Sub

    Private Sub BtnGrabar_MouseHover(sender As Object, e As EventArgs) Handles BtnGrabar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Grabar."
        ToolTipMsg.SetToolTip(BtnGrabar, "Presione para grabar los datos ingresados de la mesa de entradas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        detmsg = "Desea modificar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand("UPDATE mesaentrada SET Fecha = '" & dtpFechaME.Text & "', Hora = '" & txtHoraME.Text & "', Ingreso = '" & txtNroIngresoME.Text & "', " _
                                    & "Dequien = '" & txtDeME.Text & "', Salida = '" & txtNroSalidaME.Text & "', Aquien = '" & txtAquienME.Text & "', Matri = '" & txtMatriME.Text & "', " _
                                    & "Asunto = '" & txtAsuntoME.Text & "', Delegacion = '" & ChbDelegacion.Text & "', Referido = '" & txtReferidoME.Text & "',  MatriRef = '" & txtMatriRefME.Text & "', " _
                                    & "Actor = '" & txtActorME.Text & "', Demandado = '" & txtDemandadoME.Text & "', Sobre = '" & txtSobreME.Text & "', Expediente = '" & txtExpedienteME.Text & "', " _
                                    & "Juzgado = '" & txtJuzgadoME.Text & "', Certificado = '" & txtCertJudME.Text & "', Nojudicial = '" & txtNoJudicialME.Text & "', Nota = '" & txtNotaME.Text & "', " _
                                    & "Bienes = '" & txtBienesSubastaME.Text & "', DiaSem = '" & cbxDiaSemana.Text & "', dd = '" & txtDdME.Text & "', mm = '" & cbxMes.Text & "', " _
                                    & "yyyy = '" & txtYyyyME.Text & "', HoaraSub = '" & txtHoraSubastaME.Text & "', Imagen = '" & picImagenME.Name & "' WHERE id_ME = " & txtId_ME.Text & "", conexion)
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
        End If
        MesaentradaTableAdapter.Fill(DbcolmartDataSet.mesaentrada)

    End Sub

    Private Sub BtnModificar_MouseHover(sender As Object, e As EventArgs) Handles BtnModificar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Modificar."
        ToolTipMsg.SetToolTip(BtnModificar, "Presione para grabar los datos de la mesa de entradas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        detmsg = "Desea eliminar este registro...?"
        tipomsg = "question"
        btnmsg = 2
        frmMsgBox.ShowDialog()

        If frmMsgBox.Tag = "SI" Then
            comando = New MySqlCommand(("DELETE FROM mesadeentrada WHERE id_ME = " & txtId_ME.Text & ""), conexion)
            comando.ExecuteNonQuery()
            detmsg = "Registro eliminado...!!!"
            tipomsg = "ok"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        Else
            detmsg = "Eliminación cancelada...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
        End If
        MesaentradaTableAdapter.Fill(DbcolmartDataSet.mesaentrada)

    End Sub

    Private Sub BtnEliminar_MouseHover(sender As Object, e As EventArgs) Handles BtnEliminar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Eliminar."
        ToolTipMsg.SetToolTip(BtnEliminar, "Presione para eliminar el registro de la mesa de entrada.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        senial = 0
        Dim frmMesa As New frmConsMesa
        AddOwnedForm(frmMesa)
        frmMesa.ShowDialog()
        'txtApelNombMatri.Focus()
        'MostrarFecha()
        'LeerCodPos()
        senial = 0

    End Sub

    Private Sub BtnBuscar_MouseHover(sender As Object, e As EventArgs) Handles BtnBuscar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Buscar."
        ToolTipMsg.SetToolTip(BtnBuscar, "Presione para buscar los registros de la mesa de entradas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'Actualizar()

    End Sub

    Private Sub BtnActualizar_MouseHover(sender As Object, e As EventArgs) Handles BtnActualizar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Actualizar."
        ToolTipMsg.SetToolTip(BtnActualizar, "Presione para volver al primer registro de la mesa de entradas.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click

        BuscarImagen()

    End Sub

    Private Sub BuscarImagen()

        If txtOrigenIMG.Text <> "" Then
            '            txtOrigenIMG.Text = Unidad & ":\DBHbGames\Fotos\CaraInicial.jpg"
        End If
    End Sub

End Class