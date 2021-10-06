Imports System.Data.SqlClient
Imports System.Text.Json.Serialization
Imports FileWorxObjects.QueryConditionSql

Public Class ContactQuerySql
    Inherits BusinessQueryReportsql
    Implements IContactQueryRepositroy

    Public Property QType As String Implements IContactQueryRepositroy.QType

    <JsonIgnore>
    Public Overrides ReadOnly Property ColumnNames As String
        Get
            Return MyBase.ColumnNames + "," + Me.tabelcontact + ".C_Type," + Me.tabelcontact + ".C_Password," + Me.tabelcontact + ".C_UserName," + Me.tabelcontact + ".C_Address " '+ Me.tabelcontact + ".C_LastFileDate"
        End Get
    End Property
    <JsonIgnore>
    Public Overrides ReadOnly Property TableName As String
        Get
            Return MyBase.TableName + "," + Me.tabelcontact
        End Get
    End Property

    <JsonIgnore>
    Public Overrides ReadOnly Property WhereColumns As String
        Get
            Dim ContactCondition = Me.CheckData()
            If Not String.IsNullOrEmpty(ContactCondition) And Not String.IsNullOrEmpty(MyBase.WhereColumns) Then
                Return MyBase.WhereColumns + " AND " + ContactCondition
            ElseIf String.IsNullOrEmpty(ContactCondition) Then
                Return MyBase.WhereColumns
            Else
                Return ContactCondition
            End If
        End Get
    End Property



    Private tabelcontact As String = "T_CONTACT"
    Public Overloads Function Run() As List(Of Contact) Implements IContactQueryRepositroy.Run
        Dim query As String = "SELECT " + Me.ColumnNames + "
 FROM  " + Me.TableName + " "

        query &= " WHERE " + Me.WhereColumns
        If Not String.IsNullOrEmpty(Me.WhereColumns) Then
            query &= " AND " + Me.tabelcontact + ".ID=" + MyBase.TableName + ".ID"
        Else
            query &= Me.tabelcontact + ".ID=" + MyBase.TableName + ".ID"
        End If
        Using con As SqlConnection = New SqlConnection(Constr)
            Using cmd As SqlCommand = New SqlCommand(query, con)


                con.Open()

                Dim myReader As SqlDataReader
                Try
                    myReader = cmd.ExecuteReader()
                    Do While myReader.Read()
                        Dim contact As Contact = New Contact()
                        contact.IDBusiness = myReader.GetInt32(0)
                        contact.TypeContact = myReader.GetString(4)
                        contact.Password = myReader.GetString(5)
                        contact.UserName = myReader.GetString(6)
                        contact.Address = myReader.GetString(7)
                        ' contact.LastFileDate = CDate(myReader.GetDateTime(8))
                        contact.NameFileUser = myReader.GetString(1)
                        contact.DescriptionNewsPhoto = myReader.GetString(3)
                        contact.CreationDateFileUser = Format(myReader.GetDateTime(2), "MM/dd/yyyy hh:mm:ss tt")
                        Me.ListContact.Add(contact)
                    Loop

                    con.Close()
                    Return Me.ListContact
                Catch ex As Exception

                    Return Me.ListContact
                End Try
            End Using
        End Using
    End Function
    Private Function CheckData() As String

        Dim bqWhereColumns As String = ""
        If Not Me.QTypeFilter() Is Nothing Then
            If Not String.IsNullOrEmpty(bqWhereColumns) Then
                bqWhereColumns &= " AND " & Me.QTypeFilter()
            Else
                bqWhereColumns = Me.QTypeFilter()
            End If
        End If
        Return bqWhereColumns
    End Function
    Private Function QTypeFilter() As String
        If Not String.IsNullOrEmpty(Me.QType) Then
            Dim condition As New QueryConditionSql()
            condition.SelectItem = ConditionIndex.StartWith
            condition.ColumnName = "C_Type"
            condition.Value = Me.QType
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class
