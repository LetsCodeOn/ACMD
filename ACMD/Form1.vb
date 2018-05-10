Imports System.Drawing.Drawing2D
Public Class Form1

#Region "Metodos"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DiseñoLogin()
    End Sub
    Sub DiseñoLogin()
        'Ajustar al centro de la pantalla 
        Dim top = (Me.Height / 2) - (pLogin.Height / 2)
        Dim left = (Me.Width / 2) - (pLogin.Width / 2)
        pLogin.Top = top
        pLogin.Left = left

        'Borde circular
        Dim gp As GraphicsPath = GetPath(pLogin.ClientRectangle, 20)
        pLogin.Region = New Region(gp)

    End Sub
#End Region

#Region "Funciones"
    Private Function GetPath(ByVal rc As Rectangle, ByVal r As Int32) As GraphicsPath
        Dim x As Int32 = rc.X, y As Int32 = rc.Y, w As Int32 = rc.Width, h As Int32 = rc.Height
        r = r << 1
        Dim path As GraphicsPath = New GraphicsPath()
        If r > 0 Then
            If (r > h) Then r = h
            If (r > w) Then r = w
            path.AddArc(x, y, r, r, 180, 90)
            path.AddArc(x + w - r, y, r, r, 270, 90)
            path.AddArc(x + w - r, y + h - r, r, r, 0, 90)
            path.AddArc(x, y + h - r, r, r, 90, 90)
            path.CloseFigure()
        Else
            path.AddRectangle(rc)
        End If
        Return path
    End Function
#End Region

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Me.Visible = False
        frmHomePage.Show()

    End Sub
End Class
