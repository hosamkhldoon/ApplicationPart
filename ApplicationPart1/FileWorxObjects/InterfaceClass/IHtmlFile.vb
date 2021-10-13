Public Interface IHtmlFile
    Inherits IFileRepositroy
    Property LinkPage As String
    Property NameFile As String
    Sub GETNameFile()
    Sub DeleteFile()
    Sub CreateFile()
    Overloads Sub Read()
End Interface
