<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.openImport = New System.Windows.Forms.Button()
        Me.openSearchDpcode = New System.Windows.Forms.Button()
        Me.settingBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accessPathLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.defaultFilePathLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'openImport
        '
        Me.openImport.Location = New System.Drawing.Point(69, 44)
        Me.openImport.Name = "openImport"
        Me.openImport.Size = New System.Drawing.Size(181, 23)
        Me.openImport.TabIndex = 0
        Me.openImport.Text = "打开导入页面"
        Me.openImport.UseVisualStyleBackColor = True
        '
        'openSearchDpcode
        '
        Me.openSearchDpcode.Location = New System.Drawing.Point(69, 106)
        Me.openSearchDpcode.Name = "openSearchDpcode"
        Me.openSearchDpcode.Size = New System.Drawing.Size(181, 23)
        Me.openSearchDpcode.TabIndex = 1
        Me.openSearchDpcode.Text = "打开查询Dpcode页面"
        Me.openSearchDpcode.UseVisualStyleBackColor = True
        '
        'settingBtn
        '
        Me.settingBtn.Location = New System.Drawing.Point(82, 314)
        Me.settingBtn.Name = "settingBtn"
        Me.settingBtn.Size = New System.Drawing.Size(75, 23)
        Me.settingBtn.TabIndex = 2
        Me.settingBtn.Text = "设定"
        Me.settingBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(86, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Access文件地址："
        '
        'accessPathLbl
        '
        Me.accessPathLbl.AutoSize = True
        Me.accessPathLbl.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.accessPathLbl.Location = New System.Drawing.Point(230, 365)
        Me.accessPathLbl.Name = "accessPathLbl"
        Me.accessPathLbl.Size = New System.Drawing.Size(0, 15)
        Me.accessPathLbl.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(86, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "文档默认地址："
        '
        'defaultFilePathLbl
        '
        Me.defaultFilePathLbl.AutoSize = True
        Me.defaultFilePathLbl.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.defaultFilePathLbl.Location = New System.Drawing.Point(230, 401)
        Me.defaultFilePathLbl.Name = "defaultFilePathLbl"
        Me.defaultFilePathLbl.Size = New System.Drawing.Size(0, 15)
        Me.defaultFilePathLbl.TabIndex = 6
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 601)
        Me.Controls.Add(Me.defaultFilePathLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.accessPathLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.settingBtn)
        Me.Controls.Add(Me.openSearchDpcode)
        Me.Controls.Add(Me.openImport)
        Me.Name = "mainForm"
        Me.Text = "主画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents openImport As Button
    Friend WithEvents openSearchDpcode As Button
    Friend WithEvents settingBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents accessPathLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents defaultFilePathLbl As Label
End Class
