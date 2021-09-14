Imports System.Data.SqlClient
Public Class File
    Inherits BusinessObject
    Private body As String
    Public ListDescription As New List(Of String)
    Private id As Integer
    Public Property IDFile() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Public Property BodyNewsPhoto() As String
        Get
            Return body
        End Get
        Set(ByVal value As String)
            body = value
        End Set
    End Property




    Private con As SqlConnection
    Public Sub New()
        body = ""

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overloads Sub Read()
        Dim myReader As SqlDataReader


        MyBase.Read()


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

    Public Overloads Sub Delete(id As Integer, id_business As Integer)

        MyBase.Delete()
    End Sub
    Public Overloads Sub Updata()
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