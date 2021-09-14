Imports System.IO
Imports System.Data.SqlClient
Imports System.Net
Imports System.Data
Public Class News
    Inherits File
    'Create ADO.NET objects.


    Private Category As String
    Public Property CategoryNews() As String
        Get
            Return Category
        End Get
        Set(ByVal value As String)
            Category = value
        End Set
    End Property
    Private Id As Integer
    Public Property IDNews() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property
    Private idfilenews As Integer
    Public Property FileIDNews() As Integer
        Get
            Return idfilenews
        End Get
        Set(ByVal value As Integer)
            idfilenews = value
        End Set
    End Property
    Private con As SqlConnection
    Public Sub New()
        Category = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overloads Sub Read()
        Dim myReader As SqlDataReader
        MyBase.Read()
        Me.IDNews = Me.IDBusiness
        Dim cmd As SqlCommand = New SqlCommand("SELECT  [C_Category]
  FROM [dbo].[T_NEWS]
WHERE [ID]='" & Me.IDNews & "' ", con)
        con.Open()
        myReader = cmd.ExecuteReader()


        Do While myReader.Read()
            Me.CategoryNews = myReader.GetString(0)
        Loop
        myReader.Close()
        con.Close()
    End Sub

    Public Overloads Sub Delete()

        MyBase.Delete()
    End Sub
    Public Overloads Sub Updata()

        If Me.IDNews = -1 Then
            Me.IDFile = -1
            MyBase.Updata()
            Me.IDNews = Me.IDBusiness


            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_NEWS]
           ([ID]
,[C_Category]
          )
     VALUES
           ('" & Me.IDNews & "',N'" + Me.CategoryNews + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Else
            MyBase.Updata()
            Me.IDNews = Me.IDBusiness
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_NEWS]
   SET [C_Category] = N'" + Me.CategoryNews + "'
      
 WHERE [ID]='" & Me.IDNews & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If

    End Sub

End Class
