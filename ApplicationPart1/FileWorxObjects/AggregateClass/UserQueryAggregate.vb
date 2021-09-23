Imports FileWorxObjects.FileQueryAggregate
Public Class UserQueryAggregate
    Inherits BusinessQueryAggregate
    Implements IUserQueryRepositroy

    Public Property IndexConditionLastModifier As Integer Implements IUserQueryRepositroy.IndexConditionLastModifier
    Public Property IndexConditionLoginName As Integer Implements IUserQueryRepositroy.IndexConditionLoginName
    Public Property IndexConditionPassword As Integer Implements IUserQueryRepositroy.IndexConditionPassword

    Public Property QLastModifier As String Implements IUserQueryRepositroy.QLastModifier
    Public Property QLoginName As String Implements IUserQueryRepositroy.QLoginName
    Public Property QPassword As String Implements IUserQueryRepositroy.QPassword


    Public Property SeconedValueLoginName As String Implements IUserQueryRepositroy.SeconedValueLoginName
    Public Property SeconedValueLastModifier As String Implements IUserQueryRepositroy.SeconedValueLastModifier
    Public Property IDSqlServerOrElasticSearch As Integer Implements IUserQueryRepositroy.IDSqlServerOrElasticSearch




    Private UserQuerySql As New UserQueryReportsql
    Private UserQueryElstic As New UserQueryElstic

    Public Overloads Function Run() As List(Of User) Implements IUserQueryRepositroy.Run
        If Me.IDSqlServerOrElasticSearch = SqlOrElastic.ElasticSearch Then
            Me.CopyObject(Me.UserQueryElstic)
            Return Me.UserQueryElstic.Run()
        Else
            Me.CopyObject(Me.UserQuerySql)
            Return Me.UserQuerySql.Run()
        End If
    End Function
    Public Overloads Sub CopyObject(UserQuery As IUserQueryRepositroy)
        UserQuery.QCreationDate = Me.QCreationDate
        UserQuery.QClassID = Me.QClassID
        UserQuery.QDescription = Me.QDescription
        UserQuery.QID = Me.QID
        UserQuery.QName = Me.QName
        UserQuery.QLastModifier = Me.QLastModifier
        UserQuery.QLoginName = Me.QLoginName
        UserQuery.QPassword = Me.QPassword

        UserQuery.SeconedValueClassID = Me.SeconedValueClassID
        UserQuery.SeconedValueCreationDate = Me.SeconedValueCreationDate
        UserQuery.SeconedValueDescription = Me.SeconedValueDescription
        UserQuery.SeconedValueID = Me.SeconedValueID
        UserQuery.SeconedValueName = Me.SeconedValueName
        UserQuery.SeconedValueLastModifier = Me.SeconedValueLastModifier
        UserQuery.SeconedValueLoginName = Me.SeconedValueLoginName

        UserQuery.IndexConditionClassID = Me.IndexConditionClassID
        UserQuery.IndexConditionCreationDate = Me.IndexConditionCreationDate
        UserQuery.IndexConditionDescription = Me.IndexConditionDescription
        UserQuery.IndexConditionID = Me.IndexConditionID
        UserQuery.IndexConditionName = Me.IndexConditionName
        UserQuery.IndexConditionLastModifier = Me.IndexConditionLastModifier
        UserQuery.IndexConditionLoginName = Me.IndexConditionLoginName
        UserQuery.IndexConditionPassword = Me.IndexConditionPassword
    End Sub
End Class
