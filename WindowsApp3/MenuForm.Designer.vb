<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.Title = New System.Windows.Forms.Label()
        Me.bt_List = New System.Windows.Forms.Button()
        Me.bt_Employee = New System.Windows.Forms.Button()
        Me.bt_VIP = New System.Windows.Forms.Button()
        Me.bt_Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Title.Font = New System.Drawing.Font("黑体", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Title.Location = New System.Drawing.Point(47, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(347, 47)
        Me.Title.TabIndex = 2
        Me.Title.Text = "欢迎使用餐饮管理系统"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_List
        '
        Me.bt_List.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_List.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_List.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_List.Location = New System.Drawing.Point(43, 95)
        Me.bt_List.Name = "bt_List"
        Me.bt_List.Size = New System.Drawing.Size(139, 30)
        Me.bt_List.TabIndex = 3
        Me.bt_List.Text = "菜单编辑"
        Me.bt_List.UseVisualStyleBackColor = False
        '
        'bt_Employee
        '
        Me.bt_Employee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Employee.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Employee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Employee.Location = New System.Drawing.Point(258, 95)
        Me.bt_Employee.Name = "bt_Employee"
        Me.bt_Employee.Size = New System.Drawing.Size(139, 30)
        Me.bt_Employee.TabIndex = 4
        Me.bt_Employee.Text = "雇员管理"
        Me.bt_Employee.UseVisualStyleBackColor = False
        '
        'bt_VIP
        '
        Me.bt_VIP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_VIP.FlatAppearance.BorderSize = 0
        Me.bt_VIP.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_VIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_VIP.Location = New System.Drawing.Point(43, 155)
        Me.bt_VIP.Name = "bt_VIP"
        Me.bt_VIP.Size = New System.Drawing.Size(139, 30)
        Me.bt_VIP.TabIndex = 5
        Me.bt_VIP.Text = "客户信息"
        Me.bt_VIP.UseVisualStyleBackColor = False
        '
        'bt_Quit
        '
        Me.bt_Quit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bt_Quit.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.bt_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Quit.Location = New System.Drawing.Point(258, 155)
        Me.bt_Quit.Name = "bt_Quit"
        Me.bt_Quit.Size = New System.Drawing.Size(139, 30)
        Me.bt_Quit.TabIndex = 6
        Me.bt_Quit.Text = "退出"
        Me.bt_Quit.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(448, 215)
        Me.Controls.Add(Me.bt_Quit)
        Me.Controls.Add(Me.bt_VIP)
        Me.Controls.Add(Me.bt_Employee)
        Me.Controls.Add(Me.bt_List)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "主界面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents bt_List As Button
    Friend WithEvents bt_Employee As Button
    Friend WithEvents bt_VIP As Button
    Friend WithEvents bt_Quit As Button
End Class
