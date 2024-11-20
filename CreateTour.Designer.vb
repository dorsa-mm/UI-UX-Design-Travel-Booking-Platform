<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTour
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel3 = New Panel()
        lblDesc = New Label()
        btnAdder = New Button()
        txtDuration = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        Label8 = New Label()
        boxPlace = New PictureBox()
        lblPlaceName = New Label()
        Label12 = New Label()
        Panel2 = New Panel()
        Label9 = New Label()
        ListBox1 = New ListBox()
        mapBox = New PictureBox()
        panelContinent = New Panel()
        lblTimeLine = New Label()
        Label6 = New Label()
        btnAntartica = New Button()
        btnAfrica = New Button()
        btnAsia = New Button()
        btnEurope = New Button()
        btnSouthAmerica = New Button()
        btnAustralia = New Button()
        btnNorthAmerica = New Button()
        Label5 = New Label()
        panelAgeSelection = New Panel()
        Label2 = New Label()
        btnFuture = New Button()
        btnPast = New Button()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtTimeLine = New TextBox()
        Label4 = New Label()
        panelTourStatus = New Panel()
        Panel4 = New Panel()
        panelBoxes = New Panel()
        Button1 = New Button()
        lblTourName = New Label()
        Label3 = New Label()
        Label7 = New Label()
        progressDuration = New ProgressBar()
        btnConfirmTrip = New Button()
        lblDurationstatus = New Label()
        panelCreateTour = New Panel()
        btnTourSet = New Button()
        txtTourName = New TextBox()
        lblTourNamePrompt = New Label()
        Button2 = New Button()
        Panel3.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(boxPlace, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(mapBox, ComponentModel.ISupportInitialize).BeginInit()
        panelContinent.SuspendLayout()
        panelAgeSelection.SuspendLayout()
        Panel1.SuspendLayout()
        panelTourStatus.SuspendLayout()
        Panel4.SuspendLayout()
        panelCreateTour.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblDesc)
        Panel3.Controls.Add(btnAdder)
        Panel3.Controls.Add(txtDuration)
        Panel3.Controls.Add(NumericUpDown1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(boxPlace)
        Panel3.Controls.Add(lblPlaceName)
        Panel3.Controls.Add(Label12)
        Panel3.Location = New Point(381, 348)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(374, 189)
        Panel3.TabIndex = 17
        Panel3.Visible = False
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Trebuchet MS", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        lblDesc.Location = New Point(16, 44)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(41, 16)
        lblDesc.TabIndex = 6
        lblDesc.Text = "Label7"
        ' 
        ' btnAdder
        ' 
        btnAdder.Location = New Point(58, 152)
        btnAdder.Name = "btnAdder"
        btnAdder.Size = New Size(179, 23)
        btnAdder.TabIndex = 5
        btnAdder.Text = "Add Visit"
        btnAdder.UseVisualStyleBackColor = True
        ' 
        ' txtDuration
        ' 
        txtDuration.Location = New Point(114, 122)
        txtDuration.Name = "txtDuration"
        txtDuration.Size = New Size(100, 21)
        txtDuration.TabIndex = 3
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(323, 123)
        NumericUpDown1.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(30, 21)
        NumericUpDown1.TabIndex = 12
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 13)
        Label8.TabIndex = 2
        Label8.Text = "Visit Duration:"
        ' 
        ' boxPlace
        ' 
        boxPlace.Location = New Point(243, 10)
        boxPlace.Name = "boxPlace"
        boxPlace.Size = New Size(117, 78)
        boxPlace.SizeMode = PictureBoxSizeMode.StretchImage
        boxPlace.TabIndex = 1
        boxPlace.TabStop = False
        ' 
        ' lblPlaceName
        ' 
        lblPlaceName.AutoSize = True
        lblPlaceName.Location = New Point(13, 10)
        lblPlaceName.Name = "lblPlaceName"
        lblPlaceName.Size = New Size(45, 13)
        lblPlaceName.TabIndex = 0
        lblPlaceName.Text = "Label7"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(233, 125)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 13)
        Label12.TabIndex = 2
        Label12.Text = "Stop Number:"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(ListBox1)
        Panel2.Controls.Add(mapBox)
        Panel2.Location = New Point(12, 348)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(363, 189)
        Panel2.TabIndex = 16
        Panel2.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(5, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(187, 13)
        Label9.TabIndex = 2
        Label9.Text = "Select Your Prefered Location"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(5, 26)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(189, 147)
        ListBox1.TabIndex = 1
        ' 
        ' mapBox
        ' 
        mapBox.Location = New Point(200, 8)
        mapBox.Name = "mapBox"
        mapBox.Size = New Size(151, 165)
        mapBox.SizeMode = PictureBoxSizeMode.StretchImage
        mapBox.TabIndex = 0
        mapBox.TabStop = False
        ' 
        ' panelContinent
        ' 
        panelContinent.BorderStyle = BorderStyle.Fixed3D
        panelContinent.Controls.Add(lblTimeLine)
        panelContinent.Controls.Add(Label6)
        panelContinent.Controls.Add(btnAntartica)
        panelContinent.Controls.Add(btnAfrica)
        panelContinent.Controls.Add(btnAsia)
        panelContinent.Controls.Add(btnEurope)
        panelContinent.Controls.Add(btnSouthAmerica)
        panelContinent.Controls.Add(btnAustralia)
        panelContinent.Controls.Add(btnNorthAmerica)
        panelContinent.Controls.Add(Label5)
        panelContinent.Location = New Point(12, 147)
        panelContinent.Name = "panelContinent"
        panelContinent.Size = New Size(363, 202)
        panelContinent.TabIndex = 15
        panelContinent.Visible = False
        ' 
        ' lblTimeLine
        ' 
        lblTimeLine.AutoSize = True
        lblTimeLine.Location = New Point(121, 7)
        lblTimeLine.Name = "lblTimeLine"
        lblTimeLine.Size = New Size(0, 13)
        lblTimeLine.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 13)
        Label6.TabIndex = 13
        Label6.Text = "Current Timeline:"
        ' 
        ' btnAntartica
        ' 
        btnAntartica.Location = New Point(20, 165)
        btnAntartica.Name = "btnAntartica"
        btnAntartica.Size = New Size(237, 23)
        btnAntartica.TabIndex = 12
        btnAntartica.Text = "Antartica"
        btnAntartica.UseVisualStyleBackColor = True
        ' 
        ' btnAfrica
        ' 
        btnAfrica.Location = New Point(101, 102)
        btnAfrica.Name = "btnAfrica"
        btnAfrica.Size = New Size(75, 40)
        btnAfrica.TabIndex = 10
        btnAfrica.Text = "Africa"
        btnAfrica.UseVisualStyleBackColor = True
        ' 
        ' btnAsia
        ' 
        btnAsia.Location = New Point(182, 56)
        btnAsia.Name = "btnAsia"
        btnAsia.Size = New Size(75, 40)
        btnAsia.TabIndex = 9
        btnAsia.Text = "Asia"
        btnAsia.UseVisualStyleBackColor = True
        ' 
        ' btnEurope
        ' 
        btnEurope.Location = New Point(101, 56)
        btnEurope.Name = "btnEurope"
        btnEurope.Size = New Size(75, 40)
        btnEurope.TabIndex = 8
        btnEurope.Text = "Europe"
        btnEurope.UseVisualStyleBackColor = True
        ' 
        ' btnSouthAmerica
        ' 
        btnSouthAmerica.Location = New Point(20, 114)
        btnSouthAmerica.Name = "btnSouthAmerica"
        btnSouthAmerica.Size = New Size(75, 40)
        btnSouthAmerica.TabIndex = 7
        btnSouthAmerica.Text = "South America"
        btnSouthAmerica.UseVisualStyleBackColor = True
        ' 
        ' btnAustralia
        ' 
        btnAustralia.Location = New Point(182, 114)
        btnAustralia.Name = "btnAustralia"
        btnAustralia.Size = New Size(75, 40)
        btnAustralia.TabIndex = 11
        btnAustralia.Text = "Australia"
        btnAustralia.UseVisualStyleBackColor = True
        ' 
        ' btnNorthAmerica
        ' 
        btnNorthAmerica.Location = New Point(20, 46)
        btnNorthAmerica.Name = "btnNorthAmerica"
        btnNorthAmerica.Size = New Size(75, 40)
        btnNorthAmerica.TabIndex = 6
        btnNorthAmerica.Text = "North America"
        btnNorthAmerica.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(234, 13)
        Label5.TabIndex = 5
        Label5.Text = "Select the Intended Continent of Visit:"
        ' 
        ' panelAgeSelection
        ' 
        panelAgeSelection.BorderStyle = BorderStyle.Fixed3D
        panelAgeSelection.Controls.Add(Label2)
        panelAgeSelection.Controls.Add(btnFuture)
        panelAgeSelection.Controls.Add(btnPast)
        panelAgeSelection.Location = New Point(12, 62)
        panelAgeSelection.Name = "panelAgeSelection"
        panelAgeSelection.Size = New Size(363, 34)
        panelAgeSelection.TabIndex = 13
        panelAgeSelection.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 13)
        Label2.TabIndex = 5
        Label2.Text = "Please Select the Age you want to go!"
        ' 
        ' btnFuture
        ' 
        btnFuture.Location = New Point(296, 4)
        btnFuture.Name = "btnFuture"
        btnFuture.Size = New Size(60, 20)
        btnFuture.TabIndex = 4
        btnFuture.Text = "Future"
        btnFuture.UseVisualStyleBackColor = True
        ' 
        ' btnPast
        ' 
        btnPast.Location = New Point(236, 4)
        btnPast.Name = "btnPast"
        btnPast.Size = New Size(54, 20)
        btnPast.TabIndex = 3
        btnPast.Text = "Past"
        btnPast.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtTimeLine)
        Panel1.Controls.Add(Label4)
        Panel1.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(12, 97)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 49)
        Panel1.TabIndex = 14
        Panel1.Visible = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(198, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(70, 18)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtTimeLine
        ' 
        txtTimeLine.Location = New Point(3, 21)
        txtTimeLine.Name = "txtTimeLine"
        txtTimeLine.Size = New Size(189, 21)
        txtTimeLine.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(267, 13)
        Label4.TabIndex = 0
        Label4.Text = "Please enter the timeline you want to visit:"
        ' 
        ' panelTourStatus
        ' 
        panelTourStatus.BorderStyle = BorderStyle.FixedSingle
        panelTourStatus.Controls.Add(Panel4)
        panelTourStatus.Controls.Add(Button1)
        panelTourStatus.Controls.Add(lblTourName)
        panelTourStatus.Controls.Add(Label3)
        panelTourStatus.Controls.Add(Label7)
        panelTourStatus.Controls.Add(progressDuration)
        panelTourStatus.Controls.Add(btnConfirmTrip)
        panelTourStatus.Controls.Add(lblDurationstatus)
        panelTourStatus.Location = New Point(381, 14)
        panelTourStatus.Name = "panelTourStatus"
        panelTourStatus.Size = New Size(537, 335)
        panelTourStatus.TabIndex = 12
        panelTourStatus.Visible = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(panelBoxes)
        Panel4.Location = New Point(6, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(503, 233)
        Panel4.TabIndex = 14
        ' 
        ' panelBoxes
        ' 
        panelBoxes.Location = New Point(9, 55)
        panelBoxes.Name = "panelBoxes"
        panelBoxes.Size = New Size(465, 135)
        panelBoxes.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Cursor = Cursors.Hand
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(335, 302)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 23)
        Button1.TabIndex = 13
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblTourName
        ' 
        lblTourName.AutoSize = True
        lblTourName.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTourName.Location = New Point(84, 8)
        lblTourName.Name = "lblTourName"
        lblTourName.Size = New Size(0, 13)
        lblTourName.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 13)
        Label3.TabIndex = 7
        Label3.Text = "Tour Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(5, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 14)
        Label7.TabIndex = 12
        Label7.Text = "Time Filled:"
        ' 
        ' progressDuration
        ' 
        progressDuration.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        progressDuration.Location = New Point(6, 277)
        progressDuration.Maximum = 6
        progressDuration.Name = "progressDuration"
        progressDuration.Size = New Size(364, 23)
        progressDuration.TabIndex = 10
        ' 
        ' btnConfirmTrip
        ' 
        btnConfirmTrip.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnConfirmTrip.Cursor = Cursors.Hand
        btnConfirmTrip.ForeColor = Color.Black
        btnConfirmTrip.Location = New Point(432, 302)
        btnConfirmTrip.Name = "btnConfirmTrip"
        btnConfirmTrip.Size = New Size(91, 23)
        btnConfirmTrip.TabIndex = 9
        btnConfirmTrip.Text = "Confirm Trip"
        btnConfirmTrip.UseVisualStyleBackColor = False
        ' 
        ' lblDurationstatus
        ' 
        lblDurationstatus.AutoSize = True
        lblDurationstatus.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDurationstatus.Location = New Point(92, 311)
        lblDurationstatus.Name = "lblDurationstatus"
        lblDurationstatus.Size = New Size(47, 14)
        lblDurationstatus.TabIndex = 11
        lblDurationstatus.Text = "0.0/6.0"
        ' 
        ' panelCreateTour
        ' 
        panelCreateTour.BorderStyle = BorderStyle.Fixed3D
        panelCreateTour.Controls.Add(btnTourSet)
        panelCreateTour.Controls.Add(txtTourName)
        panelCreateTour.Controls.Add(lblTourNamePrompt)
        panelCreateTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        panelCreateTour.Location = New Point(12, 12)
        panelCreateTour.Name = "panelCreateTour"
        panelCreateTour.Size = New Size(363, 44)
        panelCreateTour.TabIndex = 11
        panelCreateTour.Visible = False
        ' 
        ' btnTourSet
        ' 
        btnTourSet.Location = New Point(274, 16)
        btnTourSet.Name = "btnTourSet"
        btnTourSet.Size = New Size(77, 18)
        btnTourSet.TabIndex = 2
        btnTourSet.Text = "Set"
        btnTourSet.UseVisualStyleBackColor = True
        ' 
        ' txtTourName
        ' 
        txtTourName.Location = New Point(118, 16)
        txtTourName.Name = "txtTourName"
        txtTourName.Size = New Size(150, 21)
        txtTourName.TabIndex = 1
        ' 
        ' lblTourNamePrompt
        ' 
        lblTourNamePrompt.AutoSize = True
        lblTourNamePrompt.Location = New Point(5, 19)
        lblTourNamePrompt.Name = "lblTourNamePrompt"
        lblTourNamePrompt.Size = New Size(109, 13)
        lblTourNamePrompt.TabIndex = 0
        lblTourNamePrompt.Text = "Enter Tour Name:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 568)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 23)
        Button2.TabIndex = 18
        Button2.Text = "Back to Home"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CreateTour
        ' 
        AutoScaleDimensions = New SizeF(7F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 603)
        Controls.Add(Button2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(panelContinent)
        Controls.Add(panelAgeSelection)
        Controls.Add(Panel1)
        Controls.Add(panelTourStatus)
        Controls.Add(panelCreateTour)
        Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "CreateTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreateTour"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(boxPlace, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(mapBox, ComponentModel.ISupportInitialize).EndInit()
        panelContinent.ResumeLayout(False)
        panelContinent.PerformLayout()
        panelAgeSelection.ResumeLayout(False)
        panelAgeSelection.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        panelTourStatus.ResumeLayout(False)
        panelTourStatus.PerformLayout()
        Panel4.ResumeLayout(False)
        panelCreateTour.ResumeLayout(False)
        panelCreateTour.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnAdder As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents boxPlace As PictureBox
    Friend WithEvents lblPlaceName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents mapBox As PictureBox
    Friend WithEvents panelContinent As Panel
    Friend WithEvents lblTimeLine As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAntartica As Button
    Friend WithEvents btnAfrica As Button
    Friend WithEvents btnAsia As Button
    Friend WithEvents btnEurope As Button
    Friend WithEvents btnSouthAmerica As Button
    Friend WithEvents btnAustralia As Button
    Friend WithEvents btnNorthAmerica As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents panelAgeSelection As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFuture As Button
    Friend WithEvents btnPast As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtTimeLine As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents panelTourStatus As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelBoxes As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTourName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents progressDuration As ProgressBar
    Friend WithEvents btnConfirmTrip As Button
    Friend WithEvents lblDurationstatus As Label
    Friend WithEvents panelCreateTour As Panel
    Friend WithEvents btnTourSet As Button
    Friend WithEvents txtTourName As TextBox
    Friend WithEvents lblTourNamePrompt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button2 As Button
End Class
