Imports System.Threading

Public Class loading
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form1.Show()
        Timer1.Stop()


    End Sub
End Class