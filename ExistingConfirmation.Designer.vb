<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingConfirmation
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(136, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Label1.Location = New Point(31, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 25)
        Label1.TabIndex = 1
        Label1.Text = "Trip Confirmed!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(1, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 19)
        Label2.TabIndex = 2
        Label2.Text = "Trip Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(109, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 17)
        Label3.TabIndex = 3
        Label3.Text = "Trip Name:"
        ' 
        ' ExistingConfirmation
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(387, 152)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "ExistingConfirmation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ExistingConfirmation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
