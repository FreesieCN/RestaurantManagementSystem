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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.bt_Login = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.lb_PWD = New System.Windows.Forms.Label()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        resources.ApplyResources(Me.bt_Login, "bt_Login")
        Me.bt_Login.Name = "bt_Login"
        Me.bt_Login.UseVisualStyleBackColor = False
        '
        'Title
        '
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Name = "Title"
        '
        'UserName
        '
        resources.ApplyResources(Me.UserName, "UserName")
        Me.UserName.Name = "UserName"
        '
        'lb_PWD
        '
        resources.ApplyResources(Me.lb_PWD, "lb_PWD")
        Me.lb_PWD.Name = "lb_PWD"
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.bt_Quit, "bt_Quit")
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'lb_ErrorInfo_0
        '
        resources.ApplyResources(Me.lb_ErrorInfo_0, "lb_ErrorInfo_0")
        Me.lb_ErrorInfo_0.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_0.Name = "lb_ErrorInfo_0"
        '
        'lb_ErrorInfo_1
        '
        resources.ApplyResources(Me.lb_ErrorInfo_1, "lb_ErrorInfo_1")
        Me.lb_ErrorInfo_1.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_1.Name = "lb_ErrorInfo_1"
        '
        'lb_ErrorInfo_2
        '
        resources.ApplyResources(Me.lb_ErrorInfo_2, "lb_ErrorInfo_2")
        Me.lb_ErrorInfo_2.ForeColor = System.Drawing.Color.Red
        Me.lb_ErrorInfo_2.Name = "lb_ErrorInfo_2"
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
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.lb_ErrorInfo_1)
        Me.Controls.Add(Me.lb_ErrorInfo_0)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lb_ErrorInfo_0 As Label
    Friend WithEvents lb_ErrorInfo_1 As Label
    Friend WithEvents lb_ErrorInfo_2 As Label
End Class
