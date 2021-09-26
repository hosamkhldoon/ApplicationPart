Imports Nest

Public Class FileQueryElastic
    Inherits BusinessQueryElastic
    Implements IFileQueryRepositroy

    Public Property IndexConditionBody As Integer Implements IFileQueryRepositroy.IndexConditionBody
    Public Property QBody As String Implements IFileQueryRepositroy.QBody
    Public Property SeconedValueBody As String Implements IFileQueryRepositroy.SeconedValueBody
    Public Property IDSqlServerOrElasticSearch As Integer Implements IFileQueryRepositroy.IDSqlServerOrElasticSearch

    Private client As New ElasticClient()



    Public Overrides Function Run() As List(Of BusinessObject) Implements IFileQueryRepositroy.Run
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("file")
        Dim client = New ElasticClient(settings)

        Dim response = client.Search(Of BusinessObject)(Function(s) s.Query(Function(q) q.Bool(Function(f) f.Filter(Me.BuildQueryElstic()))))

        For Each hit In response.Hits
            Dim BusinessObject As BusinessObject = New BusinessObject()
            BusinessObject.IDBusiness = hit.Source.IDBusiness
            BusinessObject.NameFileUser = hit.Source.NameFileUser.ToString
            BusinessObject.CreationDateFileUser = Format(hit.Source.DateElastic, "MM/dd/yyyy hh:mm:ss tt")
            BusinessObject.DescriptionNewsPhoto = hit.Source.DescriptionNewsPhoto.ToString
            Me.ListNewsAndPhotos.Add(BusinessObject)
        Next
        Return Me.ListNewsAndPhotos
    End Function
    Private Function BuildQueryElstic() As QueryContainer
        Dim QueryCondition As New QueryContainer

        If Not Me.Idfilter() Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.Idfilter()

            End If
        If Not Me.Descriptionfilter() Is Nothing Then


            QueryCondition = QueryCondition AndAlso Me.Descriptionfilter()


            End If
            If Not Me.Namefilter() Is Nothing Then


            QueryCondition = QueryCondition AndAlso Me.Namefilter()


            End If
        If Not Me.CreationDatefilter() Is Nothing Then


            QueryCondition = QueryCondition AndAlso Me.CreationDatefilter()


            End If
        If Not Me.ClassIdfilter Is Nothing Then


            QueryCondition = QueryCondition AndAlso Me.ClassIdfilter()


            End If



        Return QueryCondition

    End Function
    Private Function Idfilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QID) Then
            Dim condition As New QueryConditionElstic

            condition.SelectItem = Me.IndexConditionID
            condition.Field = "iDBusiness"
            condition.Value = Me.QID
            condition.SeconedValue = Me.SeconedValueID
            Return condition.ConditionInteger()
        End If
        Return Nothing
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
    Private Function Descriptionfilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QDescription) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionDescription
            condition.Field = "descriptionNewsPhoto"
            condition.Value = Me.QDescription
            condition.SeconedValue = Me.SeconedValueDescription
            Return condition.ConditionString()
        End If
        Return Nothing
    End Function
    Private Function CreationDatefilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QCreationDate) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionCreationDate
            condition.Field = "dateElastic"
            condition.DateValue = Me.QCreationDate
            Date.TryParse(Me.SeconedValueCreationDate, condition.SeconedDate)
            Return condition.Conditiondate()
        End If
        Return Nothing
    End Function
    Private Function ClassIdfilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QClassID) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionClassID
            condition.Field = "classIDFileOrUser"
            condition.Value = Me.QClassID
            condition.SeconedValue = Me.SeconedValueClassID
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
End Class
