Public Class frmLogin
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        txtUsuario.Select()

    End Sub

    Private Sub btnIngreso_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnIngreso.Click

        consulta = "SELECT Usuario, Clave FROM Usuarios WHERE Usuario = '" & txtUsuario.Text & "' AND Clave = '" & txtClave.Text & "'"
        comando = New MySql.Data.MySqlClient.MySqlCommand(consulta, conexion)
        dr = comando.ExecuteReader

        If dr.HasRows = True Then
            ProgressBar1.Visible = True
            lblPorcen.Visible = True
            Timer1.Enabled = True
            Timer1.Start()
        Else
            MsgBox("Ingreso no válido", MsgBoxStyle.Critical, "Aviso")
            Limpiar()
        End If

    End Sub

    Private Sub Limpiar()

        txtUsuario.Clear()
        txtClave.Clear()
        txtUsuario.Select()
        dr.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        End

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        lblPorcen.Text = ProgressBar1.Value.ToString & "%"

        If ProgressBar1.Value = 100 Then
            DesconectarMySql()
            MenuPpal.Show()
            Me.Hide()
        End If

    End Sub

End Class
