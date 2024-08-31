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
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.菜单信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.菜单信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.菜单信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        Me.菜单信息DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.bt_Add = New System.Windows.Forms.Button()
        Me.bt_Search = New System.Windows.Forms.Button()
        Me.bt_Delete = New System.Windows.Forms.Button()
        Me.bt_Edit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.rb_isGiven = New System.Windows.Forms.RadioButton()
        Me.rb_isnotGiven = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.菜单信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.菜单信息DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RMS_DataSet
        '
        Me.RMS_DataSet.DataSetName = "RMS_DataSet"
        Me.RMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '菜单信息BindingSource
        '
        Me.菜单信息BindingSource.DataMember = "菜单信息"
        Me.菜单信息BindingSource.DataSource = Me.RMS_DataSet
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
        '菜单信息DataGridView
        '
        Me.菜单信息DataGridView.AutoGenerateColumns = False
        Me.菜单信息DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.菜单信息DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
        Me.菜单信息DataGridView.DataSource = Me.菜单信息BindingSource
        Me.菜单信息DataGridView.Location = New System.Drawing.Point(-2, 154)
        Me.菜单信息DataGridView.Name = "菜单信息DataGridView"
        Me.菜单信息DataGridView.RowTemplate.Height = 23
        Me.菜单信息DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.菜单信息DataGridView.Size = New System.Drawing.Size(543, 220)
        Me.菜单信息DataGridView.TabIndex = 8
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
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(429, 98)
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
        Me.bt_Add.TabIndex = 9
        Me.bt_Add.Text = "添加"
        Me.bt_Add.UseVisualStyleBackColor = False
        '
        'bt_Search
        '
        Me.bt_Search.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Search.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Search.Location = New System.Drawing.Point(332, 98)
        Me.bt_Search.Name = "bt_Search"
        Me.bt_Search.Size = New System.Drawing.Size(90, 35)
        Me.bt_Search.TabIndex = 10
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
        Me.bt_Delete.TabIndex = 11
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
        Me.bt_Edit.TabIndex = 12
        Me.bt_Edit.Text = "编辑"
        Me.bt_Edit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 21)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(72, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 21)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(72, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 21)
        Me.TextBox3.TabIndex = 15
        '
        'rb_isGiven
        '
        Me.rb_isGiven.AutoSize = True
        Me.rb_isGiven.Location = New System.Drawing.Point(14, 135)
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
        Me.rb_isnotGiven.Location = New System.Drawing.Point(115, 135)
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
        Me.Label4.Location = New System.Drawing.Point(429, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "总菜品数量："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(451, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "1"
        '
        'ListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 375)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rb_isnotGiven)
        Me.Controls.Add(Me.rb_isGiven)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.bt_Delete)
        Me.Controls.Add(Me.bt_Search)
        Me.Controls.Add(Me.bt_Add)
        Me.Controls.Add(Me.菜单信息DataGridView)
        Me.Controls.Add(Me.bt_Quit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListForm"
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.菜单信息BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.菜单信息DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents rb_isGiven As RadioButton
    Friend WithEvents rb_isnotGiven As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
