Imports System.Data.SqlClient

Public Class BusinessReportsql
    Implements IBusinessObjectRepositroy


    Public Property IDBusiness() As Integer Implements IBusinessObjectRepositroy.IDBusiness
    Public Property CreationDateFileUser() As String Implements IBusinessObjectRepositroy.CreationDateFileUser
    Public Property NameFileUser() As String Implements IBusinessObjectRepositroy.NameFileUser
    Public Property ClassIDFileOrUser() As Integer Implements IBusinessObjectRepositroy.ClassIDFileOrUser
    Public Property DescriptionNewsPhoto() As String Implements IBusinessObjectRepositroy.DescriptionNewsPhoto

    Public Property Id As Integer Implements IBusinessObjectRepositroy.Id

    Public Property DateElastic As Date Implements IBusinessObjectRepositroy.DateElastic


    Private con As SqlConnection


    Public Overridable Sub Read() Implements IBusinessObjectRepositroy.Read
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

    Public Overridable Sub Delete() Implements IBusinessObjectRepositroy.Delete
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [dbo].[T_BUSINESSOBJECT]
      WHERE [ID]='" & Me.IDBusiness & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Overridable Sub Updata() Implements IBusinessObjectRepositroy.Updata
        If Me.IDBusiness = -1 Then
            con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_BUSINESSOBJECT]
           ([C_CreationDate]
           ,[C_Name]
        ,[C_ClassID]
,[C_Description]
)
     VALUES
           ('" + Me.CreationDateFileUser + "',N'" + Me.NameFileUser + "','" & Me.ClassIDFileOrUser & "',N'" + Me.DescriptionNewsPhoto + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim newcmd As SqlCommand = New SqlCommand("SELECT @@IDENTITY", con)
            Me.IDBusiness = newcmd.ExecuteScalar
            con.Close()
        Else
            con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_BUSINESSOBJECT]
   SET [C_Name] = N'" + Me.NameFileUser + "'
   ,[C_Description]=N'" + Me.DescriptionNewsPhoto + "'
    ,[C_CreationDate]='" + Me.CreationDateFileUser + "'
 WHERE [ID]='" & Me.IDBusiness & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        End If
    End Sub
End Class
