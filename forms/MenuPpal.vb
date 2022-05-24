Imports System.Runtime.InteropServices

Public Class MenuPpal

    Dim ActiveForm As New Form

#Region "FUNCIONALIDADES DEL FORMULARIO"
    '---------------RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    '---------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelBotonesMenu.Region = region
        Me.Invalidate()
    End Sub

    '---------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(60, 60, 60))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    '---------------ARRASTRAR EL FORMULARIO

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    '---------------BOTONES BARRA TITULO

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Application.Exit()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        Size = New Size(sw, sh)
        Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Location.X
        ly = Location.Y
        sw = Size.Width
        sh = Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub
#End Region

#Region "Menu General"
    'METODO DE ABRIR FORMULARIO ------NO LO USAMOS POR AHORA
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion

        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            'AddHandler Formulario.FormClosed, AddressOf CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub MostrarHijo(formhijo As Form)

        If ActiveForm.Name <> formhijo.Name Then
            DesconectarMySql()
            ActiveForm.Close()
            ActiveForm = formhijo
            formhijo.TopLevel = False
            formhijo.FormBorderStyle = FormBorderStyle.None
            formhijo.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formhijo)
            PanelFormularios.Tag = formhijo
            formhijo.BringToFront()
            formhijo.Show()
        Else
            ActiveForm = formhijo
            formhijo.TopLevel = False
            formhijo.FormBorderStyle = FormBorderStyle.None
            formhijo.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formhijo)
            PanelFormularios.Tag = formhijo
            formhijo.BringToFront()
            formhijo.Show()
        End If

    End Sub

    Private Sub MenuPpal_Load(sender As Object, e As EventArgs) Handles Me.Load

        OcultarMenues()

    End Sub
    Private Sub OcultarMenues()

        SubMenuMatriculados.Visible = False
        SubMenuSociedades.Visible = False
        SubMenuCaja.Visible = False
        SubMenuParametros.Visible = False
        SubMenuSistema.Visible = False

    End Sub

    Private Sub OcultarSubmenu()

        If SubMenuMatriculados.Visible Then
            SubMenuMatriculados.Visible = False
        End If
        If SubMenuSociedades.Visible Then
            SubMenuSociedades.Visible = False
        End If
        If SubMenuCaja.Visible Then
            SubMenuCaja.Visible = False
        End If
        If SubMenuParametros.Visible Then
            SubMenuParametros.Visible = False
        End If
        If SubMenuSistema.Visible Then
            SubMenuSistema.Visible = False
        End If

    End Sub

    Private Sub MostrarSubmenu(Submenu)

        If Submenu.Visible = False Then
            OcultarSubmenu()
            Submenu.Visible = True
        Else
            Submenu.Visible = False
        End If

    End Sub

#End Region

#Region "Menu Matriculados"

    Private Sub btnMatriculados_Click(sender As Object, e As EventArgs) Handles btnMatriculados.Click

        MostrarSubmenu(SubMenuMatriculados)

    End Sub

    Private Sub btnActualizarMat_Click(sender As Object, e As EventArgs) Handles btnActualizarMat.Click

        MostrarHijo(frmMatriculados)
        OcultarSubmenu()

    End Sub

    Private Sub btnDebitosMat_Click(sender As Object, e As EventArgs) Handles btnDebitosMat.Click

        MostrarHijo(frmCargarDebMat)
        OcultarSubmenu()

    End Sub

    Private Sub btnLiquidarMat_Click(sender As Object, e As EventArgs) Handles btnLiquidarMat.Click

        MostrarHijo(frmLiquidarMat)
        OcultarSubmenu()

    End Sub

    Private Sub btnCtasCtesMat_Click(sender As Object, e As EventArgs) Handles btnCtasCtesMat.Click

        MostrarHijo(frmCtasCtesMat)
        OcultarSubmenu()

    End Sub

    Private Sub btnMailMat_Click(sender As Object, e As EventArgs) Handles btnMailMat.Click

        MostrarHijo(frmEnviarMail)
        OcultarSubmenu()

    End Sub

    Private Sub btnListadosMat_Click(sender As Object, e As EventArgs) Handles btnListadosMat.Click

        MostrarHijo(frmListaPadron)
        OcultarSubmenu()

    End Sub

    Private Sub btnSaldoPago_Click(sender As Object, e As EventArgs) Handles btnSaldoPago.Click

        MostrarHijo(frmListaSaldoPago)
        OcultarSubmenu()

    End Sub

    Private Sub btnListaOficio_Click(sender As Object, e As EventArgs) Handles btnListaOficio.Click

        MostrarHijo(frmListaOficio)
        OcultarSubmenu()

    End Sub

#End Region

#Region "Menu Sociedades"
    Private Sub btnSociedades_Click(sender As Object, e As EventArgs) Handles btnSociedades.Click

        MostrarSubmenu(SubMenuSociedades)

    End Sub

    Private Sub btnActualizarSoc_Click(sender As Object, e As EventArgs) Handles btnActualizarSoc.Click

        MostrarHijo(frmSociedades)
        OcultarSubmenu()

    End Sub

    Private Sub btnDebitosSoc_Click(sender As Object, e As EventArgs) Handles btnDebitosSoc.Click

        MostrarHijo(frmCargarDebSoc)
        OcultarSubmenu()

    End Sub

    Private Sub btnLiquidarSoc_Click(sender As Object, e As EventArgs) Handles btnLiquidarSoc.Click

        MostrarHijo(frmLiquidarSoc)
        OcultarSubmenu()

    End Sub

    Private Sub btnCtasCtesSoc_Click(sender As Object, e As EventArgs) Handles btnCtasCtesSoc.Click

        MostrarHijo(frmCtasCtesSoc)
        OcultarSubmenu()

    End Sub

    Private Sub btnBoletaSoc_Click(sender As Object, e As EventArgs) Handles btnBoletaSoc.Click

        MostrarHijo(frmBoletasSoc)
        OcultarSubmenu()

    End Sub

#End Region

#Region "Menu Caja"

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click

        MostrarSubmenu(SubMenuCaja)

    End Sub

    Private Sub btnMovimCaja_Click(sender As Object, e As EventArgs) Handles btnMovimCaja.Click

        MostrarHijo(frmMovimCaja)
        OcultarSubmenu()

    End Sub

    Private Sub btnReciboPago_Click_1(sender As Object, e As EventArgs) Handles btnReciboPago.Click

        MostrarHijo(frmReciboPago)
        OcultarSubmenu()

    End Sub

    Private Sub btnImportarBanco_Click_1(sender As Object, e As EventArgs) Handles btnImportarBanco.Click

        MostrarHijo(frmCobroBanco)
        OcultarSubmenu()

    End Sub

    Private Sub btnReciboGral_Click(sender As Object, e As EventArgs) Handles btnReciboGral.Click

        MostrarHijo(frmReciboGral)
        OcultarSubmenu()

    End Sub

#End Region

#Region "Menu Parámetros"
    Private Sub btnParametros_Click(sender As Object, e As EventArgs) Handles btnParametros.Click

        MostrarSubmenu(SubMenuParametros)

    End Sub

    Private Sub btnCodPostales_Click(sender As Object, e As EventArgs) Handles btnCodPostales.Click

        MostrarHijo(frmCodPostal)
        OcultarSubmenu()

    End Sub

    Private Sub btnCodDebitar_Click(sender As Object, e As EventArgs) Handles btnCodDebitar.Click

        MostrarHijo(frmCodigoDebito)
        OcultarSubmenu()

    End Sub

    Private Sub btnTribunal_Click(sender As Object, e As EventArgs) Handles btnTribunal.Click

        MostrarHijo(frmTribunales)
        OcultarSubmenu()

    End Sub

#End Region

#Region "Menu Sistema"
    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnSistema.Click

        MostrarSubmenu(SubMenuSistema)

    End Sub

    Private Sub btnNiveles_Click(sender As Object, e As EventArgs) Handles btnNiveles.Click

        MostrarHijo(frmNiveles)
        OcultarSubmenu()

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        MostrarHijo(frmUsuarios)
        OcultarSubmenu()

    End Sub

    Private Sub btnBackupRestore_Click(sender As Object, e As EventArgs) Handles btnBackupRestore.Click

        MostrarHijo(frmBackupRestore)
        OcultarSubmenu()

    End Sub

#End Region

#Region "Salir Sistema"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Application.Exit()

    End Sub

#End Region

End Class