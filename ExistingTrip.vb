Imports TimebusB2.CreateTour
Imports TimebusB2.MainInterface
Imports TimebusB2.TripOK

Public Class ExistingTrip
    Dim stopDetailsList1 As New List(Of StopDetails)
    Dim stopDetailsList2 As New List(Of StopDetails)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time1 As Integer = Label3.Text
        ' Create a new Trip object and fill it with the current trip data
        Dim trip As New Trip
        trip.TripName = ToolStripStatusLabel1.Text
        trip.TotalDuration = time1

        ' Add all stops to the trip
        For Each stops In stopDetailsList1
            trip.Stops.Add(stops)
        Next

        ' Pass the Trip object to the new form
        Dim tripSummaryForm As New TripOK(trip)
        tripSummaryForm.Show() ' Show the new form

    End Sub
End Class