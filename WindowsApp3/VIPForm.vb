Public Class VIPForm
    Private Sub bt_Quit_Click(sender As Object, e As EventArgs)
        If bt_Quit.Text = "返回" Then
            bt_Quit.Text = "确定？"
            bt_Quit.ForeColor = Color.Red
        Else
            Me.Close()
            MenuForm.Show()
        End If
    End Sub

    Private Sub 会员信息BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.会员信息BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMS_DataSet)

    End Sub

    Private Sub VIPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.会员信息”中。您可以根据需要移动或移除它。
        Me.会员信息TableAdapter.Fill(Me.RMS_DataSet.会员信息)
        'TODO: 这行代码将数据加载到表“RMS_DataSet.会员信息”中。您可以根据需要移动或移除它。
        Me.会员信息TableAdapter.Fill(Me.RMS_DataSet.会员信息)

    End Sub

    Private Sub 会员信息BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.会员信息BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMS_DataSet)

    End Sub

    Private Sub 雇员信息DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 雇员信息DataGridView.CellContentClick

    End Sub
End Class