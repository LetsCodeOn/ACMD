Imports System.Drawing
Public Class frmHistoriaClinica

    Private Sub frmHistoriaClinico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DiseñoLogin()
    End Sub
#Region "Metodos"
    Sub DiseñoLogin()
        'Ajustar al centro de la pantalla 
        Dim top = (Me.Height / 2) - (pfrmHistorial.Height / 2)
        Dim left = (Me.Width / 2) - (pfrmHistorial.Width / 2)
        pfrmHistorial.Top = top
        pfrmHistorial.Left = left

        For Each tp As TabPage In TabHistorial.TabPages
            tp.BackColor = Color.FromArgb(255, 229, 204)
        Next
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabHistorial.SelectedTab = Me.Expediente

    End Sub


End Class