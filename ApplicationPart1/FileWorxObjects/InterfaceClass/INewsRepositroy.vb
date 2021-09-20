Public Interface INewsRepositroy
    Inherits IFileRepositroy
    Property CategoryNews As String

    Property IDNews As Integer


    Overloads Sub Delete()

    Overloads Sub Read()

    Overloads Sub Updata()


End Interface
