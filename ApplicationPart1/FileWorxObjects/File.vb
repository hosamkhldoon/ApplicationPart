Imports System.Data.SqlClient
Public Class File
    Inherits BusinessObject


    Public Property IDFile() As Integer

    Public Property BodyNewsPhoto() As String

    Private AggregateClassFile As New FileAggregateClass

    Private con As SqlConnection

    Public Sub New()
        Me.BodyNewsPhoto = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Read()
        MyBase.Read()
        Me.IDFile = Me.IDBusiness
        Dim myReader As SqlDataReader




        Dim cmd As SqlCommand = New SqlCommand("SELECT 
[C_Body]

  FROM [dbo].[T_FILE]
WHERE [ID]='" & Me.IDFile & "'", con)
        con.Open()
        myReader = cmd.ExecuteReader()
        Do While myReader.Read()
            Me.BodyNewsPhoto = myReader.GetString(0)

        Loop

        myReader.Close()
        con.Close()
    End Sub

    Public Overrides Sub Delete()

        MyBase.Delete()
    End Sub
    Public Overrides Sub Updata()

    End Sub
    Private Sub CopyObject(AggregateObject As FileAggregateClass)
        AggregateObject.IDFile = Me.IDFile
        AggregateObject.BodyNewsPhoto = Me.BodyNewsPhoto

    End Sub
End Class