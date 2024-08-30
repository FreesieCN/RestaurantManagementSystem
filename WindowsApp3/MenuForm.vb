Public Class MenuForm

    Private Sub bt_Quit_Click(sender As Object, e As EventArgs) Handles bt_Quit.Click
        If bt_Quit.Text = "退出" Then
            bt_Quit.Text = "确定退出？"
            bt_Quit.ForeColor = Color.Red
        Else
            End
        End If
    End Sub

    Private Sub bt_List_Click(sender As Object, e As EventArgs) Handles bt_List.Click
        Me.Hide()
        ListForm.Show()
    End Sub

    Private Sub bt_Employee_Click(sender As Object, e As EventArgs) Handles bt_Employee.Click
        Me.Hide()
        EmployeeForm.Show()
    End Sub

    Private Sub bt_VIP_Click(sender As Object, e As EventArgs) Handles bt_VIP.Click
        Me.Hide()
        VIPForm.Show()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class