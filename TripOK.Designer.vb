<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
Partial Class TripOK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerNonUserCode()> _
=======
    <System.Diagnostics.DebuggerNonUserCode()>
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
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

<<<<<<< HEAD
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
=======
    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
    Private Sub InitializeComponent()
        Me.lblTripName = New System.Windows.Forms.Label()
        Me.ListBoxStops = New System.Windows.Forms.ListBox()
        Me.btnModifyTrip = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
<<<<<<< HEAD
        'lblTripName
        '
        Me.lblTripName.AutoSize = True
        Me.lblTripName.Location = New System.Drawing.Point(132, 58)
        Me.lblTripName.Name = "lblTripName"
        Me.lblTripName.Size = New System.Drawing.Size(61, 18)
        Me.lblTripName.TabIndex = 0
        Me.lblTripName.Text = "Label1"
        '
        'ListBoxStops
        '
        Me.ListBoxStops.FormattingEnabled = True
        Me.ListBoxStops.ItemHeight = 18
        Me.ListBoxStops.Location = New System.Drawing.Point(30, 81)
        Me.ListBoxStops.Name = "ListBoxStops"
        Me.ListBoxStops.Size = New System.Drawing.Size(380, 202)
        Me.ListBoxStops.TabIndex = 1
        '
        'btnModifyTrip
        '
        Me.btnModifyTrip.Location = New System.Drawing.Point(342, 289)
        Me.btnModifyTrip.Name = "btnModifyTrip"
        Me.btnModifyTrip.Size = New System.Drawing.Size(68, 27)
        Me.btnModifyTrip.TabIndex = 2
        Me.btnModifyTrip.Text = "OK"
        Me.btnModifyTrip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Trip Confirmed!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tour Name:"
        '
        'TripOK
=======
        ' TripOK Form Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 387)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIP CONFIRMATION"
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        '
        ' lblTripName
        '
        Me.lblTripName.AutoSize = True
        Me.lblTripName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTripName.Location = New System.Drawing.Point(150, 60)
        Me.lblTripName.Name = "lblTripName"
        Me.lblTripName.Size = New System.Drawing.Size(80, 23)
        Me.lblTripName.TabIndex = 0
        Me.lblTripName.Text = "TRIP NAME"
        '
        ' ListBoxStops
        '
        Me.ListBoxStops.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBoxStops.FormattingEnabled = True
        Me.ListBoxStops.ItemHeight = 23
        Me.ListBoxStops.Location = New System.Drawing.Point(30, 95)
        Me.ListBoxStops.Name = "ListBoxStops"
        Me.ListBoxStops.Size = New System.Drawing.Size(380, 184)
        Me.ListBoxStops.TabIndex = 1
        '
        ' btnModifyTrip
        '
        Me.btnModifyTrip.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModifyTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyTrip.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnModifyTrip.ForeColor = System.Drawing.Color.White
        Me.btnModifyTrip.Location = New System.Drawing.Point(342, 290)
        Me.btnModifyTrip.Name = "btnModifyTrip"
        Me.btnModifyTrip.Size = New System.Drawing.Size(68, 30)
        Me.btnModifyTrip.TabIndex = 2
        Me.btnModifyTrip.Text = "OK"
        Me.btnModifyTrip.UseVisualStyleBackColor = False
        '
        ' Label1 (Title)
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TRIP CONFIRMED!"
        '
        ' Label2 (Tour Name Label)
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TOUR NAME:"
        '
        ' TripOK
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 387)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModifyTrip)
        Me.Controls.Add(Me.ListBoxStops)
        Me.Controls.Add(Me.lblTripName)
<<<<<<< HEAD
        Me.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "TripOK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TripOK"
=======
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "TripOK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIP CONFIRMATION"
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTripName As Label
    Friend WithEvents ListBoxStops As ListBox
    Friend WithEvents btnModifyTrip As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
