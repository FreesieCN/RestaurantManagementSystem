Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.管理员信息”中。您可以根据需要移动或移除它。
        Me.管理员信息TableAdapter.Fill(Me.RMS_DataSet.管理员信息)

    End Sub
End Class
