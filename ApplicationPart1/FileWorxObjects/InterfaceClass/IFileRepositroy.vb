Public Interface IFileRepositroy
    Inherits IBusinessObjectRepositroy
    Property BodyNewsPhoto As String
    Property IDFile As Integer
    Overloads Sub Delete()
    Overloads Sub Read()
    Overloads Sub Updata()
End Interface
