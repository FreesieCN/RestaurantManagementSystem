Imports WindowsApp3.RMS_DataSetTableAdapters

Public Class EmployeeForm

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“RMS_DataSet.雇员信息”中。您可以根据需要移动或移除它。
        Me.雇员信息TableAdapter.Fill(Me.RMS_DataSet.雇员信息)
        tb_Search.Text = "输入日期时请按照'9999/99/99'的形式"
        tb_Search.ForeColor = Color.Gray
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
        If tb_Age.Text = "" Then
            lb_ErrorInfo.Text = "请输入年龄！"
        ElseIf tb_Name.Text = "" Then
            lb_ErrorInfo.Text = "请输入名称！"
        ElseIf tb_Price.Text = "" Then
            lb_ErrorInfo.Text = "请输入薪水！"
        Else
            IsError = False
            lb_ErrorInfo.Visible = False
        End If
        Return IsError
    End Function

    Private Sub DGVRefresh()
        Me.雇员信息TableAdapter.Fill(Me.RMS_DataSet.雇员信息)
        lb_Num.Text = Me.雇员信息TableAdapter.Num().ToString
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
                Me.雇员信息TableAdapter.Insert(tb_Name.Text, LB_Sex.SelectedItem, tb_Age.Text, dt_Birth.Value, tb_Price.Text, tb_Job.Text)
                DGVRefresh()
                MsgBox("添加成功！")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    '标识排序对象
    '0：名称，1：年龄，2：性别，3：年份，4：薪水，5：职位
    Enum SearchMode
        Name = &H0
        Age = &H1
        Sex = &H2
        Year = &H3
        Price = &H4
        Job = &H5
    End Enum

    Sub Search(m As SearchMode)
        Select Case m
            Case &H0
                雇员信息TableAdapter.FillByName(RMS_DataSet.雇员信息, tb_Search.Text)
            Case &H1
                雇员信息TableAdapter.FillByAge(RMS_DataSet.雇员信息, tb_Search.Text)
            Case &H2
                雇员信息TableAdapter.FillBySex(RMS_DataSet.雇员信息, tb_Search.Text)
            Case &H3
                雇员信息TableAdapter.FillByYear(RMS_DataSet.雇员信息, tb_Search.Text)
            Case &H4
                雇员信息TableAdapter.FillByPrice(RMS_DataSet.雇员信息, tb_Search.Text)
            Case &H5
                雇员信息TableAdapter.FillByJob(RMS_DataSet.雇员信息, tb_Search.Text)
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
                ElseIf rb_AgeSH.Checked Then
                    info = SearchMode.Age
                ElseIf rb_YearSH.Checked Then
                    info = SearchMode.Year
                ElseIf rb_HighSH.Checked Then
                    info = SearchMode.Price
                ElseIf rb_JobSH.Checked Then
                    info = SearchMode.Job
                ElseIf rb_SexSH.Checked Then
                    info = SearchMode.Sex
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

    Private Sub 雇员信息DataGridView_Click(sender As Object, e As EventArgs) Handles 雇员信息DataGridView.Click
        tb_Name.Text = Me.雇员信息DataGridView.CurrentRow.Cells(0).Value.ToString
        LB_Sex.SelectedItem = Me.雇员信息DataGridView.CurrentRow.Cells(1).Value
        tb_Age.Text = Me.雇员信息DataGridView.CurrentRow.Cells(2).Value.ToString
        dt_Birth.Value = Me.雇员信息DataGridView.CurrentRow.Cells(3).Value
        tb_Price.Text = Me.雇员信息DataGridView.CurrentRow.Cells(4).Value.ToString
        tb_Job.Text = Me.雇员信息DataGridView.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub bt_Edit_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click
        If ErrorDivide() = False Then
            Try
                Dim o_name As String = Me.雇员信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_sex As String = Me.雇员信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_age As String = Me.雇员信息DataGridView.CurrentRow.Cells(2).Value.ToString
                Dim o_birth = Me.雇员信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_price As String = Me.雇员信息DataGridView.CurrentRow.Cells(4).Value.ToString
                Dim o_job As String = Me.雇员信息DataGridView.CurrentRow.Cells(5).Value.ToString
                Me.雇员信息TableAdapter.Update(tb_Name.Text, LB_Sex.SelectedItem, tb_Age.Text, dt_Birth.Value, tb_Price.Text, tb_Job.Text, o_name, o_sex, o_age, o_birth, o_price, o_job)
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
                Dim o_name As String = Me.雇员信息DataGridView.CurrentRow.Cells(0).Value.ToString
                Dim o_sex As String = Me.雇员信息DataGridView.CurrentRow.Cells(1).Value.ToString
                Dim o_age As String = Me.雇员信息DataGridView.CurrentRow.Cells(2).Value.ToString
                Dim o_birth = Me.雇员信息DataGridView.CurrentRow.Cells(3).Value
                Dim o_price As String = Me.雇员信息DataGridView.CurrentRow.Cells(4).Value.ToString
                Dim o_job As String = Me.雇员信息DataGridView.CurrentRow.Cells(5).Value.ToString
                雇员信息TableAdapter.Delete(o_name, o_sex, o_age, o_birth, o_price, o_job)
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