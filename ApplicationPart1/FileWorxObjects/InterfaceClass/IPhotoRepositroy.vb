Public Interface IPhotoRepositroy
    Inherits IFileRepositroy
    Property FileIDPhoto As Integer
    Property IDPhoto As Integer
    Property LocationPhoto As String

    Overloads Sub Delete()
    Overloads Sub Read()
    Overloads Sub Updata()
End Interface
