Imports System.Data.SqlClient

Public Class HtmlReportSql
    Inherits FileReportSql
    Implements IHtmlFile

    Public Property LinkPage As String Implements IHtmlFile.LinkPage


    Public Property NameFile As String Implements IHtmlFile.NameFile

    Public Property IDHtmlFile As Integer

    Private con As SqlConnection
    Public Sub New()

        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Sub GETNameFile() Implements IHtmlFile.GETNameFile


        Dim myReader As SqlDataReader


        Dim cmd As SqlCommand = New SqlCommand("SELECT  [C_NameFile]
  FROM [dbo].[T_HTML]
WHERE [C_Link]='" & Me.LinkPage & "' ", con)
        con.Open()
        myReader = cmd.ExecuteReader()


        Do While myReader.Read()
            Me.NameFile = myReader.GetString(0)
        Loop
        myReader.Close()
        con.Close()
    End Sub
    Public Sub DeleteFile() Implements IHtmlFile.DeleteFile
        MyBase.Delete()
    End Sub
    Public Sub CreateFile() Implements IHtmlFile.CreateFile

        Me.IDBusiness = -1
        MyBase.Updata()
        Me.IDHtmlFile = Me.IDBusiness
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[T_HTML]
           ([ID]
,[C_Link]
,[C_NameFile]
          )
     VALUES
           ('" & Me.IDHtmlFile & "','" & Me.LinkPage & "',N'" + Me.NameFile + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Overrides Sub Read() Implements IHtmlFile.Read
        Dim myReader As SqlDataReader
        MyBase.Read()

        Dim cmd As SqlCommand = New SqlCommand("SELECT  [C_NameFile]
,[C_Link]
  FROM [dbo].[T_HTML]
WHERE [ID]='" & Me.IDBusiness & "' ", con)
        con.Open()
        myReader = cmd.ExecuteReader()


        Do While myReader.Read()
            Me.NameFile = myReader.GetString(0)
            Me.LinkPage = myReader.GetString(1)
        Loop
        myReader.Close()
        con.Close()
    End Sub
End Class
