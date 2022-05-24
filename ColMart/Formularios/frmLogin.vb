Public Class frmLogin
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        txtUsuario.Select()

    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        consulta = "SELECT * FROM Usuarios WHERE UserUsuario = '" & txtUsuario.Text & "' AND ClaveUsuario = '" & txtClave.Text & "'"
        'consulta = "SELECT UserUsuario, ClaveUsuario, NivelUsuario FROM Usuarios WHERE UserUsuario = '" & txtUsuario.Text & "' AND ClaveUsuario = '" & txtClave.Text & "'"
        comando = New MySqlCommand(consulta, conexion)
        dr = comando.ExecuteReader

        If dr.HasRows = True Then
            While dr.Read
                usuario = dr("UserUsuario")
                nivel = dr("NivelUsuario")
                sector = dr("TipoUsuario")
                'usuario = dr(5).ToString
                'nivel = dr(3).ToString
            End While
            ProgressBar1.Visible = True
            lblPorcen.Visible = True
            Timer1.Enabled = True
            Timer1.Start()
        Else
            detmsg = "Ingreso no válido...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()
            Limpiar()
        End If
        dr.Close()

    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Ingresar."
        ToolTipMsg.SetToolTip(btnIngresar, "Presione para ingresar al sistema.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click

        Salir()
        'End

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub Limpiar()

        txtUsuario.Clear()
        txtClave.Clear()
        txtUsuario.Select()
        dr.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        lblPorcen.Text = ProgressBar1.Value.ToString & "%"

        If ProgressBar1.Value = 100 Then
            MenuPpal.Show()
            Hide()
        End If

    End Sub

    Private Sub Salir()

        DesconectarMySql()

    End Sub
End Class
