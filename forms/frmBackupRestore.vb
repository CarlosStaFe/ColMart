Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.IO.File
Imports System.Data
Imports IWshRuntimeLibrary

Public Class frmBackupRestore
    Dim nomArchivo As New OpenFileDialog
    Dim posicion As Integer

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
            txtArchivoBac.Text = nomArchivo.FileName & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".sql"
            btnBackup.Visible = True
            btnRestore.Visible = False
        End If

    End Sub

    Private Sub btnBuscarRes_Click(sender As Object, e As EventArgs) Handles btnBuscarRes.Click

        nomArchivo.Filter = "Archivos | *.sql"
        If nomArchivo.ShowDialog = SaveFileDialog1.ShowDialog.OK Then
            txtArchivoRes.Text = nomArchivo.FileName
            btnBackup.Visible = False
            btnRestore.Visible = True
        End If

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Try
            Dim conn As MySqlConnection = New MySqlConnection("server=DESKTOP; database=dbcolmart; user id=martillero; password=soporte; Convert Zero Datetime=True")
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conn
            conn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(txtArchivoBac.Text)
            conn.Close()

            detmsg = "BACKUP Exitoso...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        btnBackup.Visible = False
        btnRestore.Visible = False
        txtArchivoBac.Text = ""

    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        Try
            Dim conn As MySqlConnection = New MySqlConnection("server=DESKTOP; database=dbcolmart; user id=martillero; password=soporte; Convert Zero Datetime=True")
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

    Private Sub Anterior()

        Try
            Dim cadena = "cmd.exe /c mysqldump -h localhost -u root -pcamb9145 dbcolmart > " & txtArchivoBac.Text & ""

            Shell(cadena)

            detmsg = "BACKUP Exitoso...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

        Try

            Dim cadena = "cmd.exe /c mysql -h localhost -u root -pcamb9145 dbcolmart < " & txtArchivoBac.Text & ""

            Shell(cadena)

            detmsg = "RESTORE Exitoso...!!!"
            tipomsg = "info"
            btnmsg = 1
            frmMsgBox.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtArchivoBac.Text = ""
        txtArchivoRes.Text = ""
        btnBackup.Visible = False
        btnRestore.Visible = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        DesconectarMySql()
        Close()

    End Sub

End Class