Public Class LoginForm
    Enum enum_LoginErrorInfo
        UserNameEmpty = 0
        PWDEmpty = 1
        LoginFalse = 2
        LoginSuccess = 3
    End Enum

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.管理员信息”中。您可以根据需要移动或移除它。
        Me.管理员信息TableAdapter.Fill(Me.RMS_DataSet.管理员信息)

    End Sub

    Private Sub bt_Quit_Click(sender As Object, e As EventArgs) Handles bt_Quit.Click
        If bt_Quit.Text = "退出" Then
            bt_Quit.Text = "确定退出？"
            bt_Quit.ForeColor = Color.Red
        Else
            End
        End If
    End Sub
    Sub LoginFuc(ByVal info As enum_LoginErrorInfo)
        lb_ErrorInfo_0.Visible = False
        lb_ErrorInfo_1.Visible = False
        lb_ErrorInfo_2.Visible = False
        Select Case info
            Case 0
                lb_ErrorInfo_0.Visible = True
            Case 1
                lb_ErrorInfo_1.Visible = True
            Case 2
                lb_ErrorInfo_2.Visible = True
            Case 3
                MessageBox.Show("登录成功")
                Me.Close()
                MenuForm.Show()
        End Select
    End Sub

    Private Sub bt_Login_Click(sender As Object, e As EventArgs) Handles bt_Login.Click
        Dim enum_ErrorInfo As enum_LoginErrorInfo
        If tb_UserName.Text = "" Then
            enum_ErrorInfo = enum_LoginErrorInfo.UserNameEmpty
        ElseIf tb_PWD.Text = "" Then
            enum_ErrorInfo = enum_LoginErrorInfo.PWDEmpty
        Else
            Dim isOK As Boolean = Me.管理员信息TableAdapter.Login(tb_UserName.Text, tb_PWD.Text)
            If Not isOK Then
                enum_ErrorInfo = enum_LoginErrorInfo.LoginFalse
            Else
                enum_ErrorInfo = enum_LoginErrorInfo.LoginSuccess
            End If
        End If
        LoginFuc(enum_ErrorInfo)

    End Sub
End Class
