Public Class ExistingTrip
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ex1 As New ExistingConfirmation()
        ex1.Label3.Text = ToolStripStatusLabel1.Text
        ex1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ex1 As New ExistingConfirmation()
        ex1.Label3.Text = ToolStripStatusLabel2.Text
        ex1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ex1 As New ExistingConfirmation()
        ex1.Label3.Text = ToolStripStatusLabel3.Text
        ex1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MI As New MainInterface()
        MI.Show()
        Me.Close()
    End Sub
<<<<<<< HEAD
=======

    Private Sub ExistingTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
End Class