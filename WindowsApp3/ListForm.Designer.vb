<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.菜单信息DataGridView = New System.Windows.Forms.DataGridView()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.bt_Add = New System.Windows.Forms.Button()
        Me.bt_Search = New System.Windows.Forms.Button()
        Me.bt_Delete = New System.Windows.Forms.Button()
        Me.bt_Edit = New System.Windows.Forms.Button()
        Me.tb_Number = New System.Windows.Forms.TextBox()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.tb_Price = New System.Windows.Forms.TextBox()
        Me.rb_isGiven = New System.Windows.Forms.RadioButton()
        Me.rb_isnotGiven = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_Num = New System.Windows.Forms.Label()
        Me.lb_ErrorInfo = New System.Windows.Forms.Label()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rb_NumberSH = New System.Windows.Forms.RadioButton()
        Me.rb_NameSH = New System.Windows.Forms.RadioButton()
        Me.rb_PriceSH = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lb_Search = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.菜单信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.菜单信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.菜单信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        CType(Me.菜单信息DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.菜单信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '菜单信息DataGridView
        '
        Me.菜单信息DataGridView.AllowUserToAddRows = False
        Me.菜单信息DataGridView.AllowUserToDeleteRows = False
        Me.菜单信息DataGridView.AllowUserToResizeColumns = False
        Me.菜单信息DataGridView.AllowUserToResizeRows = False
        Me.菜单信息DataGridView.AutoGenerateColumns = False
        Me.菜单信息DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.菜单信息DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.菜单信息DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        Me.菜单信息DataGridView.DataSource = Me.菜单信息BindingSource
        Me.菜单信息DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.菜单信息DataGridView.Location = New System.Drawing.Point(-2, 206)
        Me.菜单信息DataGridView.Name = "菜单信息DataGridView"
        Me.菜单信息DataGridView.RowTemplate.Height = 23
        Me.菜单信息DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.菜单信息DataGridView.Size = New System.Drawing.Size(543, 258)
        Me.菜单信息DataGridView.TabIndex = 8
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(332, 98)
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.Size = New System.Drawing.Size(90, 35)
        Me.bt_Quit.TabIndex = 7
        Me.bt_Quit.Text = "返回"
        Me.bt_Quit.UseVisualStyleBackColor = False
        '
        'bt_Add
        '
        Me.bt_Add.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Add.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Add.Location = New System.Drawing.Point(225, 53)
        Me.bt_Add.Name = "bt_Add"
        Me.bt_Add.Size = New System.Drawing.Size(90, 35)
        Me.bt_Add.TabIndex = 3
        Me.bt_Add.Text = "添加"
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'bt_Search
        '
        Me.bt_Search.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Search.Location = New System.Drawing.Point(384, 150)
        Me.bt_Search.Name = "bt_Search"
        Me.bt_Search.Size = New System.Drawing.Size(141, 31)
        Me.bt_Search.TabIndex = 6
        Me.bt_Search.Text = "查询"
        Me.bt_Search.UseVisualStyleBackColor = False
        '
        'bt_Delete
        '
        Me.bt_Delete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Delete.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Delete.Location = New System.Drawing.Point(225, 98)
        Me.bt_Delete.Name = "bt_Delete"
        Me.bt_Delete.Size = New System.Drawing.Size(90, 35)
        Me.bt_Delete.TabIndex = 4
        Me.bt_Delete.Text = "删除"
        Me.bt_Delete.UseVisualStyleBackColor = False
        '
        'bt_Edit
        '
        Me.bt_Edit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Edit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Edit.Location = New System.Drawing.Point(332, 53)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(90, 35)
        Me.bt_Edit.TabIndex = 5
        Me.bt_Edit.Text = "编辑"
        Me.bt_Edit.UseVisualStyleBackColor = False
        '
        'tb_Number
        '
        Me.tb_Number.Location = New System.Drawing.Point(72, 54)
        Me.tb_Number.Name = "tb_Number"
        Me.tb_Number.Size = New System.Drawing.Size(126, 21)
        Me.tb_Number.TabIndex = 0
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(72, 80)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(126, 21)
        Me.tb_Name.TabIndex = 1
        '
        'tb_Price
        '
        Me.tb_Price.Location = New System.Drawing.Point(72, 108)
        Me.tb_Price.Name = "tb_Price"
        Me.tb_Price.Size = New System.Drawing.Size(126, 21)
        Me.tb_Price.TabIndex = 2
        '
        'rb_isGiven
        '
        Me.rb_isGiven.AutoSize = True
        Me.rb_isGiven.Location = New System.Drawing.Point(0, 1)
        Me.rb_isGiven.Name = "rb_isGiven"
        Me.rb_isGiven.Size = New System.Drawing.Size(71, 16)
        Me.rb_isGiven.TabIndex = 16
        Me.rb_isGiven.TabStop = True
        Me.rb_isGiven.Text = "现可供应"
        Me.rb_isGiven.UseVisualStyleBackColor = True
        '
        'rb_isnotGiven
        '
        Me.rb_isnotGiven.AutoSize = True
        Me.rb_isnotGiven.Location = New System.Drawing.Point(101, 1)
        Me.rb_isnotGiven.Name = "rb_isnotGiven"
        Me.rb_isnotGiven.Size = New System.Drawing.Size(83, 16)
        Me.rb_isnotGiven.TabIndex = 17
        Me.rb_isnotGiven.TabStop = True
        Me.rb_isnotGiven.Text = "现不可供应"
        Me.rb_isnotGiven.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "编号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "名称："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "价格："
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Title.Location = New System.Drawing.Point(97, 3)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(347, 47)
        Me.Title.TabIndex = 21
        Me.Title.Text = "菜单编辑界面"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "总菜品数量："
        '
        'lb_Num
        '
        Me.lb_Num.AutoSize = True
        Me.lb_Num.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_Num.Location = New System.Drawing.Point(458, 91)
        Me.lb_Num.Name = "lb_Num"
        Me.lb_Num.Size = New System.Drawing.Size(15, 16)
        Me.lb_Num.TabIndex = 23
        Me.lb_Num.Text = "1"
        '
        'lb_ErrorInfo
        '
        Me.lb_ErrorInfo.AutoSize = True
        Me.lb_ErrorInfo.Font = New System.Drawing.Font("黑体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb_ErrorInfo.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo.Location = New System.Drawing.Point(223, 139)
        Me.lb_ErrorInfo.Name = "lb_ErrorInfo"
        Me.lb_ErrorInfo.Size = New System.Drawing.Size(65, 12)
        Me.lb_ErrorInfo.TabIndex = 24
        Me.lb_ErrorInfo.Text = "Error_Info"
        Me.lb_ErrorInfo.Visible = False
        '
        'tb_Search
        '
        Me.tb_Search.Location = New System.Drawing.Point(90, 162)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(267, 21)
        Me.tb_Search.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "查询框："
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
        'rb_NameSH
        '
        Me.rb_NameSH.AutoSize = True
        Me.rb_NameSH.Location = New System.Drawing.Point(128, 3)
        Me.rb_NameSH.Name = "rb_NameSH"
        Me.rb_NameSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_NameSH.TabIndex = 28
        Me.rb_NameSH.TabStop = True
        Me.rb_NameSH.Text = "按名称查询"
        Me.rb_NameSH.UseVisualStyleBackColor = True
        '
        'rb_PriceSH
        '
        Me.rb_PriceSH.AutoSize = True
        Me.rb_PriceSH.Location = New System.Drawing.Point(256, 3)
        Me.rb_PriceSH.Name = "rb_PriceSH"
        Me.rb_PriceSH.Size = New System.Drawing.Size(83, 16)
        Me.rb_PriceSH.TabIndex = 29
        Me.rb_PriceSH.TabStop = True
        Me.rb_PriceSH.Text = "按价格查询"
        Me.rb_PriceSH.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rb_NumberSH)
        Me.Panel1.Controls.Add(Me.rb_PriceSH)
        Me.Panel1.Controls.Add(Me.rb_NameSH)
        Me.Panel1.Location = New System.Drawing.Point(14, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 19)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rb_isGiven)
        Me.Panel2.Controls.Add(Me.rb_isnotGiven)
        Me.Panel2.Location = New System.Drawing.Point(14, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 20)
        Me.Panel2.TabIndex = 31
        '
        'lb_Search
        '
        Me.lb_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_Search.Location = New System.Drawing.Point(384, 184)
        Me.lb_Search.Name = "lb_Search"
        Me.lb_Search.Size = New System.Drawing.Size(141, 19)
        Me.lb_Search.TabIndex = 32
        Me.lb_Search.Text = "查询完成"
        Me.lb_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_Search.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "编号"
        Me.DataGridViewTextBoxColumn1.HeaderText = "编号"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "名称"
        Me.DataGridViewTextBoxColumn2.HeaderText = "名称"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "价格"
        Me.DataGridViewTextBoxColumn3.HeaderText = "价格"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VIP价格"
        Me.DataGridViewTextBoxColumn4.HeaderText = "VIP价格"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "现可供应"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "现可供应"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        '菜单信息BindingSource
        '
        Me.菜单信息BindingSource.DataMember = "菜单信息"
        Me.菜单信息BindingSource.DataSource = Me.RMS_DataSet
        '
        'RMS_DataSet
        '
        Me.RMS_DataSet.DataSetName = "RMS_DataSet"
        Me.RMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '菜单信息TableAdapter
        '
        Me.菜单信息TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.会员信息TableAdapter = Nothing
        Me.TableAdapterManager.管理员信息TableAdapter = Nothing
        Me.TableAdapterManager.菜单信息TableAdapter = Me.菜单信息TableAdapter
        Me.TableAdapterManager.雇员信息TableAdapter = Nothing
        '
        'ListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 465)
        Me.Controls.Add(Me.lb_Search)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_Search)
        Me.Controls.Add(Me.lb_ErrorInfo)
        Me.Controls.Add(Me.lb_Num)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Price)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.tb_Number)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Search)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.菜单信息DataGridView)
        Me.Controls.Add(Me.bt_Quit)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListForm"
        CType(Me.菜单信息DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.菜单信息BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RMS_DataSet As RMS_DataSet
    Friend WithEvents 菜单信息BindingSource As BindingSource
    Friend WithEvents 菜单信息TableAdapter As RMS_DataSetTableAdapters.菜单信息TableAdapter
    Friend WithEvents TableAdapterManager As RMS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 菜单信息DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents bt_Quit As Button
    Friend WithEvents bt_Add As Button
    Friend WithEvents bt_Search As Button
    Friend WithEvents bt_Delete As Button
    Friend WithEvents bt_Edit As Button
    Friend WithEvents tb_Number As TextBox
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents tb_Price As TextBox
    Friend WithEvents rb_isGiven As RadioButton
    Friend WithEvents rb_isnotGiven As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_Num As Label
    Friend WithEvents lb_ErrorInfo As Label
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rb_NumberSH As RadioButton
    Friend WithEvents rb_NameSH As RadioButton
    Friend WithEvents rb_PriceSH As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lb_Search As Label
End Class
