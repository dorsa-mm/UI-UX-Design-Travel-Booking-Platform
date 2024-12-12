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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnModify1 = New System.Windows.Forms.Button()
        Me.lblTripName1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnModify1)
        Me.GroupBox1.Controls.Add(Me.lblTripName1)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1270, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(186, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 115)
        Me.Panel2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Visit Duration (hrs):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Visit Location:"
        '
        'btnModify1
        '
        Me.btnModify1.Location = New System.Drawing.Point(1189, 156)
        Me.btnModify1.Name = "btnModify1"
        Me.btnModify1.Size = New System.Drawing.Size(75, 28)
        Me.btnModify1.TabIndex = 21
        Me.btnModify1.Text = "Save"
        Me.btnModify1.UseVisualStyleBackColor = True
        '
        'lblTripName1
        '
        Me.lblTripName1.AutoSize = True
        Me.lblTripName1.Location = New System.Drawing.Point(6, 12)
        Me.lblTripName1.Name = "lblTripName1"
        Me.lblTripName1.Size = New System.Drawing.Size(61, 18)
        Me.lblTripName1.TabIndex = 2
        Me.lblTripName1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(522, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Modify your trip"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Back to Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(310, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(627, 42)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Instructions: To modify your trip, Drag the boxes to reorganize the order."
        '
        'ModifyTour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 344)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ModifyTour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyTour"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModify1 As Button
    Friend WithEvents lblTripName1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class
