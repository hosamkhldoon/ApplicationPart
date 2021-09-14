Imports System.IO
Imports System.Data.SqlClient
Public Class photo

    Inherits File
    'Create ADO.NET objects.

    Private id As Integer
    Public Property IDPhoto() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Private location As String
    Public Property LocationPhoto() As String
        Get
            Return location
        End Get
        Set(ByVal value As String)
            location = value
        End Set
    End Property
    Private idfilephoto As Integer
    Public Property FileIDPhoto() As Integer
        Get
            Return idfilephoto
        End Get
        Set(ByVal value As Integer)
            idfilephoto = value
        End Set
    End Property

    Private con As SqlConnection
    Public Sub New()
        location = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub


    Public Overloads Sub Read()
        Dim myReader As SqlDataReader
        MyBase.Read()

        Dim cmd As SqlCommand = New SqlCommand("SELECT [C_Location]
  FROM [dbo].[T_PHOTO]
WHERE [ID]='" & Me.IDPhoto & "'", con)
        con.Open()
        myReader = cmd.ExecuteReader()

        Do While myReader.Read()
            Me.LocationPhoto = myReader.GetString(0)
        Loop

        myReader.Close()
        con.Close()
    End Sub

    Public Overloads Sub Delete()

        MyBase.Delete()

    End Sub
    Public Overloads Sub Updata()
        If Me.IDPhoto = -1 Then
            Me.IDFile = -1
            MyBase.Updata()
            Me.IDPhoto = Me.IDBusiness

            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_PHOTO]
           ([ID]
,[C_Location]
         )
     VALUES
           ('" & Me.IDPhoto & "','" + Me.LocationPhoto + "')", con)
            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()
        Else
            MyBase.Updata()
            Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[T_PHOTO]
   SET [C_Location] = '" + Me.LocationPhoto + "'
     
 WHERE [ID]='" & Me.IDPhoto & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub





End Class
