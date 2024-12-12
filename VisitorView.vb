Public Class VisitorView
    Private volumeRow As PictureBox()
    Private brightnessRow As PictureBox()
    Private temperatureRow As PictureBox()
    Private aromaRow As PictureBox()
    Private _trip As Trip
    Private WithEvents slideTimer As New Timer()
    Private currentIndex As Integer = 0
    Private WithEvents progressTimer As New Timer()
    Private remainingTime As Integer = 0
    Private _skipNext = False
    Public Event TourEnd()
    Private imageScale As Double = 1.0
    Private originalWidth
    Private originalHeight
    Private isDragging As Boolean = False
    Private lastStartTime As Integer
    Private startPoint As Point

    Public Sub New(trip As Trip)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _trip = trip
        Tour_Name.Text = _trip.TripName
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        volumeRow = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        brightnessRow = {PictureBox11, PictureBox10, PictureBox9, PictureBox8, PictureBox7}
        temperatureRow = {PictureBox16, PictureBox15, PictureBox14, PictureBox13, PictureBox12}
        aromaRow = {PictureBox21, PictureBox20, PictureBox19, PictureBox18, PictureBox17}
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
        If currentIndex >= _trip.Stops.Count Then
            Dim endTour As New EndOfTour
            AddHandler endTour.EndTour, AddressOf TourEnded
            endTour.Show()
            slideTimer.Stop()
            progressTimer.Stop()
            Close()
        Else
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub TourEnded()
        slideTimer.Stop()
        progressTimer.Stop()
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

    Private Sub VolumeUp_Click(sender As Object, e As EventArgs) Handles VolumeUp.Click
        For Each box In volumeRow
            If box.BackColor <> Color.GreenYellow Then
                box.BackColor = Color.GreenYellow
                Exit Sub
            End If
        Next
    End Sub

    Private Sub VolumeDown_Click(sender As Object, e As EventArgs) Handles VolumeDown.Click
        For i As Integer = volumeRow.Length - 1 To 0 Step -1
            If volumeRow(i).BackColor <> Color.Gray Then
                volumeRow(i).BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BrightnessUp_Click(sender As Object, e As EventArgs) Handles BrightnessUp.Click
        For Each box In brightnessRow
            If box.BackColor <> Color.GreenYellow Then
                box.BackColor = Color.GreenYellow
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BrightnessDown_Click(sender As Object, e As EventArgs) Handles BrightnessDown.Click
        For i As Integer = brightnessRow.Length - 1 To 0 Step -1
            If brightnessRow(i).BackColor <> Color.Gray Then
                brightnessRow(i).BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TempUp_Click(sender As Object, e As EventArgs) Handles TempUp.Click
        For Each box In temperatureRow
            If box.BackColor <> Color.GreenYellow Then
                box.BackColor = Color.GreenYellow
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TempDown_Click(sender As Object, e As EventArgs) Handles TempDown.Click
        For i As Integer = temperatureRow.Length - 1 To 0 Step -1
            If temperatureRow(i).BackColor <> Color.Gray Then
                temperatureRow(i).BackColor = Color.Gray
                Exit Sub
            End If
        Next
    End Sub

    Private Sub AromaUp_Click(sender As Object, e As EventArgs) Handles AromaUp.Click
        For Each box In aromaRow
            If box.BackColor <> Color.GreenYellow Then
                box.BackColor = Color.GreenYellow
                Exit Sub
            End If
        Next
    End Sub

    Private Sub AromaDown_Click(sender As Object, e As EventArgs) Handles AromaDown.Click
        For i As Integer = aromaRow.Length - 1 To 0 Step -1
            If aromaRow(i).BackColor <> Color.Gray Then
                aromaRow(i).BackColor = Color.Gray
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
        slideTimer.Interval = 30000 * _trip.Stops(currentIndex).Duration
        If remainingTime > 0 Then
            slideTimer.Interval = remainingTime
            remainingTime = 0
        End If
        slideTimer.Start()
        progressTimer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _skipNext = True
        Button2.BackColor = Color.Red
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim endTour As New EndOfTour
        slideTimer.Stop()
        progressTimer.Stop()
        AddHandler endTour.EndTour, AddressOf TourEnded
        endTour.Show()
        Close()
    End Sub
End Class
