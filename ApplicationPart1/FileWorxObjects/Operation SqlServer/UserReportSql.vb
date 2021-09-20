Imports System.Data.SqlClient

Public Class UserReportSql
    Inherits BusinessReportsql
    Implements IUserRepositroy




    Public Property IDUser As Integer Implements IUserRepositroy.IDUser
    Public Property LastModifierUser As String Implements IUserRepositroy.LastModifierUser
    Public Property NameLogin As String Implements IUserRepositroy.NameLogin
    Public Property PasswordUser As String Implements IUserRepositroy.PasswordUser
    Public Property TypeUser As String Implements IUserRepositroy.TypeUser


    Private con As SqlConnection
    Public Sub New()
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Delete() Implements IUserRepositroy.Delete
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Read() Implements IUserRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IUserRepositroy.Updata
        If Me.IDUser = -1 Then
            Me.IDBusiness = -1
            MyBase.Updata()
            Me.IDUser = Me.IDBusiness

            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_USER]
           ([ID]
,[C_LoginName]
           ,[C_Password]
,[C_Type]
,[C_LastModifier]
          )
     VALUES
           ('" & Me.IDUser & "',N'" + Me.NameLogin + "','" + Me.PasswordUser + "','" + Me.TypeUser + "',N'" + Me.LastModifierUser + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Else
            Me.IDBusiness = Me.IDUser
            MyBase.Updata()
            Me.IDUser = Me.IDBusiness
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_USER]
   SET [C_LoginName] = N'" + Me.NameLogin + "'
      ,[C_Password] = '" + Me.PasswordUser + "'
     
      ,[C_LastModifier] = N'" + Me.LastModifierUser + "'
      ,[C_Type]='" + Me.TypeUser + "'
 WHERE [ID]='" & Me.IDUser & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub

    Public Function CheckLoginUser() As Boolean Implements IUserRepositroy.CheckLoginUser
        Throw New NotImplementedException()
    End Function
End Class
