
Imports System.Data.SqlClient
Public Class BusinessObject



    Private id As Integer
    Public Property IDBusiness() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property


    Private creationdate As String
    Public Property CreationDateFileUser() As String
        Get
            Return creationdate
        End Get
        Set(ByVal value As String)
            creationdate = value
        End Set
    End Property
    Private name As String
    Public Property NameFileUser() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Private classid As Integer
    Public Property ClassIDFileOrUser() As Integer
        Get
            Return classid
        End Get
        Set(ByVal value As Integer)
            classid = value
        End Set
    End Property
    Private description As String
    Public Property DescriptionNewsPhoto() As String
        Get
            Return description
        End Get
        Set(ByVal value As String)
            description = value
        End Set
    End Property

    Private con As SqlConnection
    Public Sub New()
        description = ""

    End Sub
    Public Overloads Sub Read()
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

    Public Overloads Sub Delete()
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM [dbo].[T_BUSINESSOBJECT]
      WHERE [ID]='" & Me.IDBusiness & "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Overloads Sub Updata()
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
    
 WHERE [ID]='" & Me.IDBusiness & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        End If
    End Sub
End Class