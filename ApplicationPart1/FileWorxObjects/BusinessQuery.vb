Imports System.Data.SqlClient
Imports System.Data
Imports Newtonsoft.Json

Public Class BusinessQuery

    Public ListNewsAndPhotos As New List(Of BusinessObject)

    Public Property IndexConditionID As Integer
    Public Property IndexConditionName As Integer
    Public Property IndexConditionDescription As Integer
    Public Property IndexConditionCreationDate As Integer
    Public Property IndexConditionClassID As Integer
    <JsonIgnore>
    Public Overridable ReadOnly Property ColumnNames As String
        Get
            Return "" + Me.tablebusiness + ".ID
                    , " + Me.tablebusiness + ".C_Name
                    , " + Me.tablebusiness + ".C_CreationDate
                    , " + Me.tablebusiness + ".C_Description"
        End Get
    End Property
    Public Property SeconedValueID As String
    Public Property SeconedValueName As String
    Public Property SeconedValueDescription As String
    Public Property SeconedValueCreationDate As String
    Public Property SeconedValueClassID As String

    <JsonIgnore>
    Public Overridable ReadOnly Property WhereColumns As String
        Get
            Dim BusinessCondition = Me.CheckData()
            If Not String.IsNullOrEmpty(BusinessCondition) Then
                Return BusinessCondition
            End If
            Return ""
        End Get

    End Property

    Public Property QID As String
    Public Property QClassID As String
    Public Property QName As String
    Public Property QCreationDate As String
    Public Property QDescription As String

    Public Property ValueCondition As String
    Public Property StringCondition As String
    Public Property SeconedValueCondition As String

    Private tablebusiness As String = "T_BUSINESSOBJECT"
    <JsonIgnore>
    Public Overridable ReadOnly Property TableName As String
        Get
            Return tablebusiness
        End Get

    End Property

    Public ListUser As New List(Of User)

    Public ItemIndexBusiness As Integer
    Public Conditionbusiness As String


    Public Constr As String = "Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True"
    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""
        Me.Conditionbusiness = ""

    End Sub

    Public Overridable Function Run() As List(Of BusinessObject)
        Dim myReader As SqlDataReader


        Dim con As SqlConnection = New SqlConnection(Me.Constr)
        Dim cmd As SqlCommand = New SqlCommand("SELECT " + Me.TableName + ".[ID]
," + Me.TableName + ".[C_Name]
," + Me.TableName + ".[C_CreationDate]
," + Me.TableName + ".[C_Description]

            FROM " + Me.TableName + " 
WHERE " + Me.TableName + ".[C_ClassID] in (1,2) ", con)
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

        Return Me.ListNewsAndPhotos
        myReader.Close()
        con.Close()
    End Function
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

            condition.SelectItem = Me.IndexConditionID
            condition.ColumnName = "ID"
            condition.Value = Me.QID
            condition.SeconedValue = Me.SeconedValueID
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function

    Private Function Namefilter() As String
        If Not String.IsNullOrEmpty(Me.QName) Then
            Dim condition As New QueryCondition()

            condition.SelectItem = Me.IndexConditionName
            condition.ColumnName = "C_Name"
            condition.Value = Me.QName
            condition.SeconedValue = Me.SeconedValueName
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function Descriptionfilter() As String
        If Not String.IsNullOrEmpty(Me.QDescription) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.IndexConditionDescription
            condition.ColumnName = "C_Description"
            condition.Value = Me.QDescription
            condition.SeconedValue = Me.SeconedValueDescription
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function CreationDatefilter() As String
        If Not String.IsNullOrEmpty(Me.QCreationDate) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.IndexConditionCreationDate
            condition.ColumnName = "C_CreationDate"
            condition.DateValue = Me.QCreationDate
            DateTime.TryParse(Me.SeconedValueCreationDate, condition.SeconedDate)
            Return condition.Conditiondate()
        End If
        Return Nothing
    End Function
    Private Function ClassIdfilter() As String
        If Not String.IsNullOrEmpty(Me.QClassID) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.IndexConditionClassID
            condition.ColumnName = "C_ClassID"
            condition.Value = Me.QClassID
            condition.SeconedValue = Me.SeconedValueClassID
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
End Class