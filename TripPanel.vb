Imports TimebusB2.CreateTour
Imports TimebusB2.MainInterface


Public Class TripPanel
    Public Function GetTripData() As Trip
        Dim trip2 As New Trip()
        trip2.TripName = "Sample Trip Name" ' Replace with actual trip name source, if available.

        ' Collect stop details from the labels.
        For i As Integer = 1 To 5
            Dim O As Integer
            Dim L As String
            Dim D As Double
            Dim stopDetails1 As New StopDetails(L, D, O)


            stopDetails1.Order = Integer.Parse(Controls($"Label{i}").Text)
            stopDetails1.LocationName = Controls($"Label{i + 5}").Text ' Labels 6 to 10
            stopDetails1.Duration = Double.Parse(Controls($"Label{i + 10}").Text) ' Labels 11 to 15

            trip2.Stops.Add(stopDetails1)
        Next

        Return trip2
    End Function







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tripData As Trip = GetTripData()
        Dim tripOKForm As New TripOK(tripData)
        tripOKForm.Show()
    End Sub
End Class
