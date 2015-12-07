


Public Class ASLTerriroryManager
#Region "Declarations"
    Dim _contact As New Contact
    Dim _ta As DSTableAdapters.ContactsTableAdapter = New DSTableAdapters.ContactsTableAdapter
    Dim _tadt As DSTableAdapters.Deaf_TerritoriesTableAdapter = New DSTableAdapters.Deaf_TerritoriesTableAdapter
    Dim _tavpt As DSTableAdapters.VP_TerritoriesTableAdapter = New DSTableAdapters.VP_TerritoriesTableAdapter
    Dim _tavps As DSTableAdapters.VP_Search_TerritoriesTableAdapter = New DSTableAdapters.VP_Search_TerritoriesTableAdapter
    Dim _tans As DSTableAdapters.Name_Search_TerritoriesTableAdapter = New DSTableAdapters.Name_Search_TerritoriesTableAdapter
    Dim _tams As DSTableAdapters.MapsTableAdapter = New DSTableAdapters.MapsTableAdapter

    Dim _firstload As Boolean = True

#End Region
    Private Sub ASLTerriroryManager_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' _ta.Fill(DS.Contacts)
        _firstload = False
        Try
            BuildContact(DS.Contacts.Rows.Find(dgvContacts.CurrentRow.DataBoundItem(0)))
        Catch ex As Exception
        End Try
    End Sub
#Region "Methods"

    Private Sub BuildContact(dataRow As DataRow)
        Dim contactRow As New Generic.List(Of String)
        For Each field In dataRow.ItemArray
            If field.ToString IsNot Nothing Then
                contactRow.Add(field.ToString.Trim)
            Else : contactRow.Add("")
            End If
        Next
        _contact.UID = contactRow(0)
        _contact.Agent = contactRow(1)
        _contact.FirstName = contactRow(2)
        _contact.LastName = contactRow(3)
        _contact.Address = contactRow(4)
        _contact.City = contactRow(5)
        _contact.State = contactRow(6)
        _contact.Zip = contactRow(7)
        _contact.VP1 = contactRow(8)
        _contact.VP2 = contactRow(9)
        _contact.VP3 = contactRow(10)
        _contact.Notes = contactRow(11)
        _contact.NameFrom = contactRow(12)
        _contact.DoNotCall = contactRow(13)
        _contact.DeafTerNo = contactRow(14)
        _contact.VpTerNo = contactRow(15)
        _contact.NameTerNo = contactRow(16)
        _contact.DateSearched = contactRow(17)
        _contact.DateFound = contactRow(18)
        _contact.Latitude = contactRow(19)
        _contact.Longitude = contactRow(20)
        PopulateFields()

    End Sub
    Private Sub PopulateFields()
        tbAgent.Text = _contact.Agent
        tbFirstName.Text = _contact.FirstName
        tbLastName.Text = _contact.LastName
        tbAddress.Text = _contact.Address
        tbCity.Text = _contact.City
        tbState.Text = _contact.State
        tbZip.Text = _contact.Zip
        tbVP1.Text = _contact.VP1
        tbVP2.Text = _contact.VP2
        tbVP3.Text = _contact.VP3
        tbNotes.Text = _contact.Notes
        tbNameFrom.Text = _contact.NameFrom
        tbDoNotCall.Text = _contact.DoNotCall
        tbDeafTerNo.Text = _contact.DeafTerNo
        tbVpTerNo.Text = _contact.VpTerNo
        tbNameTerNo.Text = _contact.NameTerNo
        tbSearched.Text = _contact.DateSearched
        tbFound.Text = _contact.DateFound
        tbLat.Text = _contact.Latitude
        tbLong.Text = _contact.Longitude
    End Sub
    Public Function GenerateUID()
        Dim num As New Random
        Dim uid As String = num.Next(1, 1000000)
        For Each id As DataGridViewRow In dgvContacts.Rows
            If id.Cells.Item(0).Value IsNot Nothing Then
                If uid = id.Cells.Item(0).Value.trim Then
                    GenerateUID()
                End If
            End If
        Next
        Return uid
    End Function
    Private Sub UncheckBoxes(ByVal boxName As String)
        For Each control In gbQuickSearch.Controls

            If control.Name <> boxName Then
                Try
                    control.CheckState = CheckState.Unchecked
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub

#Region "Printing"
    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click _
        , btnPreview1.Click, btnPreview2.Click, btnPreview3.Click, btnPreview4.Click
        Dim pp As New PrintPreviewDialog()
        pp.Document = PrintDocument1
        pp.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnPrint1.Click _
        , btnPrint2.Click, btnPrint3.Click, btnPrint4.Click
        'MsgBox("Many apologies!  The quick print feature is not available yet.")
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim margins As New System.Drawing.Printing.Margins(50, 50, 15, 15)
        PrintDocument1.DefaultPageSettings.Margins = margins

        Dim font1 As New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        Dim fontsmall As New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        If Me.TabControl.SelectedIndex = 1 Then
            e.Graphics.DrawString(rtbDeafTerritory.Text, font1, Brushes.Black, e.MarginBounds)
        ElseIf Me.TabControl.SelectedIndex = 2 Then
            e.Graphics.DrawString(rtbVPTerritory.Text, font1, Brushes.Black, e.MarginBounds)


        ElseIf Me.TabControl.SelectedIndex = 3 Then
            Dim charactersOnPage As Integer = 0
            Dim linesPerPage As Integer = 0

            Dim isPage As RichTextBox

            isPage = rtbVPsearchTer

            Dim wx As Size
            wx.Width = 650
            wx.Height = 1000
            Dim x As Drawing.Point
            x.X = 50
            x.Y = 50
            Dim y As Drawing.Point
            y.X = 650
            y.Y = 1000

            'e.Graphics.MeasureString(rtbxVPsrchTerCard.Text, fontsmall, printSize, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)
            e.Graphics.MeasureString(isPage.Text, fontsmall, wx, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

            'e.Graphics.DrawString(rtbxVPsrchTerCard.Text, font1, Brushes.Black, e.MarginBounds)
            e.Graphics.DrawString(isPage.Text, fontsmall, Brushes.Black, New Rectangle(x, y), StringFormat.GenericTypographic)

            isPage.Text = isPage.Text.Substring(charactersOnPage)
            If isPage.Text.Length > 0 Then e.HasMorePages = True

        ElseIf Me.TabControl.SelectedIndex = 4 Then
            WebBrowser.ShowPrintPreviewDialog()
        ElseIf Me.TabControl.SelectedIndex = 5 Then
            e.Graphics.DrawString(rtbNameSearchTer.Text, font1, Brushes.Black, e.MarginBounds)
        End If
    End Sub
#End Region
#End Region

#Region "Events"
    Private Sub btnGetCoord_Click(sender As Object, e As EventArgs) Handles btnGetCoord.Click
        Process.Start("iexplore.exe", "http://gmaps-samples.googlecode.com/svn/trunk/geocoder/singlegeocode.html")
    End Sub
#Region "Contact Events"
    Private Sub tabManageContacts_Enter(sender As Object, e As EventArgs) Handles tabManageContacts.Enter
        _ta.Fill(DS.Contacts)
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub
    Private Sub dgvContacts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContacts.CellClick
        Try
            BuildContact(DS.Contacts.Rows.Find(dgvContacts.CurrentRow.DataBoundItem(0)))
        Catch ex As Exception
        End Try

    End Sub
    Private Sub ContactsBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles ContactsBindingSource.CurrentItemChanged
        'If _firstload = True Then Exit Sub
        _ta.Update(DS.Contacts)
    End Sub
    Private Sub btnNewContact_Click(sender As Object, e As EventArgs) Handles btnNewContact.Click
        _firstload = True
        Dim uid As Integer = GenerateUID()
        DS.Contacts.AddContactsRow(uid, vbNull, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        _ta.Update(DS.Contacts)
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub
    Private Sub btnRemoveContact_Click(sender As Object, e As EventArgs) Handles btnRemoveContact.Click
        Dim result = MsgBox("Are you sure you want to delete this contact?", MsgBoxStyle.YesNo, "Remove Contact?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvContacts.CurrentRow.Index
            DS.Contacts.RemoveContactsRow(DS.Contacts.Rows(row))
            _ta.Update(DS.Contacts)
            lblRecordsCount.Text = dgvContacts.Rows.Count
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim uid As String = dgvContacts.CurrentRow.DataBoundItem(0)

        _ta.UpdateContact(tbAgent.Text, tbFirstName.Text, tbLastName.Text, tbAddress.Text, tbCity.Text, tbState.Text, tbZip.Text _
       , tbVP1.Text, tbVP2.Text, tbVP3.Text, tbNotes.Text, tbNameFrom.Text, tbDoNotCall.Text, tbDeafTerNo.Text, tbVpTerNo.Text _
       , tbNameTerNo.Text, tbSearched.Text, tbFound.Text, tbLat.Text, tbLong.Text, uid)
        MsgBox("Contact information saved...")
        _ta.Fill(DS.Contacts)
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If tbFind.Text = "" Then
            _ta.Fill(DS.Contacts)
        Else
            _ta.FindFillBy(DS.Contacts, tbFind.Text)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub
    Private Sub cbAddressesOnlywDNC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddressesOnlywDNC.CheckedChanged
        If cbAddressesOnlywDNC.CheckState = CheckState.Checked Then
            UncheckBoxes(cbAddressesOnlywDNC.Name)
            _ta.FillAllAddresses(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbAddressOnlyNoDNC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddressOnlyNoDNC.CheckedChanged
        If cbAddressOnlyNoDNC.CheckState = CheckState.Checked Then
            UncheckBoxes(cbAddressOnlyNoDNC.Name)
            _ta.FillAddressesNoDNCs(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbNamesNoAddresses_CheckedChanged(sender As Object, e As EventArgs) Handles cbNamesNoAddresses.CheckedChanged
        If cbNamesNoAddresses.CheckState = CheckState.Checked Then
            UncheckBoxes(cbNamesNoAddresses.Name)
            _ta.FillNamesNoAddresses(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbNamesNoAgent_CheckedChanged(sender As Object, e As EventArgs) Handles cbNamesNoAgent.CheckedChanged
        If cbNamesNoAgent.CheckState = CheckState.Checked Then
            UncheckBoxes(cbNamesNoAgent.Name)
            _ta.FillNamesNoAgent(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbRecordsWithVP_CheckedChanged(sender As Object, e As EventArgs) Handles cbRecordsWithVP.CheckedChanged
        If cbRecordsWithVP.CheckState = CheckState.Checked Then
            UncheckBoxes(cbRecordsWithVP.Name)
            _ta.FillContactsWithVP(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbVPwithoutName_CheckedChanged(sender As Object, e As EventArgs) Handles cbVPwithoutName.CheckedChanged
        If cbVPwithoutName.CheckState = CheckState.Checked Then
            UncheckBoxes(cbVPwithoutName.Name)
            _ta.FillVPnoNames(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

    Private Sub cbDNC_CheckedChanged(sender As Object, e As EventArgs) Handles cbDNC.CheckedChanged
        If cbDNC.CheckState = CheckState.Checked Then
            UncheckBoxes(cbDNC.Name)
            _ta.FillDoNotCalls(DS.Contacts)
        End If
        lblRecordsCount.Text = dgvContacts.Rows.Count
    End Sub

#End Region
#Region "Deaf Territory Events"
    Private Sub tabDeafTeritorries_Enter(sender As Object, e As EventArgs) Handles tabDeafTeritorries.Enter
        _tadt.Fill(DS.Deaf_Territories)
        lblDeafTerCount.Text = dgvDeafTerritories.Rows.Count
    End Sub

    Private Sub DeafTerBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles DeafTerBindingSource.CurrentItemChanged
        _tadt.Update(DS.Deaf_Territories)
    End Sub

    Private Sub dgvDeafTerritories_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeafTerritories.CellEnter

        Try
            Dim terno As String = dgvDeafTerritories.CurrentRow.DataBoundItem(0)

        rtbDeafTerritory.Clear()

        rtbDeafTerritory.AppendText("Territory No: " & terno & Environment.NewLine)
        rtbDeafTerritory.AppendText("Please check with the Agent before contacting the deaf person." & Environment.NewLine)
        rtbDeafTerritory.AppendText(Environment.NewLine)

        For Each Contact As DataRow In DS.Contacts.Rows
            BuildContact(Contact)
            If _contact.DeafTerNo IsNot Nothing And _contact.DeafTerNo = terno.Trim Then
                rtbDeafTerritory.AppendText(_contact.FirstName & " " & _contact.LastName & Environment.NewLine)
                rtbDeafTerritory.AppendText("Agent: " & _contact.Agent & Environment.NewLine)
                rtbDeafTerritory.AppendText("Address: " & _contact.Address & " " & _contact.City & " " & _contact.State & " " & _contact.Zip & Environment.NewLine)
                rtbDeafTerritory.AppendText("VP1: " & _contact.VP1 & " VP2: " & _contact.VP2 & " VP3: " & _contact.VP3 & Environment.NewLine)
                rtbDeafTerritory.AppendText(Environment.NewLine)
                rtbDeafTerritory.AppendText("Notes: " & _contact.Notes & Environment.NewLine)
                rtbDeafTerritory.AppendText(Environment.NewLine)
                rtbDeafTerritory.AppendText("_____________________________________________________________________________" & Environment.NewLine)
                rtbDeafTerritory.AppendText(Environment.NewLine)
            End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNewDeafTer_Click(sender As Object, e As EventArgs) Handles btnNewDeafTer.Click
        DS.Deaf_Territories.AddDeaf_TerritoriesRow("new", "", "", "")
        _tadt.Update(DS.Deaf_Territories)
        lblDeafTerCount.Text = dgvDeafTerritories.Rows.Count
    End Sub
    Private Sub btnDelDeafTer_Click(sender As Object, e As EventArgs) Handles btnDelDeafTer.Click
        Dim result = MsgBox("Are you sure you want to delete this territory?", MsgBoxStyle.YesNo, "Delete Territory?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvDeafTerritories.CurrentRow.Index
            DS.Deaf_Territories.RemoveDeaf_TerritoriesRow(DS.Deaf_Territories.Rows(row))
            lblDeafTerCount.Text = dgvDeafTerritories.Rows.Count
        End If
    End Sub
#End Region
#Region "VP Territory Events"
    Private Sub tabVPterritories_Enter(sender As Object, e As EventArgs) Handles tabVPterritories.Enter
        _tavpt.Fill(DS.VP_Territories)
        lblVpTerCount.Text = dgvVPTerritory.Rows.Count
    End Sub

    Private Sub VPTerBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles VPTerBindingSource.CurrentItemChanged
        _tavpt.Update(DS.VP_Territories)
    End Sub

    Private Sub dgvVPTerritoryCellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVPTerritory.CellEnter
        Try
            Dim terno As String = dgvVPTerritory.CurrentRow.DataBoundItem(0)
            rtbVPTerritory.Clear()

            rtbVPTerritory.AppendText("Territory No: " & terno & Environment.NewLine)
            rtbVPTerritory.AppendText("Please check with the Agent before contacting the deaf person." & Environment.NewLine)
            rtbVPTerritory.AppendText(Environment.NewLine)

            For Each Contact As DataRow In DS.Contacts.Rows
                BuildContact(Contact)
                If _contact.VpTerNo IsNot Nothing And _contact.VpTerNo = terno.Trim Then
                    rtbVPTerritory.AppendText("VP1: " & _contact.VP1 & " VP2: " & _contact.VP2 & " VP3: " & _contact.VP3 & Environment.NewLine)
                    rtbVPTerritory.AppendText(Environment.NewLine)
                    rtbVPTerritory.AppendText("Notes: " & _contact.Notes & Environment.NewLine)
                    rtbVPTerritory.AppendText(Environment.NewLine)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNewVPTer_Click(sender As Object, e As EventArgs) Handles btnNewVPTer.Click
        DS.VP_Territories.AddVP_TerritoriesRow("new", "", "", "")
        _tavpt.Update(DS.VP_Territories)
        lblVpTerCount.Text = dgvVPTerritory.Rows.Count
    End Sub
    Private Sub btnDelVPTer_Click(sender As Object, e As EventArgs) Handles btnDelVPTer.Click
        Dim result = MsgBox("Are you sure you want to delete this territory?", MsgBoxStyle.YesNo, "Delete Territory?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvVPTerritory.CurrentRow.Index
            DS.VP_Territories.RemoveVP_TerritoriesRow(DS.VP_Territories.Rows(row))
            lblVpTerCount.Text = dgvVPTerritory.Rows.Count
        End If
    End Sub
#End Region
#Region "VP Search Territory Events"
    Private Sub tabVPsearch_Enter(sender As Object, e As EventArgs) Handles tabVPsearch.Enter
        dgvVPsearchTer.Columns(0).Visible = False
        _tavps.Fill(DS.VP_Search_Territories)
        lblVpSearchTerCount.Text = dgvVPsearchTer.Rows.Count
    End Sub

    'Private Sub VPsearchTerBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles VPsearchTerBindingSourrce.CurrentItemChanged
    '    Try
    '        If dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "1-10" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "11-20" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "21-30" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "31-40" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "41-50" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "51-60" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "61-70" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "71-80" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "81-90" Or
    '        dgvVPsearchTer.CurrentRow.DataBoundItem(1) <> "91-100" Then
    '            MsgBox("Please enter only one of the following values: 1-10, 11-20 , 21-30 , 31-40, 41-50, 51-60, 61-70, 71-80, 81-90, 91-100")
    '            dgvVPsearchTer.CurrentRow.DataBoundItem(1) = ""
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try
    '    _tavps.Update(DS.VP_Search_Territories)
    'End Sub
    Private Sub dgvVPsearchTerCellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVPsearchTer.CellEnter
        Try
            rtbVPsearchTer.Clear()
        Dim terGroup As String = dgvVPsearchTer.CurrentRow.DataBoundItem(1)
        Dim prefix As String = dgvVPsearchTer.CurrentRow.DataBoundItem(0)
        Dim number As String = 0
        Dim terno As String = prefix & " Territories: " & terGroup
        Dim x As Double


        ' Build the territory
        If Not String.IsNullOrWhiteSpace(terGroup) Then
            Dim startCount As Integer = terGroup.Substring(0, 2)
            If startCount = -1 Then startCount = 1
            Dim endCount As Integer = terGroup.Substring(3)
            If endCount = 0 Then endCount = 10
                If startCount > 10 Then number = startCount * 100

            rtbVPsearchTer.AppendText("Territory: " & prefix.Trim & "  Territory Group: " & terGroup & Environment.NewLine)
            rtbVPsearchTer.AppendText(Environment.NewLine)
            For buildIt = startCount To endCount

                    For incNum = 1 To 100
                        If number < 10 Then
                            number = number.Insert(0, "000")
                        End If

                        If number > 9 AndAlso number < 100 Then number = number.Insert(0, "00")
                        If number.ToString.Length = 3 Then number = number.Insert(0, "0")
                        x = (Conversion.Int(number) / 2)
                        If x = Int(x) Then
                            rtbVPsearchTer.AppendText(prefix.Trim & "-" & number)
                        Else : rtbVPsearchTer.AppendText("                                                                   " & prefix.Trim & "-" & number & Environment.NewLine)
                        End If
                        number += 1
                    Next
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNewVPsearchTer_Click(sender As Object, e As EventArgs) Handles btnNewVPserchTer.Click
        DS.VP_Search_Territories.AddVP_Search_TerritoriesRow("New", "", "", "", "")
        _tavps.Update(DS.VP_Search_Territories)
        lblVpSearchTerCount.Text = dgvVPsearchTer.Rows.Count
    End Sub
    Private Sub btnDelVPsearchTer_Click(sender As Object, e As EventArgs) Handles btnDelVPsearchTer.Click
        Dim result = MsgBox("Are you sure you want to delete this territory?", MsgBoxStyle.YesNo, "Delete Territory?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvVPsearchTer.CurrentRow.Index
            DS.VP_Search_Territories.RemoveVP_Search_TerritoriesRow(DS.VP_Search_Territories.Rows(row))
            lblVpSearchTerCount.Text = dgvVPsearchTer.Rows.Count
        End If
    End Sub
#End Region
#Region "Name Search Territory Events"
    Private Sub tabNameTerritories_Enter(sender As Object, e As EventArgs) Handles tabNameTerritories.Enter
        _tans.Fill(DS.Name_Search_Territories)
        lblNameSearchTerCount.Text = dgvNameSearchTer.Rows.Count
    End Sub
    Private Sub NameSearchBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles NameSearchBindingSource.CurrentItemChanged
        _tans.Update(DS.Name_Search_Territories)
    End Sub
    Private Sub dgvNameSearchTer_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNameSearchTer.CellEnter
        Try
            Dim terno As String = dgvNameSearchTer.CurrentRow.DataBoundItem(0)
            rtbNameSearchTer.Clear()

            rtbNameSearchTer.AppendText("Territory No: " & terno & Environment.NewLine)
            rtbNameSearchTer.AppendText(Environment.NewLine)

            For Each Contact As DataRow In DS.Contacts.Rows
                BuildContact(Contact)
                If _contact.NameTerNo IsNot Nothing And _contact.NameTerNo = terno.Trim Then
                    rtbNameSearchTer.AppendText(_contact.FirstName & " " & _contact.LastName & Environment.NewLine)
                    rtbNameSearchTer.AppendText(Environment.NewLine)
                    rtbNameSearchTer.AppendText("Notes: " & _contact.Notes & Environment.NewLine)
                    rtbNameSearchTer.AppendText(Environment.NewLine)
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNameSearchAdd_Click(sender As Object, e As EventArgs) Handles btnNameSearchAdd.Click
        DS.Name_Search_Territories.AddName_Search_TerritoriesRow("new", "", "", "")
        _tans.Update(DS.Name_Search_Territories)
        lblNameSearchTerCount.Text = dgvNameSearchTer.Rows.Count
    End Sub
    Private Sub btnNameSearchDel_Click(sender As Object, e As EventArgs) Handles btnNameSearchDel.Click
        Dim result = MsgBox("Are you sure you want to delete this territory?", MsgBoxStyle.YesNo, "Delete Territory?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvNameSearchTer.CurrentRow.Index
            DS.Name_Search_Territories.RemoveName_Search_TerritoriesRow(DS.Name_Search_Territories.Rows(row))
            lblNameSearchTerCount.Text = dgvNameSearchTer.Rows.Count
        End If
    End Sub
#End Region
#Region "Map Search Territory Events"
    Private Sub tabMapSearchTer_Enter(sender As Object, e As EventArgs) Handles tabMapSearchTer.Enter
        _tams.Fill(DS.Maps)
        lblMapTerCount.Text = dgvMapsSearchTer.Rows.Count
    End Sub
    Private Sub MapsBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles MapsBindingSource.CurrentItemChanged
        _tams.Update(DS.Maps)
    End Sub
    Private Sub dgvMapsSearchTer_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMapsSearchTer.CellEnter
        Try
            _firstload = True
            For Each cell As DataGridViewCell In dgvMapsSearchTer.CurrentRow.Cells
                If Not String.IsNullOrEmpty(cell.Value.ToString) Then
                    _firstload = False
                End If
            Next
            If _firstload = False Then
                Dim ter As New Territory("map")
                CreateMap(ter.Latitude, ter.Longitude, ter.TerNo)
                rtbNameSearchTer.Clear()
                rtbNameSearchTer.AppendText(Environment.NewLine)
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub btnNewMap_Click(sender As Object, e As EventArgs) Handles btnNewMap.Click
        DS.Maps.AddMapsRow("new", "", "", "", "", "", "")
        _tams.Update(DS.Maps)
        lblMapTerCount.Text = dgvMapsSearchTer.Rows.Count
    End Sub
    Private Sub btnDelMap_Click(sender As Object, e As EventArgs) Handles btnDelMap.Click
        Dim result = MsgBox("Are you sure you want to delete this territory?", MsgBoxStyle.YesNo, "Delete Territory?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim row As Integer = dgvMapsSearchTer.CurrentRow.Index
            DS.Maps.RemoveMapsRow(DS.Maps.Rows(row))
            lblMapTerCount.Text = dgvMapsSearchTer.Rows.Count
        End If
    End Sub
#End Region

#Region "Export to CSV"
    Private Sub Export_To_File(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim headers = (From header As DataGridViewColumn In dgvContacts.Columns.Cast(Of DataGridViewColumn)() _
            Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dgvContacts.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("csv.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("csv.txt")
    End Sub
#End Region
#Region "Delete Tables"
    Private Sub btnDeleteAllRecords_Click(sender As Object, e As EventArgs) Handles btnDeleteAllRecords.Click
        Dim result = MsgBox("Are you sure you want to delete the entire database?", MsgBoxStyle.YesNo, "Delete Everything?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _ta.DeleteAll()
            _tadt.DeleteAll()
            _tavps.DeleteAll()
            _tans.DeleteAll()
            _tams.DeleteAll()
            _tavpt.DeleteAll()
            MsgBox("Your database is deleted")
        End If
    End Sub
    Private Sub btnDeleteAllContacts_Click(sender As Object, e As EventArgs) Handles btnDeleteAllContacts.Click
        Dim result = MsgBox("Are you sure you want to delete all of your contacts?", MsgBoxStyle.YesNo, "Delete Contacts?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _ta.DeleteAll()
            MsgBox("Your contacts are deleted")
        End If
    End Sub
    Private Sub btnDeleteAllDeafTer_Click(sender As Object, e As EventArgs) Handles btnDeleteAllDeafTer.Click
        Dim result = MsgBox("Are you sure you want to delete all of your deaf territories?", MsgBoxStyle.YesNo, "Delete Deaf Territories?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _tadt.DeleteAll()
            MsgBox("Your deaf territories are deleted")
        End If
    End Sub
    Private Sub btnDeleteVpTer_Click(sender As Object, e As EventArgs) Handles btnDeleteVpTer.Click
        Dim result = MsgBox("Are you sure you want to delete all of your VP territories?", MsgBoxStyle.YesNo, "Delete VP Territories?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _tavpt.DeleteAll()
            MsgBox("Your VP territories are deleted")
        End If
    End Sub
    Private Sub btnDeleteVpSerTer_Click(sender As Object, e As EventArgs) Handles btnDeleteVpSerTer.Click
        Dim result = MsgBox("Are you sure you want to delete all of your VP search territories?", MsgBoxStyle.YesNo, "Delete VP Search Territories?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _tavps.DeleteAll()
            MsgBox("Your VP search territories are deleted")
        End If
    End Sub
    Private Sub btnDelMapSer_Click(sender As Object, e As EventArgs) Handles btnDelMapSer.Click
        Dim result = MsgBox("Are you sure you want to delete all of your map search territories?", MsgBoxStyle.YesNo, "Delete Map Search Territories?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _tams.DeleteAll()
            MsgBox("Your map search territories are deleted")
        End If
    End Sub
    Private Sub btnDelNameSer_Click(sender As Object, e As EventArgs) Handles btnDelNameSer.Click
        Dim result = MsgBox("Are you sure you want to delete all of your name search territories?", MsgBoxStyle.YesNo, "Delete Name Search Territories?")
        If result = MsgBoxResult.No Then
            Exit Sub
        Else
            _tans.DeleteAll()
            MsgBox("Your name search territories are deleted")
        End If
    End Sub
#End Region
#Region "Backup and Restore"
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        _ta.Backup(DS.Contacts)
        MsgBox("ASL Territory Manager has been backed up to C:\Dropbox\ASl Territory Manager\ASL_Territory_Manager.bak")
    End Sub
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        _ta.Restore(DS.Contacts)

        MsgBox("ASL Territory Manager has been restored from C:\Dropbox\ASl Territory Manager\ASL_Territory_Manager.bak")
    End Sub
#End Region
#End Region
  
    
   
    
End Class
