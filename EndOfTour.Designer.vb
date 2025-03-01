<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)
Partial Class EndOfTour
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
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(240, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1012, 239)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thank you for Riding the Time Bus"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back To Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EndOfTour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 682)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EndOfTour"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EndOfTour"
        Me.ResumeLayout(False)
=======
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(1200, 150)
        Label1.TabIndex = 0
        Label1.Text = "THANK YOU FOR RIDING THE TIME BUS! HOPE YOU ENJOYED!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(500, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 45)
        Button1.TabIndex = 1
        Button1.Text = "BACK TO MAIN MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EndOfTour
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1200, 550)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "EndOfTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "END OF TOUR"
        ResumeLayout(False)
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
