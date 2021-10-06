Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class FileQueryReportSql
    Inherits BusinessQueryReportsql
    Implements IFileQueryRepositroy

    Public Property QBody As String Implements IFileQueryRepositroy.QBody
    Public Property IndexConditionBody As Integer Implements IFileQueryRepositroy.IndexConditionBody
    Public Property SeconedValueBody As String Implements IFileQueryRepositroy.SeconedValueBody


    <JsonIgnore>
    Public Overrides ReadOnly Property TableName As String
        Get
            Return MyBase.TableName + "," + Me.tablefile
        End Get
    End Property
    <JsonIgnore>
    Public Overrides ReadOnly Property WhereColumns As String
        Get
            Dim FileCondition = Me.CheckData()
            If Not String.IsNullOrEmpty(FileCondition) Then
                Return MyBase.WhereColumns + " AND " + FileCondition
            Else
                Return MyBase.WhereColumns
            End If
        End Get
    End Property




    Private tablefile As String = "T_FILE"


    Public Sub New()

        Me.QBody = ""
    End Sub


    Public Overrides Function Run() As List(Of BusinessObject) Implements IFileQueryRepositroy.Run
        Me.ListNewsAndPhotos.Clear()
        Dim query As String = "SELECT " + Me.ColumnNames + " FROM  " + Me.TableName + " "
        query &= "WHERE " & Me.WhereColumns
        If Not String.IsNullOrEmpty(Me.WhereColumns) Then
            query &= " AND " + Me.tablefile + ".ID=" + MyBase.TableName + ".ID"
        Else
            query &= Me.tablefile + ".ID=" + MyBase.TableName + ".ID"
        End If
        Using con As SqlConnection = New SqlConnection(Me.Constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)


                con.Open()
                Dim myReader As SqlDataReader
                myReader = cmd.ExecuteReader()
                Do While myReader.Read()
                    Dim businessobject As BusinessObject = New BusinessObject()
                    businessobject.IDBusiness = myReader.GetInt32(0)
                    businessobject.NameFileUser = myReader.GetString(1)
                    businessobject.CreationDateFileUser = Format(myReader.GetDateTime(2), " MM/dd/yyyy hh:mm:ss tt")
                    businessobject.DescriptionNewsPhoto = myReader.GetString(3)
                    Me.ListNewsAndPhotos.Add(businessobject)
                Loop


                myReader.Close()
                con.Close()

                Return Me.ListNewsAndPhotos
            End Using
        End Using
    End Function
    Private Function CheckData() As String

        Dim bqWhereColumns As String = ""
        If Not Me.QBodyfilter Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.QBodyfilter()
            Else
                bqWhereColumns = Me.QBodyfilter()
            End If
        End If
        Return bqWhereColumns


    End Function
    Private Function QBodyfilter() As String
        If Not String.IsNullOrEmpty(Me.QBody) Then
            Dim condition As New QueryConditionSql
            condition.SelectItem = Me.IndexConditionBody
            condition.ColumnName = "C_Body"
            condition.Value = Me.QBody
            condition.SeconedValue = Me.SeconedValueBody
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class
