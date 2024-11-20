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
        Label1 = New Label()
        btnCreateTour = New Button()
        btnModifyTour = New Button()
        btnCopyTour = New Button()
        btnCloseAll = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 23)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to Timebus Inc."
        ' 
        ' btnCreateTour
        ' 
        btnCreateTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreateTour.Location = New Point(53, 38)
        btnCreateTour.Name = "btnCreateTour"
        btnCreateTour.Size = New Size(161, 19)
        btnCreateTour.TabIndex = 1
        btnCreateTour.Text = "Create a tour"
        btnCreateTour.UseVisualStyleBackColor = True
        ' 
        ' btnModifyTour
        ' 
        btnModifyTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnModifyTour.Location = New Point(53, 86)
        btnModifyTour.Name = "btnModifyTour"
        btnModifyTour.Size = New Size(161, 19)
        btnModifyTour.TabIndex = 2
        btnModifyTour.Text = "Modify a Tour"
        btnModifyTour.UseVisualStyleBackColor = True
        ' 
        ' btnCopyTour
        ' 
        btnCopyTour.Font = New Font("Stencil", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCopyTour.Location = New Point(53, 62)
        btnCopyTour.Name = "btnCopyTour"
        btnCopyTour.Size = New Size(161, 19)
        btnCopyTour.TabIndex = 3
        btnCopyTour.Text = "Copy from Existing tour"
        btnCopyTour.UseVisualStyleBackColor = True
        ' 
        ' btnCloseAll
        ' 
        btnCloseAll.Location = New Point(53, 272)
        btnCloseAll.Name = "btnCloseAll"
        btnCloseAll.Size = New Size(161, 19)
        btnCloseAll.TabIndex = 4
        btnCloseAll.Text = "Close Program"
        btnCloseAll.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(53, 111)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 23)
        Button1.TabIndex = 5
        Button1.Text = "Experience As a Visitor"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(288, 313)
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
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateTour As Button
    Friend WithEvents btnModifyTour As Button
    Friend WithEvents btnCopyTour As Button
    Friend WithEvents btnCloseAll As Button
    Friend WithEvents Button1 As Button

End Class
