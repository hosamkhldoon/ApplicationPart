
Imports System.Data.SqlClient
Public Class BusinessObject



    Public Property IDBusiness() As Integer
    Public Property CreationDateFileUser As String

    Public Property NameFileUser As String

    Public Property ClassIDFileOrUser As Integer

    Public Property DescriptionNewsPhoto As String

    Private AggregateClassBusiness As New BusinessObjectAggregate
    Private BusinessRepositroy As IBusinessObjectRepositroy = New BusinessObjectAggregate
    Private con As SqlConnection
    Public Sub New()
        Me.DescriptionNewsPhoto = ""
        Me.CreationDateFileUser = ""
        Me.NameFileUser = ""
        Me.IDBusiness = 0
        Me.ClassIDFileOrUser = 0
    End Sub
    Public Overridable Sub Read()

        Dim myReader As SqlDataReader

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")

        Dim cmd As SqlCommand = New SqlCommand("SELECT  [C_Name]
,[C_CreationDate]
,[C_Description]
,[C_ClassID]
            FROM [dbo].[T_BUSINESSOBJECT]
WHERE [ID]='" & Me.IDBusiness & "'", con)
        con.Open()
        myReader = cmd.ExecuteReader()
        Do While myReader.Read()
            Me.NameFileUser = myReader.GetString(0)
            Me.CreationDateFileUser = Format(myReader.GetDateTime(1), "MM/dd/yyyy hh:mm:ss tt")
            Me.DescriptionNewsPhoto = myReader.GetString(2)
            Me.ClassIDFileOrUser = myReader.GetInt32(3)
        Loop

        myReader.Close()
        con.Close()



    End Sub

    Public Overridable Sub Delete()

        BusinessRepositroy.IDBusiness = Me.IDBusiness
        BusinessRepositroy.Delete()
    End Sub
    Public Overridable Sub Updata()

    End Sub
    Private Sub CopyObject(AggregateObject As BusinessObjectAggregate)
        AggregateObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        AggregateObject.CreationDateFileUser = Me.CreationDateFileUser
        AggregateObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        AggregateObject.NameFileUser = Me.NameFileUser
        AggregateObject.IDBusiness = Me.IDBusiness

    End Sub
End Class