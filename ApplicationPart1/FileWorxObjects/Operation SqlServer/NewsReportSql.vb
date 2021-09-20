Imports System.IO
Imports System.Data.SqlClient
Imports System.Net
Imports System.Data
Public Class NewsReportSql
    Inherits FileReportSql
    Implements INewsRepositroy
    'Create ADO.NET objects.



    Public Property CategoryNews As String Implements INewsRepositroy.CategoryNews


    Public Property IDNews As Integer Implements INewsRepositroy.IDNews




    Private con As SqlConnection
    Public Sub New()

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Read() Implements INewsRepositroy.Read

    End Sub

    Public Overrides Sub Delete() Implements INewsRepositroy.Delete
        MyBase.Delete()
    End Sub
    Public Overrides Sub Updata() Implements INewsRepositroy.Updata
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
            Me.IDFile = Me.IDNews
            MyBase.Updata()

            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_NEWS]
   SET [C_Category] = N'" + Me.CategoryNews + "'
      
 WHERE [ID]='" & Me.IDNews & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If


    End Sub

End Class
