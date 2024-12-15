Public Class CockpitForm
    Private _trip As Trip
    Public Event TourEnd()
    Private currentIndex As Integer = 0
    Private WithEvents slideTimer As New Timer()
    Private WithEvents progressTimer As New Timer()
    Private originalWidth
    Private isDragging As Boolean = False
    Private imageScale As Double = 1.0
    Private startPoint As Point
    Private originalHeight
    Private pause = False
    Private remainingTime
    Public Event Emergency()
    Private lastStartTime As Integer

    Public Sub New(trip As Trip)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _trip = trip
        Tour_Name.Text = _trip.TripName
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        originalWidth = WindowBox.Width
        originalHeight = WindowBox.Height
        StartTrip()
    End Sub
    Private Sub StartTrip()
        If _trip.Stops.Count > 0 Then
            ShowCurrentTrip()
        End If
    End Sub
    Private Sub ShowCurrentTrip()
        lastStartTime = Environment.TickCount
        progressTimer.Interval = 100
        progressTimer.Start()
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        slideTimer.Start()
        WindowBox.Image = _trip.Stops(currentIndex).CountryInfo.Image
        Location.Text = _trip.Stops(currentIndex).LocationName
        Information.Text = _trip.Stops(currentIndex).CountryInfo.TravelDescription
        Year.Text = _trip.Stops(currentIndex).Year
    End Sub

    Private Sub slideTimer_Tick(sender As Object, e As EventArgs) Handles slideTimer.Tick
        currentIndex = (currentIndex + 1)
        If currentIndex >= _trip.Stops.Count Then
            Dim endTour As New EndOfTour
            AddHandler endTour.EndTour, AddressOf TourEnded
            endTour.Show()
            slideTimer.Stop()
            progressTimer.Stop()
            Close()
        Else
            Me.Button4.Enabled = currentIndex < _trip.Stops.Count - 1
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub TourEnded()
        RaiseEvent TourEnd()
    End Sub
    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        Dim currentTime As Integer = Environment.TickCount
        Dim elapsed As Integer = currentTime - lastStartTime

        If elapsed >= slideTimer.Interval Then
            lastStartTime = currentTime
            elapsed = 0
        End If

        ProgressBar1.Value = elapsed * 100 / slideTimer.Interval
    End Sub
    Private Sub ZoomIn_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        imageScale += 0.1 ' Increment the zoom scale
        ApplyZoom()
    End Sub

    Private Sub ApplyZoom()
        Dim img As Image = WindowBox.Image
        WindowBox.Width = CInt(WindowBox.Width * imageScale)
        WindowBox.Height = CInt(WindowBox.Height * imageScale)
    End Sub

    Private Sub ZoomOut_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        If WindowBox.Height > originalHeight And WindowBox.Width > originalWidth Then ' Prevent zooming out too far
            imageScale -= 0.1
            ApplyZoom()
        End If
    End Sub

    Private Sub WindowBox_MouseDown(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseDown
        isDragging = True
        startPoint = e.Location
    End Sub

    Private Sub WindowBox_MouseMove(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseMove
        If isDragging Then
            Dim dx As Integer = e.X - startPoint.X
            Dim dy As Integer = e.Y - startPoint.Y

            Dim newX As Integer = Math.Max(Math.Min(WindowBox.Left + dx, 0), Panel1.Width - WindowBox.Width)
            Dim newY As Integer = Math.Max(Math.Min(WindowBox.Top + dy, 0), Panel1.Height - WindowBox.Height)

            WindowBox.Location = New Point(newX, newY)
        End If
    End Sub

    Private Sub WindowBox_MouseUp(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseUp
        isDragging = False
    End Sub

    Private Sub SpeedPlus_Click(sender As Object, e As EventArgs) Handles SpeedPlus.Click
        Speed.Text = (Int(Speed.Text) + 10).ToString()
    End Sub

    Private Sub SpeedMinus_Click(sender As Object, e As EventArgs) Handles SpeedMinus.Click
        Speed.Text = (Int(Speed.Text) - 10).ToString()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.BackColor = Color.CornflowerBlue
            slideTimer.Start()
            progressTimer.Start()

        Else
            Me.BackColor = Color.GreenYellow
            slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
            If remainingTime > 0 Then
                slideTimer.Interval = remainingTime
                remainingTime = 0
            End If
            slideTimer.Stop()
            progressTimer.Stop()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Forward.CheckedChanged
        If Forward.Checked Then
            Backward.Checked = False
        Else
            Backward.Checked = True
        End If
    End Sub

    Private Sub Backward_CheckedChanged(sender As Object, e As EventArgs) Handles Backward.CheckedChanged
        If Forward.Checked Then
            Backward.Checked = False
        Else
            Backward.Checked = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If pause Then
            Button3.Text = "Pause Time"
            pause = True
        Else
            Button3.Text = "Resume Time"
            pause = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        currentIndex = (currentIndex + 1)
        If currentIndex >= _trip.Stops.Count Then
            RaiseEvent TourEnd()
            slideTimer.Stop()
            progressTimer.Stop()
            Close()
        Else
            Me.Button4.Enabled = currentIndex < _trip.Stops.Count - 1
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent Emergency()
        slideTimer.Stop()
        progressTimer.Stop()
        Close()
    End Sub
End Class