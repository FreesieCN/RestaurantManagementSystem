Public Class LoginForm
    '定义错误信息枚举
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

    '登录函数，接受错误信息枚举
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
                Me.Hide()
                MenuForm.Show()
        End Select
    End Sub

    Private Sub bt_Login_Click(sender As Object, e As EventArgs) Handles bt_Login.Click
        Login()
    End Sub

    '登录函数,用于不同事件共享方法
    Private Sub Login()
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

    Private Sub tb_UserName_Enter(sender As Object, e As EventArgs) Handles tb_UserName.Enter, tb_PWD.Enter
        lb_ErrorInfo_0.Visible = False
        lb_ErrorInfo_1.Visible = False
        lb_ErrorInfo_2.Visible = False
    End Sub

    '回车进入密码框
    Private Sub tb_UserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_UserName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            tb_PWD.Focus()
            e.Handled = True
        End If
    End Sub

    '回车登录
    Private Sub tb_PWD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_PWD.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Login()
        End If
    End Sub

    Private Sub bt_Quit_Leave(sender As Object, e As EventArgs) Handles bt_Quit.Leave
        If bt_Quit.Text = "确定退出？" Then
            bt_Quit.Text = "退出"
            bt_Quit.ForeColor = Color.Black
        End If
    End Sub

End Class
