Imports WindowsApp3.RMS_DataSetTableAdapters

Public Class VIPForm

    Private Sub 会员信息BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.会员信息BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMS_DataSet)

    End Sub

    Private Sub VIPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.会员信息”中。您可以根据需要移动或移除它。
        Me.会员信息TableAdapter.Fill(Me.RMS_DataSet.会员信息)
        rb_isVIP.Checked = True
        rb_SexSH.Checked = True
    End Sub

    Private Sub 会员信息BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.会员信息BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMS_DataSet)

    End Sub

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
        If tb_PWD.Text = "" Then
            lb_ErrorInfo.Text = "请输入密码！"
        ElseIf tb_Name.Text = "" Then
            lb_ErrorInfo.Text = "请输入名称！"
        ElseIf tb_TelePhone.Text = "" Then
            lb_ErrorInfo.Text = "请输入联系方式！"
        Else
            IsError = False
            lb_ErrorInfo.Visible = False
        End If
        Return IsError
    End Function

    Private Sub DGVRefresh()
        Me.会员信息TableAdapter.Fill(Me.RMS_DataSet.会员信息)
        lb_Num.Text = Me.会员信息TableAdapter.Num().ToString
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
                Dim isVIP As Boolean = False
                If rb_isVIP.Checked = True Then
                    isVIP = True
                End If
                Me.会员信息TableAdapter.Insert(tb_Name.Text, tb_PWD.Text, LB_Sex.SelectedItem, isVIP, Today, tb_TelePhone.Text)
                DGVRefresh()
                MsgBox("添加成功！")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    '标识排序对象
    '0：姓名，1：性别，2：是VIP，3：非VIP
    Enum SearchMode
        Name = &H0
        Sex = &H1
        isVIP = &H2
        isnotVIP = &H3
    End Enum

    Sub Search(m As SearchMode)
        Select Case m
            Case &H0
                会员信息TableAdapter.FillByName(RMS_DataSet.会员信息, tb_Search.Text)
            Case &H1
                会员信息TableAdapter.FillBySex(RMS_DataSet.会员信息, tb_Search.Text)
            Case &H2
                会员信息TableAdapter.FillByisVIP(RMS_DataSet.会员信息)
            Case &H3
                会员信息TableAdapter.FillByisnotVIP(RMS_DataSet.会员信息)
        End Select
    End Sub

    Private Sub bt_Search_Click(sender As Object, e As EventArgs) Handles bt_Search.Click
        Dim info As SearchMode = SearchMode.Name
        If bt_Search.Text = "查询" Then
            bt_Search.Text = "确定？"
            bt_Search.ForeColor = Color.Red
        Else
            bt_Search.Text = "查询"
            bt_Search.ForeColor = Color.Black
            Try
                If rb_NameSH.Checked Then
                    info = SearchMode.Name
                ElseIf rb_SexSH.Checked Then
                    info = SearchMode.Sex
                ElseIf rb_isVIPSH.Checked Then
                    info = SearchMode.isVIP
                ElseIf rb_isnotVIPSH.Checked Then
                    info = SearchMode.isnotVIP
                End If
                lb_Search.ForeColor = Color.Black
                lb_Search.Visible = True
                Search(info)
                lb_Search.Text = "查询成功"
                bt_Reset.Enabled = True
            Catch ex As Exception
                lb_Search.ForeColor = Color.Red
                lb_Search.Text = "查询失败"
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_Search_Leave(sender As Object, e As EventArgs) Handles bt_Search.Leave
        bt_Search.Text = "查询"
        bt_Search.ForeColor = Color.Black
    End Sub

    Private Sub 雇员信息DataGridView_Click(sender As Object, e As EventArgs) Handles 会员信息DataGridView.Click
        tb_Name.Text = Me.会员信息DataGridView.CurrentRow.Cells(0).Value.ToString
        LB_Sex.SelectedItem = Me.会员信息DataGridView.CurrentRow.Cells(2).Value
        tb_PWD.Text = Me.会员信息DataGridView.CurrentRow.Cells(1).Value.ToString
        Dim isVIP As Boolean = Me.会员信息DataGridView.CurrentRow.Cells(3).Value
        tb_TelePhone.Text = Me.会员信息DataGridView.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        If ErrorDivide() = False Then
            Try
                Dim isVIP As Boolean = False
                If rb_isVIP.Checked Then
                    isVIP = True
                End If
                Dim o_name As String = Me.会员信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_PWD As String = Me.会员信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_Sex As String = Me.会员信息DataGridView.CurrentRow.Cells(2).Value.ToString
                Dim o_isVIP = Me.会员信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_Time = Me.会员信息DataGridView.CurrentRow.Cells(4).Value
                Dim o_TelePhone As String = Me.会员信息DataGridView.CurrentRow.Cells(5).Value.ToString
                Me.会员信息TableAdapter.Update(tb_Name.Text, tb_PWD.Text, LB_Sex.SelectedItem, isVIP, o_Time, tb_TelePhone.Text, o_name, o_PWD, o_Sex, o_isVIP, o_Time, o_TelePhone)
                DGVRefresh()
                MsgBox("编辑成功！")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_Delete_Click(sender As Object, e As EventArgs) Handles bt_Delete.Click
        If ErrorDivide() = False Then
            Try
                Dim isVIP As Boolean = False
                If rb_isVIP.Checked Then
                    isVIP = True
                End If
                Dim o_name As String = Me.会员信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_PWD As String = Me.会员信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_Sex As String = Me.会员信息DataGridView.CurrentRow.Cells(2).Value.ToString
                Dim o_isVIP = Me.会员信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_Time = Me.会员信息DataGridView.CurrentRow.Cells(4).Value
                Dim o_TelePhone As String = Me.会员信息DataGridView.CurrentRow.Cells(5).Value.ToString
                会员信息TableAdapter.Delete(o_name, o_PWD, o_Sex, o_isVIP, o_Time, o_TelePhone)
                DGVRefresh()
                MsgBox("删除成功！")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub bt_Reset_Click(sender As Object, e As EventArgs) Handles bt_Reset.Click
        bt_Reset.Enabled = False
        DGVRefresh()
    End Sub
    Dim flag = 0
    Private Sub tb_Search_Enter(sender As Object, e As EventArgs) Handles tb_Search.Enter
        If flag = 0 Then
            tb_Search.Text = ""
            tb_Search.ForeColor = Color.Black
            flag = 1
        End If
    End Sub

    Private Sub tb_Search_Leave(sender As Object, e As EventArgs) Handles tb_Search.Leave
        If tb_Search.Text = "" Then
            flag = 0
        End If
        If flag = 0 Then
            tb_Search.Text = "输入日期时请按照'9999/99/99'的形式"
            tb_Search.ForeColor = Color.Gray
        End If
    End Sub
End Class