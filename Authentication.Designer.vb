<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication
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
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnPasswordOK = New System.Windows.Forms.Button()
        Me.btnPasswordCancel = New System.Windows.Forms.Button()
        Me.lblAutentication = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(28, 107)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(264, 20)
        Me.tbPassword.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(28, 88)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(194, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Please enter the administrator password"
        '
        'btnPasswordOK
        '
        Me.btnPasswordOK.Location = New System.Drawing.Point(28, 143)
        Me.btnPasswordOK.Name = "btnPasswordOK"
        Me.btnPasswordOK.Size = New System.Drawing.Size(75, 23)
        Me.btnPasswordOK.TabIndex = 2
        Me.btnPasswordOK.Text = "OK"
        Me.btnPasswordOK.UseVisualStyleBackColor = True
        '
        'btnPasswordCancel
        '
        Me.btnPasswordCancel.Location = New System.Drawing.Point(217, 42)
        Me.btnPasswordCancel.Name = "btnPasswordCancel"
        Me.btnPasswordCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnPasswordCancel.TabIndex = 3
        Me.btnPasswordCancel.Text = "Cancel"
        Me.btnPasswordCancel.UseVisualStyleBackColor = True
        '
        'lblAutentication
        '
        Me.lblAutentication.AutoSize = True
        Me.lblAutentication.Location = New System.Drawing.Point(25, 9)
        Me.lblAutentication.Name = "lblAutentication"
        Me.lblAutentication.Size = New System.Drawing.Size(234, 13)
        Me.lblAutentication.TabIndex = 4
        Me.lblAutentication.Text = "Do you have authorization to edit the database?"
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(28, 42)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 5
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(109, 42)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 6
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 179)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblAutentication)
        Me.Controls.Add(Me.btnPasswordCancel)
        Me.Controls.Add(Me.btnPasswordOK)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbPassword)
        Me.Name = "Authentication"
        Me.Text = "Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnPasswordOK As Button
    Friend WithEvents btnPasswordCancel As Button
    Friend WithEvents lblAutentication As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
