<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm
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
        Me.lb_Search = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_JobSH = New System.Windows.Forms.RadioButton()
        Me.rb_HighSH = New System.Windows.Forms.RadioButton()
        Me.rb_YearSH = New System.Windows.Forms.RadioButton()
        Me.rb_AgeSH = New System.Windows.Forms.RadioButton()
        Me.rb_SexSH = New System.Windows.Forms.RadioButton()
        Me.rb_NameSH = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.lb_ErrorInfo = New System.Windows.Forms.Label()
        Me.lb_Num = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Price = New System.Windows.Forms.TextBox()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.bt_Edit = New System.Windows.Forms.Button()
        Me.bt_Delete = New System.Windows.Forms.Button()
        Me.bt_Search = New System.Windows.Forms.Button()
        Me.bt_Add = New System.Windows.Forms.Button()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.雇员信息DataGridView = New System.Windows.Forms.DataGridView()
        Me.名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.性别DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.年龄DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出生日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.薪水DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.职位DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.雇员信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Age = New System.Windows.Forms.TextBox()
        Me.LB_Sex = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dt_Birth = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Job = New System.Windows.Forms.TextBox()
        Me.雇员信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.雇员信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.雇员信息DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.雇员信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_Reset
        '
        Me.bt_Reset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Reset.Enabled = False
        Me.bt_Reset.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Reset.Location = New System.Drawing.Point(468, 160)
        Me.bt_Reset.Name = "bt_Reset"
        Me.bt_Reset.Size = New System.Drawing.Size(129, 35)
        Me.bt_Reset.TabIndex = 54
        Me.bt_Reset.Text = "还原"
        Me.bt_Reset.UseVisualStyleBackColor = False
        '
        'lb_Search
        '
        Me.lb_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_Search.Location = New System.Drawing.Point(258, 198)
        Me.lb_Search.Name = "lb_Search"
        Me.lb_Search.Size = New System.Drawing.Size(141, 19)
        Me.lb_Search.TabIndex = 53
        Me.lb_Search.Text = "查询完成"
        Me.lb_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_Search.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_JobSH)
        Me.Panel1.Controls.Add(Me.rb_HighSH)
        Me.Panel1.Controls.Add(Me.rb_YearSH)
        Me.Panel1.Controls.Add(Me.rb_AgeSH)
        Me.Panel1.Controls.Add(Me.rb_SexSH)
        Me.Panel1.Controls.Add(Me.rb_NameSH)
        Me.Panel1.Location = New System.Drawing.Point(16, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 19)
        Me.Panel1.TabIndex = 51
        '
        'rb_JobSH
        '
        Me.rb_JobSH.AutoSize = True
        Me.rb_JobSH.Location = New System.Drawing.Point(514, 3)
        Me.rb_JobSH.Name = "rb_JobSH"
        Me.rb_JobSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_JobSH.TabIndex = 32
        Me.rb_JobSH.TabStop = True
        Me.rb_JobSH.Text = "按职位查询"
        Me.rb_JobSH.UseVisualStyleBackColor = True
        '
        'rb_HighSH
        '
        Me.rb_HighSH.AutoSize = True
        Me.rb_HighSH.Location = New System.Drawing.Point(401, 3)
        Me.rb_HighSH.Name = "rb_HighSH"
        Me.rb_HighSH.Size = New System.Drawing.Size(101, 16)
        Me.rb_HighSH.TabIndex = 31
        Me.rb_HighSH.TabStop = True
        Me.rb_HighSH.Text = "查询薪水高于*"
        Me.rb_HighSH.UseVisualStyleBackColor = True
        '
        'rb_YearSH
        '
        Me.rb_YearSH.AutoSize = True
        Me.rb_YearSH.Location = New System.Drawing.Point(288, 3)
        Me.rb_YearSH.Name = "rb_YearSH"
        Me.rb_YearSH.Size = New System.Drawing.Size(101, 16)
        Me.rb_YearSH.TabIndex = 30
        Me.rb_YearSH.TabStop = True
        Me.rb_YearSH.Text = "查询*年及以后"
        Me.rb_YearSH.UseVisualStyleBackColor = True
        '
        'rb_AgeSH
        '
        Me.rb_AgeSH.AutoSize = True
        Me.rb_AgeSH.Location = New System.Drawing.Point(3, 3)
        Me.rb_AgeSH.Name = "rb_AgeSH"
        Me.rb_AgeSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_AgeSH.TabIndex = 27
        Me.rb_AgeSH.TabStop = True
        Me.rb_AgeSH.Text = "按年龄查询"
        Me.rb_AgeSH.UseVisualStyleBackColor = True
        '
        'rb_SexSH
        '
        Me.rb_SexSH.AutoSize = True
        Me.rb_SexSH.Location = New System.Drawing.Point(193, 3)
        Me.rb_SexSH.Name = "rb_SexSH"
        Me.rb_SexSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_SexSH.TabIndex = 29
        Me.rb_SexSH.TabStop = True
        Me.rb_SexSH.Text = "按性别查询"
        Me.rb_SexSH.UseVisualStyleBackColor = True
        '
        'rb_NameSH
        '
        Me.rb_NameSH.AutoSize = True
        Me.rb_NameSH.Location = New System.Drawing.Point(98, 3)
        Me.rb_NameSH.Name = "rb_NameSH"
        Me.rb_NameSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_NameSH.TabIndex = 28
        Me.rb_NameSH.TabStop = True
        Me.rb_NameSH.Text = "按名称查询"
        Me.rb_NameSH.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(15, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "查询框："
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(92, 220)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(530, 21)
        Me.tb_Search.TabIndex = 41
        '
        'lb_ErrorInfo
        '
        Me.lb_ErrorInfo.AutoSize = True
        Me.lb_ErrorInfo.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb_ErrorInfo.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo.Location = New System.Drawing.Point(16, 183)
        Me.lb_ErrorInfo.Name = "lb_ErrorInfo"
        Me.lb_ErrorInfo.Size = New System.Drawing.Size(65, 12)
        Me.lb_ErrorInfo.TabIndex = 49
        Me.lb_ErrorInfo.Text = "Error_Info"
        Me.lb_ErrorInfo.Visible = False
        '
        'lb_Num
        '
        Me.lb_Num.AutoSize = True
        Me.lb_Num.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_Num.Location = New System.Drawing.Point(100, 37)
        Me.lb_Num.Name = "lb_Num"
        Me.lb_Num.Size = New System.Drawing.Size(15, 16)
        Me.lb_Num.TabIndex = 48
        Me.lb_Num.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "总雇员数量："
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Title.Location = New System.Drawing.Point(141, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(347, 47)
        Me.Title.TabIndex = 46
        Me.Title.Text = "雇员管理界面"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(15, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "薪水："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(145, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "名称："
        '
        'tb_Price
        '
        Me.tb_Price.Location = New System.Drawing.Point(64, 119)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.Size = New System.Drawing.Size(245, 21)
        Me.tb_Price.TabIndex = 36
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(189, 65)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(120, 21)
        Me.tb_Name.TabIndex = 35
        '
        'bt_Edit
        '
        Me.bt_Edit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Edit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Edit.Location = New System.Drawing.Point(468, 60)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(129, 35)
        Me.bt_Edit.TabIndex = 39
        Me.bt_Edit.Text = "编辑"
        Me.bt_Edit.UseVisualStyleBackColor = False
        '
        'bt_Delete
        '
        Me.bt_Delete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Delete.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Delete.Location = New System.Drawing.Point(322, 110)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(129, 35)
        Me.bt_Delete.TabIndex = 38
        Me.bt_Delete.Text = "删除"
        Me.bt_Delete.UseVisualStyleBackColor = False
        '
        'bt_Search
        '
        Me.bt_Search.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Search.Location = New System.Drawing.Point(322, 160)
        Me.bt_Search.Name = "bt_Search"
        Me.bt_Search.Size = New System.Drawing.Size(129, 35)
        Me.bt_Search.TabIndex = 42
        Me.bt_Search.Text = "查询"
        Me.bt_Search.UseVisualStyleBackColor = False
        '
        'bt_Add
        '
        Me.bt_Add.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Add.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Add.Location = New System.Drawing.Point(322, 60)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.Size = New System.Drawing.Size(129, 35)
        Me.bt_Add.TabIndex = 37
        Me.bt_Add.Text = "添加"
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(468, 110)
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.Size = New System.Drawing.Size(129, 35)
        Me.bt_Quit.TabIndex = 40
        Me.bt_Quit.Text = "返回"
        Me.bt_Quit.UseVisualStyleBackColor = False
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
        Me.雇员信息DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.名称DataGridViewTextBoxColumn, Me.性别DataGridViewTextBoxColumn, Me.年龄DataGridViewTextBoxColumn, Me.出生日期DataGridViewTextBoxColumn, Me.薪水DataGridViewTextBoxColumn, Me.职位DataGridViewTextBoxColumn})
        Me.雇员信息DataGridView.DataSource = Me.雇员信息BindingSource
        Me.雇员信息DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.雇员信息DataGridView.Location = New System.Drawing.Point(0, 264)
        Me.雇员信息DataGridView.Name = "雇员信息DataGridView"
        Me.雇员信息DataGridView.RowTemplate.Height = 23
        Me.雇员信息DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.雇员信息DataGridView.Size = New System.Drawing.Size(644, 249)
        Me.雇员信息DataGridView.TabIndex = 55
        '
        '名称DataGridViewTextBoxColumn
        '
        Me.名称DataGridViewTextBoxColumn.DataPropertyName = "名称"
        Me.名称DataGridViewTextBoxColumn.HeaderText = "名称"
        Me.名称DataGridViewTextBoxColumn.Name = "名称DataGridViewTextBoxColumn"
        '
        '性别DataGridViewTextBoxColumn
        '
        Me.性别DataGridViewTextBoxColumn.DataPropertyName = "性别"
        Me.性别DataGridViewTextBoxColumn.HeaderText = "性别"
        Me.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn"
        '
        '年龄DataGridViewTextBoxColumn
        '
        Me.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄"
        Me.年龄DataGridViewTextBoxColumn.HeaderText = "年龄"
        Me.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn"
        '
        '出生日期DataGridViewTextBoxColumn
        '
        Me.出生日期DataGridViewTextBoxColumn.DataPropertyName = "出生日期"
        Me.出生日期DataGridViewTextBoxColumn.HeaderText = "出生日期"
        Me.出生日期DataGridViewTextBoxColumn.Name = "出生日期DataGridViewTextBoxColumn"
        '
        '薪水DataGridViewTextBoxColumn
        '
        Me.薪水DataGridViewTextBoxColumn.DataPropertyName = "薪水"
        Me.薪水DataGridViewTextBoxColumn.HeaderText = "薪水"
        Me.薪水DataGridViewTextBoxColumn.Name = "薪水DataGridViewTextBoxColumn"
        '
        '职位DataGridViewTextBoxColumn
        '
        Me.职位DataGridViewTextBoxColumn.DataPropertyName = "职位"
        Me.职位DataGridViewTextBoxColumn.HeaderText = "职位"
        Me.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn"
        '
        '雇员信息BindingSource
        '
        Me.雇员信息BindingSource.DataMember = "雇员信息"
        Me.雇员信息BindingSource.DataSource = Me.RMS_DataSet
        '
        'RMS_DataSet
        '
        Me.RMS_DataSet.DataSetName = "RMS_DataSet"
        Me.RMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "年龄："
        '
        'tb_Age
        '
        Me.tb_Age.Location = New System.Drawing.Point(64, 65)
        Me.tb_Age.Name = "tb_Age"
        Me.tb_Age.Size = New System.Drawing.Size(75, 21)
        Me.tb_Age.TabIndex = 34
        '
        'LB_Sex
        '
        Me.LB_Sex.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.LB_Sex.FormattingEnabled = True
        Me.LB_Sex.ItemHeight = 16
        Me.LB_Sex.Items.AddRange(New Object() {"男", "女"})
        Me.LB_Sex.Location = New System.Drawing.Point(261, 149)
        Me.LB_Sex.Name = "LB_Sex"
        Me.LB_Sex.Size = New System.Drawing.Size(48, 20)
        Me.LB_Sex.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(209, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "性别："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(13, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "出生日期："
        '
        'dt_Birth
        '
        Me.dt_Birth.Location = New System.Drawing.Point(92, 150)
        Me.dt_Birth.Name = "dt_Birth"
        Me.dt_Birth.Size = New System.Drawing.Size(111, 21)
        Me.dt_Birth.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(13, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "职位："
        '
        'tb_Job
        '
        Me.tb_Job.Location = New System.Drawing.Point(64, 92)
        Me.tb_Job.Name = "tb_Job"
        Me.tb_Job.Size = New System.Drawing.Size(245, 21)
        Me.tb_Job.TabIndex = 61
        '
        '雇员信息TableAdapter
        '
        Me.雇员信息TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.会员信息TableAdapter = Nothing
        Me.TableAdapterManager.管理员信息TableAdapter = Nothing
        Me.TableAdapterManager.菜单信息TableAdapter = Nothing
        Me.TableAdapterManager.雇员信息TableAdapter = Me.雇员信息TableAdapter
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(641, 513)
        Me.Controls.Add(Me.tb_Job)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dt_Birth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LB_Sex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_Price)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.tb_Age)
        Me.Controls.Add(Me.雇员信息DataGridView)
        Me.Controls.Add(Me.bt_Reset)
        Me.Controls.Add(Me.lb_Search)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Search)
        Me.Controls.Add(Me.lb_ErrorInfo)
        Me.Controls.Add(Me.lb_Num)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Search)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.bt_Quit)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.雇员信息DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.雇员信息BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RMS_DataSet As RMS_DataSet
    Friend WithEvents 雇员信息BindingSource As BindingSource
    Friend WithEvents 雇员信息TableAdapter As RMS_DataSetTableAdapters.雇员信息TableAdapter
    Friend WithEvents TableAdapterManager As RMS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents bt_Reset As Button
    Friend WithEvents lb_Search As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb_YearSH As RadioButton
    Friend WithEvents rb_AgeSH As RadioButton
    Friend WithEvents rb_SexSH As RadioButton
    Friend WithEvents rb_NameSH As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents lb_ErrorInfo As Label
    Friend WithEvents lb_Num As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_Price As TextBox
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents bt_Edit As Button
    Friend WithEvents bt_Delete As Button
    Friend WithEvents bt_Search As Button
    Friend WithEvents bt_Add As Button
    Friend WithEvents bt_Quit As Button
    Friend WithEvents 雇员信息DataGridView As DataGridView
    Friend WithEvents rb_HighSH As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Age As TextBox
    Friend WithEvents LB_Sex As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dt_Birth As DateTimePicker
    Friend WithEvents 名称DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 性别DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 年龄DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 出生日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 薪水DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 职位DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents rb_JobSH As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_Job As TextBox
End Class
