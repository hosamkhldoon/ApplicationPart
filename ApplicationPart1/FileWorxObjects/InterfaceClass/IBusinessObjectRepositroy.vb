﻿Public Interface IBusinessObjectRepositroy
    Property ClassIDFileOrUser As Integer
    Property CreationDateFileUser As String
    Property DescriptionNewsPhoto As String
    Property IDBusiness As Integer
    Property NameFileUser As String

    Sub Delete()

    Sub Read()

    Sub Updata()
End Interface