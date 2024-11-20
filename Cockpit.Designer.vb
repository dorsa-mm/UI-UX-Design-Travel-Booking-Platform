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
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
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
        Me.ZoomIn.Size = New System.Drawing.Size(68, 57)
        Me.ZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ZoomIn.TabIndex = 1
        Me.ZoomIn.TabStop = False
        '
        'WindowBox
        '
        Me.WindowBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.WindowBox.Location = New System.Drawing.Point(-27, -15)
        Me.WindowBox.Name = "WindowBox"
        Me.WindowBox.Size = New System.Drawing.Size(744, 658)
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
        Me.Year.Size = New System.Drawing.Size(53, 20)
        Me.Year.TabIndex = 7
        Me.Year.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Year: "
        '
        'Information
        '
        Me.Information.Location = New System.Drawing.Point(106, 50)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(291, 152)
        Me.Information.TabIndex = 5
        Me.Information.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Information:"
        '
        'Location
        '
        Me.Location.AutoSize = True
        Me.Location.Location = New System.Drawing.Point(106, 30)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(53, 20)
        Me.Location.TabIndex = 3
        Me.Location.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location: "
        '
        'Tour_Name
        '
        Me.Tour_Name.AutoSize = True
        Me.Tour_Name.Location = New System.Drawing.Point(106, 10)
        Me.Tour_Name.Name = "Tour_Name"
        Me.Tour_Name.Size = New System.Drawing.Size(53, 20)
        Me.Tour_Name.TabIndex = 1
        Me.Tour_Name.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
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
        Me.Panel3.Location = New System.Drawing.Point(709, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(674, 331)
        Me.Panel3.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(124, 279)
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
        Me.Backward.Size = New System.Drawing.Size(131, 24)
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
        Me.Forward.Size = New System.Drawing.Size(121, 24)
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
        Me.Label7.Size = New System.Drawing.Size(23, 20)
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
        Me.SpeedPlus.Location = New System.Drawing.Point(196, 11)
        Me.SpeedPlus.Name = "SpeedPlus"
        Me.SpeedPlus.Size = New System.Drawing.Size(36, 29)
        Me.SpeedPlus.TabIndex = 13
        Me.SpeedPlus.Text = "+"
        Me.SpeedPlus.UseVisualStyleBackColor = True
        '
        'Speed
        '
        Me.Speed.AutoSize = True
        Me.Speed.Location = New System.Drawing.Point(126, 15)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(33, 20)
        Me.Speed.TabIndex = 12
        Me.Speed.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
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
        Me.CheckBox1.Size = New System.Drawing.Size(94, 24)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Autopilot"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(199, 652)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1176, 29)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 661)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
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
