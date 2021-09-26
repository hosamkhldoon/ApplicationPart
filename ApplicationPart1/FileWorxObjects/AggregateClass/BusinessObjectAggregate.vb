Public Class BusinessObjectAggregate
    Implements IBusinessObjectRepositroy

    Public Property ClassIDFileOrUser As Integer Implements IBusinessObjectRepositroy.ClassIDFileOrUser
    Public Property CreationDateFileUser As String Implements IBusinessObjectRepositroy.CreationDateFileUser
    Public Property DescriptionNewsPhoto As String Implements IBusinessObjectRepositroy.DescriptionNewsPhoto
    Public Property IDBusiness As Integer Implements IBusinessObjectRepositroy.IDBusiness
    Public Property NameFileUser As String Implements IBusinessObjectRepositroy.NameFileUser

    Public Property Id As Integer Implements IBusinessObjectRepositroy.Id
    Public Property DateElastic As Date Implements IBusinessObjectRepositroy.DateElastic
    Public Property IDCreateOrUpdate As Integer Implements IBusinessObjectRepositroy.IDCreateOrUpdate


    Private BusinessObjectSql As New BusinessReportsql


    Public Overridable Sub Delete() Implements IBusinessObjectRepositroy.Delete

    End Sub

    Public Overridable Sub Read() Implements IBusinessObjectRepositroy.Read
        BusinessObjectSql.IDBusiness = Me.IDBusiness
        BusinessObjectSql.Read()
        Me.ClassIDFileOrUser = BusinessObjectSql.ClassIDFileOrUser
    End Sub

    Public Overridable Sub Updata() Implements IBusinessObjectRepositroy.Updata

    End Sub
    Private Sub CopyObject(BusinessObject As IBusinessObjectRepositroy)
        BusinessObject.IDBusiness = Me.IDBusiness
        BusinessObject.DescriptionNewsPhoto = Me.DescriptionNewsPhoto
        BusinessObject.CreationDateFileUser = Me.CreationDateFileUser
        BusinessObject.ClassIDFileOrUser = Me.ClassIDFileOrUser
        BusinessObject.NameFileUser = Me.NameFileUser

    End Sub
End Class
