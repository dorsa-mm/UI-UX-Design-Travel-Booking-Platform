Public Class VisitorView
    Dim volumeRow As PictureBox() = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
    Dim brightnessRow As PictureBox() = {PictureBox11, PictureBox10, PictureBox9, PictureBox8, PictureBox7}
    Dim temperatureRow As PictureBox() = {PictureBox16, PictureBox15, PictureBox14, PictureBox13, PictureBox12}
    Private _trip As Trip
    Private WithEvents slideTimer As New Timer()
    Private currentIndex As Integer = 0
    Private WithEvents progressTimer As New Timer()
    Private remainingTime As Integer = 0
    Private _skipNext = False

    Public Sub New(trip As Trip)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _trip = trip
        Tour_Name.Text = _trip.TripName
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        StartTrip()
    End Sub

    Private Sub StartTrip()
        If _trip.Stops.Count > 0 Then
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub ShowCurrentTrip()
        progressTimer.Interval = 100
        progressTimer.Start()
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        slideTimer.Start()
        WindowBox.Image = _trip.Stops(currentIndex).CountryInfo.Image
        TourLocation.Text = _trip.Stops(currentIndex).LocationName
        Information.Text = _trip.Stops(currentIndex).CountryInfo.TravelDescription
        Year.Text = _trip.Stops(currentIndex).Year
    End Sub

    Private Sub slideTimer_Tick(sender As Object, e As EventArgs) Handles slideTimer.Tick
        ' Move to next trip
        If _skipNext Then
            currentIndex = (currentIndex + 2)
        Else
            currentIndex = (currentIndex + 1)
        End If
        MessageBox.Show(currentIndex)
        If currentIndex >= _trip.Stops.Count Then
            Dim endTour As New EndOfTour
            endTour.Show()
            Close()
        End If
        ShowCurrentTrip()
    End Sub

    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        Dim elapsed As Integer = slideTimer.Interval - (Environment.TickCount Mod slideTimer.Interval)
        ProgressBar1.Value = 100 - (elapsed * 100 / slideTimer.Interval)
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        remainingTime = slideTimer.Interval - (Environment.TickCount Mod slideTimer.Interval)
        slideTimer.Stop()
        progressTimer.Stop()
        Dim modifyTour As New ModifyTour(_trip)
        AddHandler modifyTour.Confirm, AddressOf UpdateTrip
        modifyTour.Show()
    End Sub

    Private Sub UpdateTrip(trip As Trip)
        _trip = trip
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        If remainingTime > 0 Then
            slideTimer.Interval = remainingTime
            remainingTime = 0
        End If
        slideTimer.Start()
        progressTimer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _skipNext = True
    End Sub
End Class
