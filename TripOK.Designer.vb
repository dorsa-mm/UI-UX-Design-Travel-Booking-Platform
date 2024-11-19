<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripOK
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
        Label1 = New Label()
        Label2 = New Label()
        lblTripName = New Label()
        ListBoxStops = New ListBox()
        btnModifyTrip = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(27, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 22)
        Label1.TabIndex = 0
        Label1.Text = "Trip Confirmed!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 14)
        Label2.TabIndex = 1
        Label2.Text = "Trip Name: "
        ' 
        ' lblTripName
        ' 
        lblTripName.AutoSize = True
        lblTripName.Location = New Point(84, 38)
        lblTripName.Name = "lblTripName"
        lblTripName.Size = New Size(48, 14)
        lblTripName.TabIndex = 2
        lblTripName.Text = "Label3"
        ' 
        ' ListBoxStops
        ' 
        ListBoxStops.FormattingEnabled = True
        ListBoxStops.ItemHeight = 14
        ListBoxStops.Location = New Point(12, 66)
        ListBoxStops.Name = "ListBoxStops"
        ListBoxStops.Size = New Size(197, 130)
        ListBoxStops.TabIndex = 3
        ' 
        ' btnModifyTrip
        ' 
        btnModifyTrip.Location = New Point(134, 202)
        btnModifyTrip.Name = "btnModifyTrip"
        btnModifyTrip.Size = New Size(75, 23)
        btnModifyTrip.TabIndex = 4
        btnModifyTrip.Text = "Close"
        btnModifyTrip.UseVisualStyleBackColor = True
        ' 
        ' TripOK
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 235)
        Controls.Add(btnModifyTrip)
        Controls.Add(ListBoxStops)
        Controls.Add(lblTripName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "TripOK"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TripOK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTripName As Label
    Friend WithEvents ListBoxStops As ListBox
    Friend WithEvents btnModifyTrip As Button
End Class
