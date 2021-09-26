Public Class BusinessReportElastic
    Implements IBusinessObjectRepositroy

    Public Property ClassIDFileOrUser As Integer Implements IBusinessObjectRepositroy.ClassIDFileOrUser


    Public Property CreationDateFileUser As String Implements IBusinessObjectRepositroy.CreationDateFileUser


    Public Property DescriptionNewsPhoto As String Implements IBusinessObjectRepositroy.DescriptionNewsPhoto


    Public Property IDBusiness As Integer Implements IBusinessObjectRepositroy.IDBusiness


    Public Property NameFileUser As String Implements IBusinessObjectRepositroy.NameFileUser


    Public Property Id As Integer Implements IBusinessObjectRepositroy.Id

    Public Property IDCreateOrUpdate As Integer Implements IBusinessObjectRepositroy.IDCreateOrUpdate

    Public Property DATEElastic As Date

    Private Property IBusinessObjectRepositroy_DateElastic As Date Implements IBusinessObjectRepositroy.DateElastic
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Date)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overridable Sub Delete() Implements IBusinessObjectRepositroy.Delete
        Throw New NotImplementedException()
    End Sub

    Public Overridable Sub Read() Implements IBusinessObjectRepositroy.Read
        Throw New NotImplementedException()
    End Sub

    Public Overridable Sub Updata() Implements IBusinessObjectRepositroy.Updata
        Throw New NotImplementedException()
    End Sub
End Class
