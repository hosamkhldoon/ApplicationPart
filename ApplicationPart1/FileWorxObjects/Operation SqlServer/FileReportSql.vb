Imports System.Data.SqlClient

Public Class FileReportSql
    Inherits BusinessReportsql
    Implements IFileRepositroy



    Private con As SqlConnection

    Public Property IDFile() As Integer Implements IFileRepositroy.IDFile

    Public Property BodyNewsPhoto() As String Implements IFileRepositroy.BodyNewsPhoto




    Public Sub New()

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub

    Public Overrides Sub Read() Implements IFileRepositroy.Read
    End Sub

    Public Overrides Sub Delete() Implements IFileRepositroy.Delete
        MyBase.Delete()
    End Sub
    Public Overrides Sub Updata() Implements IFileRepositroy.Updata
        If Me.IDFile = -1 Then
            Me.IDBusiness = -1
            MyBase.Updata()
            Me.IDFile = Me.IDBusiness

            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_FILE]
           ([ID]
,[C_Body]
  
        
          )
     VALUES
           ('" & Me.IDFile & "',N'" + Me.BodyNewsPhoto + "' )", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Else
            Me.IDBusiness = Me.IDFile
            MyBase.Updata()

            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_FILE]
   SET [C_Body] = N'" + Me.BodyNewsPhoto + "'
 
    
   
 WHERE [ID]='" & Me.IDFile & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub
End Class
