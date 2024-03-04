<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lstDisplay = New ListBox()
        btnDisplay = New Button()
        btnAppend = New Button()
        SuspendLayout()
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(46, 248)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(721, 164)
        lstDisplay.TabIndex = 0
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(207, 174)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(200, 46)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnAppend
        ' 
        btnAppend.Location = New Point(440, 174)
        btnAppend.Name = "btnAppend"
        btnAppend.Size = New Size(200, 46)
        btnAppend.TabIndex = 2
        btnAppend.Text = "Append Data"
        btnAppend.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAppend)
        Controls.Add(btnDisplay)
        Controls.Add(lstDisplay)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAppend As Button

End Class
