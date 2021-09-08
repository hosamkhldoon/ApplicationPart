Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class UserQuery
    Inherits BusinessQuery
    Private tabeluser As String = "T_USER"
    Public Overrides ReadOnly Property TableName As String
        Get
            Return MyBase.TableName + "," + Me.tabeluser
        End Get
    End Property
    Public Property QLoginName As String
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

    Public Property QLastModifier As String

    Public Overrides ReadOnly Property ColumnNames As String
        Get
            Return MyBase.ColumnNames + "," + Me.tabeluser + ".C_LoginName," + Me.tabeluser + ".C_Password," + Me.tabeluser + ".C_LastModifier"
        End Get
    End Property

    'TODO: Remove


    Public Sub New()

        Me.QLoginName = ""
        Me.QLastModifier = ""
    End Sub
    Public Overrides Sub Run()



        Me.ListUser.Clear()
        Dim query As String = "SELECT " + Me.ColumnNames + "
 FROM  " + Me.TableName + " "

        query &= " WHERE " + Me.WhereColumns
        query &= "AND " + Me.tabeluser + ".ID=" + MyBase.TableName + ".ID"


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

                Me.ListIndex.Clear()
            End Using
        End Using

    End Sub

    Private Function CheckData() As String

        Dim bqWhereColumns As String = ""
        If Not Me.QLoginNamefilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.QLoginNamefilter()
            Else
                bqWhereColumns = Me.QLoginNamefilter()
            End If
        End If
        If Not Me.Lastmodifierfilter Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.Lastmodifierfilter()
            Else
                bqWhereColumns = Me.Lastmodifierfilter()
            End If
        End If
        Return bqWhereColumns


    End Function
    Private Function QLoginNamefilter() As String
        If Not String.IsNullOrEmpty(Me.QLoginName) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ListIndex(FilterIndex.LoginName)
            condition.ColumnName = "C_LoginName"
            condition.Value = Me.QLoginName
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.LoginName)
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function Lastmodifierfilter() As String
        If Not String.IsNullOrEmpty(Me.QLastModifier) Then
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ListIndex(FilterIndex.LastModifer)
            condition.ColumnName = "C_LastModifier"
            condition.Value = Me.QLastModifier
            condition.SeconedValue = Me.ListSeconedValue(FilterIndex.LastModifer)
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class