Public Class BusinessObjectAggregate
    Implements IBusinessObjectRepositroy

    Public Property ClassIDFileOrUser As Integer Implements IBusinessObjectRepositroy.ClassIDFileOrUser
    Public Property CreationDateFileUser As String Implements IBusinessObjectRepositroy.CreationDateFileUser
    Public Property DescriptionNewsPhoto As String Implements IBusinessObjectRepositroy.DescriptionNewsPhoto
    Public Property IDBusiness As Integer Implements IBusinessObjectRepositroy.IDBusiness
    Public Property NameFileUser As String Implements IBusinessObjectRepositroy.NameFileUser



    Private BusinessObjectSql As New BusinessReportsql
    Private FileObjectElastic As New FileReportElstic
    Private UserObjectElstic As New UserReportElastic


    Public Overridable Sub Delete() Implements IBusinessObjectRepositroy.Delete
        BusinessObjectSql.IDBusiness = Me.IDBusiness
        BusinessObjectSql.Delete()
        FileObjectElastic.IDBusiness = Me.IDBusiness
        UserObjectElstic.IDBusiness = Me.IDBusiness
        FileObjectElastic.Delete()
        UserObjectElstic.Delete()
    End Sub

    Public Overridable Sub Read() Implements IBusinessObjectRepositroy.Read
        Throw New NotImplementedException()
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
