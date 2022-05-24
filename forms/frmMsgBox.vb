Imports System.ComponentModel

Public Class frmMsgBox

    Private Sub frmMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtMensaje.Text = detmsg
        If tipomsg = "info" Then
            picInformacion.Visible = True
        End If
        If tipomsg = "question" Then
            picAdvertencia.Visible = True
        End If
        If tipomsg = "ok" Then
            picCorrecto.Visible = True
        End If

        If btnmsg = 1 Then
            btnAceptar.Visible = True
            btnCancelar.Visible = False
        End If
        If btnmsg = 2 Then
            btnAceptar.Visible = True
            btnCancelar.Visible = True
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Tag = "SI"
        Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Tag = "NO"
        Close()

    End Sub

End Class