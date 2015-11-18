Public Class Territory

#Region "Declarations"
    Dim _terNo As String
    Dim _dateOut As String
    Dim _dateIn As String
    Dim _pub As String
    Dim _area As String
    Dim _lat As String
    Dim _long As String
#End Region

#Region "Methods"
    Public Sub New(terType As String)


        Dim terRow As New Generic.List(Of String)

        For Each field In ASLTerriroryManager.dgvMapsSearchTer.CurrentRow.Cells
            If Not IsDBNull(field.value) Then
                terRow.Add(field.Value.trim)
            Else : terRow.Add("")
            End If
        Next
       
        _terNo = terRow.Item(0)
        _area = terRow.Item(1)
        _dateOut = terRow.Item(2)
        _dateIn = terRow.Item(3)
        _pub = terRow.Item(4)
        _lat = terRow.Item(5)
        _long = terRow.Item(6)

    End Sub
#End Region

#Region "Properties"
    Public Property TerNo As String
        Get
            Return _terNo
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property DateOut As String
        Get
            Return _dateOut
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property DateIn As String
        Get
            Return _dateIn
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Pub As String
        Get
            Return _pub
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Area As String
        Get
            Return _area
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Latitude As String
        Get
            Return _lat
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Longitude As String
        Get
            Return _long
        End Get
        Set(value As String)

        End Set
    End Property
#End Region

End Class
