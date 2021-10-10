Imports System
Imports System.Runtime
Imports System.Collections.Generic
Imports System.ServiceModel
Imports RabbitMQ.Client
Imports System.Text
Imports Microsoft.Extensions.Configuration
Imports RestSharp
Imports Newtonsoft.Json

Public Class FileOperation
    Inherits BusinessObject

    Public Property ListContactId As New List(Of Integer)
    Public Property ListNewsId As New List(Of Integer)

    Public Property CategoryFile() As String

    Public Property LocationPhoto() As String
    Public Property BodyFile() As String
    Public Property UserName As String
    Public Property Password As String
    Public Property Address As String
    Public Property TypeFile As String
    Public Sub Upload()




        Dim ListContactAndNews As New List(Of FileOperation)
        Dim businessobject As New BusinessObject
        For Each idcontact In Me.ListContactId

            Dim contactobject As New Contact()
            contactobject.IDBusiness = idcontact
            contactobject.Read()



            For Each id In Me.ListNewsId
                Dim FileObject As FileOperation = New FileOperation()
                Dim newsobject As News = New News()
                Dim photoobject As Photo = New Photo()
                FileObject.UserName = contactobject.UserName
                FileObject.Password = contactobject.Password
                FileObject.Address = contactobject.Address
                businessobject.IDBusiness = id
                businessobject.Read()
                If businessobject.ClassIDFileOrUser = 1 Then

                    newsobject.IDBusiness = id
                    newsobject.Read()

                    FileObject.NameFileUser = newsobject.NameFileUser
                    FileObject.DescriptionNewsPhoto = newsobject.DescriptionNewsPhoto
                    FileObject.BodyFile = newsobject.BodyNewsPhoto
                    FileObject.TypeFile = "News"
                    FileObject.CategoryFile = newsobject.CategoryNews


                Else

                    photoobject.IDBusiness = id
                    photoobject.Read()

                    FileObject.NameFileUser = photoobject.NameFileUser
                    FileObject.DescriptionNewsPhoto = photoobject.DescriptionNewsPhoto
                    FileObject.BodyFile = photoobject.BodyNewsPhoto
                    FileObject.TypeFile = "Photo"
                    FileObject.LocationPhoto = photoobject.LocationPhoto

                End If
                ListContactAndNews.Add(FileObject)

            Next

        Next
        Dim jsonInfo As JsonObject = New JsonObject()

        Dim factory = New RabbitMQ.Client.ConnectionFactory() With {
                         .Uri = New Uri("amqp://guest:guest@localhost:5672")
                          }
        Dim JSONresult As String = JsonConvert.SerializeObject(ListContactAndNews)
        Using connection = factory.CreateConnection()
            Using channel = connection.CreateModel()
                Dim basicProperties As IBasicProperties = channel.CreateBasicProperties()
                basicProperties.Persistent = True
                channel.QueueDeclare(queue:="News", durable:=True, exclusive:=False, autoDelete:=False, arguments:=Nothing)
                Dim body = Encoding.UTF8.GetBytes(JSONresult)
                channel.BasicPublish(exchange:="", routingKey:="News", basicProperties, body:=body)

            End Using
        End Using


    End Sub
End Class
