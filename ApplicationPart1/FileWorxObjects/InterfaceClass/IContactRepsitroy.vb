Public Interface IContactRepsitroy
    Inherits IBusinessObjectRepositroy
    Property Address As String
    Property Password As String
    Property TypeContact As String
    Property UserName As String
    Property IDContact As Integer
    Property LastFileDate As DateTime
    Overloads Sub Delete()
    Overloads Sub Read()
    Overloads Sub Updata()
End Interface
