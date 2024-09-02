<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VIPForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bt_Reset = New System.Windows.Forms.Button()
        Me.bt_Edit = New System.Windows.Forms.Button()
        Me.bt_Delete = New System.Windows.Forms.Button()
        Me.bt_Search = New System.Windows.Forms.Button()
        Me.bt_Add = New System.Windows.Forms.Button()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.会员信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.会员信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.会员信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        Me.雇员信息DataGridView = New System.Windows.Forms.DataGridView()
        Me.姓名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.密码DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.性别DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.是否为VIPDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.注册时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.身份信息DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_PWD = New System.Windows.Forms.TextBox()
        Me.lb_PWD = New System.Windows.Forms.Label()
        Me.LB_Sex = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rb_isVIP = New System.Windows.Forms.RadioButton()
        Me.rb_isnotVIP = New System.Windows.Forms.RadioButton()
        Me.lb_Search = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_IsNotGivenSH = New System.Windows.Forms.RadioButton()
        Me.rb_NumberSH = New System.Windows.Forms.RadioButton()
        Me.rb_IsGivenSH = New System.Windows.Forms.RadioButton()
        Me.rb_NameSH = New System.Windows.Forms.RadioButton()
        Me.lb_ErrorInfo = New System.Windows.Forms.Label()
        CType(Me.会员信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.雇员信息DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_Reset
        '
        Me.bt_Reset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Reset.Enabled = False
        Me.bt_Reset.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Reset.Location = New System.Drawing.Point(490, 167)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(129, 35)
        Me.bt_Reset.TabIndex = 61
        Me.bt_Reset.Text = "还原"
        Me.bt_Reset.UseVisualStyleBackColor = False
        '
        'bt_Edit
        '
        Me.bt_Edit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Edit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Edit.Location = New System.Drawing.Point(490, 67)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(129, 35)
        Me.bt_Edit.TabIndex = 57
        Me.bt_Edit.Text = "编辑"
        Me.bt_Edit.UseVisualStyleBackColor = False
        '
        'bt_Delete
        '
        Me.bt_Delete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Delete.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Delete.Location = New System.Drawing.Point(344, 117)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(129, 35)
        Me.bt_Delete.TabIndex = 56
        Me.bt_Delete.Text = "删除"
        Me.bt_Delete.UseVisualStyleBackColor = False
        '
        'bt_Search
        '
        Me.bt_Search.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Search.Location = New System.Drawing.Point(344, 167)
        Me.bt_Search.Name = "bt_Search"
        Me.bt_Search.Size = New System.Drawing.Size(129, 35)
        Me.bt_Search.TabIndex = 59
        Me.bt_Search.Text = "查询"
        Me.bt_Search.UseVisualStyleBackColor = False
        '
        'bt_Add
        '
        Me.bt_Add.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Add.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Add.Location = New System.Drawing.Point(344, 67)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.Size = New System.Drawing.Size(129, 35)
        Me.bt_Add.TabIndex = 55
        Me.bt_Add.Text = "添加"
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(490, 117)
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.Size = New System.Drawing.Size(129, 35)
        Me.bt_Quit.TabIndex = 58
        Me.bt_Quit.Text = "返回"
        Me.bt_Quit.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Title.Location = New System.Drawing.Point(146, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(347, 47)
        Me.Title.TabIndex = 60
        Me.Title.Text = "会员信息界面"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '会员信息BindingSource
        '
        Me.会员信息BindingSource.DataMember = "会员信息"
        Me.会员信息BindingSource.DataSource = Me.RMS_DataSet
        '
        'RMS_DataSet
        '
        Me.RMS_DataSet.DataSetName = "RMS_DataSet"
        Me.RMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '会员信息TableAdapter
        '
        Me.会员信息TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.会员信息TableAdapter = Me.会员信息TableAdapter
        Me.TableAdapterManager.管理员信息TableAdapter = Nothing
        Me.TableAdapterManager.菜单信息TableAdapter = Nothing
        Me.TableAdapterManager.雇员信息TableAdapter = Nothing
        '
        '雇员信息DataGridView
        '
        Me.雇员信息DataGridView.AllowUserToAddRows = False
        Me.雇员信息DataGridView.AllowUserToDeleteRows = False
        Me.雇员信息DataGridView.AllowUserToResizeColumns = False
        Me.雇员信息DataGridView.AllowUserToResizeRows = False
        Me.雇员信息DataGridView.AutoGenerateColumns = False
        Me.雇员信息DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.雇员信息DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.雇员信息DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.姓名DataGridViewTextBoxColumn, Me.密码DataGridViewTextBoxColumn, Me.性别DataGridViewTextBoxColumn, Me.是否为VIPDataGridViewCheckBoxColumn, Me.注册时间DataGridViewTextBoxColumn, Me.身份信息DataGridViewTextBoxColumn})
        Me.雇员信息DataGridView.DataSource = Me.会员信息BindingSource
        Me.雇员信息DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.雇员信息DataGridView.Location = New System.Drawing.Point(0, 262)
        Me.雇员信息DataGridView.Name = "雇员信息DataGridView"
        Me.雇员信息DataGridView.RowTemplate.Height = 23
        Me.雇员信息DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.雇员信息DataGridView.Size = New System.Drawing.Size(644, 249)
        Me.雇员信息DataGridView.TabIndex = 63
        '
        '姓名DataGridViewTextBoxColumn
        '
        Me.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名"
        Me.姓名DataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn"
        '
        '密码DataGridViewTextBoxColumn
        '
        Me.密码DataGridViewTextBoxColumn.DataPropertyName = "密码"
        Me.密码DataGridViewTextBoxColumn.HeaderText = "密码"
        Me.密码DataGridViewTextBoxColumn.Name = "密码DataGridViewTextBoxColumn"
        '
        '性别DataGridViewTextBoxColumn
        '
        Me.性别DataGridViewTextBoxColumn.DataPropertyName = "性别"
        Me.性别DataGridViewTextBoxColumn.HeaderText = "性别"
        Me.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn"
        '
        '是否为VIPDataGridViewCheckBoxColumn
        '
        Me.是否为VIPDataGridViewCheckBoxColumn.DataPropertyName = "是否为VIP"
        Me.是否为VIPDataGridViewCheckBoxColumn.HeaderText = "是否为VIP"
        Me.是否为VIPDataGridViewCheckBoxColumn.Name = "是否为VIPDataGridViewCheckBoxColumn"
        '
        '注册时间DataGridViewTextBoxColumn
        '
        Me.注册时间DataGridViewTextBoxColumn.DataPropertyName = "注册时间"
        Me.注册时间DataGridViewTextBoxColumn.HeaderText = "注册时间"
        Me.注册时间DataGridViewTextBoxColumn.Name = "注册时间DataGridViewTextBoxColumn"
        '
        '身份信息DataGridViewTextBoxColumn
        '
        Me.身份信息DataGridViewTextBoxColumn.DataPropertyName = "身份信息"
        Me.身份信息DataGridViewTextBoxColumn.HeaderText = "身份信息"
        Me.身份信息DataGridViewTextBoxColumn.Name = "身份信息DataGridViewTextBoxColumn"
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(77, 78)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(107, 21)
        Me.tb_Name.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "姓名："
        '
        'tb_PWD
        '
        Me.tb_PWD.Location = New System.Drawing.Point(77, 105)
        Me.tb_PWD.Name = "tb_PWD"
        Me.tb_PWD.Size = New System.Drawing.Size(214, 21)
        Me.tb_PWD.TabIndex = 66
        '
        'lb_PWD
        '
        Me.lb_PWD.AutoSize = True
        Me.lb_PWD.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_PWD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PWD.Location = New System.Drawing.Point(16, 105)
        Me.lb_PWD.Name = "lb_PWD"
        Me.lb_PWD.Size = New System.Drawing.Size(55, 16)
        Me.lb_PWD.TabIndex = 67
        Me.lb_PWD.Text = "密码："
        '
        'LB_Sex
        '
        Me.LB_Sex.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LB_Sex.FormattingEnabled = True
        Me.LB_Sex.ItemHeight = 16
        Me.LB_Sex.Items.AddRange(New Object() {"男", "女"})
        Me.LB_Sex.Location = New System.Drawing.Point(242, 75)
        Me.LB_Sex.Name = "LB_Sex"
        Me.LB_Sex.Size = New System.Drawing.Size(48, 20)
        Me.LB_Sex.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(190, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "性别："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_isVIP)
        Me.Panel2.Controls.Add(Me.rb_isnotVIP)
        Me.Panel2.Location = New System.Drawing.Point(77, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 20)
        Me.Panel2.TabIndex = 70
        '
        'rb_isVIP
        '
        Me.rb_isVIP.AutoSize = True
        Me.rb_isVIP.Location = New System.Drawing.Point(0, 3)
        Me.rb_isVIP.Name = "rb_isVIP"
        Me.rb_isVIP.Size = New System.Drawing.Size(65, 16)
        Me.rb_isVIP.TabIndex = 16
        Me.rb_isVIP.TabStop = True
        Me.rb_isVIP.Text = "VIP用户"
        Me.rb_isVIP.UseVisualStyleBackColor = True
        '
        'rb_isnotVIP
        '
        Me.rb_isnotVIP.AutoSize = True
        Me.rb_isnotVIP.Location = New System.Drawing.Point(137, 3)
        Me.rb_isnotVIP.Name = "rb_isnotVIP"
        Me.rb_isnotVIP.Size = New System.Drawing.Size(77, 16)
        Me.rb_isnotVIP.TabIndex = 17
        Me.rb_isnotVIP.TabStop = True
        Me.rb_isnotVIP.Text = "非VIP用户"
        Me.rb_isnotVIP.UseVisualStyleBackColor = True
        '
        'lb_Search
        '
        Me.lb_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_Search.Location = New System.Drawing.Point(149, 155)
        Me.lb_Search.Name = "lb_Search"
        Me.lb_Search.Size = New System.Drawing.Size(141, 19)
        Me.lb_Search.TabIndex = 73
        Me.lb_Search.Text = "查询完成"
        Me.lb_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_Search.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "查询框："
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(97, 177)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(194, 21)
        Me.tb_Search.TabIndex = 71
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_IsNotGivenSH)
        Me.Panel1.Controls.Add(Me.rb_NumberSH)
        Me.Panel1.Controls.Add(Me.rb_IsGivenSH)
        Me.Panel1.Controls.Add(Me.rb_NameSH)
        Me.Panel1.Location = New System.Drawing.Point(23, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 19)
        Me.Panel1.TabIndex = 74
        '
        'rb_IsNotGivenSH
        '
        Me.rb_IsNotGivenSH.AutoSize = True
        Me.rb_IsNotGivenSH.Location = New System.Drawing.Point(270, 3)
        Me.rb_IsNotGivenSH.Name = "rb_IsNotGivenSH"
        Me.rb_IsNotGivenSH.Size = New System.Drawing.Size(95, 16)
        Me.rb_IsNotGivenSH.TabIndex = 30
        Me.rb_IsNotGivenSH.TabStop = True
        Me.rb_IsNotGivenSH.Text = "查询不可供应"
        Me.rb_IsNotGivenSH.UseVisualStyleBackColor = True
        '
        'rb_NumberSH
        '
        Me.rb_NumberSH.AutoSize = True
        Me.rb_NumberSH.Location = New System.Drawing.Point(3, 3)
        Me.rb_NumberSH.Name = "rb_NumberSH"
        Me.rb_NumberSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_NumberSH.TabIndex = 27
        Me.rb_NumberSH.TabStop = True
        Me.rb_NumberSH.Text = "按编号查询"
        Me.rb_NumberSH.UseVisualStyleBackColor = True
        '
        'rb_IsGivenSH
        '
        Me.rb_IsGivenSH.AutoSize = True
        Me.rb_IsGivenSH.Location = New System.Drawing.Point(181, 3)
        Me.rb_IsGivenSH.Name = "rb_IsGivenSH"
        Me.rb_IsGivenSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_IsGivenSH.TabIndex = 29
        Me.rb_IsGivenSH.TabStop = True
        Me.rb_IsGivenSH.Text = "查询可供应"
        Me.rb_IsGivenSH.UseVisualStyleBackColor = True
        '
        'rb_NameSH
        '
        Me.rb_NameSH.AutoSize = True
        Me.rb_NameSH.Location = New System.Drawing.Point(92, 3)
        Me.rb_NameSH.Name = "rb_NameSH"
        Me.rb_NameSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_NameSH.TabIndex = 28
        Me.rb_NameSH.TabStop = True
        Me.rb_NameSH.Text = "按名称查询"
        Me.rb_NameSH.UseVisualStyleBackColor = True
        '
        'lb_ErrorInfo
        '
        Me.lb_ErrorInfo.AutoSize = True
        Me.lb_ErrorInfo.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb_ErrorInfo.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo.Location = New System.Drawing.Point(24, 160)
        Me.lb_ErrorInfo.Name = "lb_ErrorInfo"
        Me.lb_ErrorInfo.Size = New System.Drawing.Size(65, 12)
        Me.lb_ErrorInfo.TabIndex = 50
        Me.lb_ErrorInfo.Text = "Error_Info"
        Me.lb_ErrorInfo.Visible = False
        '
        'VIPForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(644, 507)
        Me.Controls.Add(Me.lb_ErrorInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_Search)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Search)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LB_Sex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_PWD)
        Me.Controls.Add(Me.lb_PWD)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.雇员信息DataGridView)
        Me.Controls.Add(Me.bt_Reset)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Search)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.bt_Quit)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VIPForm"
        Me.Text = "VIPForm"
        CType(Me.会员信息BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.雇员信息DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_Reset As Button
    Friend WithEvents bt_Edit As Button
    Friend WithEvents bt_Delete As Button
    Friend WithEvents bt_Search As Button
    Friend WithEvents bt_Add As Button
    Friend WithEvents bt_Quit As Button
    Friend WithEvents Title As Label
    Friend WithEvents RMS_DataSet As RMS_DataSet
    Friend WithEvents 会员信息BindingSource As BindingSource
    Friend WithEvents 会员信息TableAdapter As RMS_DataSetTableAdapters.会员信息TableAdapter
    Friend WithEvents TableAdapterManager As RMS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 雇员信息DataGridView As DataGridView
    Friend WithEvents 姓名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 密码DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 性别DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 是否为VIPDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents 注册时间DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 身份信息DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_PWD As TextBox
    Friend WithEvents lb_PWD As Label
    Friend WithEvents LB_Sex As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rb_isVIP As RadioButton
    Friend WithEvents rb_isnotVIP As RadioButton
    Friend WithEvents lb_Search As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb_IsNotGivenSH As RadioButton
    Friend WithEvents rb_NumberSH As RadioButton
    Friend WithEvents rb_IsGivenSH As RadioButton
    Friend WithEvents rb_NameSH As RadioButton
    Friend WithEvents lb_ErrorInfo As Label
End Class
