Imports FileWorxObjects.QueryConditionElstic
Imports Nest

Public Class ContactQueryElastic
    Inherits BusinessQueryReportsql
    Implements IContactQueryRepositroy

    Public Property QType As String Implements IContactQueryRepositroy.QType


    Public Overloads Function Run() As List(Of Contact) Implements IContactQueryRepositroy.Run
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("contact")
        Dim client = New ElasticClient(settings)

        Dim response = client.Search(Of Contact)(Function(s) s.Query(Function(q) q.Bool(Function(f) f.Filter(Me.BuildQueryElstic()))))

        For Each hit In response.Hits
            Dim contact As Contact = New Contact()
            contact.IDBusiness = hit.Source.IDBusiness
            contact.TypeContact = hit.Source.TypeContact.ToString
            contact.Password = hit.Source.Password.ToString
            contact.UserName = hit.Source.UserName.ToString
            contact.Address = hit.Source.Address.ToString
            contact.NameFileUser = hit.Source.NameFileUser.ToString
            contact.DescriptionNewsPhoto = hit.Source.DescriptionNewsPhoto.ToString
            contact.CreationDateFileUser = Format(hit.Source.DateElastic, "MM/dd/yyyy hh:mm:ss tt")
            Me.ListContact.Add(contact)
        Next
        Return Me.ListContact
    End Function
    Private Function BuildQueryElstic() As QueryContainer
        Dim QueryCondition As New QueryContainer
        If Not Me.Namefilter() Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.Namefilter()


        End If
        If Not Me.QTypeFilter Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.QTypeFilter()


        End If
        Return QueryCondition
    End Function
    Private Function Namefilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QName) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionName
            condition.Field = "nameFileUser"
            condition.Value = Me.QName
            condition.SeconedValue = Me.SeconedValueName
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function QTypeFilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QType) Then
            Dim condition As New QueryConditionElstic()
            condition.SelectItem = ConditionIndex.StartWith
            condition.Field = "typeContact"
            condition.Value = Me.QType
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
End Class
