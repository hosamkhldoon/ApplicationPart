Imports System.Data.SqlClient

Public Class PhotoReportSql
    Inherits FileReportSql
    Implements IPhotoRepositroy

    Public Property FileIDPhoto As Integer Implements IPhotoRepositroy.FileIDPhoto

    Public Property IDPhoto As Integer Implements IPhotoRepositroy.IDPhoto

    Public Property LocationPhoto As String Implements IPhotoRepositroy.LocationPhoto




    Private con As SqlConnection
    Public Sub New()
        Me.LocationPhoto = ""
        con = New SqlConnection("Data Source=HUSSAMI;Initial Catalog=NewsDB;Integrated Security=True")
    End Sub
    Public Overrides Sub Delete() Implements IPhotoRepositroy.Delete

    End Sub

    Public Overrides Sub Read() Implements IPhotoRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Updata() Implements IPhotoRepositroy.Updata
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
            Me.IDFile = Me.IDPhoto
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
