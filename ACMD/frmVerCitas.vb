Public Class frmVerCitas

    Private Sub frmVerCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DiseñoPantalla()
    End Sub
#Region "Metodos"
    Sub DiseñoPantalla()
        'Ajustar al centro de la pantalla 
        Dim top = (Me.Height / 2) - (pfrmConsulta.Height / 2)
        Dim left = (Me.Width / 2) - (pfrmConsulta.Width / 2)
        pfrmConsulta.Top = top
        pfrmConsulta.Left = left

    End Sub
#End Region

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmAgenda.Show()
    End Sub
End Class