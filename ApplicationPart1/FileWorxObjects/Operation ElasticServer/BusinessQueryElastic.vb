Imports Nest
Imports Newtonsoft.Json

Public Class BusinessQueryElastic
    Implements IBusinessQueryRepositroy




    Public Property IndexConditionClassID As Integer Implements IBusinessQueryRepositroy.IndexConditionClassID
    Public Property IndexConditionCreationDate As Integer Implements IBusinessQueryRepositroy.IndexConditionCreationDate
    Public Property IndexConditionDescription As Integer Implements IBusinessQueryRepositroy.IndexConditionDescription
    Public Property IndexConditionID As Integer Implements IBusinessQueryRepositroy.IndexConditionID
    Public Property IndexConditionName As Integer Implements IBusinessQueryRepositroy.IndexConditionName


    Public Property QClassID As String Implements IBusinessQueryRepositroy.QClassID
    Public Property QCreationDate As String Implements IBusinessQueryRepositroy.QCreationDate
    Public Property QDescription As String Implements IBusinessQueryRepositroy.QDescription
    Public Property QID As String Implements IBusinessQueryRepositroy.QID
    Public Property QName As String Implements IBusinessQueryRepositroy.QName

    Public Property SeconedValueClassID As String Implements IBusinessQueryRepositroy.SeconedValueClassID
    Public Property SeconedValueCondition As String
    Public Property SeconedValueCreationDate As String Implements IBusinessQueryRepositroy.SeconedValueCreationDate
    Public Property SeconedValueDescription As String Implements IBusinessQueryRepositroy.SeconedValueDescription
    Public Property SeconedValueID As String Implements IBusinessQueryRepositroy.SeconedValueID
    Public Property SeconedValueName As String Implements IBusinessQueryRepositroy.SeconedValueName


    Public Property StringCondition As String
    Public Property ValueCondition As String

    Public Property IDSqlServerOrElasticSearch As Integer Implements IBusinessQueryRepositroy.IDSqlServerOrElasticSearch


    Public ListUser As New List(Of User)
    Public ItemIndexBusiness As Integer
    Public Conditionbusiness As String
    Public Sub New()
        Me.QID = ""
        Me.QName = ""
        Me.QDescription = ""
        Me.QCreationDate = ""
        Me.QClassID = ""
        Me.Conditionbusiness = ""


    End Sub
    Public ListNewsAndPhotos As New List(Of BusinessObject)


    Public Overridable Function Run() As List(Of BusinessObject) Implements IBusinessQueryRepositroy.Run
        Dim settings = New ConnectionSettings(New Uri("http://localhost:9200")).DefaultIndex("file")
        Dim client = New ElasticClient(settings)
        Dim response = client.Search(Of BusinessObject)(Function(s) s.Index("file").Query(Function(q) q.MatchAll()))

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
End Class
