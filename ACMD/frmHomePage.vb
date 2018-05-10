Public Class frmHomePage

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmConsulta.Show()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        frmHistoriaClinica.Show()
    End Sub

   
    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem.Click
        frmAgendarCita.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem1.Click
        frmVerCitas.Show()
    End Sub

    Private Sub frmHomePage_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Dispose()
    End Sub

    Private Sub frmHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim top = (Me.Height / 2) - (PictureBox1.Height / 2)
        Dim left = (Me.Width / 2) - (PictureBox1.Width / 2)
        PictureBox1.Top = top
        PictureBox1.Left = left
    End Sub
End Class