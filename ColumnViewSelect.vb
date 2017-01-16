Public Class ColumnViewSelect
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        For Each control As Control In My.Forms.ColumnViewSelect.Controls
            If control.GetType = GetType(Windows.Forms.CheckBox) Then
                Dim checkbox As CheckBox = control
                If checkbox.CheckState = CheckState.Checked Then
                    My.Forms.ASLTerriroryManager.dgvContacts.Columns.Item(CInt(checkbox.Name)).Visible = True
                Else
                    My.Forms.ASLTerriroryManager.dgvContacts.Columns.Item(CInt(checkbox.Name)).Visible = False
                End If
            End If
        Next
        My.Forms.ASLTerriroryManager.dgvContacts.Update()
        My.Forms.ColumnViewSelect.Close()
        Me.Cursor = Cursor
    End Sub
End Class