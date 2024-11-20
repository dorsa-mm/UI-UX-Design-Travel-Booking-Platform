Imports TimebusB2.CreateTour

Public Class ModifyTour
    Private orderMapping As Dictionary(Of Label, TextBox)
    Private spotMapping As Dictionary(Of Label, TextBox)
    Private durationMapping As Dictionary(Of Label, TextBox)
    Private titleMapping As Dictionary(Of Label, TextBox)

    Private Sub AAA(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize trip details here or dynamically load them from data storage
        InitializeTrips()

        For i As Integer = 1 To 6
            Dim durationLabel As Label = TryCast(Me.Controls($"lblDur{i}"), Label)
            If durationLabel IsNot Nothing Then
                AddHandler durationLabel.Click, AddressOf Label_Click
            End If

            Dim spotLabel As Label = TryCast(Me.Controls($"lblSpot{i}"), Label)
            If spotLabel IsNot Nothing Then
                AddHandler spotLabel.Click, AddressOf Label_Click
            End If
        Next

        orderMapping = New Dictionary(Of Label, TextBox) From {
            {lblOrder1, TextBox1},
            {lblOrder2, TextBox1},
            {lblOrder3, TextBox1},
            {lblOrder4, TextBox1},
            {lblOrder5, TextBox1},
            {lblOrder6, TextBox1}
        }

        spotMapping = New Dictionary(Of Label, TextBox) From {
            {lblSpot1, TextBox2},
            {lblSpot2, TextBox2},
            {lblSpot3, TextBox2},
            {lblSpot4, TextBox2},
            {lblSpot5, TextBox2},
            {lblSpot6, TextBox2}
        }

        durationMapping = New Dictionary(Of Label, TextBox) From {
            {lblDur1, TextBox3},
            {lblDur2, TextBox3},
            {lblDur3, TextBox3},
            {lblDur4, TextBox3},
            {lblDur5, TextBox3},
            {lblDur6, TextBox3}
        }
        titleMapping = New Dictionary(Of Label, TextBox) From {
            {lblTripName1, TextBox4}}






    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        ' Check if a label is selected before making any changes
        If lblSelected IsNot Nothing Then
            Dim textBox = DirectCast(sender, TextBox)

            ' Update only the selected label
            If textBox Is TextBox1 Then
                lblSelected.Text = textBox.Text ' Update only the selected order label
            ElseIf textBox Is TextBox2 Then
                lblSelected.Text = textBox.Text ' Update only the selected spot label
            ElseIf textBox Is TextBox3 Then
                lblSelected.Text = textBox.Text ' Update only the selected duration label

            ElseIf textBox Is TextBox4 Then
                lblSelected.Text = textBox.Text
            End If
        End If
    End Sub


    Private Sub InitializeTrips()
        ' Populate initial trip data (Example: hard-coded for now)
        lblTripName1.Text = "Historical Landmarks"
        lblOrder1.Text = "1"
        lblOrder2.Text = "2"
        lblOrder3.Text = "3"
        lblOrder4.Text = "4"
        lblOrder5.Text = "5"
        lblOrder6.Text = "6"
        lblSpot1.Text = "Ancient Rome"
        lblSpot2.Text = "Ephesus"
        lblSpot3.Text = "Jerusalem"
        lblSpot4.Text = "Alexandria"
        lblSpot5.Text = "Pompeii"
        lblSpot6.Text = "Carthage"
        lblDur1.Text = "1 hr"
        lblDur2.Text = "1 hr"
        lblDur3.Text = "1 hr"
        lblDur4.Text = "1 hr"
        lblDur5.Text = "1 hr"
        lblDur6.Text = "1 hr"
        ' Initialize dictionaries


        ' Assign TextChanged events dynamically

    End Sub





    Private lblSelected As Label = Nothing

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles lblDur1.Click, lblDur6.Click, lblDur2.Click, lblDur5.Click, lblDur4.Click, lblDur3.Click, lblOrder6.Click, lblOrder5.Click, lblOrder4.Click, lblOrder3.Click, lblOrder2.Click, lblSpot6.Click, lblOrder1.Click, lblSpot5.Click, lblSpot4.Click, lblSpot2.Click, lblSpot3.Click, lblSpot1.Click, lblTripName1.Click
        Dim clickedLabel = DirectCast(sender, Label)

        If lblSelected IsNot Nothing Then
            lblSelected.BackColor = SystemColors.Control
        End If

        ' Highlight the new label
        lblSelected = DirectCast(sender, Label)
        lblSelected.BackColor = Color.LightBlue


        If clickedLabel.Name.StartsWith("lblOrder") Then
            TextBox1.Text = clickedLabel.Text
        ElseIf clickedLabel.Name.StartsWith("lblSpot") Then
            TextBox2.Text = clickedLabel.Text
        ElseIf clickedLabel.Name.StartsWith("lblDur") Then
            TextBox3.Text = clickedLabel.Text
        ElseIf clickedLabel.Name.StartsWith("lblTripName") Then
            TextBox4.Text = clickedLabel.Text
        End If
    End Sub

    Private textboxLabelMapping As Dictionary(Of TextBox, Label)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add more mappings for all 15 labels
    End Sub





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the total duration from all duration labels

        ' Close the form
        MessageBox.Show("Changes saved successfully!", "Success")
        Me.Close()
    End Sub

    Private Sub btnModify1_Click(sender As Object, e As EventArgs) Handles btnModify1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MI As New MainInterface()
        MI.Show()
        Me.Hide()
    End Sub
End Class
