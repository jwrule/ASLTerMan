Public Class Authentication
    Public _canManage As Boolean = False

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPassword.Visible = False
        tbPassword.Visible = False
        btnPasswordOK.Visible = False
    End Sub

    Private Sub btnPasswordCancel_Click(sender As Object, e As EventArgs) Handles btnPasswordCancel.Click
        Application.Exit()
        End
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        lblPassword.Visible = True
        tbPassword.Visible = True
        btnPasswordOK.Visible = True
        tbPassword.PasswordChar = "*"
    End Sub
    Private Sub btnPasswordOK_Click(sender As Object, e As EventArgs) Handles btnPasswordOK.Click
        If tbPassword.Text = "letmein" Then
            Me.Close()
            _canManage = True
        Else
            lblPassword.Text = "Password incorrect please try again."
            lblPassword.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub tbPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbPassword.Text = "letmein" Then
                Me.Close()
                _canManage = True
            Else
                lblPassword.Text = "Password incorrect please try again."
                lblPassword.ForeColor = Color.Red
            End If
        End If
    End Sub

End Class