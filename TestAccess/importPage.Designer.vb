<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importPage
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addImport1Btn = New System.Windows.Forms.Button()
        Me.newImport1Btn = New System.Windows.Forms.Button()
        Me.selectFile1Btn = New System.Windows.Forms.Button()
        Me.selectFile2Btn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.setExcelTitleBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.TextBox1.Location = New System.Drawing.Point(165, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "E:\myThing\testAccess\QAD导出文件\dpcode.xls"
        '
        'addImport1Btn
        '
        Me.addImport1Btn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.addImport1Btn.Location = New System.Drawing.Point(619, 53)
        Me.addImport1Btn.Name = "addImport1Btn"
        Me.addImport1Btn.Size = New System.Drawing.Size(75, 23)
        Me.addImport1Btn.TabIndex = 1
        Me.addImport1Btn.Text = "新增导入"
        Me.addImport1Btn.UseVisualStyleBackColor = True
        '
        'newImport1Btn
        '
        Me.newImport1Btn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.newImport1Btn.Location = New System.Drawing.Point(712, 53)
        Me.newImport1Btn.Name = "newImport1Btn"
        Me.newImport1Btn.Size = New System.Drawing.Size(75, 23)
        Me.newImport1Btn.TabIndex = 2
        Me.newImport1Btn.Text = "覆盖导入"
        Me.newImport1Btn.UseVisualStyleBackColor = True
        '
        'selectFile1Btn
        '
        Me.selectFile1Btn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.selectFile1Btn.Location = New System.Drawing.Point(552, 52)
        Me.selectFile1Btn.Name = "selectFile1Btn"
        Me.selectFile1Btn.Size = New System.Drawing.Size(34, 23)
        Me.selectFile1Btn.TabIndex = 3
        Me.selectFile1Btn.Text = "..."
        Me.selectFile1Btn.UseVisualStyleBackColor = True
        '
        'selectFile2Btn
        '
        Me.selectFile2Btn.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.selectFile2Btn.Location = New System.Drawing.Point(552, 104)
        Me.selectFile2Btn.Name = "selectFile2Btn"
        Me.selectFile2Btn.Size = New System.Drawing.Size(34, 23)
        Me.selectFile2Btn.TabIndex = 5
        Me.selectFile2Btn.Text = "..."
        Me.selectFile2Btn.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.TextBox2.Location = New System.Drawing.Point(165, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(380, 24)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DpCode表位置"
        '
        'setExcelTitleBtn
        '
        Me.setExcelTitleBtn.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.setExcelTitleBtn.Location = New System.Drawing.Point(809, 52)
        Me.setExcelTitleBtn.Name = "setExcelTitleBtn"
        Me.setExcelTitleBtn.Size = New System.Drawing.Size(107, 23)
        Me.setExcelTitleBtn.TabIndex = 7
        Me.setExcelTitleBtn.Text = "设定excel标题"
        Me.setExcelTitleBtn.UseVisualStyleBackColor = True
        '
        'importPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 450)
        Me.Controls.Add(Me.setExcelTitleBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectFile2Btn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.selectFile1Btn)
        Me.Controls.Add(Me.newImport1Btn)
        Me.Controls.Add(Me.addImport1Btn)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "importPage"
        Me.Text = "导入页面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addImport1Btn As Button
    Friend WithEvents newImport1Btn As Button
    Friend WithEvents selectFile1Btn As Button
    Friend WithEvents selectFile2Btn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents setExcelTitleBtn As Button
End Class
