<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeBusForm
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
        Button1 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(156, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 33)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Timebus Inc."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(215, 140)
        Button1.Name = "Button1"
        Button1.Size = New Size(339, 33)
        Button1.TabIndex = 2
        Button1.Text = "Start the program"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(531, 14)
        Label2.TabIndex = 3
        Label2.Text = "By Clicking on this button, You agree to the terms and conditions of TimeBus Inc."
        ' 
        ' TimeBusForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(803, 283)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "TimeBusForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TimeBus.B2"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
