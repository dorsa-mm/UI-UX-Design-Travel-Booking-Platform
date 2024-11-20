<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingTrip
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
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 14)
        Label1.TabIndex = 0
        Label1.Text = "Please Select Any of the Pre-Existing trip to continue:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(StatusStrip1)
        Panel1.Location = New Point(12, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(410, 93)
        Panel1.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(342, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 14)
        Label7.TabIndex = 8
        Label7.Text = "Label7"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(276, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 14)
        Label6.TabIndex = 7
        Label6.Text = "Label6"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(213, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 14)
        Label5.TabIndex = 6
        Label5.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(157, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 14)
        Label4.TabIndex = 5
        Label4.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(14, 14)
        Label3.TabIndex = 4
        Label3.Text = "1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(3, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 13)
        Label2.TabIndex = 3
        Label2.Text = "Mamoth Age"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 71)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(410, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Font = New Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(159, 17)
        ToolStripStatusLabel1.Text = "Ice Age Tour Package"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(428, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ExistingTrip
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(827, 420)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "ExistingTrip"
        Text = "ExistingTrip"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
