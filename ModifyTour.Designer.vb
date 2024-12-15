<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyTour
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
        GroupBox1 = New GroupBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        btnModify1 = New Button()
        lblTripName1 = New Label()
        Label1 = New Label()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnModify1)
        GroupBox1.Controls.Add(lblTripName1)
        GroupBox1.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1270, 276)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(186, 21)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1078, 115)
        Panel2.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 14)
        Label6.TabIndex = 24
        Label6.Text = "Visit Duration (hrs):"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 14)
        Label7.TabIndex = 23
        Label7.Text = "Visit Location:"
        ' 
        ' btnModify1
        ' 
        btnModify1.Location = New Point(1189, 156)
        btnModify1.Name = "btnModify1"
        btnModify1.Size = New Size(75, 28)
        btnModify1.TabIndex = 21
        btnModify1.Text = "Save"
        btnModify1.UseVisualStyleBackColor = True
        ' 
        ' lblTripName1
        ' 
        lblTripName1.AutoSize = True
        lblTripName1.Location = New Point(6, 12)
        lblTripName1.Name = "lblTripName1"
        lblTripName1.Size = New Size(48, 14)
        lblTripName1.TabIndex = 2
        lblTripName1.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(522, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 19)
        Label1.TabIndex = 3
        Label1.Text = "Modify your trip"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(310, 68)
        Label9.Name = "Label9"
        Label9.Size = New Size(627, 42)
        Label9.TabIndex = 5
        Label9.Text = "Instructions: To modify your trip, Drag the boxes to reorganize the order."
        ' 
        ' ModifyTour
        ' 
        AutoScaleDimensions = New SizeF(7F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1294, 344)
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "ModifyTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModifyTour"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModify1 As Button
    Friend WithEvents lblTripName1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class
