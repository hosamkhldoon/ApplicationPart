Imports Nest

Public Class UserQueryElstic
    Inherits BusinessQueryElastic
    Implements IUserQueryRepositroy

    Public Property IndexConditionLastModifier As Integer Implements IUserQueryRepositroy.IndexConditionLastModifier
    Public Property IndexConditionLoginName As Integer Implements IUserQueryRepositroy.IndexConditionLoginName
    Public Property IndexConditionPassword As Integer Implements IUserQueryRepositroy.IndexConditionPassword


    Public Property QLastModifier As String Implements IUserQueryRepositroy.QLastModifier
    Public Property QLoginName As String Implements IUserQueryRepositroy.QLoginName
    Public Property QPassword As String Implements IUserQueryRepositroy.QPassword


    Public Property SeconedValueLastModifier As String Implements IUserQueryRepositroy.SeconedValueLastModifier
    Public Property SeconedValueLoginName As String Implements IUserQueryRepositroy.SeconedValueLoginName




    Public Overloads Function Run() As List(Of User) Implements IUserQueryRepositroy.Run
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("user")
        Dim client = New ElasticClient(settings)

        Dim response = client.Search(Of User)(Function(s) s.Query(Function(q) q.Bool(Function(f) f.Filter(Me.BuildQueryElstic()))))

        For Each hit In response.Hits
            Dim User As New User()
            User.IDBusiness = hit.Source.IDBusiness
            User.NameLogin = hit.Source.NameLogin.ToString

            User.LastModifierUser = hit.Source.LastModifierUser.ToString
            User.NameFileUser = hit.Source.NameFileUser.ToString

            User.CreationDateFileUser = Format(hit.Source.DateElastic, "MM/dd/yyyy hh:mm:ss tt")
            Me.ListUser.Add(User)
        Next
        Return Me.ListUser
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

        If Not Me.QLoginNamefilter() Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.QLoginNamefilter

            End If
        If Not Me.Lastmodifierfilter() Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.Lastmodifierfilter

            End If

        If Not Me.PasswordFilter() Is Nothing Then

            QueryCondition = QueryCondition AndAlso Me.Lastmodifierfilter

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
    Private Function QLoginNamefilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QLoginName) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionClassID
            condition.Field = "classIDFileOrUser"
            condition.Value = Me.QClassID
            condition.SeconedValue = Me.SeconedValueClassID
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
    Private Function Lastmodifierfilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QLastModifier) Then
            Dim condition As New QueryConditionElstic
            condition.SelectItem = Me.IndexConditionClassID
            condition.Field = "classIDFileOrUser"
            condition.Value = Me.QClassID
            condition.SeconedValue = Me.SeconedValueClassID
            Return condition.ConditionInteger()
        End If
        Return Nothing
    End Function
    Private Function PasswordFilter() As QueryContainer
        If Not String.IsNullOrEmpty(Me.QPassword) Then
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

