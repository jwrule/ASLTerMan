<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASLTerriroryManager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASLTerriroryManager))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabManageContacts = New System.Windows.Forms.TabPage()
        Me.lblRecordsCount = New System.Windows.Forms.Label()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.lblNameTerNo = New System.Windows.Forms.Label()
        Me.tbNameTerNo = New System.Windows.Forms.TextBox()
        Me.gbQuickSearch = New System.Windows.Forms.GroupBox()
        Me.cbVPwithoutName = New System.Windows.Forms.CheckBox()
        Me.cbNamesNoAgent = New System.Windows.Forms.CheckBox()
        Me.cbDNC = New System.Windows.Forms.CheckBox()
        Me.cbRecordsWithVP = New System.Windows.Forms.CheckBox()
        Me.cbNamesNoAddresses = New System.Windows.Forms.CheckBox()
        Me.cbAddressOnlyNoDNC = New System.Windows.Forms.CheckBox()
        Me.cbAddressesOnlywDNC = New System.Windows.Forms.CheckBox()
        Me.tbFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblVpTerNo = New System.Windows.Forms.Label()
        Me.tbVpTerNo = New System.Windows.Forms.TextBox()
        Me.btnGetCoord = New System.Windows.Forms.Button()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.tbLong = New System.Windows.Forms.TextBox()
        Me.tbLat = New System.Windows.Forms.TextBox()
        Me.lblDeafTerNo = New System.Windows.Forms.Label()
        Me.tbDeafTerNo = New System.Windows.Forms.TextBox()
        Me.gbContactManage = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewContact = New System.Windows.Forms.Button()
        Me.btnRemoveContact = New System.Windows.Forms.Button()
        Me.lblConfirmedDeaf = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.lblSearched = New System.Windows.Forms.Label()
        Me.tbConfirmedDeaf = New System.Windows.Forms.TextBox()
        Me.tbFound = New System.Windows.Forms.TextBox()
        Me.tbSearched = New System.Windows.Forms.TextBox()
        Me.lblNameFrom = New System.Windows.Forms.Label()
        Me.tbNameFrom = New System.Windows.Forms.TextBox()
        Me.lblVP2 = New System.Windows.Forms.Label()
        Me.lblVP3 = New System.Windows.Forms.Label()
        Me.lblVP1 = New System.Windows.Forms.Label()
        Me.tbVP2 = New System.Windows.Forms.TextBox()
        Me.tbVP3 = New System.Windows.Forms.TextBox()
        Me.tbVP1 = New System.Windows.Forms.TextBox()
        Me.tbNotes = New System.Windows.Forms.RichTextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.tbZip = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.lblDoNotCall = New System.Windows.Forms.Label()
        Me.tbDoNotCall = New System.Windows.Forms.TextBox()
        Me.tbAgent = New System.Windows.Forms.TextBox()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.dgvContacts = New System.Windows.Forms.DataGridView()
        Me.UIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP3DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameFromDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoNotCallDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeafTerNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPTerNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameTerNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSearchedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFoundDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New ASL_Teritory_Manager.DS()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tabDeafTeritorries = New System.Windows.Forms.TabPage()
        Me.lblDeafTerCount = New System.Windows.Forms.Label()
        Me.lblDeafTer = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.rtbDeafTerritory = New System.Windows.Forms.RichTextBox()
        Me.btnDelDeafTer = New System.Windows.Forms.Button()
        Me.btnNewDeafTer = New System.Windows.Forms.Button()
        Me.dgvDeafTerritories = New System.Windows.Forms.DataGridView()
        Me.TerNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeafTerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabVPterritories = New System.Windows.Forms.TabPage()
        Me.lblVpTerCount = New System.Windows.Forms.Label()
        Me.lblVpTer = New System.Windows.Forms.Label()
        Me.btnPreview1 = New System.Windows.Forms.Button()
        Me.btnPrint1 = New System.Windows.Forms.Button()
        Me.rtbVPTerritory = New System.Windows.Forms.RichTextBox()
        Me.btnDelVPTer = New System.Windows.Forms.Button()
        Me.btnNewVPTer = New System.Windows.Forms.Button()
        Me.dgvVPTerritory = New System.Windows.Forms.DataGridView()
        Me.TerNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOutDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateInDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPTerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabVPsearch = New System.Windows.Forms.TabPage()
        Me.lblVpSearchTerCount = New System.Windows.Forms.Label()
        Me.lblVpSearchTer = New System.Windows.Forms.Label()
        Me.btnPrint2 = New System.Windows.Forms.Button()
        Me.btnPreview2 = New System.Windows.Forms.Button()
        Me.rtbVPsearchTer = New System.Windows.Forms.RichTextBox()
        Me.btnDelVPsearchTer = New System.Windows.Forms.Button()
        Me.btnNewVPserchTer = New System.Windows.Forms.Button()
        Me.dgvVPsearchTer = New System.Windows.Forms.DataGridView()
        Me.AreaCodeAndPrefixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerritoryGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOutDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPsearchTerBindingSourrce = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabMapSearchTer = New System.Windows.Forms.TabPage()
        Me.lblMapTerCount = New System.Windows.Forms.Label()
        Me.lblMapTer = New System.Windows.Forms.Label()
        Me.btnPrint3 = New System.Windows.Forms.Button()
        Me.btnPreview3 = New System.Windows.Forms.Button()
        Me.btnDelMap = New System.Windows.Forms.Button()
        Me.btnNewMap = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.dgvMapsSearchTer = New System.Windows.Forms.DataGridView()
        Me.TerNoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOutDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateInDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MapsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxTerMap = New System.Windows.Forms.GroupBox()
        Me.tabNameTerritories = New System.Windows.Forms.TabPage()
        Me.lblNameSearchTerCount = New System.Windows.Forms.Label()
        Me.lblNameSearchTer = New System.Windows.Forms.Label()
        Me.btnPrint4 = New System.Windows.Forms.Button()
        Me.btnPreview4 = New System.Windows.Forms.Button()
        Me.rtbNameSearchTer = New System.Windows.Forms.RichTextBox()
        Me.btnNameSearchDel = New System.Windows.Forms.Button()
        Me.btnNameSearchAdd = New System.Windows.Forms.Button()
        Me.dgvNameSearchTer = New System.Windows.Forms.DataGridView()
        Me.TerNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOutDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateInDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDatabase = New System.Windows.Forms.TabPage()
        Me.lblRestore = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.lblDelMapSer = New System.Windows.Forms.Label()
        Me.lblDelNameSer = New System.Windows.Forms.Label()
        Me.lblDelVpSer = New System.Windows.Forms.Label()
        Me.lblDeleteVpTer = New System.Windows.Forms.Label()
        Me.lblDeleteDeafTer = New System.Windows.Forms.Label()
        Me.lblDeleteAllContacts = New System.Windows.Forms.Label()
        Me.btnDelMapSer = New System.Windows.Forms.Button()
        Me.btnDelNameSer = New System.Windows.Forms.Button()
        Me.btnDeleteVpSerTer = New System.Windows.Forms.Button()
        Me.btnDeleteVpTer = New System.Windows.Forms.Button()
        Me.btnDeleteAllDeafTer = New System.Windows.Forms.Button()
        Me.btnDeleteAllContacts = New System.Windows.Forms.Button()
        Me.lblDeleteAllButton = New System.Windows.Forms.Label()
        Me.lblExportButton = New System.Windows.Forms.Label()
        Me.btnDeleteAllRecords = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Agent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Zip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoNotCallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeafTerNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPTerNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.UIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VP3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameFromDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deaf_TerritoriesTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.Deaf_TerritoriesTableAdapter()
        Me.VP_TerritoriesTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.VP_TerritoriesTableAdapter()
        Me.VP_Search_TerritoriesTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.VP_Search_TerritoriesTableAdapter()
        Me.Name_Search_TerritoriesTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.Name_Search_TerritoriesTableAdapter()
        Me.ContactsTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.ContactsTableAdapter()
        Me.MapsTableAdapter = New ASL_Teritory_Manager.DSTableAdapters.MapsTableAdapter()
        Me.TabControl.SuspendLayout()
        Me.tabManageContacts.SuspendLayout()
        Me.gbQuickSearch.SuspendLayout()
        Me.gbContactManage.SuspendLayout()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDeafTeritorries.SuspendLayout()
        CType(Me.dgvDeafTerritories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeafTerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVPterritories.SuspendLayout()
        CType(Me.dgvVPTerritory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPTerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVPsearch.SuspendLayout()
        CType(Me.dgvVPsearchTer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VPsearchTerBindingSourrce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMapSearchTer.SuspendLayout()
        CType(Me.dgvMapsSearchTer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNameTerritories.SuspendLayout()
        CType(Me.dgvNameSearchTer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatabase.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabManageContacts)
        Me.TabControl.Controls.Add(Me.tabDeafTeritorries)
        Me.TabControl.Controls.Add(Me.tabVPterritories)
        Me.TabControl.Controls.Add(Me.tabVPsearch)
        Me.TabControl.Controls.Add(Me.tabMapSearchTer)
        Me.TabControl.Controls.Add(Me.tabNameTerritories)
        Me.TabControl.Controls.Add(Me.tabDatabase)
        Me.TabControl.Location = New System.Drawing.Point(37, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1200, 725)
        Me.TabControl.TabIndex = 0
        '
        'tabManageContacts
        '
        Me.tabManageContacts.Controls.Add(Me.lblRecordsCount)
        Me.tabManageContacts.Controls.Add(Me.lblRecords)
        Me.tabManageContacts.Controls.Add(Me.lblNameTerNo)
        Me.tabManageContacts.Controls.Add(Me.tbNameTerNo)
        Me.tabManageContacts.Controls.Add(Me.gbQuickSearch)
        Me.tabManageContacts.Controls.Add(Me.lblVpTerNo)
        Me.tabManageContacts.Controls.Add(Me.tbVpTerNo)
        Me.tabManageContacts.Controls.Add(Me.btnGetCoord)
        Me.tabManageContacts.Controls.Add(Me.lblLong)
        Me.tabManageContacts.Controls.Add(Me.lblLat)
        Me.tabManageContacts.Controls.Add(Me.tbLong)
        Me.tabManageContacts.Controls.Add(Me.tbLat)
        Me.tabManageContacts.Controls.Add(Me.lblDeafTerNo)
        Me.tabManageContacts.Controls.Add(Me.tbDeafTerNo)
        Me.tabManageContacts.Controls.Add(Me.gbContactManage)
        Me.tabManageContacts.Controls.Add(Me.lblConfirmedDeaf)
        Me.tabManageContacts.Controls.Add(Me.lblFound)
        Me.tabManageContacts.Controls.Add(Me.lblSearched)
        Me.tabManageContacts.Controls.Add(Me.tbConfirmedDeaf)
        Me.tabManageContacts.Controls.Add(Me.tbFound)
        Me.tabManageContacts.Controls.Add(Me.tbSearched)
        Me.tabManageContacts.Controls.Add(Me.lblNameFrom)
        Me.tabManageContacts.Controls.Add(Me.tbNameFrom)
        Me.tabManageContacts.Controls.Add(Me.lblVP2)
        Me.tabManageContacts.Controls.Add(Me.lblVP3)
        Me.tabManageContacts.Controls.Add(Me.lblVP1)
        Me.tabManageContacts.Controls.Add(Me.tbVP2)
        Me.tabManageContacts.Controls.Add(Me.tbVP3)
        Me.tabManageContacts.Controls.Add(Me.tbVP1)
        Me.tabManageContacts.Controls.Add(Me.tbNotes)
        Me.tabManageContacts.Controls.Add(Me.lblState)
        Me.tabManageContacts.Controls.Add(Me.lblZip)
        Me.tabManageContacts.Controls.Add(Me.lblNotes)
        Me.tabManageContacts.Controls.Add(Me.lblCity)
        Me.tabManageContacts.Controls.Add(Me.tbState)
        Me.tabManageContacts.Controls.Add(Me.tbZip)
        Me.tabManageContacts.Controls.Add(Me.tbCity)
        Me.tabManageContacts.Controls.Add(Me.lblAddress)
        Me.tabManageContacts.Controls.Add(Me.tbAddress)
        Me.tabManageContacts.Controls.Add(Me.lblDoNotCall)
        Me.tabManageContacts.Controls.Add(Me.tbDoNotCall)
        Me.tabManageContacts.Controls.Add(Me.tbAgent)
        Me.tabManageContacts.Controls.Add(Me.lblAgent)
        Me.tabManageContacts.Controls.Add(Me.lblLastName)
        Me.tabManageContacts.Controls.Add(Me.lblFirstName)
        Me.tabManageContacts.Controls.Add(Me.dgvContacts)
        Me.tabManageContacts.Controls.Add(Me.tbLastName)
        Me.tabManageContacts.Controls.Add(Me.tbFirstName)
        Me.tabManageContacts.Location = New System.Drawing.Point(4, 22)
        Me.tabManageContacts.Name = "tabManageContacts"
        Me.tabManageContacts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManageContacts.Size = New System.Drawing.Size(1192, 699)
        Me.tabManageContacts.TabIndex = 0
        Me.tabManageContacts.Text = "Manage Contacts"
        Me.tabManageContacts.UseVisualStyleBackColor = True
        '
        'lblRecordsCount
        '
        Me.lblRecordsCount.AutoSize = True
        Me.lblRecordsCount.Location = New System.Drawing.Point(81, 681)
        Me.lblRecordsCount.Name = "lblRecordsCount"
        Me.lblRecordsCount.Size = New System.Drawing.Size(0, 13)
        Me.lblRecordsCount.TabIndex = 51
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Location = New System.Drawing.Point(22, 681)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(52, 13)
        Me.lblRecords.TabIndex = 1
        Me.lblRecords.Text = "Contacts:"
        '
        'lblNameTerNo
        '
        Me.lblNameTerNo.AutoSize = True
        Me.lblNameTerNo.Location = New System.Drawing.Point(1054, 123)
        Me.lblNameTerNo.Name = "lblNameTerNo"
        Me.lblNameTerNo.Size = New System.Drawing.Size(71, 13)
        Me.lblNameTerNo.TabIndex = 50
        Me.lblNameTerNo.Text = "Name Ter No"
        '
        'tbNameTerNo
        '
        Me.tbNameTerNo.Location = New System.Drawing.Point(1057, 138)
        Me.tbNameTerNo.Name = "tbNameTerNo"
        Me.tbNameTerNo.Size = New System.Drawing.Size(65, 20)
        Me.tbNameTerNo.TabIndex = 49
        '
        'gbQuickSearch
        '
        Me.gbQuickSearch.Controls.Add(Me.cbVPwithoutName)
        Me.gbQuickSearch.Controls.Add(Me.cbNamesNoAgent)
        Me.gbQuickSearch.Controls.Add(Me.cbDNC)
        Me.gbQuickSearch.Controls.Add(Me.cbRecordsWithVP)
        Me.gbQuickSearch.Controls.Add(Me.cbNamesNoAddresses)
        Me.gbQuickSearch.Controls.Add(Me.cbAddressOnlyNoDNC)
        Me.gbQuickSearch.Controls.Add(Me.cbAddressesOnlywDNC)
        Me.gbQuickSearch.Controls.Add(Me.tbFind)
        Me.gbQuickSearch.Controls.Add(Me.btnFind)
        Me.gbQuickSearch.Location = New System.Drawing.Point(11, 164)
        Me.gbQuickSearch.Name = "gbQuickSearch"
        Me.gbQuickSearch.Size = New System.Drawing.Size(1111, 58)
        Me.gbQuickSearch.TabIndex = 48
        Me.gbQuickSearch.TabStop = False
        Me.gbQuickSearch.Text = "Quick Search"
        '
        'cbVPwithoutName
        '
        Me.cbVPwithoutName.AutoSize = True
        Me.cbVPwithoutName.Location = New System.Drawing.Point(893, 30)
        Me.cbVPwithoutName.Name = "cbVPwithoutName"
        Me.cbVPwithoutName.Size = New System.Drawing.Size(118, 17)
        Me.cbVPwithoutName.TabIndex = 8
        Me.cbVPwithoutName.Text = "VPs without Names"
        Me.cbVPwithoutName.UseVisualStyleBackColor = True
        '
        'cbNamesNoAgent
        '
        Me.cbNamesNoAgent.AutoSize = True
        Me.cbNamesNoAgent.Location = New System.Drawing.Point(729, 30)
        Me.cbNamesNoAgent.Name = "cbNamesNoAgent"
        Me.cbNamesNoAgent.Size = New System.Drawing.Size(129, 17)
        Me.cbNamesNoAgent.TabIndex = 7
        Me.cbNamesNoAgent.Text = "Names with No Agent"
        Me.cbNamesNoAgent.UseVisualStyleBackColor = True
        '
        'cbDNC
        '
        Me.cbDNC.AutoSize = True
        Me.cbDNC.Location = New System.Drawing.Point(1018, 10)
        Me.cbDNC.Name = "cbDNC"
        Me.cbDNC.Size = New System.Drawing.Size(85, 17)
        Me.cbDNC.TabIndex = 6
        Me.cbDNC.Text = "Do Not Calls"
        Me.cbDNC.UseVisualStyleBackColor = True
        '
        'cbRecordsWithVP
        '
        Me.cbRecordsWithVP.AutoSize = True
        Me.cbRecordsWithVP.Location = New System.Drawing.Point(893, 10)
        Me.cbRecordsWithVP.Name = "cbRecordsWithVP"
        Me.cbRecordsWithVP.Size = New System.Drawing.Size(108, 17)
        Me.cbRecordsWithVP.TabIndex = 5
        Me.cbRecordsWithVP.Text = "Records With VP"
        Me.cbRecordsWithVP.UseVisualStyleBackColor = True
        '
        'cbNamesNoAddresses
        '
        Me.cbNamesNoAddresses.AutoSize = True
        Me.cbNamesNoAddresses.Location = New System.Drawing.Point(729, 10)
        Me.cbNamesNoAddresses.Name = "cbNamesNoAddresses"
        Me.cbNamesNoAddresses.Size = New System.Drawing.Size(150, 17)
        Me.cbNamesNoAddresses.TabIndex = 4
        Me.cbNamesNoAddresses.Text = "Names with No Addresses"
        Me.cbNamesNoAddresses.UseVisualStyleBackColor = True
        '
        'cbAddressOnlyNoDNC
        '
        Me.cbAddressOnlyNoDNC.AutoSize = True
        Me.cbAddressOnlyNoDNC.Location = New System.Drawing.Point(555, 31)
        Me.cbAddressOnlyNoDNC.Name = "cbAddressOnlyNoDNC"
        Me.cbAddressOnlyNoDNC.Size = New System.Drawing.Size(153, 17)
        Me.cbAddressOnlyNoDNC.TabIndex = 3
        Me.cbAddressOnlyNoDNC.Text = "Addresses Only (No DNCs)"
        Me.cbAddressOnlyNoDNC.UseVisualStyleBackColor = True
        '
        'cbAddressesOnlywDNC
        '
        Me.cbAddressesOnlywDNC.AutoSize = True
        Me.cbAddressesOnlywDNC.Location = New System.Drawing.Point(555, 10)
        Me.cbAddressesOnlywDNC.Name = "cbAddressesOnlywDNC"
        Me.cbAddressesOnlywDNC.Size = New System.Drawing.Size(156, 17)
        Me.cbAddressesOnlywDNC.TabIndex = 2
        Me.cbAddressesOnlywDNC.Text = "Addresses Only (Incl DNCs)"
        Me.cbAddressesOnlywDNC.UseVisualStyleBackColor = True
        '
        'tbFind
        '
        Me.tbFind.Location = New System.Drawing.Point(101, 24)
        Me.tbFind.Name = "tbFind"
        Me.tbFind.Size = New System.Drawing.Size(433, 20)
        Me.tbFind.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(6, 24)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblVpTerNo
        '
        Me.lblVpTerNo.AutoSize = True
        Me.lblVpTerNo.Location = New System.Drawing.Point(975, 123)
        Me.lblVpTerNo.Name = "lblVpTerNo"
        Me.lblVpTerNo.Size = New System.Drawing.Size(57, 13)
        Me.lblVpTerNo.TabIndex = 47
        Me.lblVpTerNo.Text = "VP Ter No"
        '
        'tbVpTerNo
        '
        Me.tbVpTerNo.Location = New System.Drawing.Point(978, 137)
        Me.tbVpTerNo.Name = "tbVpTerNo"
        Me.tbVpTerNo.Size = New System.Drawing.Size(65, 20)
        Me.tbVpTerNo.TabIndex = 46
        '
        'btnGetCoord
        '
        Me.btnGetCoord.Location = New System.Drawing.Point(1025, 83)
        Me.btnGetCoord.Name = "btnGetCoord"
        Me.btnGetCoord.Size = New System.Drawing.Size(75, 23)
        Me.btnGetCoord.TabIndex = 45
        Me.btnGetCoord.Text = "Get Coord"
        Me.btnGetCoord.UseVisualStyleBackColor = True
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Location = New System.Drawing.Point(1022, 43)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(54, 13)
        Me.lblLong.TabIndex = 44
        Me.lblLong.Text = "Longitude"
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(1022, 6)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(45, 13)
        Me.lblLat.TabIndex = 43
        Me.lblLat.Text = "Latitude"
        '
        'tbLong
        '
        Me.tbLong.Location = New System.Drawing.Point(1022, 57)
        Me.tbLong.Name = "tbLong"
        Me.tbLong.Size = New System.Drawing.Size(100, 20)
        Me.tbLong.TabIndex = 42
        '
        'tbLat
        '
        Me.tbLat.Location = New System.Drawing.Point(1022, 22)
        Me.tbLat.Name = "tbLat"
        Me.tbLat.Size = New System.Drawing.Size(100, 20)
        Me.tbLat.TabIndex = 41
        '
        'lblDeafTerNo
        '
        Me.lblDeafTerNo.AutoSize = True
        Me.lblDeafTerNo.Location = New System.Drawing.Point(895, 123)
        Me.lblDeafTerNo.Name = "lblDeafTerNo"
        Me.lblDeafTerNo.Size = New System.Drawing.Size(66, 13)
        Me.lblDeafTerNo.TabIndex = 40
        Me.lblDeafTerNo.Text = "Deaf Ter No"
        '
        'tbDeafTerNo
        '
        Me.tbDeafTerNo.Location = New System.Drawing.Point(898, 137)
        Me.tbDeafTerNo.Name = "tbDeafTerNo"
        Me.tbDeafTerNo.Size = New System.Drawing.Size(65, 20)
        Me.tbDeafTerNo.TabIndex = 39
        '
        'gbContactManage
        '
        Me.gbContactManage.Controls.Add(Me.btnSave)
        Me.gbContactManage.Controls.Add(Me.btnNewContact)
        Me.gbContactManage.Controls.Add(Me.btnRemoveContact)
        Me.gbContactManage.Location = New System.Drawing.Point(898, 6)
        Me.gbContactManage.Name = "gbContactManage"
        Me.gbContactManage.Size = New System.Drawing.Size(100, 111)
        Me.gbContactManage.TabIndex = 38
        Me.gbContactManage.TabStop = False
        Me.gbContactManage.Text = "Manage Contact"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewContact
        '
        Me.btnNewContact.Location = New System.Drawing.Point(12, 19)
        Me.btnNewContact.Name = "btnNewContact"
        Me.btnNewContact.Size = New System.Drawing.Size(75, 23)
        Me.btnNewContact.TabIndex = 3
        Me.btnNewContact.Text = "New"
        Me.btnNewContact.UseVisualStyleBackColor = True
        '
        'btnRemoveContact
        '
        Me.btnRemoveContact.Location = New System.Drawing.Point(12, 48)
        Me.btnRemoveContact.Name = "btnRemoveContact"
        Me.btnRemoveContact.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveContact.TabIndex = 4
        Me.btnRemoveContact.Text = "Remove"
        Me.btnRemoveContact.UseVisualStyleBackColor = True
        '
        'lblConfirmedDeaf
        '
        Me.lblConfirmedDeaf.AutoSize = True
        Me.lblConfirmedDeaf.Location = New System.Drawing.Point(789, 83)
        Me.lblConfirmedDeaf.Name = "lblConfirmedDeaf"
        Me.lblConfirmedDeaf.Size = New System.Drawing.Size(80, 13)
        Me.lblConfirmedDeaf.TabIndex = 37
        Me.lblConfirmedDeaf.Text = "Confirmed Deaf"
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Location = New System.Drawing.Point(789, 43)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(37, 13)
        Me.lblFound.TabIndex = 36
        Me.lblFound.Text = "Found"
        '
        'lblSearched
        '
        Me.lblSearched.AutoSize = True
        Me.lblSearched.Location = New System.Drawing.Point(789, 6)
        Me.lblSearched.Name = "lblSearched"
        Me.lblSearched.Size = New System.Drawing.Size(53, 13)
        Me.lblSearched.TabIndex = 35
        Me.lblSearched.Text = "Searched"
        '
        'tbConfirmedDeaf
        '
        Me.tbConfirmedDeaf.HideSelection = False
        Me.tbConfirmedDeaf.Location = New System.Drawing.Point(792, 97)
        Me.tbConfirmedDeaf.Name = "tbConfirmedDeaf"
        Me.tbConfirmedDeaf.Size = New System.Drawing.Size(100, 20)
        Me.tbConfirmedDeaf.TabIndex = 34
        '
        'tbFound
        '
        Me.tbFound.Location = New System.Drawing.Point(792, 57)
        Me.tbFound.Name = "tbFound"
        Me.tbFound.Size = New System.Drawing.Size(100, 20)
        Me.tbFound.TabIndex = 33
        '
        'tbSearched
        '
        Me.tbSearched.Location = New System.Drawing.Point(792, 20)
        Me.tbSearched.Name = "tbSearched"
        Me.tbSearched.Size = New System.Drawing.Size(100, 20)
        Me.tbSearched.TabIndex = 32
        '
        'lblNameFrom
        '
        Me.lblNameFrom.AutoSize = True
        Me.lblNameFrom.Location = New System.Drawing.Point(683, 123)
        Me.lblNameFrom.Name = "lblNameFrom"
        Me.lblNameFrom.Size = New System.Drawing.Size(61, 13)
        Me.lblNameFrom.TabIndex = 31
        Me.lblNameFrom.Text = "Name From"
        '
        'tbNameFrom
        '
        Me.tbNameFrom.Location = New System.Drawing.Point(686, 137)
        Me.tbNameFrom.Name = "tbNameFrom"
        Me.tbNameFrom.Size = New System.Drawing.Size(206, 20)
        Me.tbNameFrom.TabIndex = 30
        '
        'lblVP2
        '
        Me.lblVP2.AutoSize = True
        Me.lblVP2.Location = New System.Drawing.Point(683, 43)
        Me.lblVP2.Name = "lblVP2"
        Me.lblVP2.Size = New System.Drawing.Size(30, 13)
        Me.lblVP2.TabIndex = 29
        Me.lblVP2.Text = "VP 2"
        '
        'lblVP3
        '
        Me.lblVP3.AutoSize = True
        Me.lblVP3.Location = New System.Drawing.Point(683, 83)
        Me.lblVP3.Name = "lblVP3"
        Me.lblVP3.Size = New System.Drawing.Size(30, 13)
        Me.lblVP3.TabIndex = 28
        Me.lblVP3.Text = "VP 3"
        '
        'lblVP1
        '
        Me.lblVP1.AutoSize = True
        Me.lblVP1.Location = New System.Drawing.Point(683, 6)
        Me.lblVP1.Name = "lblVP1"
        Me.lblVP1.Size = New System.Drawing.Size(30, 13)
        Me.lblVP1.TabIndex = 27
        Me.lblVP1.Text = "VP 1"
        '
        'tbVP2
        '
        Me.tbVP2.Location = New System.Drawing.Point(686, 57)
        Me.tbVP2.Name = "tbVP2"
        Me.tbVP2.Size = New System.Drawing.Size(100, 20)
        Me.tbVP2.TabIndex = 26
        '
        'tbVP3
        '
        Me.tbVP3.Location = New System.Drawing.Point(686, 97)
        Me.tbVP3.Name = "tbVP3"
        Me.tbVP3.Size = New System.Drawing.Size(100, 20)
        Me.tbVP3.TabIndex = 25
        '
        'tbVP1
        '
        Me.tbVP1.Location = New System.Drawing.Point(686, 20)
        Me.tbVP1.Name = "tbVP1"
        Me.tbVP1.Size = New System.Drawing.Size(100, 20)
        Me.tbVP1.TabIndex = 24
        '
        'tbNotes
        '
        Me.tbNotes.Location = New System.Drawing.Point(383, 20)
        Me.tbNotes.Name = "tbNotes"
        Me.tbNotes.Size = New System.Drawing.Size(297, 138)
        Me.tbNotes.TabIndex = 22
        Me.tbNotes.Text = ""
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(253, 123)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 21
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(297, 123)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(22, 13)
        Me.lblZip.TabIndex = 20
        Me.lblZip.Text = "Zip"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(380, 6)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 19
        Me.lblNotes.Text = "Notes"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(6, 123)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 18
        Me.lblCity.Text = "City"
        '
        'tbState
        '
        Me.tbState.Location = New System.Drawing.Point(256, 137)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(36, 20)
        Me.tbState.TabIndex = 17
        '
        'tbZip
        '
        Me.tbZip.Location = New System.Drawing.Point(299, 137)
        Me.tbZip.Name = "tbZip"
        Me.tbZip.Size = New System.Drawing.Size(64, 20)
        Me.tbZip.TabIndex = 16
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(7, 137)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(242, 20)
        Me.tbCity.TabIndex = 14
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 83)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(6, 97)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(357, 20)
        Me.tbAddress.TabIndex = 12
        '
        'lblDoNotCall
        '
        Me.lblDoNotCall.AutoSize = True
        Me.lblDoNotCall.Location = New System.Drawing.Point(191, 6)
        Me.lblDoNotCall.Name = "lblDoNotCall"
        Me.lblDoNotCall.Size = New System.Drawing.Size(61, 13)
        Me.lblDoNotCall.TabIndex = 11
        Me.lblDoNotCall.Text = "Do Not Call"
        '
        'tbDoNotCall
        '
        Me.tbDoNotCall.Location = New System.Drawing.Point(194, 20)
        Me.tbDoNotCall.Name = "tbDoNotCall"
        Me.tbDoNotCall.Size = New System.Drawing.Size(100, 20)
        Me.tbDoNotCall.TabIndex = 10
        '
        'tbAgent
        '
        Me.tbAgent.Location = New System.Drawing.Point(7, 20)
        Me.tbAgent.Name = "tbAgent"
        Me.tbAgent.Size = New System.Drawing.Size(100, 20)
        Me.tbAgent.TabIndex = 9
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Location = New System.Drawing.Point(4, 6)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(35, 13)
        Me.lblAgent.TabIndex = 8
        Me.lblAgent.Text = "Agent"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(191, 43)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(4, 43)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name"
        '
        'dgvContacts
        '
        Me.dgvContacts.AutoGenerateColumns = False
        Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UIDDataGridViewTextBoxColumn1, Me.AgentDataGridViewTextBoxColumn2, Me.FirstNameDataGridViewTextBoxColumn3, Me.LastNameDataGridViewTextBoxColumn3, Me.AddressDataGridViewTextBoxColumn2, Me.CityDataGridViewTextBoxColumn2, Me.StateDataGridViewTextBoxColumn2, Me.ZipDataGridViewTextBoxColumn2, Me.VP1DataGridViewTextBoxColumn2, Me.VP2DataGridViewTextBoxColumn2, Me.VP3DataGridViewTextBoxColumn2, Me.NotesDataGridViewTextBoxColumn2, Me.NameFromDataGridViewTextBoxColumn2, Me.DoNotCallDataGridViewTextBoxColumn1, Me.DeafTerNoDataGridViewTextBoxColumn1, Me.VPTerNoDataGridViewTextBoxColumn1, Me.NameTerNoDataGridViewTextBoxColumn, Me.DateSearchedDataGridViewTextBoxColumn, Me.DateFoundDataGridViewTextBoxColumn, Me.LatDataGridViewTextBoxColumn, Me.LongDataGridViewTextBoxColumn})
        Me.dgvContacts.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvContacts.DataSource = Me.ContactsBindingSource
        Me.dgvContacts.Location = New System.Drawing.Point(9, 228)
        Me.dgvContacts.Name = "dgvContacts"
        Me.dgvContacts.Size = New System.Drawing.Size(1175, 450)
        Me.dgvContacts.TabIndex = 5
        '
        'UIDDataGridViewTextBoxColumn1
        '
        Me.UIDDataGridViewTextBoxColumn1.DataPropertyName = "UID"
        Me.UIDDataGridViewTextBoxColumn1.HeaderText = "UID"
        Me.UIDDataGridViewTextBoxColumn1.Name = "UIDDataGridViewTextBoxColumn1"
        Me.UIDDataGridViewTextBoxColumn1.Visible = False
        '
        'AgentDataGridViewTextBoxColumn2
        '
        Me.AgentDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AgentDataGridViewTextBoxColumn2.DataPropertyName = "Agent"
        Me.AgentDataGridViewTextBoxColumn2.HeaderText = "Agent"
        Me.AgentDataGridViewTextBoxColumn2.Name = "AgentDataGridViewTextBoxColumn2"
        Me.AgentDataGridViewTextBoxColumn2.Width = 60
        '
        'FirstNameDataGridViewTextBoxColumn3
        '
        Me.FirstNameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FirstNameDataGridViewTextBoxColumn3.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn3.Name = "FirstNameDataGridViewTextBoxColumn3"
        Me.FirstNameDataGridViewTextBoxColumn3.Width = 76
        '
        'LastNameDataGridViewTextBoxColumn3
        '
        Me.LastNameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LastNameDataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn3.Name = "LastNameDataGridViewTextBoxColumn3"
        Me.LastNameDataGridViewTextBoxColumn3.Width = 77
        '
        'AddressDataGridViewTextBoxColumn2
        '
        Me.AddressDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AddressDataGridViewTextBoxColumn2.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn2.Name = "AddressDataGridViewTextBoxColumn2"
        Me.AddressDataGridViewTextBoxColumn2.Width = 70
        '
        'CityDataGridViewTextBoxColumn2
        '
        Me.CityDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CityDataGridViewTextBoxColumn2.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn2.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn2.Name = "CityDataGridViewTextBoxColumn2"
        Me.CityDataGridViewTextBoxColumn2.Width = 49
        '
        'StateDataGridViewTextBoxColumn2
        '
        Me.StateDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StateDataGridViewTextBoxColumn2.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn2.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn2.Name = "StateDataGridViewTextBoxColumn2"
        Me.StateDataGridViewTextBoxColumn2.Width = 57
        '
        'ZipDataGridViewTextBoxColumn2
        '
        Me.ZipDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ZipDataGridViewTextBoxColumn2.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn2.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn2.Name = "ZipDataGridViewTextBoxColumn2"
        Me.ZipDataGridViewTextBoxColumn2.Width = 47
        '
        'VP1DataGridViewTextBoxColumn2
        '
        Me.VP1DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP1DataGridViewTextBoxColumn2.DataPropertyName = "VP1"
        Me.VP1DataGridViewTextBoxColumn2.HeaderText = "VP1"
        Me.VP1DataGridViewTextBoxColumn2.Name = "VP1DataGridViewTextBoxColumn2"
        Me.VP1DataGridViewTextBoxColumn2.Width = 52
        '
        'VP2DataGridViewTextBoxColumn2
        '
        Me.VP2DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP2DataGridViewTextBoxColumn2.DataPropertyName = "VP2"
        Me.VP2DataGridViewTextBoxColumn2.HeaderText = "VP2"
        Me.VP2DataGridViewTextBoxColumn2.Name = "VP2DataGridViewTextBoxColumn2"
        Me.VP2DataGridViewTextBoxColumn2.Width = 52
        '
        'VP3DataGridViewTextBoxColumn2
        '
        Me.VP3DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP3DataGridViewTextBoxColumn2.DataPropertyName = "VP3"
        Me.VP3DataGridViewTextBoxColumn2.HeaderText = "VP3"
        Me.VP3DataGridViewTextBoxColumn2.Name = "VP3DataGridViewTextBoxColumn2"
        Me.VP3DataGridViewTextBoxColumn2.Width = 52
        '
        'NotesDataGridViewTextBoxColumn2
        '
        Me.NotesDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NotesDataGridViewTextBoxColumn2.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn2.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn2.Name = "NotesDataGridViewTextBoxColumn2"
        Me.NotesDataGridViewTextBoxColumn2.Width = 60
        '
        'NameFromDataGridViewTextBoxColumn2
        '
        Me.NameFromDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NameFromDataGridViewTextBoxColumn2.DataPropertyName = "Name From"
        Me.NameFromDataGridViewTextBoxColumn2.HeaderText = "Name From"
        Me.NameFromDataGridViewTextBoxColumn2.Name = "NameFromDataGridViewTextBoxColumn2"
        Me.NameFromDataGridViewTextBoxColumn2.Width = 79
        '
        'DoNotCallDataGridViewTextBoxColumn1
        '
        Me.DoNotCallDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoNotCallDataGridViewTextBoxColumn1.DataPropertyName = "Do Not Call"
        Me.DoNotCallDataGridViewTextBoxColumn1.HeaderText = "Do Not Call"
        Me.DoNotCallDataGridViewTextBoxColumn1.Name = "DoNotCallDataGridViewTextBoxColumn1"
        Me.DoNotCallDataGridViewTextBoxColumn1.Width = 79
        '
        'DeafTerNoDataGridViewTextBoxColumn1
        '
        Me.DeafTerNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DeafTerNoDataGridViewTextBoxColumn1.DataPropertyName = "Deaf Ter No"
        Me.DeafTerNoDataGridViewTextBoxColumn1.HeaderText = "Deaf Ter No"
        Me.DeafTerNoDataGridViewTextBoxColumn1.Name = "DeafTerNoDataGridViewTextBoxColumn1"
        Me.DeafTerNoDataGridViewTextBoxColumn1.Width = 71
        '
        'VPTerNoDataGridViewTextBoxColumn1
        '
        Me.VPTerNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VPTerNoDataGridViewTextBoxColumn1.DataPropertyName = "VP Ter No"
        Me.VPTerNoDataGridViewTextBoxColumn1.HeaderText = "VP Ter No"
        Me.VPTerNoDataGridViewTextBoxColumn1.Name = "VPTerNoDataGridViewTextBoxColumn1"
        Me.VPTerNoDataGridViewTextBoxColumn1.Width = 76
        '
        'NameTerNoDataGridViewTextBoxColumn
        '
        Me.NameTerNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NameTerNoDataGridViewTextBoxColumn.DataPropertyName = "Name Ter No"
        Me.NameTerNoDataGridViewTextBoxColumn.HeaderText = "Name Ter No"
        Me.NameTerNoDataGridViewTextBoxColumn.Name = "NameTerNoDataGridViewTextBoxColumn"
        Me.NameTerNoDataGridViewTextBoxColumn.Width = 76
        '
        'DateSearchedDataGridViewTextBoxColumn
        '
        Me.DateSearchedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DateSearchedDataGridViewTextBoxColumn.DataPropertyName = "Date Searched"
        Me.DateSearchedDataGridViewTextBoxColumn.HeaderText = "Date Searched"
        Me.DateSearchedDataGridViewTextBoxColumn.Name = "DateSearchedDataGridViewTextBoxColumn"
        Me.DateSearchedDataGridViewTextBoxColumn.Width = 96
        '
        'DateFoundDataGridViewTextBoxColumn
        '
        Me.DateFoundDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DateFoundDataGridViewTextBoxColumn.DataPropertyName = "Date Found"
        Me.DateFoundDataGridViewTextBoxColumn.HeaderText = "Date Found"
        Me.DateFoundDataGridViewTextBoxColumn.Name = "DateFoundDataGridViewTextBoxColumn"
        Me.DateFoundDataGridViewTextBoxColumn.Width = 81
        '
        'LatDataGridViewTextBoxColumn
        '
        Me.LatDataGridViewTextBoxColumn.DataPropertyName = "Lat"
        Me.LatDataGridViewTextBoxColumn.HeaderText = "Lat"
        Me.LatDataGridViewTextBoxColumn.Name = "LatDataGridViewTextBoxColumn"
        '
        'LongDataGridViewTextBoxColumn
        '
        Me.LongDataGridViewTextBoxColumn.DataPropertyName = "Long"
        Me.LongDataGridViewTextBoxColumn.HeaderText = "Long"
        Me.LongDataGridViewTextBoxColumn.Name = "LongDataGridViewTextBoxColumn"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(194, 57)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(170, 20)
        Me.tbLastName.TabIndex = 1
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(7, 57)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(170, 20)
        Me.tbFirstName.TabIndex = 0
        '
        'tabDeafTeritorries
        '
        Me.tabDeafTeritorries.Controls.Add(Me.lblDeafTerCount)
        Me.tabDeafTeritorries.Controls.Add(Me.lblDeafTer)
        Me.tabDeafTeritorries.Controls.Add(Me.btnPreview)
        Me.tabDeafTeritorries.Controls.Add(Me.btnPrint)
        Me.tabDeafTeritorries.Controls.Add(Me.rtbDeafTerritory)
        Me.tabDeafTeritorries.Controls.Add(Me.btnDelDeafTer)
        Me.tabDeafTeritorries.Controls.Add(Me.btnNewDeafTer)
        Me.tabDeafTeritorries.Controls.Add(Me.dgvDeafTerritories)
        Me.tabDeafTeritorries.Location = New System.Drawing.Point(4, 22)
        Me.tabDeafTeritorries.Name = "tabDeafTeritorries"
        Me.tabDeafTeritorries.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDeafTeritorries.Size = New System.Drawing.Size(1192, 699)
        Me.tabDeafTeritorries.TabIndex = 1
        Me.tabDeafTeritorries.Text = "Manage Deaf Territories"
        Me.tabDeafTeritorries.UseVisualStyleBackColor = True
        '
        'lblDeafTerCount
        '
        Me.lblDeafTerCount.AutoSize = True
        Me.lblDeafTerCount.Location = New System.Drawing.Point(534, 150)
        Me.lblDeafTerCount.Name = "lblDeafTerCount"
        Me.lblDeafTerCount.Size = New System.Drawing.Size(0, 13)
        Me.lblDeafTerCount.TabIndex = 7
        '
        'lblDeafTer
        '
        Me.lblDeafTer.AutoSize = True
        Me.lblDeafTer.Location = New System.Drawing.Point(454, 150)
        Me.lblDeafTer.Name = "lblDeafTer"
        Me.lblDeafTer.Size = New System.Drawing.Size(56, 13)
        Me.lblDeafTer.TabIndex = 6
        Me.lblDeafTer.Text = "Territories:"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(488, 66)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(488, 95)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'rtbDeafTerritory
        '
        Me.rtbDeafTerritory.Location = New System.Drawing.Point(596, 8)
        Me.rtbDeafTerritory.Name = "rtbDeafTerritory"
        Me.rtbDeafTerritory.Size = New System.Drawing.Size(525, 675)
        Me.rtbDeafTerritory.TabIndex = 3
        Me.rtbDeafTerritory.Text = ""
        '
        'btnDelDeafTer
        '
        Me.btnDelDeafTer.Location = New System.Drawing.Point(488, 37)
        Me.btnDelDeafTer.Name = "btnDelDeafTer"
        Me.btnDelDeafTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelDeafTer.TabIndex = 2
        Me.btnDelDeafTer.Text = "Delete"
        Me.btnDelDeafTer.UseVisualStyleBackColor = True
        '
        'btnNewDeafTer
        '
        Me.btnNewDeafTer.Location = New System.Drawing.Point(488, 8)
        Me.btnNewDeafTer.Name = "btnNewDeafTer"
        Me.btnNewDeafTer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewDeafTer.TabIndex = 1
        Me.btnNewDeafTer.Text = "New"
        Me.btnNewDeafTer.UseVisualStyleBackColor = True
        '
        'dgvDeafTerritories
        '
        Me.dgvDeafTerritories.AutoGenerateColumns = False
        Me.dgvDeafTerritories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeafTerritories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TerNoDataGridViewTextBoxColumn, Me.DateOutDataGridViewTextBoxColumn, Me.DateInDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn})
        Me.dgvDeafTerritories.DataSource = Me.DeafTerBindingSource
        Me.dgvDeafTerritories.Location = New System.Drawing.Point(6, 6)
        Me.dgvDeafTerritories.Name = "dgvDeafTerritories"
        Me.dgvDeafTerritories.Size = New System.Drawing.Size(442, 675)
        Me.dgvDeafTerritories.TabIndex = 0
        '
        'TerNoDataGridViewTextBoxColumn
        '
        Me.TerNoDataGridViewTextBoxColumn.DataPropertyName = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn.HeaderText = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn.Name = "TerNoDataGridViewTextBoxColumn"
        '
        'DateOutDataGridViewTextBoxColumn
        '
        Me.DateOutDataGridViewTextBoxColumn.DataPropertyName = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn.HeaderText = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn.Name = "DateOutDataGridViewTextBoxColumn"
        '
        'DateInDataGridViewTextBoxColumn
        '
        Me.DateInDataGridViewTextBoxColumn.DataPropertyName = "Date In"
        Me.DateInDataGridViewTextBoxColumn.HeaderText = "Date In"
        Me.DateInDataGridViewTextBoxColumn.Name = "DateInDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'DeafTerBindingSource
        '
        Me.DeafTerBindingSource.DataMember = "Deaf Territories"
        Me.DeafTerBindingSource.DataSource = Me.DS
        '
        'tabVPterritories
        '
        Me.tabVPterritories.Controls.Add(Me.lblVpTerCount)
        Me.tabVPterritories.Controls.Add(Me.lblVpTer)
        Me.tabVPterritories.Controls.Add(Me.btnPreview1)
        Me.tabVPterritories.Controls.Add(Me.btnPrint1)
        Me.tabVPterritories.Controls.Add(Me.rtbVPTerritory)
        Me.tabVPterritories.Controls.Add(Me.btnDelVPTer)
        Me.tabVPterritories.Controls.Add(Me.btnNewVPTer)
        Me.tabVPterritories.Controls.Add(Me.dgvVPTerritory)
        Me.tabVPterritories.Location = New System.Drawing.Point(4, 22)
        Me.tabVPterritories.Name = "tabVPterritories"
        Me.tabVPterritories.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVPterritories.Size = New System.Drawing.Size(1192, 699)
        Me.tabVPterritories.TabIndex = 2
        Me.tabVPterritories.Text = "Manage VP Territories"
        Me.tabVPterritories.UseVisualStyleBackColor = True
        '
        'lblVpTerCount
        '
        Me.lblVpTerCount.AutoSize = True
        Me.lblVpTerCount.Location = New System.Drawing.Point(534, 150)
        Me.lblVpTerCount.Name = "lblVpTerCount"
        Me.lblVpTerCount.Size = New System.Drawing.Size(0, 13)
        Me.lblVpTerCount.TabIndex = 8
        '
        'lblVpTer
        '
        Me.lblVpTer.AutoSize = True
        Me.lblVpTer.Location = New System.Drawing.Point(454, 150)
        Me.lblVpTer.Name = "lblVpTer"
        Me.lblVpTer.Size = New System.Drawing.Size(56, 13)
        Me.lblVpTer.TabIndex = 7
        Me.lblVpTer.Text = "Territories:"
        '
        'btnPreview1
        '
        Me.btnPreview1.Location = New System.Drawing.Point(487, 73)
        Me.btnPreview1.Name = "btnPreview1"
        Me.btnPreview1.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview1.TabIndex = 6
        Me.btnPreview1.Text = "Preview"
        Me.btnPreview1.UseVisualStyleBackColor = True
        '
        'btnPrint1
        '
        Me.btnPrint1.Location = New System.Drawing.Point(487, 102)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint1.TabIndex = 5
        Me.btnPrint1.Text = "Print"
        Me.btnPrint1.UseVisualStyleBackColor = True
        '
        'rtbVPTerritory
        '
        Me.rtbVPTerritory.Location = New System.Drawing.Point(596, 15)
        Me.rtbVPTerritory.Name = "rtbVPTerritory"
        Me.rtbVPTerritory.Size = New System.Drawing.Size(525, 675)
        Me.rtbVPTerritory.TabIndex = 3
        Me.rtbVPTerritory.Text = ""
        '
        'btnDelVPTer
        '
        Me.btnDelVPTer.Location = New System.Drawing.Point(487, 44)
        Me.btnDelVPTer.Name = "btnDelVPTer"
        Me.btnDelVPTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelVPTer.TabIndex = 2
        Me.btnDelVPTer.Text = "Delete"
        Me.btnDelVPTer.UseVisualStyleBackColor = True
        '
        'btnNewVPTer
        '
        Me.btnNewVPTer.Location = New System.Drawing.Point(487, 15)
        Me.btnNewVPTer.Name = "btnNewVPTer"
        Me.btnNewVPTer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewVPTer.TabIndex = 1
        Me.btnNewVPTer.Text = "New"
        Me.btnNewVPTer.UseVisualStyleBackColor = True
        '
        'dgvVPTerritory
        '
        Me.dgvVPTerritory.AutoGenerateColumns = False
        Me.dgvVPTerritory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVPTerritory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TerNoDataGridViewTextBoxColumn1, Me.DateOutDataGridViewTextBoxColumn1, Me.DateInDataGridViewTextBoxColumn1, Me.PublisherDataGridViewTextBoxColumn1})
        Me.dgvVPTerritory.DataSource = Me.VPTerBindingSource
        Me.dgvVPTerritory.Location = New System.Drawing.Point(6, 15)
        Me.dgvVPTerritory.Name = "dgvVPTerritory"
        Me.dgvVPTerritory.Size = New System.Drawing.Size(442, 675)
        Me.dgvVPTerritory.TabIndex = 0
        '
        'TerNoDataGridViewTextBoxColumn1
        '
        Me.TerNoDataGridViewTextBoxColumn1.DataPropertyName = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn1.HeaderText = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn1.Name = "TerNoDataGridViewTextBoxColumn1"
        '
        'DateOutDataGridViewTextBoxColumn1
        '
        Me.DateOutDataGridViewTextBoxColumn1.DataPropertyName = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn1.HeaderText = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn1.Name = "DateOutDataGridViewTextBoxColumn1"
        '
        'DateInDataGridViewTextBoxColumn1
        '
        Me.DateInDataGridViewTextBoxColumn1.DataPropertyName = "Date In"
        Me.DateInDataGridViewTextBoxColumn1.HeaderText = "Date In"
        Me.DateInDataGridViewTextBoxColumn1.Name = "DateInDataGridViewTextBoxColumn1"
        '
        'PublisherDataGridViewTextBoxColumn1
        '
        Me.PublisherDataGridViewTextBoxColumn1.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn1.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn1.Name = "PublisherDataGridViewTextBoxColumn1"
        '
        'VPTerBindingSource
        '
        Me.VPTerBindingSource.DataMember = "VP Territories"
        Me.VPTerBindingSource.DataSource = Me.DS
        '
        'tabVPsearch
        '
        Me.tabVPsearch.Controls.Add(Me.lblVpSearchTerCount)
        Me.tabVPsearch.Controls.Add(Me.lblVpSearchTer)
        Me.tabVPsearch.Controls.Add(Me.btnPrint2)
        Me.tabVPsearch.Controls.Add(Me.btnPreview2)
        Me.tabVPsearch.Controls.Add(Me.rtbVPsearchTer)
        Me.tabVPsearch.Controls.Add(Me.btnDelVPsearchTer)
        Me.tabVPsearch.Controls.Add(Me.btnNewVPserchTer)
        Me.tabVPsearch.Controls.Add(Me.dgvVPsearchTer)
        Me.tabVPsearch.Location = New System.Drawing.Point(4, 22)
        Me.tabVPsearch.Name = "tabVPsearch"
        Me.tabVPsearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVPsearch.Size = New System.Drawing.Size(1192, 699)
        Me.tabVPsearch.TabIndex = 3
        Me.tabVPsearch.Text = "Manage VP Search Territories"
        Me.tabVPsearch.UseVisualStyleBackColor = True
        '
        'lblVpSearchTerCount
        '
        Me.lblVpSearchTerCount.AutoSize = True
        Me.lblVpSearchTerCount.Location = New System.Drawing.Point(544, 158)
        Me.lblVpSearchTerCount.Name = "lblVpSearchTerCount"
        Me.lblVpSearchTerCount.Size = New System.Drawing.Size(0, 13)
        Me.lblVpSearchTerCount.TabIndex = 9
        '
        'lblVpSearchTer
        '
        Me.lblVpSearchTer.AutoSize = True
        Me.lblVpSearchTer.Location = New System.Drawing.Point(544, 139)
        Me.lblVpSearchTer.Name = "lblVpSearchTer"
        Me.lblVpSearchTer.Size = New System.Drawing.Size(56, 13)
        Me.lblVpSearchTer.TabIndex = 8
        Me.lblVpSearchTer.Text = "Territories:"
        '
        'btnPrint2
        '
        Me.btnPrint2.Location = New System.Drawing.Point(534, 94)
        Me.btnPrint2.Name = "btnPrint2"
        Me.btnPrint2.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint2.TabIndex = 6
        Me.btnPrint2.Text = "Print"
        Me.btnPrint2.UseVisualStyleBackColor = True
        '
        'btnPreview2
        '
        Me.btnPreview2.Location = New System.Drawing.Point(534, 65)
        Me.btnPreview2.Name = "btnPreview2"
        Me.btnPreview2.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview2.TabIndex = 5
        Me.btnPreview2.Text = "Preview"
        Me.btnPreview2.UseVisualStyleBackColor = True
        '
        'rtbVPsearchTer
        '
        Me.rtbVPsearchTer.Location = New System.Drawing.Point(612, 7)
        Me.rtbVPsearchTer.Name = "rtbVPsearchTer"
        Me.rtbVPsearchTer.Size = New System.Drawing.Size(525, 675)
        Me.rtbVPsearchTer.TabIndex = 3
        Me.rtbVPsearchTer.Text = ""
        '
        'btnDelVPsearchTer
        '
        Me.btnDelVPsearchTer.Location = New System.Drawing.Point(534, 36)
        Me.btnDelVPsearchTer.Name = "btnDelVPsearchTer"
        Me.btnDelVPsearchTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelVPsearchTer.TabIndex = 2
        Me.btnDelVPsearchTer.Text = "Delete"
        Me.btnDelVPsearchTer.UseVisualStyleBackColor = True
        '
        'btnNewVPserchTer
        '
        Me.btnNewVPserchTer.Location = New System.Drawing.Point(534, 7)
        Me.btnNewVPserchTer.Name = "btnNewVPserchTer"
        Me.btnNewVPserchTer.Size = New System.Drawing.Size(75, 23)
        Me.btnNewVPserchTer.TabIndex = 1
        Me.btnNewVPserchTer.Text = "New"
        Me.btnNewVPserchTer.UseVisualStyleBackColor = True
        '
        'dgvVPsearchTer
        '
        Me.dgvVPsearchTer.AutoGenerateColumns = False
        Me.dgvVPsearchTer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVPsearchTer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AreaCodeAndPrefixDataGridViewTextBoxColumn, Me.TerritoryGroupDataGridViewTextBoxColumn, Me.DateOutDataGridViewTextBoxColumn2, Me.PublisherDataGridViewTextBoxColumn2, Me.PrintedDataGridViewTextBoxColumn})
        Me.dgvVPsearchTer.DataSource = Me.VPsearchTerBindingSourrce
        Me.dgvVPsearchTer.Location = New System.Drawing.Point(6, 6)
        Me.dgvVPsearchTer.Name = "dgvVPsearchTer"
        Me.dgvVPsearchTer.Size = New System.Drawing.Size(525, 675)
        Me.dgvVPsearchTer.TabIndex = 0
        '
        'AreaCodeAndPrefixDataGridViewTextBoxColumn
        '
        Me.AreaCodeAndPrefixDataGridViewTextBoxColumn.DataPropertyName = "Area Code and Prefix"
        Me.AreaCodeAndPrefixDataGridViewTextBoxColumn.HeaderText = "Area Code and Prefix"
        Me.AreaCodeAndPrefixDataGridViewTextBoxColumn.Name = "AreaCodeAndPrefixDataGridViewTextBoxColumn"
        '
        'TerritoryGroupDataGridViewTextBoxColumn
        '
        Me.TerritoryGroupDataGridViewTextBoxColumn.DataPropertyName = "Territory Group"
        Me.TerritoryGroupDataGridViewTextBoxColumn.HeaderText = "Territory Group"
        Me.TerritoryGroupDataGridViewTextBoxColumn.Name = "TerritoryGroupDataGridViewTextBoxColumn"
        '
        'DateOutDataGridViewTextBoxColumn2
        '
        Me.DateOutDataGridViewTextBoxColumn2.DataPropertyName = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn2.HeaderText = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn2.Name = "DateOutDataGridViewTextBoxColumn2"
        '
        'PublisherDataGridViewTextBoxColumn2
        '
        Me.PublisherDataGridViewTextBoxColumn2.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn2.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn2.Name = "PublisherDataGridViewTextBoxColumn2"
        '
        'PrintedDataGridViewTextBoxColumn
        '
        Me.PrintedDataGridViewTextBoxColumn.DataPropertyName = "Printed"
        Me.PrintedDataGridViewTextBoxColumn.HeaderText = "Printed"
        Me.PrintedDataGridViewTextBoxColumn.Name = "PrintedDataGridViewTextBoxColumn"
        '
        'VPsearchTerBindingSourrce
        '
        Me.VPsearchTerBindingSourrce.DataMember = "VP Search Territories"
        Me.VPsearchTerBindingSourrce.DataSource = Me.DS
        '
        'tabMapSearchTer
        '
        Me.tabMapSearchTer.Controls.Add(Me.lblMapTerCount)
        Me.tabMapSearchTer.Controls.Add(Me.lblMapTer)
        Me.tabMapSearchTer.Controls.Add(Me.btnPrint3)
        Me.tabMapSearchTer.Controls.Add(Me.btnPreview3)
        Me.tabMapSearchTer.Controls.Add(Me.btnDelMap)
        Me.tabMapSearchTer.Controls.Add(Me.btnNewMap)
        Me.tabMapSearchTer.Controls.Add(Me.WebBrowser)
        Me.tabMapSearchTer.Controls.Add(Me.dgvMapsSearchTer)
        Me.tabMapSearchTer.Controls.Add(Me.gbxTerMap)
        Me.tabMapSearchTer.Location = New System.Drawing.Point(4, 22)
        Me.tabMapSearchTer.Name = "tabMapSearchTer"
        Me.tabMapSearchTer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMapSearchTer.Size = New System.Drawing.Size(1192, 699)
        Me.tabMapSearchTer.TabIndex = 4
        Me.tabMapSearchTer.Text = "Manage Map Search Territories"
        Me.tabMapSearchTer.UseVisualStyleBackColor = True
        '
        'lblMapTerCount
        '
        Me.lblMapTerCount.AutoSize = True
        Me.lblMapTerCount.Location = New System.Drawing.Point(457, 160)
        Me.lblMapTerCount.Name = "lblMapTerCount"
        Me.lblMapTerCount.Size = New System.Drawing.Size(0, 13)
        Me.lblMapTerCount.TabIndex = 10
        '
        'lblMapTer
        '
        Me.lblMapTer.AutoSize = True
        Me.lblMapTer.Location = New System.Drawing.Point(457, 139)
        Me.lblMapTer.Name = "lblMapTer"
        Me.lblMapTer.Size = New System.Drawing.Size(56, 13)
        Me.lblMapTer.TabIndex = 9
        Me.lblMapTer.Text = "Territories:"
        '
        'btnPrint3
        '
        Me.btnPrint3.Location = New System.Drawing.Point(447, 102)
        Me.btnPrint3.Name = "btnPrint3"
        Me.btnPrint3.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint3.TabIndex = 6
        Me.btnPrint3.Text = "Print"
        Me.btnPrint3.UseVisualStyleBackColor = True
        '
        'btnPreview3
        '
        Me.btnPreview3.Location = New System.Drawing.Point(447, 73)
        Me.btnPreview3.Name = "btnPreview3"
        Me.btnPreview3.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview3.TabIndex = 5
        Me.btnPreview3.Text = "Preview"
        Me.btnPreview3.UseVisualStyleBackColor = True
        '
        'btnDelMap
        '
        Me.btnDelMap.Location = New System.Drawing.Point(447, 44)
        Me.btnDelMap.Name = "btnDelMap"
        Me.btnDelMap.Size = New System.Drawing.Size(75, 23)
        Me.btnDelMap.TabIndex = 3
        Me.btnDelMap.Text = "Delete"
        Me.btnDelMap.UseVisualStyleBackColor = True
        '
        'btnNewMap
        '
        Me.btnNewMap.Location = New System.Drawing.Point(448, 15)
        Me.btnNewMap.Name = "btnNewMap"
        Me.btnNewMap.Size = New System.Drawing.Size(75, 23)
        Me.btnNewMap.TabIndex = 2
        Me.btnNewMap.Text = "New"
        Me.btnNewMap.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(538, 25)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(590, 655)
        Me.WebBrowser.TabIndex = 1
        '
        'dgvMapsSearchTer
        '
        Me.dgvMapsSearchTer.AutoGenerateColumns = False
        Me.dgvMapsSearchTer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMapsSearchTer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TerNoDataGridViewTextBoxColumn3, Me.AreaDataGridViewTextBoxColumn, Me.DateOutDataGridViewTextBoxColumn4, Me.DateInDataGridViewTextBoxColumn3, Me.PublisherDataGridViewTextBoxColumn4, Me.LatDataGridViewTextBoxColumn1, Me.LongDataGridViewTextBoxColumn1})
        Me.dgvMapsSearchTer.DataSource = Me.MapsBindingSource
        Me.dgvMapsSearchTer.Location = New System.Drawing.Point(6, 10)
        Me.dgvMapsSearchTer.Name = "dgvMapsSearchTer"
        Me.dgvMapsSearchTer.Size = New System.Drawing.Size(435, 675)
        Me.dgvMapsSearchTer.TabIndex = 0
        '
        'TerNoDataGridViewTextBoxColumn3
        '
        Me.TerNoDataGridViewTextBoxColumn3.DataPropertyName = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn3.HeaderText = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn3.Name = "TerNoDataGridViewTextBoxColumn3"
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "Area"
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        '
        'DateOutDataGridViewTextBoxColumn4
        '
        Me.DateOutDataGridViewTextBoxColumn4.DataPropertyName = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn4.HeaderText = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn4.Name = "DateOutDataGridViewTextBoxColumn4"
        '
        'DateInDataGridViewTextBoxColumn3
        '
        Me.DateInDataGridViewTextBoxColumn3.DataPropertyName = "Date In"
        Me.DateInDataGridViewTextBoxColumn3.HeaderText = "Date In"
        Me.DateInDataGridViewTextBoxColumn3.Name = "DateInDataGridViewTextBoxColumn3"
        '
        'PublisherDataGridViewTextBoxColumn4
        '
        Me.PublisherDataGridViewTextBoxColumn4.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn4.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn4.Name = "PublisherDataGridViewTextBoxColumn4"
        '
        'LatDataGridViewTextBoxColumn1
        '
        Me.LatDataGridViewTextBoxColumn1.DataPropertyName = "Lat"
        Me.LatDataGridViewTextBoxColumn1.HeaderText = "Lat"
        Me.LatDataGridViewTextBoxColumn1.Name = "LatDataGridViewTextBoxColumn1"
        '
        'LongDataGridViewTextBoxColumn1
        '
        Me.LongDataGridViewTextBoxColumn1.DataPropertyName = "Long"
        Me.LongDataGridViewTextBoxColumn1.HeaderText = "Long"
        Me.LongDataGridViewTextBoxColumn1.Name = "LongDataGridViewTextBoxColumn1"
        '
        'MapsBindingSource
        '
        Me.MapsBindingSource.DataMember = "Maps"
        Me.MapsBindingSource.DataSource = Me.DS
        '
        'gbxTerMap
        '
        Me.gbxTerMap.Location = New System.Drawing.Point(531, 10)
        Me.gbxTerMap.Name = "gbxTerMap"
        Me.gbxTerMap.Size = New System.Drawing.Size(604, 675)
        Me.gbxTerMap.TabIndex = 4
        Me.gbxTerMap.TabStop = False
        Me.gbxTerMap.Text = "Territory Map"
        '
        'tabNameTerritories
        '
        Me.tabNameTerritories.Controls.Add(Me.lblNameSearchTerCount)
        Me.tabNameTerritories.Controls.Add(Me.lblNameSearchTer)
        Me.tabNameTerritories.Controls.Add(Me.btnPrint4)
        Me.tabNameTerritories.Controls.Add(Me.btnPreview4)
        Me.tabNameTerritories.Controls.Add(Me.rtbNameSearchTer)
        Me.tabNameTerritories.Controls.Add(Me.btnNameSearchDel)
        Me.tabNameTerritories.Controls.Add(Me.btnNameSearchAdd)
        Me.tabNameTerritories.Controls.Add(Me.dgvNameSearchTer)
        Me.tabNameTerritories.Location = New System.Drawing.Point(4, 22)
        Me.tabNameTerritories.Name = "tabNameTerritories"
        Me.tabNameTerritories.Size = New System.Drawing.Size(1192, 699)
        Me.tabNameTerritories.TabIndex = 5
        Me.tabNameTerritories.Text = "Manage Name Search Territories"
        Me.tabNameTerritories.UseVisualStyleBackColor = True
        '
        'lblNameSearchTerCount
        '
        Me.lblNameSearchTerCount.AutoSize = True
        Me.lblNameSearchTerCount.Location = New System.Drawing.Point(534, 150)
        Me.lblNameSearchTerCount.Name = "lblNameSearchTerCount"
        Me.lblNameSearchTerCount.Size = New System.Drawing.Size(0, 13)
        Me.lblNameSearchTerCount.TabIndex = 10
        '
        'lblNameSearchTer
        '
        Me.lblNameSearchTer.AutoSize = True
        Me.lblNameSearchTer.Location = New System.Drawing.Point(454, 150)
        Me.lblNameSearchTer.Name = "lblNameSearchTer"
        Me.lblNameSearchTer.Size = New System.Drawing.Size(56, 13)
        Me.lblNameSearchTer.TabIndex = 9
        Me.lblNameSearchTer.Text = "Territories:"
        '
        'btnPrint4
        '
        Me.btnPrint4.Location = New System.Drawing.Point(485, 100)
        Me.btnPrint4.Name = "btnPrint4"
        Me.btnPrint4.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint4.TabIndex = 6
        Me.btnPrint4.Text = "Print"
        Me.btnPrint4.UseVisualStyleBackColor = True
        '
        'btnPreview4
        '
        Me.btnPreview4.Location = New System.Drawing.Point(485, 71)
        Me.btnPreview4.Name = "btnPreview4"
        Me.btnPreview4.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview4.TabIndex = 5
        Me.btnPreview4.Text = "Preview"
        Me.btnPreview4.UseVisualStyleBackColor = True
        '
        'rtbNameSearchTer
        '
        Me.rtbNameSearchTer.Location = New System.Drawing.Point(596, 13)
        Me.rtbNameSearchTer.Name = "rtbNameSearchTer"
        Me.rtbNameSearchTer.Size = New System.Drawing.Size(525, 675)
        Me.rtbNameSearchTer.TabIndex = 3
        Me.rtbNameSearchTer.Text = ""
        '
        'btnNameSearchDel
        '
        Me.btnNameSearchDel.Location = New System.Drawing.Point(485, 42)
        Me.btnNameSearchDel.Name = "btnNameSearchDel"
        Me.btnNameSearchDel.Size = New System.Drawing.Size(75, 23)
        Me.btnNameSearchDel.TabIndex = 2
        Me.btnNameSearchDel.Text = "Delete"
        Me.btnNameSearchDel.UseVisualStyleBackColor = True
        '
        'btnNameSearchAdd
        '
        Me.btnNameSearchAdd.Location = New System.Drawing.Point(485, 13)
        Me.btnNameSearchAdd.Name = "btnNameSearchAdd"
        Me.btnNameSearchAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnNameSearchAdd.TabIndex = 1
        Me.btnNameSearchAdd.Text = "Add"
        Me.btnNameSearchAdd.UseVisualStyleBackColor = True
        '
        'dgvNameSearchTer
        '
        Me.dgvNameSearchTer.AutoGenerateColumns = False
        Me.dgvNameSearchTer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNameSearchTer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TerNoDataGridViewTextBoxColumn2, Me.DateOutDataGridViewTextBoxColumn3, Me.DateInDataGridViewTextBoxColumn2, Me.PublisherDataGridViewTextBoxColumn3})
        Me.dgvNameSearchTer.DataSource = Me.NameSearchBindingSource
        Me.dgvNameSearchTer.Location = New System.Drawing.Point(3, 13)
        Me.dgvNameSearchTer.Name = "dgvNameSearchTer"
        Me.dgvNameSearchTer.Size = New System.Drawing.Size(443, 675)
        Me.dgvNameSearchTer.TabIndex = 0
        '
        'TerNoDataGridViewTextBoxColumn2
        '
        Me.TerNoDataGridViewTextBoxColumn2.DataPropertyName = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn2.HeaderText = "TerNo"
        Me.TerNoDataGridViewTextBoxColumn2.Name = "TerNoDataGridViewTextBoxColumn2"
        '
        'DateOutDataGridViewTextBoxColumn3
        '
        Me.DateOutDataGridViewTextBoxColumn3.DataPropertyName = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn3.HeaderText = "Date Out"
        Me.DateOutDataGridViewTextBoxColumn3.Name = "DateOutDataGridViewTextBoxColumn3"
        '
        'DateInDataGridViewTextBoxColumn2
        '
        Me.DateInDataGridViewTextBoxColumn2.DataPropertyName = "Date In"
        Me.DateInDataGridViewTextBoxColumn2.HeaderText = "Date In"
        Me.DateInDataGridViewTextBoxColumn2.Name = "DateInDataGridViewTextBoxColumn2"
        '
        'PublisherDataGridViewTextBoxColumn3
        '
        Me.PublisherDataGridViewTextBoxColumn3.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn3.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn3.Name = "PublisherDataGridViewTextBoxColumn3"
        '
        'NameSearchBindingSource
        '
        Me.NameSearchBindingSource.DataMember = "Name Search Territories"
        Me.NameSearchBindingSource.DataSource = Me.DS
        '
        'tabDatabase
        '
        Me.tabDatabase.Controls.Add(Me.lblRestore)
        Me.tabDatabase.Controls.Add(Me.btnRestore)
        Me.tabDatabase.Controls.Add(Me.lblBackup)
        Me.tabDatabase.Controls.Add(Me.btnBackup)
        Me.tabDatabase.Controls.Add(Me.lblDelMapSer)
        Me.tabDatabase.Controls.Add(Me.lblDelNameSer)
        Me.tabDatabase.Controls.Add(Me.lblDelVpSer)
        Me.tabDatabase.Controls.Add(Me.lblDeleteVpTer)
        Me.tabDatabase.Controls.Add(Me.lblDeleteDeafTer)
        Me.tabDatabase.Controls.Add(Me.lblDeleteAllContacts)
        Me.tabDatabase.Controls.Add(Me.btnDelMapSer)
        Me.tabDatabase.Controls.Add(Me.btnDelNameSer)
        Me.tabDatabase.Controls.Add(Me.btnDeleteVpSerTer)
        Me.tabDatabase.Controls.Add(Me.btnDeleteVpTer)
        Me.tabDatabase.Controls.Add(Me.btnDeleteAllDeafTer)
        Me.tabDatabase.Controls.Add(Me.btnDeleteAllContacts)
        Me.tabDatabase.Controls.Add(Me.lblDeleteAllButton)
        Me.tabDatabase.Controls.Add(Me.lblExportButton)
        Me.tabDatabase.Controls.Add(Me.btnDeleteAllRecords)
        Me.tabDatabase.Controls.Add(Me.btnExport)
        Me.tabDatabase.Location = New System.Drawing.Point(4, 22)
        Me.tabDatabase.Name = "tabDatabase"
        Me.tabDatabase.Size = New System.Drawing.Size(1192, 699)
        Me.tabDatabase.TabIndex = 6
        Me.tabDatabase.Text = "Manage Database"
        Me.tabDatabase.UseVisualStyleBackColor = True
        '
        'lblRestore
        '
        Me.lblRestore.AutoSize = True
        Me.lblRestore.Location = New System.Drawing.Point(127, 129)
        Me.lblRestore.Name = "lblRestore"
        Me.lblRestore.Size = New System.Drawing.Size(171, 13)
        Me.lblRestore.TabIndex = 19
        Me.lblRestore.Text = "Restore the database from backup"
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(24, 124)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(75, 23)
        Me.btnRestore.TabIndex = 18
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(127, 88)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(109, 13)
        Me.lblBackup.TabIndex = 17
        Me.lblBackup.Text = "Backup the database"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(24, 83)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 16
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'lblDelMapSer
        '
        Me.lblDelMapSer.AutoSize = True
        Me.lblDelMapSer.Location = New System.Drawing.Point(605, 270)
        Me.lblDelMapSer.Name = "lblDelMapSer"
        Me.lblDelMapSer.Size = New System.Drawing.Size(154, 13)
        Me.lblDelMapSer.TabIndex = 15
        Me.lblDelMapSer.Text = "Delete all map search territories"
        '
        'lblDelNameSer
        '
        Me.lblDelNameSer.AutoSize = True
        Me.lblDelNameSer.Location = New System.Drawing.Point(605, 316)
        Me.lblDelNameSer.Name = "lblDelNameSer"
        Me.lblDelNameSer.Size = New System.Drawing.Size(160, 13)
        Me.lblDelNameSer.TabIndex = 14
        Me.lblDelNameSer.Text = "Delete all name search territories"
        '
        'lblDelVpSer
        '
        Me.lblDelVpSer.AutoSize = True
        Me.lblDelVpSer.Location = New System.Drawing.Point(605, 225)
        Me.lblDelVpSer.Name = "lblDelVpSer"
        Me.lblDelVpSer.Size = New System.Drawing.Size(148, 13)
        Me.lblDelVpSer.TabIndex = 13
        Me.lblDelVpSer.Text = "Delete all VP search territories"
        '
        'lblDeleteVpTer
        '
        Me.lblDeleteVpTer.AutoSize = True
        Me.lblDeleteVpTer.Location = New System.Drawing.Point(605, 181)
        Me.lblDeleteVpTer.Name = "lblDeleteVpTer"
        Me.lblDeleteVpTer.Size = New System.Drawing.Size(116, 13)
        Me.lblDeleteVpTer.TabIndex = 12
        Me.lblDeleteVpTer.Text = "Delete all VP verritories"
        '
        'lblDeleteDeafTer
        '
        Me.lblDeleteDeafTer.AutoSize = True
        Me.lblDeleteDeafTer.Location = New System.Drawing.Point(605, 134)
        Me.lblDeleteDeafTer.Name = "lblDeleteDeafTer"
        Me.lblDeleteDeafTer.Size = New System.Drawing.Size(120, 13)
        Me.lblDeleteDeafTer.TabIndex = 11
        Me.lblDeleteDeafTer.Text = "Delete all deaf territories"
        '
        'lblDeleteAllContacts
        '
        Me.lblDeleteAllContacts.AutoSize = True
        Me.lblDeleteAllContacts.Location = New System.Drawing.Point(605, 88)
        Me.lblDeleteAllContacts.Name = "lblDeleteAllContacts"
        Me.lblDeleteAllContacts.Size = New System.Drawing.Size(95, 13)
        Me.lblDeleteAllContacts.TabIndex = 10
        Me.lblDeleteAllContacts.Text = "Delete all contacts"
        '
        'btnDelMapSer
        '
        Me.btnDelMapSer.Location = New System.Drawing.Point(503, 265)
        Me.btnDelMapSer.Name = "btnDelMapSer"
        Me.btnDelMapSer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelMapSer.TabIndex = 9
        Me.btnDelMapSer.Text = "Delete"
        Me.btnDelMapSer.UseVisualStyleBackColor = True
        '
        'btnDelNameSer
        '
        Me.btnDelNameSer.Location = New System.Drawing.Point(502, 311)
        Me.btnDelNameSer.Name = "btnDelNameSer"
        Me.btnDelNameSer.Size = New System.Drawing.Size(75, 23)
        Me.btnDelNameSer.TabIndex = 8
        Me.btnDelNameSer.Text = "Delete"
        Me.btnDelNameSer.UseVisualStyleBackColor = True
        '
        'btnDeleteVpSerTer
        '
        Me.btnDeleteVpSerTer.Location = New System.Drawing.Point(503, 220)
        Me.btnDeleteVpSerTer.Name = "btnDeleteVpSerTer"
        Me.btnDeleteVpSerTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteVpSerTer.TabIndex = 7
        Me.btnDeleteVpSerTer.Text = "Delete"
        Me.btnDeleteVpSerTer.UseVisualStyleBackColor = True
        '
        'btnDeleteVpTer
        '
        Me.btnDeleteVpTer.Location = New System.Drawing.Point(503, 176)
        Me.btnDeleteVpTer.Name = "btnDeleteVpTer"
        Me.btnDeleteVpTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteVpTer.TabIndex = 6
        Me.btnDeleteVpTer.Text = "Delete"
        Me.btnDeleteVpTer.UseVisualStyleBackColor = True
        '
        'btnDeleteAllDeafTer
        '
        Me.btnDeleteAllDeafTer.Location = New System.Drawing.Point(502, 129)
        Me.btnDeleteAllDeafTer.Name = "btnDeleteAllDeafTer"
        Me.btnDeleteAllDeafTer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAllDeafTer.TabIndex = 5
        Me.btnDeleteAllDeafTer.Text = "Delete"
        Me.btnDeleteAllDeafTer.UseVisualStyleBackColor = True
        '
        'btnDeleteAllContacts
        '
        Me.btnDeleteAllContacts.Location = New System.Drawing.Point(502, 83)
        Me.btnDeleteAllContacts.Name = "btnDeleteAllContacts"
        Me.btnDeleteAllContacts.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAllContacts.TabIndex = 4
        Me.btnDeleteAllContacts.Text = "Delete"
        Me.btnDeleteAllContacts.UseVisualStyleBackColor = True
        '
        'lblDeleteAllButton
        '
        Me.lblDeleteAllButton.AutoSize = True
        Me.lblDeleteAllButton.Location = New System.Drawing.Point(605, 44)
        Me.lblDeleteAllButton.Name = "lblDeleteAllButton"
        Me.lblDeleteAllButton.Size = New System.Drawing.Size(165, 13)
        Me.lblDeleteAllButton.TabIndex = 3
        Me.lblDeleteAllButton.Text = "Delete all records in the database"
        '
        'lblExportButton
        '
        Me.lblExportButton.AutoSize = True
        Me.lblExportButton.Location = New System.Drawing.Point(127, 44)
        Me.lblExportButton.Name = "lblExportButton"
        Me.lblExportButton.Size = New System.Drawing.Size(163, 13)
        Me.lblExportButton.TabIndex = 2
        Me.lblExportButton.Text = "Export contacts to a spreadsheet"
        '
        'btnDeleteAllRecords
        '
        Me.btnDeleteAllRecords.Location = New System.Drawing.Point(502, 39)
        Me.btnDeleteAllRecords.Name = "btnDeleteAllRecords"
        Me.btnDeleteAllRecords.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteAllRecords.TabIndex = 1
        Me.btnDeleteAllRecords.Text = "Delete"
        Me.btnDeleteAllRecords.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(24, 39)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Agent
        '
        Me.Agent.DataPropertyName = "Agent"
        Me.Agent.HeaderText = "Agent"
        Me.Agent.Name = "Agent"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn2.HeaderText = "City"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Zip
        '
        Me.Zip.DataPropertyName = "Zip"
        Me.Zip.HeaderText = "Zip"
        Me.Zip.Name = "Zip"
        '
        'VP1
        '
        Me.VP1.DataPropertyName = "VP1"
        Me.VP1.HeaderText = "VP1"
        Me.VP1.Name = "VP1"
        '
        'VP2
        '
        Me.VP2.DataPropertyName = "VP2"
        Me.VP2.HeaderText = "VP2"
        Me.VP2.Name = "VP2"
        '
        'VP3
        '
        Me.VP3.DataPropertyName = "VP3"
        Me.VP3.HeaderText = "VP3"
        Me.VP3.Name = "VP3"
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Agent"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Agent"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'UIDDataGridViewTextBoxColumn
        '
        Me.UIDDataGridViewTextBoxColumn.DataPropertyName = "UID"
        Me.UIDDataGridViewTextBoxColumn.HeaderText = "UID"
        Me.UIDDataGridViewTextBoxColumn.Name = "UIDDataGridViewTextBoxColumn"
        Me.UIDDataGridViewTextBoxColumn.Visible = False
        '
        'AgentDataGridViewTextBoxColumn
        '
        Me.AgentDataGridViewTextBoxColumn.DataPropertyName = "Agent"
        Me.AgentDataGridViewTextBoxColumn.HeaderText = "Agent"
        Me.AgentDataGridViewTextBoxColumn.Name = "AgentDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        '
        'VP1DataGridViewTextBoxColumn
        '
        Me.VP1DataGridViewTextBoxColumn.DataPropertyName = "VP1"
        Me.VP1DataGridViewTextBoxColumn.HeaderText = "VP1"
        Me.VP1DataGridViewTextBoxColumn.Name = "VP1DataGridViewTextBoxColumn"
        '
        'VP2DataGridViewTextBoxColumn
        '
        Me.VP2DataGridViewTextBoxColumn.DataPropertyName = "VP2"
        Me.VP2DataGridViewTextBoxColumn.HeaderText = "VP2"
        Me.VP2DataGridViewTextBoxColumn.Name = "VP2DataGridViewTextBoxColumn"
        '
        'VP3DataGridViewTextBoxColumn
        '
        Me.VP3DataGridViewTextBoxColumn.DataPropertyName = "VP3"
        Me.VP3DataGridViewTextBoxColumn.HeaderText = "VP3"
        Me.VP3DataGridViewTextBoxColumn.Name = "VP3DataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'NameFromDataGridViewTextBoxColumn
        '
        Me.NameFromDataGridViewTextBoxColumn.DataPropertyName = "Name From"
        Me.NameFromDataGridViewTextBoxColumn.HeaderText = "Name From"
        Me.NameFromDataGridViewTextBoxColumn.Name = "NameFromDataGridViewTextBoxColumn"
        '
        'DoNotCallDataGridViewTextBoxColumn
        '
        Me.DoNotCallDataGridViewTextBoxColumn.DataPropertyName = "Do Not Call"
        Me.DoNotCallDataGridViewTextBoxColumn.HeaderText = "Do Not Call"
        Me.DoNotCallDataGridViewTextBoxColumn.Name = "DoNotCallDataGridViewTextBoxColumn"
        '
        'DeafTerNoDataGridViewTextBoxColumn
        '
        Me.DeafTerNoDataGridViewTextBoxColumn.DataPropertyName = "Deaf Ter No"
        Me.DeafTerNoDataGridViewTextBoxColumn.HeaderText = "Deaf Ter No"
        Me.DeafTerNoDataGridViewTextBoxColumn.Name = "DeafTerNoDataGridViewTextBoxColumn"
        '
        'VPTerNoDataGridViewTextBoxColumn
        '
        Me.VPTerNoDataGridViewTextBoxColumn.DataPropertyName = "VP Ter No"
        Me.VPTerNoDataGridViewTextBoxColumn.HeaderText = "VP Ter No"
        Me.VPTerNoDataGridViewTextBoxColumn.Name = "VPTerNoDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Agent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Agent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'UIDDataGridViewTextBoxColumn2
        '
        Me.UIDDataGridViewTextBoxColumn2.DataPropertyName = "UID"
        Me.UIDDataGridViewTextBoxColumn2.HeaderText = "UID"
        Me.UIDDataGridViewTextBoxColumn2.Name = "UIDDataGridViewTextBoxColumn2"
        Me.UIDDataGridViewTextBoxColumn2.Visible = False
        '
        'AgentDataGridViewTextBoxColumn1
        '
        Me.AgentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AgentDataGridViewTextBoxColumn1.DataPropertyName = "Agent"
        Me.AgentDataGridViewTextBoxColumn1.HeaderText = "Agent"
        Me.AgentDataGridViewTextBoxColumn1.Name = "AgentDataGridViewTextBoxColumn1"
        '
        'FirstNameDataGridViewTextBoxColumn2
        '
        Me.FirstNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FirstNameDataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn2.Name = "FirstNameDataGridViewTextBoxColumn2"
        '
        'LastNameDataGridViewTextBoxColumn2
        '
        Me.LastNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LastNameDataGridViewTextBoxColumn2.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn2.Name = "LastNameDataGridViewTextBoxColumn2"
        '
        'AddressDataGridViewTextBoxColumn1
        '
        Me.AddressDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AddressDataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn1.Name = "AddressDataGridViewTextBoxColumn1"
        '
        'CityDataGridViewTextBoxColumn1
        '
        Me.CityDataGridViewTextBoxColumn1.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn1.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn1.Name = "CityDataGridViewTextBoxColumn1"
        '
        'StateDataGridViewTextBoxColumn1
        '
        Me.StateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StateDataGridViewTextBoxColumn1.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn1.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn1.Name = "StateDataGridViewTextBoxColumn1"
        '
        'ZipDataGridViewTextBoxColumn1
        '
        Me.ZipDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ZipDataGridViewTextBoxColumn1.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn1.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn1.Name = "ZipDataGridViewTextBoxColumn1"
        '
        'VP1DataGridViewTextBoxColumn1
        '
        Me.VP1DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP1DataGridViewTextBoxColumn1.DataPropertyName = "VP1"
        Me.VP1DataGridViewTextBoxColumn1.HeaderText = "VP1"
        Me.VP1DataGridViewTextBoxColumn1.Name = "VP1DataGridViewTextBoxColumn1"
        '
        'VP2DataGridViewTextBoxColumn1
        '
        Me.VP2DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP2DataGridViewTextBoxColumn1.DataPropertyName = "VP2"
        Me.VP2DataGridViewTextBoxColumn1.HeaderText = "VP2"
        Me.VP2DataGridViewTextBoxColumn1.Name = "VP2DataGridViewTextBoxColumn1"
        '
        'VP3DataGridViewTextBoxColumn1
        '
        Me.VP3DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VP3DataGridViewTextBoxColumn1.DataPropertyName = "VP3"
        Me.VP3DataGridViewTextBoxColumn1.HeaderText = "VP3"
        Me.VP3DataGridViewTextBoxColumn1.Name = "VP3DataGridViewTextBoxColumn1"
        '
        'NotesDataGridViewTextBoxColumn1
        '
        Me.NotesDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NotesDataGridViewTextBoxColumn1.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn1.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn1.Name = "NotesDataGridViewTextBoxColumn1"
        '
        'NameFromDataGridViewTextBoxColumn1
        '
        Me.NameFromDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NameFromDataGridViewTextBoxColumn1.DataPropertyName = "Name From"
        Me.NameFromDataGridViewTextBoxColumn1.HeaderText = "Name From"
        Me.NameFromDataGridViewTextBoxColumn1.Name = "NameFromDataGridViewTextBoxColumn1"
        '
        'Deaf_TerritoriesTableAdapter
        '
        Me.Deaf_TerritoriesTableAdapter.ClearBeforeFill = True
        '
        'VP_TerritoriesTableAdapter
        '
        Me.VP_TerritoriesTableAdapter.ClearBeforeFill = True
        '
        'VP_Search_TerritoriesTableAdapter
        '
        Me.VP_Search_TerritoriesTableAdapter.ClearBeforeFill = True
        '
        'Name_Search_TerritoriesTableAdapter
        '
        Me.Name_Search_TerritoriesTableAdapter.ClearBeforeFill = True
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'MapsTableAdapter
        '
        Me.MapsTableAdapter.ClearBeforeFill = True
        '
        'ASLTerriroryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ASLTerriroryManager"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "ASL Territory Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl.ResumeLayout(False)
        Me.tabManageContacts.ResumeLayout(False)
        Me.tabManageContacts.PerformLayout()
        Me.gbQuickSearch.ResumeLayout(False)
        Me.gbQuickSearch.PerformLayout()
        Me.gbContactManage.ResumeLayout(False)
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDeafTeritorries.ResumeLayout(False)
        Me.tabDeafTeritorries.PerformLayout()
        CType(Me.dgvDeafTerritories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeafTerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVPterritories.ResumeLayout(False)
        Me.tabVPterritories.PerformLayout()
        CType(Me.dgvVPTerritory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPTerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVPsearch.ResumeLayout(False)
        Me.tabVPsearch.PerformLayout()
        CType(Me.dgvVPsearchTer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VPsearchTerBindingSourrce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMapSearchTer.ResumeLayout(False)
        Me.tabMapSearchTer.PerformLayout()
        CType(Me.dgvMapsSearchTer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNameTerritories.ResumeLayout(False)
        Me.tabNameTerritories.PerformLayout()
        CType(Me.dgvNameSearchTer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatabase.ResumeLayout(False)
        Me.tabDatabase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabManageContacts As System.Windows.Forms.TabPage
    Friend WithEvents tabDeafTeritorries As System.Windows.Forms.TabPage
    Friend WithEvents tabVPterritories As System.Windows.Forms.TabPage
    Friend WithEvents tabVPsearch As System.Windows.Forms.TabPage
    Friend WithEvents tabMapSearchTer As System.Windows.Forms.TabPage
    Friend WithEvents tabNameTerritories As System.Windows.Forms.TabPage
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents DS As ASL_Teritory_Manager.DS
    Friend WithEvents ContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnNewContact As System.Windows.Forms.Button
    Friend WithEvents btnRemoveContact As System.Windows.Forms.Button
    Friend WithEvents Agent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Zip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvContacts As System.Windows.Forms.DataGridView
    Friend WithEvents tbAgent As System.Windows.Forms.TextBox
    Friend WithEvents lblAgent As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblDoNotCall As System.Windows.Forms.Label
    Friend WithEvents tbDoNotCall As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents tbState As System.Windows.Forms.TextBox
    Friend WithEvents tbZip As System.Windows.Forms.TextBox
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents tbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblVP2 As System.Windows.Forms.Label
    Friend WithEvents lblVP3 As System.Windows.Forms.Label
    Friend WithEvents lblVP1 As System.Windows.Forms.Label
    Friend WithEvents tbVP2 As System.Windows.Forms.TextBox
    Friend WithEvents tbVP3 As System.Windows.Forms.TextBox
    Friend WithEvents tbVP1 As System.Windows.Forms.TextBox
    Friend WithEvents tbNameFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmedDeaf As System.Windows.Forms.Label
    Friend WithEvents lblFound As System.Windows.Forms.Label
    Friend WithEvents lblSearched As System.Windows.Forms.Label
    Friend WithEvents tbConfirmedDeaf As System.Windows.Forms.TextBox
    Friend WithEvents tbFound As System.Windows.Forms.TextBox
    Friend WithEvents tbSearched As System.Windows.Forms.TextBox
    Friend WithEvents lblNameFrom As System.Windows.Forms.Label
    Friend WithEvents gbContactManage As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblDeafTerNo As System.Windows.Forms.Label
    Friend WithEvents tbDeafTerNo As System.Windows.Forms.TextBox
    Friend WithEvents btnGetCoord As System.Windows.Forms.Button
    Friend WithEvents lblLong As System.Windows.Forms.Label
    Friend WithEvents lblLat As System.Windows.Forms.Label
    Friend WithEvents tbLong As System.Windows.Forms.TextBox
    Friend WithEvents tbLat As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVpTerNo As System.Windows.Forms.Label
    Friend WithEvents tbVpTerNo As System.Windows.Forms.TextBox
    Friend WithEvents gbQuickSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents tbFind As System.Windows.Forms.TextBox
    Friend WithEvents cbVPwithoutName As System.Windows.Forms.CheckBox
    Friend WithEvents cbNamesNoAgent As System.Windows.Forms.CheckBox
    Friend WithEvents cbDNC As System.Windows.Forms.CheckBox
    Friend WithEvents cbRecordsWithVP As System.Windows.Forms.CheckBox
    Friend WithEvents cbNamesNoAddresses As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddressOnlyNoDNC As System.Windows.Forms.CheckBox
    Friend WithEvents cbAddressesOnlywDNC As System.Windows.Forms.CheckBox
    Friend WithEvents dgvDeafTerritories As System.Windows.Forms.DataGridView
    Friend WithEvents DeafTerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Deaf_TerritoriesTableAdapter As ASL_Teritory_Manager.DSTableAdapters.Deaf_TerritoriesTableAdapter
    Friend WithEvents TerNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtbDeafTerritory As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDelDeafTer As System.Windows.Forms.Button
    Friend WithEvents btnNewDeafTer As System.Windows.Forms.Button
    Friend WithEvents dgvVPTerritory As System.Windows.Forms.DataGridView
    Friend WithEvents VPTerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VP_TerritoriesTableAdapter As ASL_Teritory_Manager.DSTableAdapters.VP_TerritoriesTableAdapter
    Friend WithEvents TerNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOutDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateInDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtbVPTerritory As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDelVPTer As System.Windows.Forms.Button
    Friend WithEvents btnNewVPTer As System.Windows.Forms.Button
    Friend WithEvents VP_Search_TerritoriesTableAdapter As ASL_Teritory_Manager.DSTableAdapters.VP_Search_TerritoriesTableAdapter
    Friend WithEvents dgvVPsearchTer As System.Windows.Forms.DataGridView
    Friend WithEvents VPsearchTerBindingSourrce As System.Windows.Forms.BindingSource
    Friend WithEvents btnDelVPsearchTer As System.Windows.Forms.Button
    Friend WithEvents btnNewVPserchTer As System.Windows.Forms.Button
    Friend WithEvents rtbVPsearchTer As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNameTerNo As System.Windows.Forms.Label
    Friend WithEvents tbNameTerNo As System.Windows.Forms.TextBox
    Friend WithEvents UIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoNotCallDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeafTerNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VPTerNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Name_Search_TerritoriesTableAdapter As ASL_Teritory_Manager.DSTableAdapters.Name_Search_TerritoriesTableAdapter
    Friend WithEvents rtbNameSearchTer As System.Windows.Forms.RichTextBox
    Friend WithEvents btnNameSearchDel As System.Windows.Forms.Button
    Friend WithEvents btnNameSearchAdd As System.Windows.Forms.Button
    Friend WithEvents dgvNameSearchTer As System.Windows.Forms.DataGridView
    Friend WithEvents TerNoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOutDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateInDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactsTableAdapter As ASL_Teritory_Manager.DSTableAdapters.ContactsTableAdapter
    Friend WithEvents MapsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvMapsSearchTer As System.Windows.Forms.DataGridView
    Friend WithEvents TerNoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOutDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateInDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents btnDelMap As System.Windows.Forms.Button
    Friend WithEvents btnNewMap As System.Windows.Forms.Button
    Friend WithEvents MapsTableAdapter As ASL_Teritory_Manager.DSTableAdapters.MapsTableAdapter
    Friend WithEvents gbxTerMap As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents lblRecordsCount As System.Windows.Forms.Label
    Friend WithEvents AreaCodeAndPrefixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TerritoryGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOutDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPreview1 As System.Windows.Forms.Button
    Friend WithEvents btnPrint2 As System.Windows.Forms.Button
    Friend WithEvents btnPreview2 As System.Windows.Forms.Button
    Friend WithEvents btnPrint3 As System.Windows.Forms.Button
    Friend WithEvents btnPreview3 As System.Windows.Forms.Button
    Friend WithEvents btnPrint4 As System.Windows.Forms.Button
    Friend WithEvents btnPreview4 As System.Windows.Forms.Button
    Friend WithEvents lblDeafTerCount As System.Windows.Forms.Label
    Friend WithEvents lblDeafTer As System.Windows.Forms.Label
    Friend WithEvents lblVpTerCount As System.Windows.Forms.Label
    Friend WithEvents lblVpTer As System.Windows.Forms.Label
    Friend WithEvents lblVpSearchTerCount As System.Windows.Forms.Label
    Friend WithEvents lblVpSearchTer As System.Windows.Forms.Label
    Friend WithEvents lblMapTerCount As System.Windows.Forms.Label
    Friend WithEvents lblMapTer As System.Windows.Forms.Label
    Friend WithEvents lblNameSearchTerCount As System.Windows.Forms.Label
    Friend WithEvents lblNameSearchTer As System.Windows.Forms.Label
    Friend WithEvents UIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgentDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameFromDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgentDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VP3DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameFromDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoNotCallDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeafTerNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VPTerNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameTerNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSearchedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFoundDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabDatabase As System.Windows.Forms.TabPage
    Friend WithEvents lblDeleteAllButton As System.Windows.Forms.Label
    Friend WithEvents lblExportButton As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAllRecords As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents lblRestore As System.Windows.Forms.Label
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents lblBackup As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents lblDelMapSer As System.Windows.Forms.Label
    Friend WithEvents lblDelNameSer As System.Windows.Forms.Label
    Friend WithEvents lblDelVpSer As System.Windows.Forms.Label
    Friend WithEvents lblDeleteVpTer As System.Windows.Forms.Label
    Friend WithEvents lblDeleteDeafTer As System.Windows.Forms.Label
    Friend WithEvents lblDeleteAllContacts As System.Windows.Forms.Label
    Friend WithEvents btnDelMapSer As System.Windows.Forms.Button
    Friend WithEvents btnDelNameSer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteVpSerTer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteVpTer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAllDeafTer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAllContacts As System.Windows.Forms.Button

End Class
