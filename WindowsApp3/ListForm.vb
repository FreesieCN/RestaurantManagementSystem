Public Class ListForm
    Private Sub bt_Quit_Click(sender As Object, e As EventArgs) Handles bt_Quit.Click
        If bt_Quit.Text = "返回" Then
            bt_Quit.Text = "确定？"
            bt_Quit.ForeColor = Color.Red
        Else
            Me.Close()
            MenuForm.Show()
        End If
    End Sub

    Function ErrorDivide() As Boolean
        Dim IsError As Boolean = True
        lb_ErrorInfo.Visible = True
        If tb_Number.Text = "" Then
            lb_ErrorInfo.Text = "请输入编号！"
        ElseIf tb_Name.Text = "" Then
            lb_ErrorInfo.Text = "请输入名称！"
        ElseIf tb_Price.Text = "" Then
            lb_ErrorInfo.Text = "请输入价格！"
        Else
            IsError = False
            lb_ErrorInfo.Visible = False
        End If
        Return IsError
    End Function

    Private Sub ListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.菜单信息”中。您可以根据需要移动或移除它。
        Me.菜单信息TableAdapter.Fill(Me.RMS_DataSet.菜单信息)

    End Sub

    Private Sub bt_Quit_Leave(sender As Object, e As EventArgs) Handles bt_Quit.Leave
        If bt_Quit.Text = "确定？" Then
            bt_Quit.Text = "返回"
            bt_Quit.ForeColor = Color.Black
        End If
    End Sub

    Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
        If ErrorDivide() = False Then
            Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class