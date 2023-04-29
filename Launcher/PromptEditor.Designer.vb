<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromptEditor
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.Save = New MaterialSkin.Controls.MaterialButton()
        Me.Restore = New MaterialSkin.Controls.MaterialButton()
        Me.PromptTextBox = New System.Windows.Forms.TextBox()
        Me.ActionBar = New System.Windows.Forms.Label()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.AutoSize = False
        Me.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Save.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Lower
        Me.Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Save.Depth = 0
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Save.HighEmphasis = True
        Me.Save.Icon = Nothing
        Me.Save.Location = New System.Drawing.Point(128, 784)
        Me.Save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Save.MouseState = MaterialSkin.MouseState.HOVER
        Me.Save.Name = "Save"
        Me.Save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Save.Size = New System.Drawing.Size(152, 40)
        Me.Save.TabIndex = 40
        Me.Save.Text = "保存"
        Me.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Save.UseAccentColor = False
        Me.Save.UseVisualStyleBackColor = True
        '
        'Restore
        '
        Me.Restore.AutoSize = False
        Me.Restore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Restore.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Lower
        Me.Restore.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Restore.Depth = 0
        Me.Restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Restore.HighEmphasis = True
        Me.Restore.Icon = Nothing
        Me.Restore.Location = New System.Drawing.Point(328, 784)
        Me.Restore.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Restore.MouseState = MaterialSkin.MouseState.HOVER
        Me.Restore.Name = "Restore"
        Me.Restore.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Restore.Size = New System.Drawing.Size(152, 40)
        Me.Restore.TabIndex = 41
        Me.Restore.Text = "恢复"
        Me.Restore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Restore.UseAccentColor = False
        Me.Restore.UseVisualStyleBackColor = True
        '
        'PromptTextBox
        '
        Me.PromptTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PromptTextBox.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PromptTextBox.ForeColor = System.Drawing.Color.Black
        Me.PromptTextBox.Location = New System.Drawing.Point(16, 88)
        Me.PromptTextBox.Multiline = True
        Me.PromptTextBox.Name = "PromptTextBox"
        Me.PromptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PromptTextBox.Size = New System.Drawing.Size(576, 680)
        Me.PromptTextBox.TabIndex = 42
        '
        'ActionBar
        '
        Me.ActionBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ActionBar.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ActionBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ActionBar.Location = New System.Drawing.Point(0, 24)
        Me.ActionBar.Name = "ActionBar"
        Me.ActionBar.Size = New System.Drawing.Size(1128, 48)
        Me.ActionBar.TabIndex = 43
        Me.ActionBar.Text = " 提示词编辑器"
        Me.ActionBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(560, 880)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(154, 36)
        Me.MaterialButton1.TabIndex = 1
        Me.MaterialButton1.Text = "MaterialButton1"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'PromptEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 841)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.ActionBar)
        Me.Controls.Add(Me.PromptTextBox)
        Me.Controls.Add(Me.Restore)
        Me.Controls.Add(Me.Save)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.MaximizeBox = False
        Me.Name = "PromptEditor"
        Me.Padding = New System.Windows.Forms.Padding(3, 26, 3, 3)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PromptEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Restore As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PromptTextBox As TextBox
    Friend WithEvents ActionBar As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
