Imports System.Net.Mail
Imports System.IO.Compression

Public Class frmBackupRestore
    Dim nomArchivo As New OpenFileDialog
    Dim directorio As String

    Private Sub frmBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarMySql()
        txtArchivoBac.Text = ""
        txtArchivoRes.Text = ""
        btnBackup.Visible = False
        btnRestore.Visible = False

    End Sub

    Private Sub btnBuscarBac_Click(sender As Object, e As EventArgs) Handles btnBuscarBac.Click

        nomArchivo.Filter = "Archivos | *.sql"
        If nomArchivo.ShowDialog = SaveFileDialog1.ShowDialog.OK Then
            txtArchivoBac.Text = Mid(nomArchivo.FileName, 1, 33) & "_" & Today.Date.ToString("dd-MM-yyyy") & "_" & TimeOfDay.ToString("hhmm") & ".sql"
            archivoBackup = txtArchivoBac.Text
            btnBackup.Visible = True
            btnRestore.Visible = False
        End If

    End Sub

    Private Sub btnBuscarBac_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarBac.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Archivo."
        ToolTipMsg.SetToolTip(btnBuscarBac, "Presione para buscar el archivo donde hacer el Backup.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnBuscarRes_Click(sender As Object, e As EventArgs) Handles btnBuscarRes.Click

        nomArchivo.Filter = "Archivos | *.sql"
        If nomArchivo.ShowDialog = SaveFileDialog1.ShowDialog.OK Then
            txtArchivoRes.Text = nomArchivo.FileName
            btnBackup.Visible = False
            btnRestore.Visible = True
        End If

    End Sub

    Private Sub btnBuscarRes_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarRes.MouseHover

        ToolTipMsg.ToolTipTitle = "Buscar Archivo."
        ToolTipMsg.SetToolTip(btnBuscarRes, "Presione para buscar el archivo donde hacer la Restauración.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        ProcesoBackup()

        btnBackup.Visible = False
        btnRestore.Visible = False
        txtArchivoBac.Text = ""

    End Sub

    Private Sub btnBackup_MouseHover(sender As Object, e As EventArgs) Handles btnBackup.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Backup."
        ToolTipMsg.SetToolTip(txtArchivoRes, "Presione para realizar el Backup.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        Try
            Dim conn As MySqlConnection = New MySqlConnection("server=DESKTOP; database=dbcolmart; user id=martillero1; password=soporte; Convert Zero Datetime=True")
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conn
            conn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ImportFromFile(txtArchivoRes.Text)
            conn.Close()

            detmsg = "RESTORE Exitoso...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        btnBackup.Visible = False
        btnRestore.Visible = False
        txtArchivoRes.Text = ""

    End Sub

    Private Sub btnRestore_MouseHover(sender As Object, e As EventArgs) Handles btnRestore.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Restore."
        ToolTipMsg.SetToolTip(txtArchivoRes, "Presione para realizar la Restauración.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtArchivoBac.Text = ""
        txtArchivoRes.Text = ""
        btnBackup.Visible = False
        btnRestore.Visible = False

    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Limpiar."
        ToolTipMsg.SetToolTip(btnLimpiar, "Presione para limpiar la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover

        ToolTipMsg.ToolTipTitle = "Botón Salir."
        ToolTipMsg.SetToolTip(btnSalir, "Presione para salir de la pantalla.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub


    Private Sub txtArchivoBac_MouseHover(sender As Object, e As EventArgs) Handles txtArchivoBac.MouseHover

        ToolTipMsg.ToolTipTitle = "Archivo de Backup."
        ToolTipMsg.SetToolTip(txtArchivoBac, "Ingrese el archivo buscando con la lupa.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtArchivoRes_MouseHover(sender As Object, e As EventArgs) Handles txtArchivoRes.MouseHover

        ToolTipMsg.ToolTipTitle = "Archivo de Restauración."
        ToolTipMsg.SetToolTip(txtArchivoRes, "Ingrese el archivo buscando con la lupa.")
        ToolTipMsg.ToolTipIcon = ToolTipIcon.Info

    End Sub


End Class