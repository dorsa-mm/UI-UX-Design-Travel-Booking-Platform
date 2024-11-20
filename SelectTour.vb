Public Class SelectTour
    Private _trips As List(Of Trip)
    Public Event Confirm(trip As Trip)
    Private _isModify As Boolean
    Private _isPilot As Boolean
    Public Event TourEnd()

    Public Sub New(trips As List(Of Trip), isModify As Boolean, isPilot As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _trips = trips
        _isModify = isModify
        _isPilot = isPilot
        ShowTrips(_trips)
    End Sub

    Private Sub ShowTrips(trips As List(Of Trip))
        Dim startX As Integer = 290 ' Starting X-coordinate
        Dim startY As Integer = 95 ' Starting Y-coordinate
        Dim buttonHeight As Integer = 30 ' Height of each button
        Dim verticalSpacing As Integer = 10 ' Space between buttons

        For i As Integer = 0 To trips.Count - 1
            Dim trip As Trip = trips(i)

            ' Create a new button
            Dim tripButton As New Button()
            tripButton.Text = trip.TripName ' Replace "Name" with the actual property for the trip name
            tripButton.Size = New Size(200, buttonHeight) ' Set size
            tripButton.Location = New Point(startX, startY + i * (buttonHeight + verticalSpacing)) ' Position dynamically

            ' Optionally, add a click event handler for each button
            AddHandler tripButton.Click, Sub(sender, e) HandleTripButtonClick(trip)

            ' Add the button to the form or container
            Me.Controls.Add(tripButton)
        Next
    End Sub

    ' Example handler for trip button clicks
    Private Sub HandleTripButtonClick(trip As Trip)
        If _isModify Then
            Dim ModifyTour As New ModifyTour(trip)
            AddHandler ModifyTour.Confirm, AddressOf Modified
            ModifyTour.Show()
        ElseIf _isPilot Then
            Dim Cockpit As New CockpitForm(trip)
            AddHandler Cockpit.TourEnd, AddressOf EndedTour
            AddHandler Cockpit.Emergency, AddressOf EndedTour
            Cockpit.Show()
        Else
            Dim Visitor As New VisitorView(trip)
            AddHandler Visitor.TourEnd, AddressOf EndedTour
            Visitor.Show()
        End If
        Close()
    End Sub

    Private Sub EndedTour()
        RaiseEvent TourEnd()
    End Sub

    Private Sub Modified(trip As Trip)
        RaiseEvent Confirm(trip)
    End Sub

    Private Sub SelectTour_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class