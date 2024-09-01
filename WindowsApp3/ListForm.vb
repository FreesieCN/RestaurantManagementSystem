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
        rb_isGiven.Checked = True
        rb_NumberSH.Checked = True
        DGVRefresh()
    End Sub

    Private Sub DGVRefresh()
        Me.菜单信息TableAdapter.Fill(Me.RMS_DataSet.菜单信息)
        lb_Num.Text = Me.菜单信息TableAdapter.Num().ToString
    End Sub

    Private Sub bt_Quit_Leave(sender As Object, e As EventArgs) Handles bt_Quit.Leave
        If bt_Quit.Text = "确定？" Then
            bt_Quit.Text = "返回"
            bt_Quit.ForeColor = Color.Black
        End If
    End Sub

    Function VIPPrice(p As Double)
        Return p * 0.8
    End Function

    Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
        If ErrorDivide() = False Then
            Try
                Dim VIP_Price As Double = VIPPrice(tb_Price.Text)
                Dim IsGiven As Boolean = False
                If rb_isGiven.Checked Then
                    IsGiven = True
                End If
                Me.菜单信息TableAdapter.Insert(tb_Number.Text, tb_Name.Text, tb_Price.Text, VIP_Price, IsGiven)
                DGVRefresh()
                MsgBox("添加成功！")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    '标识排序对象
    '0：名称，1：编号，2：可供应，3：不可供应
    Enum SearchMode
        Name = &H0
        Number = &H1
        IsGiven = &H2
        IsNotGiven = &H3
    End Enum

    Sub Search(m As SearchMode)
        Select Case m
            Case &H0
                菜单信息TableAdapter.FillByName(RMS_DataSet.菜单信息, tb_Search.Text)
            Case &H1
                菜单信息TableAdapter.FillByNumber(RMS_DataSet.菜单信息, tb_Search.Text)
            Case &H2
                菜单信息TableAdapter.FillByIsGiven(RMS_DataSet.菜单信息)
            Case &H3
                菜单信息TableAdapter.FillByIsNotGiven(RMS_DataSet.菜单信息)
        End Select
    End Sub

    Private Sub bt_Search_Click(sender As Object, e As EventArgs) Handles bt_Search.Click
        Dim info As SearchMode = SearchMode.Number
        If bt_Search.Text = "查询" Then
            bt_Search.Text = "确定？"
            bt_Search.ForeColor = Color.Red
        Else
            bt_Search.Text = "查询"
            bt_Search.ForeColor = Color.Black
            Try
                If rb_NameSH.Checked Then
                    info = SearchMode.Name
                ElseIf rb_NumberSH.Checked Then
                    info = SearchMode.Number
                ElseIf rb_IsGivenSH.Checked Then
                    info = SearchMode.IsGiven
                ElseIf rb_isnotGivenSH.Checked Then
                    info = SearchMode.IsNotGiven
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

    Private Sub 菜单信息DataGridView_Click(sender As Object, e As EventArgs) Handles 菜单信息DataGridView.Click
        tb_Number.Text = Me.菜单信息DataGridView.CurrentRow.Cells(0).Value.ToString
        tb_Name.Text = Me.菜单信息DataGridView.CurrentRow.Cells(1).Value.ToString
        tb_Price.Text = Me.菜单信息DataGridView.CurrentRow.Cells(2).Value.ToString
        If Me.菜单信息DataGridView.CurrentRow.Cells(4).Value = True Then
            rb_isGiven.Checked = True
        Else
            rb_isnotGiven.Checked = True
        End If
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        If ErrorDivide() = False Then
            Try
                Dim o_num As String = Me.菜单信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_name As String = Me.菜单信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_price As Double = Me.菜单信息DataGridView.CurrentRow.Cells(2).Value
                Dim o_VIPPrice As Double = Me.菜单信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_IsGiven As Boolean = Me.菜单信息DataGridView.CurrentRow.Cells(4).Value
                Dim VIP_Price As Double = VIPPrice(tb_Price.Text)
                Dim IsGiven As Boolean = False
                If rb_isGiven.Checked Then
                    IsGiven = True
                End If
                Me.菜单信息TableAdapter.Update(tb_Number.Text, tb_Name.Text, tb_Price.Text, VIP_Price, IsGiven, o_num, o_name, o_price, o_VIPPrice, o_IsGiven)
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
                Dim o_num As String = Me.菜单信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_name As String = Me.菜单信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_price As Double = Me.菜单信息DataGridView.CurrentRow.Cells(2).Value
                Dim o_VIPPrice As Double = Me.菜单信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_IsGiven As Boolean = Me.菜单信息DataGridView.CurrentRow.Cells(4).Value
                菜单信息TableAdapter.Delete(o_num, o_name, o_price, o_VIPPrice, o_IsGiven)
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

End Class