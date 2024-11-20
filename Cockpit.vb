Public Class CockpitForm
    Private _trip As Trip

    Public Sub New(trip As Trip)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _trip = trip
    End Sub
End Class