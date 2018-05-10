Public Class frmConsulta

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarEventosDientes()
        CargarDatosPaciente()

       
    End Sub

    Private Sub CargarEventosDientes()
        For i As Integer = 0 To Me.ShapeContainer2.Shapes.Count - 1
            'If Me.ShapeContainer2.Shapes.Item(i) = PowerPacks.OvalShape Then
            Dim s As PowerPacks.OvalShape
            Try
                s = Me.ShapeContainer2.Shapes.Item(i)

                AddHandler s.Click, Sub(f, c)
                                        If s.FillStyle = PowerPacks.FillStyle.Transparent Then
                                            s.FillStyle = PowerPacks.FillStyle.Solid
                                            s.FillColor = Color.Red
                                        Else
                                            s.FillStyle = PowerPacks.FillStyle.Transparent

                                        End If
                                    End Sub

            Catch ex As Exception
                Continue For
            End Try
        Next
    End Sub


    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        Me.tabConsulta.SelectedTab = Me.tabDiagnostico
    End Sub

    Private Sub btnSig_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSig.Click
        Me.tabConsulta.SelectedTab = Me.tabplan
        'PRUEBA MKSR
    End Sub

    Private Sub CargarDatosPaciente()
        Me.txtFecha.Text = Today.Date.ToShortDateString
        Me.txtFecha.Enabled = False
    End Sub

End Class