Imports System.ComponentModel
Imports System.Transactions
Imports TimebusB2.MainInterface

Public Class CreateTour

    Public Class CountryInfo
        Public Property Description As String
        Public Property Image As Image

        Public Sub New(description As String, image As Image)
            Me.Description = description
            Me.Image = image
        End Sub
    End Class
    Private Sub BtnTourSet_Click(sender As Object, e As EventArgs) Handles btnTourSet.Click
        Dim tourname As String = txtTourName.Text
        If tourname = "" Then
            MessageBox.Show("Please enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lblTourName.Text = tourname
            panelAgeSelection.Visible = True
            panelTourStatus.Visible = True

        End If
    End Sub



    Private Sub btnPast_Click(sender As Object, e As EventArgs) Handles btnPast.Click
        Panel1.Visible = True
    End Sub

    Private Sub btnFuture_Click(sender As Object, e As EventArgs) Handles btnFuture.Click
        Panel1.Visible = True
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim EraName As String = txtTimeLine.Text
        If EraName = "" Then
            MessageBox.Show("Please enter a valid era", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lblTimeLine.Text = EraName
            panelContinent.Visible = True

        End If
    End Sub
    Private Sub UpdateMap(continent As String)
        Panel2.Visible = True
        If continent = "NA" Then
            mapBox.Image = My.Resources.north_america_continent_map
        End If
        If continent = "SA" Then
            mapBox.Image = My.Resources.south_america_continent_map
        End If
        If continent = "AF" Then
            mapBox.Image = My.Resources.africa
        End If
        If continent = "AUS" Then
            mapBox.Image = My.Resources.australia
        End If
        If continent = "AS" Then
            mapBox.Image = My.Resources.asia
        End If
        If continent = "EU" Then
            mapBox.Image = My.Resources.europe
        End If
        If continent = "ANT" Then
            mapBox.Image = My.Resources.antarctica
        End If
    End Sub

    Private continentCountries As New Dictionary(Of String, List(Of String)) From {
    {"Africa", New List(Of String) From {"Nigeria", "Egypt", "South Africa", "Kenya", "Ghana"}},
    {"Asia", New List(Of String) From {"China", "India", "Japan", "South Korea", "Indonesia"}},
    {"Europe", New List(Of String) From {"France", "Germany", "Italy", "Spain", "United Kingdom"}},
    {"North America", New List(Of String) From {"United States", "Canada", "Mexico"}},
    {"South America", New List(Of String) From {"Brazil", "Argentina", "Colombia", "Chile"}},
    {"Australia", New List(Of String) From {"Australia", "New Zealand"}},
    {"Antarctica", New List(Of String) From {"Research Stations"}}
}
    Private Sub UpdateListBox(continent As String)

        If continentCountries.ContainsKey(continent) Then
            ListBox1.Items.Clear()  ' Clear previous entries
            ListBox1.Items.AddRange(continentCountries(continent).ToArray())
        Else
            MessageBox.Show("No countries available for this continent.", "Information")
        End If
    End Sub

    Private Sub btnNorthAmerica_Click(sender As Object, e As EventArgs) Handles btnNorthAmerica.Click
        UpdateMap("NA")
        UpdateListBox("North America")

    End Sub

    Private Sub btnEurope_Click(sender As Object, e As EventArgs) Handles btnEurope.Click
        UpdateMap("EU")
        UpdateListBox("Europe")

    End Sub

    Private Sub btnAsia_Click(sender As Object, e As EventArgs) Handles btnAsia.Click
        UpdateMap("AS")
        UpdateListBox("Asia")

    End Sub

    Private Sub btnSouthAmerica_Click(sender As Object, e As EventArgs) Handles btnSouthAmerica.Click
        UpdateMap("SA")
        UpdateListBox("South America")

    End Sub

    Private Sub btnAfrica_Click(sender As Object, e As EventArgs) Handles btnAfrica.Click
        UpdateMap("AF")
        UpdateListBox("Africa")

    End Sub

    Private Sub ButtonAussie_Click(sender As Object, e As EventArgs) Handles btnAustralia.Click
        UpdateMap("AUS")
        UpdateListBox("Australia")

    End Sub

    Private Sub btnAntartica_Click(sender As Object, e As EventArgs) Handles btnAntartica.Click
        UpdateMap("ANT")
        UpdateListBox("Antarctica")


    End Sub

    Private countryDetails As New Dictionary(Of String, CountryInfo) From {
    {"United States", New CountryInfo("US is a country in North America...", My.Resources.NY)},
    {"Canada", New CountryInfo("Canada is a country in North America...", My.Resources.cn_tower)},
    {"Mexico", New CountryInfo("Mexico Papi is a country in North America...", My.Resources.Mexico)}
}

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Panel3.Visible = True
        ' Check if a country is selected
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedCountry As String = ListBox1.SelectedItem.ToString()

            ' Check if country details exist for the selected country
            If countryDetails.ContainsKey(selectedCountry) Then
                Dim info As CountryInfo = countryDetails(selectedCountry)

                ' Update the panel controls with country details
                lblPlaceName.Text = selectedCountry
                lblDesc.Text = info.Description
                boxPlace.Image = info.Image
                ' Load and set the country image
            End If
        End If
    End Sub

    Private cumulativeDuration As Double = 0.0
    Private serialNumber As Integer = 1
    Private stopCount As Integer = 0 ' Track the number of stops



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelBoxes.Controls.Clear() ' Clear all stop panels
        cumulativeDuration = 0.0
        stopCount = 0
        serialNumber = 1
        progressDuration.Value = 0
        lblDurationstatus.Text = "0.0/6 hours" ' Reset the duration status label


    End Sub




    Private boxCounter As Integer = 1
    Private boxList As New List(Of Button)






    'Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnAdder.Click

    '    If ListBox1.SelectedItem Is Nothing Then
    '        MessageBox.Show("Please select a country.", "Warning")
    '        Return
    '    End If

    '    Dim selectedCountry As String = ListBox1.SelectedItem.ToString()
    '    Dim labeldata As String = lblPlaceName.Text

    '    Dim duration As Double
    '    If Not Double.TryParse(txtDuration.Text, duration) Then
    '        MessageBox.Show("Please enter a valid duration in hours (e.g., 1, 1.5).", "Invalid Input")
    '        Return
    '    End If


    '    ' Check if adding this duration would exceed the 6-hour limit
    '    If cumulativeDuration + duration > 6.0 Then
    '        MessageBox.Show("Cannot add this stop. Exceeds maximum tour duration of 6 hours.", "Limit Exceeded")
    '        Return
    '    End If

    '    If stopCount >= 6 Then
    '        MessageBox.Show("Cannot add more stops. Maximum of 6 stops reached.", "Limit Exceeded")
    '        Return
    '    End If





    '    ' Update the cumulative duration and the progress bar
    '    cumulativeDuration += duration
    '    progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)

    '    lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"









    '    ' Update counters
    '    stopCount += 1



    '    serialNumber += 1

    '    ' Clear the duration input for the next entry
    '    txtDuration.Clear()



    '    Dim newBox As New Button With {
    '    .Text = lblPlaceName.Text,
    '    .Width = 65,
    '    .Height = 65,
    '    .BackColor = Color.Black,
    '    .ForeColor = Color.Red,
    '    .FlatStyle = FlatStyle.Flat
    '}
    '    newBox.FlatAppearance.BorderSize = 0
    '    Dim PanelName As String = "panelTripSummary"


    '    AddHandler newBox.Click, Sub(senderObj, args)
    '                                 ShowDataPanel(PanelName)
    '                             End Sub

    '    Dim boxNumber As Integer = 0
    '    Dim reusedIndex As Integer = -1
    '    Dim boxData As String






    '    For i As Integer = 0 To boxList.Count - 1
    '        If boxList(i) Is Nothing Then
    '            reusedIndex = i
    '            boxData = lblPlaceName.Text
    '            Exit For
    '        End If
    '    Next



    '    If reusedIndex = -1 Then
    '        boxNumber = boxCounter
    '        newBox.BackColor = Color.Black


    '        newBox.ForeColor = Color.White
    '        boxList.Add(newBox)
    '        boxCounter += 1
    '    Else
    '        newBox.BackColor = Color.Green
    '        newBox.ForeColor = Color.White


    '        boxList(reusedIndex) = newBox
    '    End If

    '    newBox.Text = lblPlaceName.Text
    '    panelBoxes.Controls.Add(newBox)
    '    PositionBoxes()


    'End Sub



    Private Sub PositionBoxes()
        Dim boxWidth As Integer = 65
        Dim boxHeight As Integer = 65
        Dim spacing As Integer = 5
        Dim maxPanelWidth As Integer = panelBoxes.Width
        Dim boxesPerRow As Integer = maxPanelWidth \ (boxWidth + spacing)

        For i As Integer = 0 To boxList.Count - 1
            Dim box = boxList(i)

            If box IsNot Nothing Then
                Dim row As Integer = i \ boxesPerRow
                Dim col As Integer = i Mod boxesPerRow

                Dim xPos As Integer = col * (boxWidth + spacing)
                Dim yPos As Integer = row * (boxHeight + spacing)
                box.Location = New Point(xPos, yPos)
            End If
        Next
    End Sub





    Dim stopDetailsList As New List(Of StopDetails)

    Private Sub btnAdder_Click(sender As Object, e As EventArgs) Handles btnAdder.Click
        ' Ensure a location is selected
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a country.", "Warning")
            Return
        End If

        Dim selectedCountry As String = ListBox1.SelectedItem.ToString()
        Dim duration As Double
        Dim order As Integer

        ' Validate duration input
        If Not Double.TryParse(txtDuration.Text, duration) Then
            MessageBox.Show("Please enter a valid duration in hours (e.g., 1, 1.5).", "Invalid Input")
            Return
        End If
        If Not Integer.TryParse(NumericUpDown1.Value, order) Then
            MessageBox.Show("Please Enter a valid Stop from (1-12)", "Invalid Input")
        End If

        ' Check cumulative duration limit
        If cumulativeDuration + duration > 6.0 Then
            MessageBox.Show("Cannot add this stop. Exceeds maximum tour duration of 6 hours.", "Limit Exceeded")
            Return
        End If

        ' Create a new StopDetails instance
        Dim stopDetails As New StopDetails(selectedCountry, duration, order)

        ' Create a new button for the stop
        Dim newButton As New Button With {
        .Text = selectedCountry,
        .Width = 65,
        .Height = 65,
        .BackColor = Color.Black,
        .ForeColor = Color.Red,
        .FlatStyle = FlatStyle.Flat,
        .Tag = stopDetails
    }

        ' Add click handler to the button
        AddHandler newButton.Click, AddressOf StopButton_Click

        ' Add button to the panel
        panelBoxes.Controls.Add(newButton)

        ' Update the stop details list
        stopDetails.Button = newButton
        stopDetailsList.Add(stopDetails)

        ' Update cumulative duration
        cumulativeDuration += duration
        progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
        lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"

        ' Clear input fields
        txtDuration.Clear()

        ' Reposition all buttons dynamically
        PositionBoxes2()
    End Sub





    ' Dynamically arrange buttons in the panel
    Private Sub PositionBoxes2()
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim margin As Integer = 5

        For Each btn As Button In panelBoxes.Controls.OfType(Of Button)()
            btn.Location = New Point(x, y)
            x += btn.Width + margin
            If x + btn.Width > panelBoxes.Width Then
                x = 10
                y += btn.Height + margin
            End If
        Next
    End Sub


    Private Sub StopButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim stopDetails As StopDetails = CType(clickedButton.Tag, StopDetails)

        ' Display trip summary with options to edit or delete
        Dim result As DialogResult = MessageBox.Show($"Stop Name: {stopDetails.LocationName}{Environment.NewLine}" &
                                                    $"Stop Order: {stopDetails.Order}{Environment.NewLine}" &
                                                 $"Duration: {stopDetails.Duration} hours{Environment.NewLine}" &
                                                 $"{Environment.NewLine}" &
                                                 "Press 'Yes' to Edit, 'No' to Delete this stop.",
                                                 "Edit/Delete Stop", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            ' Edit the stop
            Dim newDurationStr As String = InputBox("Enter new duration (in hours):", "Edit Duration", stopDetails.Duration.ToString())
            Dim newDuration As Double
            Dim newOrderStr As String = InputBox("Enter new Order (in integers):", "Edit Visit Order", stopDetails.Order.ToString())
            Dim newOrder As Integer

            If Double.TryParse(newDurationStr, newDuration) AndAlso (cumulativeDuration - stopDetails.Duration + newDuration <= 6.0) Then
                ' Update duration
                cumulativeDuration = cumulativeDuration - stopDetails.Duration + newDuration
                stopDetails.Duration = newDuration
                lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"
                progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
            Else
                MessageBox.Show("Invalid or exceeding duration. Edit canceled.", "Error")
            End If

            If Integer.TryParse(newOrderStr, newOrder) Then
                stopDetails.Order = newOrder
            End If
        ElseIf result = DialogResult.No Then
            ' Delete the stop
            cumulativeDuration -= stopDetails.Duration
            lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"
            progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
            stopDetailsList.Remove(stopDetails)
            panelBoxes.Controls.Remove(clickedButton)
            PositionBoxes2()
        End If
    End Sub

    Public Class Trip
        Public Property Stops As List(Of StopDetails)  ' List of stops
        Public Property TotalDuration As Double  ' Total duration
        Public Property TripName As String  ' Name of the trip

        Public Sub New()
            Stops = New List(Of StopDetails)()
            TotalDuration = 0.0
        End Sub
    End Class






    Private Sub lbl2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged

    End Sub

    Private Sub CreateTour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCreateTour.Visible = True
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnConfirmTrip_Click(sender As Object, e As EventArgs) Handles btnConfirmTrip.Click
        ' Create a new Trip object and fill it with the current trip data
        Me.Hide()
        Dim trip As New Trip()
        trip.TripName = lblTourName.Text
        trip.TotalDuration = cumulativeDuration

        ' Add all stops to the trip
        For Each stops As StopDetails In stopDetailsList
            trip.Stops.Add(stops)
        Next

        ' Pass the Trip object to the new form
        Dim tripSummaryForm As New TripOK(trip)
        tripSummaryForm.Show() ' Show the new form





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MI As New MainInterface()
        MI.Show()
        Me.Close()
    End Sub
End Class