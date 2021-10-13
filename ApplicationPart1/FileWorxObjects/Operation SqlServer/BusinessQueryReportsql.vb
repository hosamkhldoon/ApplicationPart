Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class BusinessQueryReportsql
    Implements IBusinessQueryRepositroy



    Public Property IndexConditionID As Integer Implements IBusinessQueryRepositroy.IndexConditionID
    Public Property IndexConditionName As Integer Implements IBusinessQueryRepositroy.IndexConditionName
    Public Property IndexConditionDescription As Integer Implements IBusinessQueryRepositroy.IndexConditionDescription
    Public Property IndexConditionCreationDate As Integer Implements IBusinessQueryRepositroy.IndexConditionCreationDate
    Public Property IndexConditionClassID As Integer Implements IBusinessQueryRepositroy.IndexConditionClassID


    Public Property SeconedValueID As String Implements IBusinessQueryRepositroy.SeconedValueID
    Public Property SeconedValueName As String Implements IBusinessQueryRepositroy.SeconedValueName
    Public Property SeconedValueDescription As String Implements IBusinessQueryRepositroy.SeconedValueDescription
    Public Property SeconedValueCreationDate As String Implements IBusinessQueryRepositroy.SeconedValueCreationDate
    Public Property SeconedValueClassID As String Implements IBusinessQueryRepositroy.SeconedValueClassID



    Public Property QID As String Implements IBusinessQueryRepositroy.QID
    Public Property QClassID As String Implements IBusinessQueryRepositroy.QClassID
    Public Property QName As String Implements IBusinessQueryRepositroy.QName
    Public Property QCreationDate As String Implements IBusinessQueryRepositroy.QCreationDate
    Public Property QDescription As String Implements IBusinessQueryRepositroy.QDescription
    Public Property ValueCondition As String
    Public Property StringCondition As String
    Public Property SeconedValueCondition As String
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
    <JsonIgnore>
    Public Overridable ReadOnly Property ColumnNames As String
        Get
            Return "" + Me.tablebusiness + ".ID
                    , " + Me.tablebusiness + ".C_Name
                    , " + Me.tablebusiness + ".C_CreationDate
                    , " + Me.tablebusiness + ".C_Description"
        End Get
    End Property
    <JsonIgnore>
    Public Overridable ReadOnly Property TableName As String
        Get
            Return tablebusiness
        End Get

    End Property

    Public Property IDSqlServerOrElasticSearch As Integer Implements IBusinessQueryRepositroy.IDSqlServerOrElasticSearch


    Public ListUser As New List(Of User)
    Public ItemIndexBusiness As Integer
    Public Conditionbusiness As String
    Public Constr As String = "Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True"
    Public ListNewsAndPhotos As New List(Of BusinessObject)
    Public ListContact As New List(Of Contact)

    Private tablebusiness As String = "T_BUSINESSOBJECT"
    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""
        Me.Conditionbusiness = ""

    End Sub




    Public Overridable Function Run() As List(Of BusinessObject) Implements IBusinessQueryRepositroy.Run
        Dim myReader As SqlDataReader


        Dim con As SqlConnection = New SqlConnection(Me.Constr)
        Dim cmd As SqlCommand = New SqlCommand("SELECT " + Me.TableName + ".[ID]
," + Me.TableName + ".[C_Name]
," + Me.TableName + ".[C_CreationDate]
," + Me.TableName + ".[C_Description]

            FROM " + Me.TableName + " 
WHERE " + Me.TableName + ".[C_ClassID] in (1,2,5) ", con)
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
            Dim condition As New QueryConditionSql

            condition.SelectItem = Me.IndexConditionID
            condition.ColumnName = Me.tablebusiness + ".ID"
            condition.Value = Me.QID
        condition.SeconedValue = Me.SeconedValueID
        Return condition.ConditionInteger()
    End If
    Return Nothing
End Function

Private Function Namefilter() As String
    If Not String.IsNullOrEmpty(Me.QName) Then
            Dim condition As New QueryConditionSql

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
            Dim condition As New QueryConditionSql
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
            Dim condition As New QueryConditionSql
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
            Dim condition As New QueryConditionSql
            condition.SelectItem = Me.IndexConditionClassID
        condition.ColumnName = "C_ClassID"
        condition.Value = Me.QClassID
        condition.SeconedValue = Me.SeconedValueClassID
        Return condition.ConditionInteger()
    End If
    Return Nothing
End Function
End Class