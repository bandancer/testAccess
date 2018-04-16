<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accessPath = New System.Windows.Forms.TextBox()
        Me.selDefaultFilePathBtn = New System.Windows.Forms.Button()
        Me.defaultFilePath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selectAccessBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(62, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Access地址"
        '
        'accessPath
        '
        Me.accessPath.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.accessPath.Location = New System.Drawing.Point(197, 50)
        Me.accessPath.Name = "accessPath"
        Me.accessPath.Size = New System.Drawing.Size(391, 24)
        Me.accessPath.TabIndex = 1
        Me.accessPath.Text = "C:\testAccess\testAccess.accdb"
        '
        'selDefaultFilePathBtn
        '
        Me.selDefaultFilePathBtn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.selDefaultFilePathBtn.Location = New System.Drawing.Point(612, 95)
        Me.selDefaultFilePathBtn.Name = "selDefaultFilePathBtn"
        Me.selDefaultFilePathBtn.Size = New System.Drawing.Size(42, 23)
        Me.selDefaultFilePathBtn.TabIndex = 5
        Me.selDefaultFilePathBtn.Text = "..."
        Me.selDefaultFilePathBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selDefaultFilePathBtn.UseVisualStyleBackColor = True
        '
        'defaultFilePath
        '
        Me.defaultFilePath.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.defaultFilePath.Location = New System.Drawing.Point(197, 97)
        Me.defaultFilePath.Name = "defaultFilePath"
        Me.defaultFilePath.Size = New System.Drawing.Size(391, 24)
        Me.defaultFilePath.TabIndex = 4
        Me.defaultFilePath.Text = "C:\"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(62, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "文档文件夹地址"
        '
        'selectAccessBtn
        '
        Me.selectAccessBtn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.selectAccessBtn.Location = New System.Drawing.Point(612, 48)
        Me.selectAccessBtn.Name = "selectAccessBtn"
        Me.selectAccessBtn.Size = New System.Drawing.Size(42, 23)
        Me.selectAccessBtn.TabIndex = 2
        Me.selectAccessBtn.Text = "..."
        Me.selectAccessBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selectAccessBtn.UseVisualStyleBackColor = True
        '
        'settingPage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.selDefaultFilePathBtn)
        Me.Controls.Add(Me.defaultFilePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.selectAccessBtn)
        Me.Controls.Add(Me.accessPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "settingPage"
        Me.Text = "设定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents accessPath As TextBox
    Friend WithEvents selDefaultFilePathBtn As Button
    Friend WithEvents defaultFilePath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents selectAccessBtn As Button
End Class
