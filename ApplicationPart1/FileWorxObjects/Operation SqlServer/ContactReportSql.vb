Imports System.Data.SqlClient
Imports System.Globalization

Public Class ContactReportSql
    Inherits BusinessReportsql
    Implements IContactRepsitroy

    Public Property Address As String Implements IContactRepsitroy.Address
    Public Property Password As String Implements IContactRepsitroy.Password
    Public Property TypeContact As String Implements IContactRepsitroy.TypeContact
    Public Property UserName As String Implements IContactRepsitroy.UserName
    Public Property IDContact As Integer Implements IContactRepsitroy.IDContact
    Public Property LastFileDate As DateTime Implements IContactRepsitroy.LastFileDate


    Private con As SqlConnection
    Public Sub New()

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Delete() Implements IContactRepsitroy.Delete
        MyBase.Delete()
    End Sub

    Public Overrides Sub Read() Implements IContactRepsitroy.Read
        Dim myReader As SqlDataReader

        Try
            MyBase.Read()
            Me.IDContact = Me.IDBusiness
            Dim cmd As SqlCommand = New SqlCommand("SELECT [C_UserName]
   
,[C_Password]
,[C_Type]
,[C_Address]
,[C_LastFileDate]
  FROM [dbo].[T_CONTACT]
WHERE [ID]='" & Me.IDContact & "'", con)
            con.Open()
            myReader = cmd.ExecuteReader()
            Do While myReader.Read()
                Me.UserName = myReader.GetString(0)

                Me.Password = myReader.GetString(1)
                Me.TypeContact = myReader.GetString(2)
                Me.Address = myReader.GetString(3)

                If Me.TypeContact = "Reception"  Then
                    Me.LastFileDate = myReader.GetDateTime(4)
                End If

            Loop

            myReader.Close()
            con.Close()
        Catch e As Exception

        End Try
    End Sub

    Public Overrides Sub Updata() Implements IContactRepsitroy.Updata
        If Me.IDBusiness = -1 Then

            MyBase.Updata()
            Me.IDContact = Me.IDBusiness


            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_CONTACT]
           ([ID]
,[C_UserName]
,[C_Password]
,[C_Type]
,[C_Address]
          )
     VALUES
           ('" & Me.IDContact & "',N'" + Me.UserName + "',N'" + Me.Password + "',N'" + Me.TypeContact + "',N'" + Me.Address + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Else
            Me.IDContact = Me.IDBusiness
            MyBase.Updata()

            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_CONTACT]
   SET [C_UserName] = N'" + Me.UserName + "'
      ,[C_Address] = N'" + Me.Address + "'
      ,[C_LastFileDate] = '" + Me.LastFileDate + "'
 WHERE [ID]='" & Me.IDContact & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub
End Class
