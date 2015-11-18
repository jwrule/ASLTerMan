Public Class Contact

#Region "Declarations"

    Dim _uid As String
    Dim _agent As String
    Dim _firstName As String
    Dim _lastName As String
    Dim _address As String
    Dim _city As String
    Dim _state As String
    Dim _zip As String
    Dim _vp1 As String
    Dim _vp2 As String
    Dim _vp3 As String
    Dim _notes As String
    Dim _nameFrom As String
    Dim _doNotCall As String
    Dim _deafTerNo As String
    Dim _vpTerNo As String
    Dim _nameTerNo As String
    Dim _dateSearched As String
    Dim _dateFound As String
    Dim _lat As String
    Dim _long As String

#End Region

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

#End Region

#Region "Properties"
    Public Property UID As String
        Get
            Return _uid
        End Get
        Set(value As String)
            _uid = value
        End Set
    End Property
    Public Property Agent As String
        Get
            Return _agent
        End Get
        Set(value As String)
            _agent = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set

    End Property
    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property
    Public Property State As String
        Get
            Return _state
        End Get
        Set(value As String)
            _state = value
        End Set
    End Property
    Public Property Zip As String
        Get
            Return _zip
        End Get
        Set(value As String)
            _zip = value
        End Set
    End Property
    Public Property VP1 As String
        Get
            Return _vp1
        End Get
        Set(value As String)
            _vp1 = value
        End Set
    End Property
    Public Property VP2 As String
        Get
            Return _vp2
        End Get
        Set(value As String)
            _vp2 = value
        End Set
    End Property
    Public Property VP3 As String
        Get
            Return _vp3
        End Get
        Set(value As String)
            _vp3 = value
        End Set
    End Property
    Public Property Notes As String
        Get
            Return _notes
        End Get
        Set(value As String)
            _notes = value
        End Set
    End Property
    Public Property NameFrom As String
        Get
            Return _nameFrom
        End Get
        Set(value As String)
            _nameFrom = value
        End Set
    End Property
    Public Property DoNotCall As String
        Get
            Return _doNotCall
        End Get
        Set(value As String)
            _doNotCall = value
        End Set
    End Property
    Public Property DeafTerNo As String
        Get
            Return _deafTerNo
        End Get
        Set(value As String)
            _deafTerNo = value
        End Set
    End Property
    Public Property VpTerNo As String
        Get
            Return _vpTerNo
        End Get
        Set(value As String)
            _vpTerNo = value
        End Set
    End Property
    Public Property NameTerNo As String
        Get
            Return _nameTerNo
        End Get
        Set(value As String)
            _nameTerNo = value
        End Set
    End Property
    Public Property DateSearched As String
        Get
            Return _dateSearched
        End Get
        Set(value As String)
            _dateSearched = value
        End Set
    End Property
    Public Property DateFound As String
        Get
            Return _dateFound
        End Get
        Set(value As String)
            _dateFound = value
        End Set
    End Property
    Public Property Latitude As String
        Get
            Return _lat
        End Get
        Set(value As String)
            _lat = value
        End Set
    End Property
    Public Property Longitude As String
        Get
            Return _long
        End Get
        Set(value As String)
            _long = value
        End Set
    End Property







#End Region

#Region "Events"

#End Region


End Class
