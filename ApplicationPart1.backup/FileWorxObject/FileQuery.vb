Imports System.Data.SqlClient
Public Class FileQuery
    Inherits BusinessQuery
    Public Property QBody As String

    Private tablefile As String = "T_FILE"
    Public Overrides ReadOnly Property TableName As String
        Get
            Return MyBase.TableName + "," + Me.tablefile
        End Get
    End Property
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
    Public Sub New()

        Me.QBody = ""
    End Sub

    Public Overrides Sub Run()






        Me.ListNewsAndPhotos.Clear()
        Dim query As String = "SELECT " + Me.ColumnNames + " FROM  " + Me.TableName + " "
        query &= "WHERE " & Me.WhereColumns
        query &= " AND " + Me.tablefile + ".ID=" + MyBase.TableName + ".ID"


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
                Me.ListIndex.Clear()
            End Using
        End Using
    End Sub
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
            Dim condition As New QueryCondition()
            condition.SelectItem = Me.ItemIndexBusiness
            condition.ColumnName = "C_Body"
            condition.Value = Me.QBody
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class