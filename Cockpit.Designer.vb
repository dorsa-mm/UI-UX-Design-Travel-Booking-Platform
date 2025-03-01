<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CockpitForm
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
<<<<<<< HEAD
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ZoomOut = New System.Windows.Forms.PictureBox()
        Me.ZoomIn = New System.Windows.Forms.PictureBox()
        Me.WindowBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Year = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Information = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tour_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Backward = New System.Windows.Forms.RadioButton()
        Me.Forward = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SpeedMinus = New System.Windows.Forms.Button()
        Me.SpeedPlus = New System.Windows.Forms.Button()
        Me.Speed = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ZoomOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WindowBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ZoomOut)
        Me.Panel1.Controls.Add(Me.ZoomIn)
        Me.Panel1.Controls.Add(Me.WindowBox)
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 627)
        Me.Panel1.TabIndex = 0
        '
        'ZoomOut
        '
        Me.ZoomOut.Image = Global.TimebusB2.My.Resources.Resources.zoom_out
        Me.ZoomOut.Location = New System.Drawing.Point(624, 563)
        Me.ZoomOut.Name = "ZoomOut"
        Me.ZoomOut.Size = New System.Drawing.Size(62, 57)
        Me.ZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ZoomOut.TabIndex = 2
        Me.ZoomOut.TabStop = False
        '
        'ZoomIn
        '
        Me.ZoomIn.Image = Global.TimebusB2.My.Resources.Resources.zoom_in
        Me.ZoomIn.Location = New System.Drawing.Point(538, 563)
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.Size = New System.Drawing.Size(69, 57)
        Me.ZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ZoomIn.TabIndex = 1
        Me.ZoomIn.TabStop = False
        '
        'WindowBox
        '
        Me.WindowBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.WindowBox.Location = New System.Drawing.Point(-27, -15)
        Me.WindowBox.Name = "WindowBox"
        Me.WindowBox.Size = New System.Drawing.Size(744, 659)
        Me.WindowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WindowBox.TabIndex = 0
        Me.WindowBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Year)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Information)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Location)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Tour_Name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(709, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(674, 291)
        Me.Panel2.TabIndex = 1
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.Location = New System.Drawing.Point(64, 216)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(56, 17)
        Me.Year.TabIndex = 7
        Me.Year.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Year: "
        '
        'Information
        '
        Me.Information.Location = New System.Drawing.Point(106, 51)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(291, 152)
        Me.Information.TabIndex = 5
        Me.Information.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Information:"
        '
        'Location
        '
        Me.Location.AutoSize = True
        Me.Location.Location = New System.Drawing.Point(106, 29)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(56, 17)
        Me.Location.TabIndex = 3
        Me.Location.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location: "
        '
        'Tour_Name
        '
        Me.Tour_Name.AutoSize = True
        Me.Tour_Name.Location = New System.Drawing.Point(106, 11)
        Me.Tour_Name.Name = "Tour_Name"
        Me.Tour_Name.Size = New System.Drawing.Size(56, 17)
        Me.Tour_Name.TabIndex = 1
        Me.Tour_Name.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tour Name: "
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Backward)
        Me.Panel3.Controls.Add(Me.Forward)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.SpeedMinus)
        Me.Panel3.Controls.Add(Me.SpeedPlus)
        Me.Panel3.Controls.Add(Me.Speed)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel3.Location = New System.Drawing.Point(709, 307)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(674, 331)
        Me.Panel3.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(123, 279)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 29)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Jump to Next Visit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Pause Time"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(533, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 29)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Emergency Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Backward
        '
        Me.Backward.AutoSize = True
        Me.Backward.Location = New System.Drawing.Point(155, 55)
        Me.Backward.Name = "Backward"
        Me.Backward.Size = New System.Drawing.Size(141, 21)
        Me.Backward.TabIndex = 17
        Me.Backward.Text = "Backward Time"
        Me.Backward.UseVisualStyleBackColor = True
        '
        'Forward
        '
        Me.Forward.AutoSize = True
        Me.Forward.Checked = True
        Me.Forward.Location = New System.Drawing.Point(24, 55)
        Me.Forward.Name = "Forward"
        Me.Forward.Size = New System.Drawing.Size(132, 21)
        Me.Forward.TabIndex = 16
        Me.Forward.TabStop = True
        Me.Forward.Text = "Forward Time"
        Me.Forward.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "LY"
        '
        'SpeedMinus
        '
        Me.SpeedMinus.Location = New System.Drawing.Point(238, 11)
        Me.SpeedMinus.Name = "SpeedMinus"
        Me.SpeedMinus.Size = New System.Drawing.Size(38, 29)
        Me.SpeedMinus.TabIndex = 14
        Me.SpeedMinus.Text = "-"
        Me.SpeedMinus.UseVisualStyleBackColor = True
        '
        'SpeedPlus
        '
        Me.SpeedPlus.Location = New System.Drawing.Point(197, 11)
        Me.SpeedPlus.Name = "SpeedPlus"
        Me.SpeedPlus.Size = New System.Drawing.Size(37, 29)
        Me.SpeedPlus.TabIndex = 13
        Me.SpeedPlus.Text = "+"
        Me.SpeedPlus.UseVisualStyleBackColor = True
        '
        'Speed
        '
        Me.Speed.AutoSize = True
        Me.Speed.Location = New System.Drawing.Point(126, 15)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(32, 17)
        Me.Speed.TabIndex = 12
        Me.Speed.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Current Speed: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Return Origin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(24, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Autopilot"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(211, 661)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1157, 29)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1, 673)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Time Till Next Destination"
        '
        'CockpitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1395, 711)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CockpitForm"
        Me.Text = "Cockpit"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ZoomOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WindowBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
=======
        Panel1 = New Panel()
        ZoomOut = New PictureBox()
        ZoomIn = New PictureBox()
        WindowBox = New PictureBox()
        Panel2 = New Panel()
        Year = New Label()
        Label4 = New Label()
        Information = New Label()
        Label3 = New Label()
        Location = New Label()
        Label2 = New Label()
        Tour_Name = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Backward = New RadioButton()
        Forward = New RadioButton()
        Label7 = New Label()
        SpeedMinus = New Button()
        SpeedPlus = New Button()
        Speed = New Label()
        Label5 = New Label()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        ProgressBar1 = New ProgressBar()
        Label6 = New Label()
        Panel1.SuspendLayout()
        CType(ZoomOut, ComponentModel.ISupportInitialize).BeginInit()
        CType(ZoomIn, ComponentModel.ISupportInitialize).BeginInit()
        CType(WindowBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ZoomOut)
        Panel1.Controls.Add(ZoomIn)
        Panel1.Controls.Add(WindowBox)
        Panel1.Location = New Point(9, 8)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(607, 471)
        Panel1.TabIndex = 0
        ' 
        ' ZoomOut
        ' 
        ZoomOut.Image = My.Resources.Resources.zoom_out
        ZoomOut.Location = New Point(546, 422)
        ZoomOut.Margin = New Padding(3, 2, 3, 2)
        ZoomOut.Name = "ZoomOut"
        ZoomOut.Size = New Size(54, 43)
        ZoomOut.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomOut.TabIndex = 2
        ZoomOut.TabStop = False
        ' 
        ' ZoomIn
        ' 
        ZoomIn.Image = My.Resources.Resources.zoom_in
        ZoomIn.Location = New Point(471, 422)
        ZoomIn.Margin = New Padding(3, 2, 3, 2)
        ZoomIn.Name = "ZoomIn"
        ZoomIn.Size = New Size(60, 43)
        ZoomIn.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomIn.TabIndex = 1
        ZoomIn.TabStop = False
        ' 
        ' WindowBox
        ' 
        WindowBox.BackColor = SystemColors.ActiveBorder
        WindowBox.Location = New Point(-24, -11)
        WindowBox.Margin = New Padding(3, 2, 3, 2)
        WindowBox.Name = "WindowBox"
        WindowBox.Size = New Size(651, 494)
        WindowBox.SizeMode = PictureBoxSizeMode.StretchImage
        WindowBox.TabIndex = 0
        WindowBox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Year)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Information)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Location)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Tour_Name)
        Panel2.Controls.Add(Label1)
        Panel2.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(620, 7)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(590, 219)
        Panel2.TabIndex = 1
        ' 
        ' Year
        ' 
        Year.AutoSize = True
        Year.Location = New Point(56, 162)
        Year.Name = "Year"
        Year.Size = New Size(45, 13)
        Year.TabIndex = 7
        Year.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 13)
        Label4.TabIndex = 6.0
        Label4.Text = "Year: "
        ' 
        ' Information
        ' 
        Information.Location = New Point(93, 38)
        Information.Name = "Information"
        Information.Size = New Size(255, 114)
        Information.TabIndex = 5
        Information.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 13)
        Label3.TabIndex = 4
        Label3.Text = "Information:"
        ' 
        ' Location
        ' 
        Location.AutoSize = True
        Location.Location = New Point(93, 22)
        Location.Name = "Location"
        Location.Size = New Size(45, 13)
        Location.TabIndex = 3
        Location.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 13)
        Label2.TabIndex = 2
        Label2.Text = "Location: "
        ' 
        ' Tour_Name
        ' 
        Tour_Name.AutoSize = True
        Tour_Name.Location = New Point(93, 8)
        Tour_Name.Name = "Tour_Name"
        Tour_Name.Size = New Size(45, 13)
        Tour_Name.TabIndex = 1
        Tour_Name.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 13)
        Label1.TabIndex = 0
        Label1.Text = "Tour Name: "
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Backward)
        Panel3.Controls.Add(Forward)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(SpeedMinus)
        Panel3.Controls.Add(SpeedPlus)
        Panel3.Controls.Add(Speed)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(CheckBox1)
        Panel3.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(620, 230)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(590, 249)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(108, 209)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(142, 22)
        Button4.TabIndex = 20
        Button4.Text = "Jump to Next Visit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 209)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 22)
        Button3.TabIndex = 19
        Button3.Text = "Pause Time"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(466, 183)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 22)
        Button2.TabIndex = 18
        Button2.Text = "Emergency Stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Backward
        ' 
        Backward.AutoSize = True
        Backward.Location = New Point(136, 41)
        Backward.Margin = New Padding(3, 2, 3, 2)
        Backward.Name = "Backward"
        Backward.Size = New Size(113, 17)
        Backward.TabIndex = 17
        Backward.Text = "Backward Time"
        Backward.UseVisualStyleBackColor = True
        ' 
        ' Forward
        ' 
        Forward.AutoSize = True
        Forward.Checked = True
        Forward.Location = New Point(21, 41)
        Forward.Margin = New Padding(3, 2, 3, 2)
        Forward.Name = "Forward"
        Forward.Size = New Size(106, 17)
        Forward.TabIndex = 16
        Forward.TabStop = True
        Forward.Text = "Forward Time"
        Forward.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(144, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 13)
        Label7.TabIndex = 15
        Label7.Text = "LY"
        ' 
        ' SpeedMinus
        ' 
        SpeedMinus.Location = New Point(208, 8)
        SpeedMinus.Margin = New Padding(3, 2, 3, 2)
        SpeedMinus.Name = "SpeedMinus"
        SpeedMinus.Size = New Size(33, 22)
        SpeedMinus.TabIndex = 14
        SpeedMinus.Text = "-"
        SpeedMinus.UseVisualStyleBackColor = True
        ' 
        ' SpeedPlus
        ' 
        SpeedPlus.Location = New Point(172, 8)
        SpeedPlus.Margin = New Padding(3, 2, 3, 2)
        SpeedPlus.Name = "SpeedPlus"
        SpeedPlus.Size = New Size(32, 22)
        SpeedPlus.TabIndex = 13
        SpeedPlus.Text = "+"
        SpeedPlus.UseVisualStyleBackColor = True
        ' 
        ' Speed
        ' 
        Speed.AutoSize = True
        Speed.Location = New Point(110, 11)
        Speed.Name = "Speed"
        Speed.Size = New Size(25, 13)
        Speed.TabIndex = 12
        Speed.Text = "100"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 13)
        Label5.TabIndex = 8
        Label5.Text = "Current Speed: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(466, 209)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 22)
        Button1.TabIndex = 11
        Button1.Text = "Return Origin"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(21, 64)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(85, 17)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Autopilot"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(168, 496)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1029, 22)
        ProgressBar1.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(1, 505)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 13)
        Label6.TabIndex = 4
        Label6.Text = "Time Till Next Destination"
        ' 
        ' CockpitForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(1221, 533)
        Controls.Add(Label6)
        Controls.Add(ProgressBar1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "CockpitForm"
        Text = "Cockpit"
        Panel1.ResumeLayout(False)
        CType(ZoomOut, ComponentModel.ISupportInitialize).EndInit()
        CType(ZoomIn, ComponentModel.ISupportInitialize).EndInit()
        CType(WindowBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents WindowBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tour_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Location As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Information As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Year As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ZoomOut As PictureBox
    Friend WithEvents ZoomIn As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents SpeedMinus As Button
    Friend WithEvents SpeedPlus As Button
    Friend WithEvents Speed As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Backward As RadioButton
    Friend WithEvents Forward As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
End Class
