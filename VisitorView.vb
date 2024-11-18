Public Class VisitorView
    Dim volumeRow As PictureBox() = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
    Dim brightnessRow As PictureBox() = {PictureBox11, PictureBox10, PictureBox9, PictureBox8, PictureBox7}
    Dim temperatureRow As PictureBox() = {PictureBox16, PictureBox15, PictureBox14, PictureBox13, PictureBox12}

    Private Sub VolumeUp_Click(sender As Object, e As EventArgs) Handles VolumeUp.Click
        For Each box In volumeRow
            If box.BackColor <> Color.YellowGreen Then
                box.BackColor = Color.YellowGreen
                Exit Sub
            End If
        Next
    End Sub

    Private Sub VolumeDown_Click(sender As Object, e As EventArgs) Handles VolumeDown.Click
        For Each box In volumeRow
            If box.BackColor <> Color.Gray Then
                box.BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BrightnessUp_Click(sender As Object, e As EventArgs) Handles BrightnessUp.Click
        For Each box In brightnessRow
            If box.BackColor <> Color.YellowGreen Then
                box.BackColor = Color.YellowGreen
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BrightnessDown_Click(sender As Object, e As EventArgs) Handles BrightnessDown.Click
        For Each box In brightnessRow
            If box.BackColor <> Color.Gray Then
                box.BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TempUp_Click(sender As Object, e As EventArgs) Handles TempUp.Click
        For Each box In temperatureRow
            If box.BackColor <> Color.YellowGreen Then
                box.BackColor = Color.YellowGreen
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TempDown_Click(sender As Object, e As EventArgs) Handles TempDown.Click
        For Each box In temperatureRow
            If box.BackColor <> Color.Gray Then
                box.BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub
End Class
