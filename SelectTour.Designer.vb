<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectTour
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
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(272, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 22)
        Label1.TabIndex = 0
        Label1.Text = "Select Tour"
        ' 
        ' SelectTour
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(713, 437)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SelectTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SelectTour"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
End Class
