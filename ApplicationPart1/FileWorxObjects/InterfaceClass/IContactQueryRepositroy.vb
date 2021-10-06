Public Interface IContactQueryRepositroy
    Inherits IBusinessQueryRepositroy
    Property QType As String

    Overloads Function Run() As List(Of Contact)
End Interface
