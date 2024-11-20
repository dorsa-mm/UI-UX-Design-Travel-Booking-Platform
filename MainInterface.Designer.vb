<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateTour = New System.Windows.Forms.Button()
        Me.btnModifyTour = New System.Windows.Forms.Button()
        Me.btnCopyTour = New System.Windows.Forms.Button()
        Me.btnCloseAll = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PilotBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Timebus Inc."
        '
        'btnCreateTour
        '
        Me.btnCreateTour.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateTour.Location = New System.Drawing.Point(158, 58)
        Me.btnCreateTour.Name = "btnCreateTour"
        Me.btnCreateTour.Size = New System.Drawing.Size(161, 42)
        Me.btnCreateTour.TabIndex = 1
        Me.btnCreateTour.Text = "Create a tour"
        Me.btnCreateTour.UseVisualStyleBackColor = True
        '
        'btnModifyTour
        '
        Me.btnModifyTour.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnModifyTour.Location = New System.Drawing.Point(158, 154)
        Me.btnModifyTour.Name = "btnModifyTour"
        Me.btnModifyTour.Size = New System.Drawing.Size(161, 42)
        Me.btnModifyTour.TabIndex = 2
        Me.btnModifyTour.Text = "Modify a Tour"
        Me.btnModifyTour.UseVisualStyleBackColor = True
        '
        'btnCopyTour
        '
        Me.btnCopyTour.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCopyTour.Location = New System.Drawing.Point(158, 106)
        Me.btnCopyTour.Name = "btnCopyTour"
        Me.btnCopyTour.Size = New System.Drawing.Size(161, 42)
        Me.btnCopyTour.TabIndex = 3
        Me.btnCopyTour.Text = "Copy from Existing tour"
        Me.btnCopyTour.UseVisualStyleBackColor = True
        '
        'btnCloseAll
        '
        Me.btnCloseAll.Location = New System.Drawing.Point(158, 298)
        Me.btnCloseAll.Name = "btnCloseAll"
        Me.btnCloseAll.Size = New System.Drawing.Size(161, 42)
        Me.btnCloseAll.TabIndex = 4
        Me.btnCloseAll.Text = "Close Program"
        Me.btnCloseAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Experience As a Visitor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PilotBtn
        '
        Me.PilotBtn.Location = New System.Drawing.Point(158, 250)
        Me.PilotBtn.Name = "PilotBtn"
        Me.PilotBtn.Size = New System.Drawing.Size(161, 42)
        Me.PilotBtn.TabIndex = 6
        Me.PilotBtn.Text = "Experience As a Pilot"
        Me.PilotBtn.UseVisualStyleBackColor = True
        '
        'MainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 432)
        Me.Controls.Add(Me.PilotBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCloseAll)
        Me.Controls.Add(Me.btnCopyTour)
        Me.Controls.Add(Me.btnModifyTour)
        Me.Controls.Add(Me.btnCreateTour)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "MainInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateTour As Button
    Friend WithEvents btnModifyTour As Button
    Friend WithEvents btnCopyTour As Button
    Friend WithEvents btnCloseAll As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PilotBtn As Button
End Class
