<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.bt_Login = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.lb_PWD = New System.Windows.Forms.Label()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.tb_UserName = New System.Windows.Forms.TextBox()
        Me.tb_PWD = New System.Windows.Forms.TextBox()
        Me.lb_ErrorInfo_0 = New System.Windows.Forms.Label()
        Me.lb_ErrorInfo_1 = New System.Windows.Forms.Label()
        Me.lb_ErrorInfo_2 = New System.Windows.Forms.Label()
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.管理员信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.管理员信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.管理员信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.管理员信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_Login
        '
        Me.bt_Login.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Login.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Login.Location = New System.Drawing.Point(22, 141)
        Me.bt_Login.Name = "bt_Login"
        Me.bt_Login.Size = New System.Drawing.Size(111, 30)
        Me.bt_Login.TabIndex = 2
        Me.bt_Login.Text = "登录"
        Me.bt_Login.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Title.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(334, 48)
        Me.Title.TabIndex = 1
        Me.Title.Text = "登录界面"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UserName.Location = New System.Drawing.Point(19, 51)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(71, 16)
        Me.UserName.TabIndex = 2
        Me.UserName.Text = "用户名："
        '
        'lb_PWD
        '
        Me.lb_PWD.AutoSize = True
        Me.lb_PWD.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lb_PWD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PWD.Location = New System.Drawing.Point(19, 95)
        Me.lb_PWD.Name = "lb_PWD"
        Me.lb_PWD.Size = New System.Drawing.Size(71, 16)
        Me.lb_PWD.TabIndex = 3
        Me.lb_PWD.Text = "密  码："
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(200, 141)
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.Size = New System.Drawing.Size(111, 30)
        Me.bt_Quit.TabIndex = 3
        Me.bt_Quit.Text = "退出"
        Me.bt_Quit.UseVisualStyleBackColor = False
        '
        'tb_UserName
        '
        Me.tb_UserName.Location = New System.Drawing.Point(97, 51)
        Me.tb_UserName.Name = "tb_UserName"
        Me.tb_UserName.Size = New System.Drawing.Size(214, 21)
        Me.tb_UserName.TabIndex = 0
        '
        'tb_PWD
        '
        Me.tb_PWD.Location = New System.Drawing.Point(97, 95)
        Me.tb_PWD.Name = "tb_PWD"
        Me.tb_PWD.Size = New System.Drawing.Size(214, 21)
        Me.tb_PWD.TabIndex = 1
        '
        'lb_ErrorInfo_0
        '
        Me.lb_ErrorInfo_0.AutoSize = True
        Me.lb_ErrorInfo_0.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.lb_ErrorInfo_0.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_ErrorInfo_0.Location = New System.Drawing.Point(94, 75)
        Me.lb_ErrorInfo_0.Name = "lb_ErrorInfo_0"
        Me.lb_ErrorInfo_0.Size = New System.Drawing.Size(91, 14)
        Me.lb_ErrorInfo_0.TabIndex = 7
        Me.lb_ErrorInfo_0.Text = "未输入用户名"
        Me.lb_ErrorInfo_0.Visible = False
        '
        'lb_ErrorInfo_1
        '
        Me.lb_ErrorInfo_1.AutoSize = True
        Me.lb_ErrorInfo_1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.lb_ErrorInfo_1.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_ErrorInfo_1.Location = New System.Drawing.Point(94, 119)
        Me.lb_ErrorInfo_1.Name = "lb_ErrorInfo_1"
        Me.lb_ErrorInfo_1.Size = New System.Drawing.Size(77, 14)
        Me.lb_ErrorInfo_1.TabIndex = 8
        Me.lb_ErrorInfo_1.Text = "未输入密码"
        Me.lb_ErrorInfo_1.Visible = False
        '
        'lb_ErrorInfo_2
        '
        Me.lb_ErrorInfo_2.AutoSize = True
        Me.lb_ErrorInfo_2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.lb_ErrorInfo_2.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_ErrorInfo_2.Location = New System.Drawing.Point(94, 75)
        Me.lb_ErrorInfo_2.Name = "lb_ErrorInfo_2"
        Me.lb_ErrorInfo_2.Size = New System.Drawing.Size(203, 14)
        Me.lb_ErrorInfo_2.TabIndex = 9
        Me.lb_ErrorInfo_2.Text = "用户名或密码错误，请重新输入"
        Me.lb_ErrorInfo_2.Visible = False
        '
        'RMS_DataSet
        '
        Me.RMS_DataSet.DataSetName = "RMS_DataSet"
        Me.RMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '管理员信息BindingSource
        '
        Me.管理员信息BindingSource.DataMember = "管理员信息"
        Me.管理员信息BindingSource.DataSource = Me.RMS_DataSet
        '
        '管理员信息TableAdapter
        '
        Me.管理员信息TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._2024_08_17订单TableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.会员信息TableAdapter = Nothing
        Me.TableAdapterManager.管理员信息TableAdapter = Me.管理员信息TableAdapter
        Me.TableAdapterManager.菜单信息TableAdapter = Nothing
        Me.TableAdapterManager.雇员信息TableAdapter = Nothing
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(334, 191)
        Me.Controls.Add(Me.lb_ErrorInfo_1)
        Me.Controls.Add(Me.lb_ErrorInfo_0)
        Me.Controls.Add(Me.tb_PWD)
        Me.Controls.Add(Me.tb_UserName)
        Me.Controls.Add(Me.bt_Quit)
        Me.Controls.Add(Me.lb_PWD)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.bt_Login)
        Me.Controls.Add(Me.lb_ErrorInfo_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录界面"
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.管理员信息BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RMS_DataSet As RMS_DataSet
    Friend WithEvents 管理员信息BindingSource As BindingSource
    Friend WithEvents 管理员信息TableAdapter As RMS_DataSetTableAdapters.管理员信息TableAdapter
    Friend WithEvents TableAdapterManager As RMS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents bt_Login As Button
    Friend WithEvents Title As Label
    Friend WithEvents UserName As Label
    Friend WithEvents lb_PWD As Label
    Friend WithEvents bt_Quit As Button
    Friend WithEvents tb_UserName As TextBox
    Friend WithEvents tb_PWD As TextBox
    Friend WithEvents lb_ErrorInfo_0 As Label
    Friend WithEvents lb_ErrorInfo_1 As Label
    Friend WithEvents lb_ErrorInfo_2 As Label
End Class
