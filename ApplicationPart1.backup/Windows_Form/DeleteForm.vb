Public Class DeleteForm
    Public TypeRow As String
    Private Sub YesClick(sender As Object, e As EventArgs) Handles yesButton1.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub DeleteLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        deleteLabel1.Text = "Are You Sure To Delete This " + Me.TypeRow + " ?"
    End Sub

    Private Sub NoClick(sender As Object, e As EventArgs) Handles noButton2.Click
        Me.Close()
    End Sub
End Class