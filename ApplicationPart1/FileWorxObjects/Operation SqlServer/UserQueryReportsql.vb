Imports System.Data.SqlClient
Imports System.Text.Json.Serialization

Public Class UserQueryReportsql
    Inherits BusinessQueryReportsql
    Implements IUserQueryRepositroy

    <JsonIgnore>
    Public Overrides ReadOnly Property ColumnNames As String
        Get
            Return MyBase.ColumnNames + "," + Me.tabeluser + ".C_LoginName," + Me.tabeluser + ".C_Password," + Me.tabeluser + ".C_LastModifier"
        End Get
    End Property

    Public Property IndexConditionLastModifier As Integer Implements IUserQueryRepositroy.IndexConditionLastModifier
    Public Property IndexConditionLoginName As Integer Implements IUserQueryRepositroy.IndexConditionLoginName
    Public Property IndexConditionPassword As Integer Implements IUserQueryRepositroy.IndexConditionPassword


    Public Property QLastModifier As String Implements IUserQueryRepositroy.QLastModifier
    Public Property QLoginName As String Implements IUserQueryRepositroy.QLoginName
    Public Property QPassword As String Implements IUserQueryRepositroy.QPassword


    Public Property SeconedValueLastModifier As String Implements IUserQueryRepositroy.SeconedValueLastModifier
    Public Property SeconedValueLoginName As String Implements IUserQueryRepositroy.SeconedValueLoginName



    <JsonIgnore>
    Public Overrides ReadOnly Property TableName As String
        Get
            Return MyBase.TableName + "," + Me.tabeluser
        End Get
    End Property

    <JsonIgnore>
    Public Overrides ReadOnly Property WhereColumns As String
        Get
            Dim UserCondition = Me.CheckData()
            If Not String.IsNullOrEmpty(UserCondition) Then
                Return MyBase.WhereColumns + " AND " + UserCondition
            Else
                Return MyBase.WhereColumns
            End If
        End Get
    End Property




    Private tabeluser As String = "T_USER"


    Public Overloads Function Run() As List(Of User) Implements IUserQueryRepositroy.Run
        Dim query As String = "SELECT " + Me.ColumnNames + "
 FROM  " + Me.TableName + " "

        query &= " WHERE " + Me.WhereColumns
        If Not String.IsNullOrEmpty(Me.WhereColumns) Then
            query &= " AND " + Me.tabeluser + ".ID=" + MyBase.TableName + ".ID"
        Else
            query &= Me.tabeluser + ".ID=" + MyBase.TableName + ".ID"
        End If
        Using con As SqlConnection = New SqlConnection(Constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)


                con.Open()

                Dim myReader As SqlDataReader
                myReader = cmd.ExecuteReader()
                Do While myReader.Read()
                    Dim user As User = New User()
                    user.IDBusiness = myReader.GetInt32(0)
                    user.NameLogin = myReader.GetString(4)
                    user.PasswordUser = myReader.GetString(5)
                    user.LastModifierUser = myReader.GetString(6)
                    user.NameFileUser = myReader.GetString(1)
                    user.DescriptionNewsPhoto = myReader.GetString(3)
                    user.CreationDateFileUser = Format(myReader.GetDateTime(2), "MM/dd/yyyy hh:mm:ss tt")
                    Me.ListUser.Add(user)
                Loop

                con.Close()
                Return Me.ListUser

            End Using
        End Using

    End Function
    Private Function CheckData() As String

        Dim bqWhereColumns As String = ""
        If Not Me.QLoginNamefilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.QLoginNamefilter()
            Else
                bqWhereColumns = Me.QLoginNamefilter()
            End If
        End If
        If Not Me.Lastmodifierfilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.Lastmodifierfilter()
            Else
                bqWhereColumns = Me.Lastmodifierfilter()
            End If
        End If
        Return bqWhereColumns
        If Not Me.PasswordFilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.PasswordFilter()
            Else
                bqWhereColumns = Me.PasswordFilter()
            End If
        End If
        Return bqWhereColumns

    End Function
    Private Function QLoginNamefilter() As String
        If Not String.IsNullOrEmpty(Me.QLoginName) Then
            Dim condition As New QueryConditionSql()
            condition.SelectItem = Me.IndexConditionLoginName
            condition.ColumnName = "C_LoginName"
            condition.Value = Me.QLoginName
            condition.SeconedValue = Me.SeconedValueLoginName
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function Lastmodifierfilter() As String
        If Not String.IsNullOrEmpty(Me.QLastModifier) Then
            Dim condition As New QueryConditionSql()
            condition.SelectItem = Me.IndexConditionLastModifier
            condition.ColumnName = "C_LastModifier"
            condition.Value = Me.QLastModifier
            condition.SeconedValue = Me.SeconedValueLastModifier
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function PasswordFilter() As String
        If Not String.IsNullOrEmpty(Me.QPassword) Then
            Dim condition As New QueryConditionSql()
            condition.SelectItem = Me.IndexConditionPassword
            condition.ColumnName = "C_Password"
            condition.Value = Me.QPassword

            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
End Class
