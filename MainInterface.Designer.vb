﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        btnCreateTour = New Button()
        btnModifyTour = New Button()
        btnCopyTour = New Button()
        btnCloseAll = New Button()
        Button1 = New Button()
        PilotBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
<<<<<<< HEAD
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(78, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 23)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to Timebus Inc."
        ' 
        ' btnCreateTour
        ' 
        btnCreateTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreateTour.Location = New Point(158, 58)
        btnCreateTour.Name = "btnCreateTour"
        btnCreateTour.Size = New Size(161, 42)
        btnCreateTour.TabIndex = 1
        btnCreateTour.Text = "Create a tour"
        btnCreateTour.UseVisualStyleBackColor = True
        ' 
        ' btnModifyTour
        ' 
        btnModifyTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnModifyTour.Location = New Point(158, 154)
        btnModifyTour.Name = "btnModifyTour"
        btnModifyTour.Size = New Size(161, 42)
        btnModifyTour.TabIndex = 2
        btnModifyTour.Text = "Modify a Tour"
        btnModifyTour.UseVisualStyleBackColor = True
        ' 
        ' btnCopyTour
        ' 
        btnCopyTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCopyTour.Location = New Point(158, 106)
        btnCopyTour.Name = "btnCopyTour"
        btnCopyTour.Size = New Size(161, 42)
        btnCopyTour.TabIndex = 3
        btnCopyTour.Text = "Copy from Existing tour"
        btnCopyTour.UseVisualStyleBackColor = True
        ' 
        ' btnCloseAll
        ' 
        btnCloseAll.Location = New Point(158, 298)
        btnCloseAll.Name = "btnCloseAll"
        btnCloseAll.Size = New Size(161, 42)
        btnCloseAll.TabIndex = 4
        btnCloseAll.Text = "Close Program"
        btnCloseAll.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(158, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 42)
        Button1.TabIndex = 5
        Button1.Text = "Experience As a Visitor"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PilotBtn
        ' 
        PilotBtn.Location = New Point(158, 250)
        PilotBtn.Name = "PilotBtn"
        PilotBtn.Size = New Size(161, 42)
        PilotBtn.TabIndex = 6
        PilotBtn.Text = "Experience As a Pilot"
        PilotBtn.UseVisualStyleBackColor = True
        ' 
        ' MainInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(470, 432)
        Controls.Add(PilotBtn)
        Controls.Add(Button1)
        Controls.Add(btnCloseAll)
        Controls.Add(btnCopyTour)
        Controls.Add(btnModifyTour)
        Controls.Add(btnCreateTour)
        Controls.Add(Label1)
        Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "MainInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HomePage"
        ResumeLayout(False)
        PerformLayout()
=======
        Label1.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(38, 52)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(622, 50)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO TIMEBUS INC."
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCreateTour
        ' 
        btnCreateTour.BackColor = Color.SteelBlue
        btnCreateTour.FlatStyle = FlatStyle.Flat
        btnCreateTour.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCreateTour.ForeColor = Color.White
        btnCreateTour.Location = New Point(183, 125)
        btnCreateTour.Margin = New Padding(2, 2, 2, 2)
        btnCreateTour.Name = "btnCreateTour"
        btnCreateTour.Size = New Size(334, 42)
        btnCreateTour.TabIndex = 1
        btnCreateTour.Text = "CREATE A TOUR"
        btnCreateTour.UseVisualStyleBackColor = False
        ' 
        ' btnModifyTour
        ' 
        btnModifyTour.BackColor = Color.SteelBlue
        btnModifyTour.Enabled = False
        btnModifyTour.FlatStyle = FlatStyle.Flat
        btnModifyTour.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnModifyTour.ForeColor = Color.White
        btnModifyTour.Location = New Point(183, 225)
        btnModifyTour.Margin = New Padding(2, 2, 2, 2)
        btnModifyTour.Name = "btnModifyTour"
        btnModifyTour.Size = New Size(334, 42)
        btnModifyTour.TabIndex = 2
        btnModifyTour.Text = "MODIFY A TOUR"
        btnModifyTour.UseVisualStyleBackColor = False
        ' 
        ' btnCopyTour
        ' 
        btnCopyTour.BackColor = Color.SteelBlue
        btnCopyTour.Enabled = False
        btnCopyTour.FlatStyle = FlatStyle.Flat
        btnCopyTour.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCopyTour.ForeColor = Color.White
        btnCopyTour.Location = New Point(183, 175)
        btnCopyTour.Margin = New Padding(2, 2, 2, 2)
        btnCopyTour.Name = "btnCopyTour"
        btnCopyTour.Size = New Size(334, 42)
        btnCopyTour.TabIndex = 3
        btnCopyTour.Text = "COPY FROM EXISTING TOUR"
        btnCopyTour.UseVisualStyleBackColor = False
        ' 
        ' btnCloseAll
        ' 
        btnCloseAll.BackColor = Color.Firebrick
        btnCloseAll.FlatStyle = FlatStyle.Flat
        btnCloseAll.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCloseAll.ForeColor = Color.White
        btnCloseAll.Location = New Point(591, 17)
        btnCloseAll.Margin = New Padding(2, 2, 2, 2)
        btnCloseAll.Name = "btnCloseAll"
        btnCloseAll.Size = New Size(93, 33)
        btnCloseAll.TabIndex = 4
        btnCloseAll.Text = "EXIT"
        btnCloseAll.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Enabled = False
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(183, 275)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(334, 42)
        Button1.TabIndex = 5
        Button1.Text = "EXPERIENCE AS A VISITOR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PilotBtn
        ' 
        PilotBtn.BackColor = Color.SteelBlue
        PilotBtn.Enabled = False
        PilotBtn.FlatStyle = FlatStyle.Flat
        PilotBtn.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point)
        PilotBtn.ForeColor = Color.White
        PilotBtn.Location = New Point(183, 325)
        PilotBtn.Margin = New Padding(2, 2, 2, 2)
        PilotBtn.Name = "PilotBtn"
        PilotBtn.Size = New Size(334, 42)
        PilotBtn.TabIndex = 6
        PilotBtn.Text = "EXPERIENCE AS A PILOT"
        PilotBtn.UseVisualStyleBackColor = False
        ' 
        ' MainInterface
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(700, 417)
        Controls.Add(Label1)
        Controls.Add(btnCreateTour)
        Controls.Add(btnCopyTour)
        Controls.Add(btnModifyTour)
        Controls.Add(Button1)
        Controls.Add(PilotBtn)
        Controls.Add(btnCloseAll)
        Margin = New Padding(2, 2, 2, 2)
        Name = "MainInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TimeBus - B2"
        ResumeLayout(False)
>>>>>>> a8c1fdd (Initial commit of Time Travel Visual Basic Application)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateTour As Button
    Friend WithEvents btnModifyTour As Button
    Friend WithEvents btnCopyTour As Button
    Friend WithEvents btnCloseAll As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PilotBtn As Button
End Class
