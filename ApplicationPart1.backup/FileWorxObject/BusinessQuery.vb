Imports System.Data.SqlClient
Public Class BusinessQuery
    Public ListNewsAndPhotos As New List(Of BusinessObject)
    Enum FilterIndex
        ID = 0
        Description = 1
        Name = 2
        CreationDate = 3
        ClassID = 4
        LoginName = 5
        LastModifer = 6


    End Enum
    Public Overridable ReadOnly Property ColumnNames As String
        Get
            Return "" + Me.tablebusiness + ".ID
                    , " + Me.tablebusiness + ".C_Name
                    , " + Me.tablebusiness + ".C_CreationDate
                    , " + Me.tablebusiness + ".C_Description"
        End Get
    End Property

    Public Constr As String = "Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True"
    Public Overridable ReadOnly Property WhereColumns As String
        Get
            Dim BusinessCondition = Me.CheckData()
            If Not String.IsNullOrEmpty(BusinessCondition) Then
                Return BusinessCondition
            End If
            Return ""
        End Get

    End Property
    Public ListIndex As New List(Of Integer)({-1, -1, -1, -1, -1, -1, -1})
    Public ListSeconedValue As New List(Of String)({"", "", "", "", "", "", ""})
    Public  Property QID As String
    Public Property QClassID As String
    Public  Property QName As String
    Public  Property QCreationDate As String
    Public Property QDescription As String

    Public Property ValueCondition As String
    Public Property StringCondition As String
    Public Property SeconedValueCondition As String
    Private tablebusiness As String = "T_BUSINESSOBJECT"
    Public Overridable ReadOnly Property TableName As String
        Get
            Return tablebusiness
        End Get

    End Property

    Public ListUser As New List(Of User)

    Public ItemIndexBusiness As Integer
    Public Conditionbusiness As String

    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""
        Me.Conditionbusiness = ""

    End Sub
    Public Overridable Sub Run()
        Dim myReader As SqlDataReader


        Dim con As SqlConnection = New SqlConnection(Constr)
        Dim cmd As SqlCommand = New SqlCommand("SELECT " + Me.tablebusiness + ".[ID]
," + Me.tablebusiness + ".[C_Name]
," + Me.tablebusiness + ".[C_CreationDate]
," + Me.tablebusiness + ".[C_Description]

            FROM " + Me.tablebusiness + " 
WHERE " + Me.tablebusiness + ".[C_ClassID] in (1,2) ", con)
        con.Open()
        myReader = cmd.ExecuteReader()
        Do While myReader.Read()
            Dim businessobject As BusinessObject = New BusinessObject()
            businessobject.IDBusiness = myReader.GetInt32(0)
            businessobject.NameFileUser = myReader.GetString(1)
            businessobject.CreationDateFileUser = Format(myReader.GetDateTime(2), "MM/dd/yyyy hh:mm:ss tt")
            businessobject.DescriptionNewsPhoto = myReader.GetString(3)
            Me.ListNewsAndPhotos.Add(businessobject)
        Loop


        myReader.Close()
        con.Close()
    End Sub

    Private Function CheckData() As String
        Dim bqWhereColumns As String = ""

        If Not Me.Idfilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.Idfilter()
            Else
                bqWhereColumns = Me.Idfilter()
            End If
        End If
        If Not Me.Descriptionfilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.Descriptionfilter()
            Else
                bqWhereColumns = Me.Descriptionfilter()
            End If
        End If
        If Not Me.Namefilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.Namefilter()
            Else
                bqWhereColumns = Me.Namefilter()
            End If
        End If
        If Not Me.CreationDatefilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.CreationDatefilter()
            Else
                bqWhereColumns = Me.CreationDatefilter()
            End If
        End If
        If Not Me.ClassIdfilter Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.ClassIdfilter()
            Else
                bqWhereColumns = Me.ClassIdfilter()
            End If
        End If



        Return bqWhereColumns

    End Function
    Private Function Idfilter() As String
        If Not String.IsNullOrEmpty(Me.QID) Then
            Dim condition As New QueryCondition()

            condition.SelectItem = Me.ListIndex(FilterIndex.ID)
            condition.ColumnName = "ID"
            condition.Value = Me.QID
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.ID)
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function

    Private Function Namefilter() As String
        If Not String.IsNullOrEmpty(Me.QName) Then
            Dim condition As New QueryCondition()

            condition.SelectItem = Me.ListIndex(FilterIndex.Name)
            condition.ColumnName = "C_Name"
            condition.Value = Me.QName
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.Name)
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function Descriptionfilter() As String
        If Not String.IsNullOrEmpty(Me.QDescription) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ListIndex(FilterIndex.Description)
            condition.ColumnName = "C_Description"
            condition.Value = Me.QDescription
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.Description)
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function CreationDatefilter() As String
        If Not String.IsNullOrEmpty(Me.QCreationDate) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ListIndex(FilterIndex.CreationDate)
            condition.ColumnName = "C_CreationDate"
            condition.DateValue = Convert.ToDateTime(Me.QCreationDate)
            condition.SeconedDate = Convert.ToDateTime(Me.ListSeconedValue(FilterIndex.CreationDate))
            Return condition.Conditiondate()
        End If
        Return Nothing
    End Function
    Private Function ClassIdfilter() As String
        If Not String.IsNullOrEmpty(Me.QClassID) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ListIndex(FilterIndex.ClassID)
            condition.ColumnName = "C_ClassID"
            condition.Value = Me.QClassID
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.ClassID)
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
End Class