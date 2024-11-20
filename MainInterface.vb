Public Class MainInterface


    Private Sub btnCreateTour_Click(sender As Object, e As EventArgs) Handles btnCreateTour.Click
        Me.Hide()
        Dim CreateTour As New CreateTour()
        CreateTour.Show()

    End Sub

    Private Sub btnModifyTour_Click(sender As Object, e As EventArgs) Handles btnModifyTour.Click
        Dim Modify As New ModifyTour()
        Modify.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Class StopDetails
        Public Property LocationName As String
        Public Property Duration As Double
        Public Property Order As Integer
        Public Property Button As Button

        ' Constructor to initialize all properties
        Public Sub New(locationName As String, duration As Double, order As Integer)
            Me.LocationName = locationName
            Me.Duration = duration
            Me.Order = order
        End Sub
    End Class

    Private Sub btnCopyTour_Click(sender As Object, e As EventArgs) Handles btnCopyTour.Click
        Dim CopyTour As New ExistingTrip()
        CopyTour.Show()
        Me.Hide()
    End Sub

    Private Sub btnCloseAll_Click(sender As Object, e As EventArgs) Handles btnCloseAll.Click
        ' Loop through all open forms and close them
        For Each frm As Form In Application.OpenForms
            If Not frm.Equals(Me) Then
                frm.Close() ' Close all forms except the current form
            End If
        Next

        Application.Exit()
    End Sub
End Class
