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
        Me.RMS_DataSet = New WindowsApp3.RMS_DataSet()
        Me.管理员信息BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.管理员信息TableAdapter = New WindowsApp3.RMS_DataSetTableAdapters.管理员信息TableAdapter()
        Me.TableAdapterManager = New WindowsApp3.RMS_DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.RMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.管理员信息BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title
        '
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.Name = "Title"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'LoginForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
