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
        lblTripName = New Label()
        ListBoxStops = New ListBox()
        btnModifyTrip = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lblTripName
        ' 
        lblTripName.AutoSize = True
        lblTripName.Location = New Point(111, 58)
        lblTripName.Name = "lblTripName"
        lblTripName.Size = New Size(48, 14)
        lblTripName.TabIndex = 0
        lblTripName.Text = "Label1"
        ' 
        ' ListBoxStops
        ' 
        ListBoxStops.FormattingEnabled = True
        ListBoxStops.ItemHeight = 14
        ListBoxStops.Location = New Point(30, 75)
        ListBoxStops.Name = "ListBoxStops"
        ListBoxStops.Size = New Size(163, 158)
        ListBoxStops.TabIndex = 1
        ' 
        ' btnModifyTrip
        ' 
        btnModifyTrip.Location = New Point(125, 235)
        btnModifyTrip.Name = "btnModifyTrip"
        btnModifyTrip.Size = New Size(68, 22)
        btnModifyTrip.TabIndex = 2
        btnModifyTrip.Text = "OK"
        btnModifyTrip.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(30, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 22)
        Label1.TabIndex = 3
        Label1.Text = "Trip Confirmed!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 14)
        Label2.TabIndex = 4
        Label2.Text = "Tour Name:"
        ' 
        ' TripOK
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(231, 269)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnModifyTrip)
        Controls.Add(ListBoxStops)
        Controls.Add(lblTripName)
        Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "TripOK"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TripOK"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTripName As Label
    Friend WithEvents ListBoxStops As ListBox
    Friend WithEvents btnModifyTrip As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
