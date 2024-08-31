Public Class ListForm
    Private Sub bt_Quit_Click(sender As Object, e As EventArgs) Handles bt_Quit.Click
        If bt_Quit.Text = "返回" Then
            bt_Quit.Text = "确定返回？"
            bt_Quit.ForeColor = Color.Red
        Else
            Me.Close()
            MenuForm.Show()
        End If
    End Sub

    Private Sub 菜单信息BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.菜单信息BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMS_DataSet)

    End Sub

    Private Sub ListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.菜单信息”中。您可以根据需要移动或移除它。
        Me.菜单信息TableAdapter.Fill(Me.RMS_DataSet.菜单信息)

    End Sub
End Class