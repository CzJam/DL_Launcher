<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.GroupGPTVersion = New System.Windows.Forms.GroupBox()
        Me.CheckBW = New MaterialSkin.Controls.MaterialCheckbox()
        Me.CheckStream = New MaterialSkin.Controls.MaterialCheckbox()
        Me.ComboCharacterSelect = New MaterialSkin.Controls.MaterialComboBox()
        Me.GroupLogin = New System.Windows.Forms.GroupBox()
        Me.GetCookie = New MaterialSkin.Controls.MaterialButton()
        Me.TextOpenAIAcc = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.CheckIsPlus = New MaterialSkin.Controls.MaterialCheckbox()
        Me.TextOpenAICookie = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TextOpenAIPass = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.OptionCookie = New MaterialSkin.Controls.MaterialRadioButton()
        Me.OptionAccAndPass = New MaterialSkin.Controls.MaterialRadioButton()
        Me.GetAPI = New MaterialSkin.Controls.MaterialButton()
        Me.ComboModSelect = New MaterialSkin.Controls.MaterialComboBox()
        Me.TextProxServer = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.TextAPIKey = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.OptionAPI = New MaterialSkin.Controls.MaterialRadioButton()
        Me.OptionWeb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Launch = New MaterialSkin.Controls.MaterialButton()
        Me.ActionBar = New System.Windows.Forms.Label()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.para = New System.Windows.Forms.TextBox()
        Me.logData = New System.Windows.Forms.TextBox()
        Me.Save = New MaterialSkin.Controls.MaterialButton()
        Me.TextStatus = New System.Windows.Forms.Label()
        Me.CheckLog = New MaterialSkin.Controls.MaterialCheckbox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Editor = New MaterialSkin.Controls.MaterialButton()
        Me.IPBox = New System.Windows.Forms.TextBox()
        Me.PortBox = New System.Windows.Forms.TextBox()
        Me.GroupGPTVersion.SuspendLayout()
        Me.GroupLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupGPTVersion
        '
        Me.GroupGPTVersion.BackColor = System.Drawing.SystemColors.Control
        Me.GroupGPTVersion.Controls.Add(Me.CheckBW)
        Me.GroupGPTVersion.Controls.Add(Me.CheckStream)
        Me.GroupGPTVersion.Controls.Add(Me.ComboCharacterSelect)
        Me.GroupGPTVersion.Controls.Add(Me.GroupLogin)
        Me.GroupGPTVersion.Controls.Add(Me.GetAPI)
        Me.GroupGPTVersion.Controls.Add(Me.ComboModSelect)
        Me.GroupGPTVersion.Controls.Add(Me.TextProxServer)
        Me.GroupGPTVersion.Controls.Add(Me.TextAPIKey)
        Me.GroupGPTVersion.Controls.Add(Me.OptionAPI)
        Me.GroupGPTVersion.Controls.Add(Me.OptionWeb)
        Me.GroupGPTVersion.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupGPTVersion.Location = New System.Drawing.Point(24, 88)
        Me.GroupGPTVersion.Name = "GroupGPTVersion"
        Me.GroupGPTVersion.Size = New System.Drawing.Size(424, 456)
        Me.GroupGPTVersion.TabIndex = 3
        Me.GroupGPTVersion.TabStop = False
        Me.GroupGPTVersion.Text = "ChatGPT 版本"
        '
        'CheckBW
        '
        Me.CheckBW.Depth = 0
        Me.CheckBW.Location = New System.Drawing.Point(304, 400)
        Me.CheckBW.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBW.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckBW.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckBW.Name = "CheckBW"
        Me.CheckBW.ReadOnly = False
        Me.CheckBW.Ripple = True
        Me.CheckBW.Size = New System.Drawing.Size(99, 40)
        Me.CheckBW.TabIndex = 38
        Me.CheckBW.Text = "洗脑模式"
        Me.ToolTip1.SetToolTip(Me.CheckBW, "每隔5句话发送一次设定，有助于解决ChatGPT忘了自己的设定的问题。（仅网页版可用）")
        Me.CheckBW.UseVisualStyleBackColor = True
        '
        'CheckStream
        '
        Me.CheckStream.Depth = 0
        Me.CheckStream.Location = New System.Drawing.Point(200, 400)
        Me.CheckStream.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckStream.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckStream.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckStream.Name = "CheckStream"
        Me.CheckStream.ReadOnly = False
        Me.CheckStream.Ripple = True
        Me.CheckStream.Size = New System.Drawing.Size(99, 40)
        Me.CheckStream.TabIndex = 37
        Me.CheckStream.Text = "流式语音"
        Me.ToolTip1.SetToolTip(Me.CheckStream, "每一个完整句子都会生成一次语音，可以显著改善回答延迟问题")
        Me.CheckStream.UseVisualStyleBackColor = True
        '
        'ComboCharacterSelect
        '
        Me.ComboCharacterSelect.AutoResize = False
        Me.ComboCharacterSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboCharacterSelect.Depth = 0
        Me.ComboCharacterSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboCharacterSelect.DropDownHeight = 174
        Me.ComboCharacterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCharacterSelect.DropDownWidth = 121
        Me.ComboCharacterSelect.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ComboCharacterSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboCharacterSelect.FormattingEnabled = True
        Me.ComboCharacterSelect.Hint = "角色选择"
        Me.ComboCharacterSelect.IntegralHeight = False
        Me.ComboCharacterSelect.ItemHeight = 43
        Me.ComboCharacterSelect.Location = New System.Drawing.Point(24, 392)
        Me.ComboCharacterSelect.MaxDropDownItems = 4
        Me.ComboCharacterSelect.MouseState = MaterialSkin.MouseState.OUT
        Me.ComboCharacterSelect.Name = "ComboCharacterSelect"
        Me.ComboCharacterSelect.Size = New System.Drawing.Size(168, 49)
        Me.ComboCharacterSelect.StartIndex = 0
        Me.ComboCharacterSelect.TabIndex = 36
        '
        'GroupLogin
        '
        Me.GroupLogin.BackColor = System.Drawing.SystemColors.Control
        Me.GroupLogin.Controls.Add(Me.GetCookie)
        Me.GroupLogin.Controls.Add(Me.TextOpenAIAcc)
        Me.GroupLogin.Controls.Add(Me.CheckIsPlus)
        Me.GroupLogin.Controls.Add(Me.TextOpenAICookie)
        Me.GroupLogin.Controls.Add(Me.TextOpenAIPass)
        Me.GroupLogin.Controls.Add(Me.OptionCookie)
        Me.GroupLogin.Controls.Add(Me.OptionAccAndPass)
        Me.GroupLogin.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupLogin.Location = New System.Drawing.Point(16, 72)
        Me.GroupLogin.Name = "GroupLogin"
        Me.GroupLogin.Size = New System.Drawing.Size(392, 208)
        Me.GroupLogin.TabIndex = 26
        Me.GroupLogin.TabStop = False
        Me.GroupLogin.Text = "登录方式"
        '
        'GetCookie
        '
        Me.GetCookie.AutoSize = False
        Me.GetCookie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GetCookie.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Lower
        Me.GetCookie.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.GetCookie.Depth = 0
        Me.GetCookie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GetCookie.HighEmphasis = True
        Me.GetCookie.Icon = Nothing
        Me.GetCookie.Location = New System.Drawing.Point(16, 120)
        Me.GetCookie.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GetCookie.MouseState = MaterialSkin.MouseState.HOVER
        Me.GetCookie.Name = "GetCookie"
        Me.GetCookie.NoAccentTextColor = System.Drawing.Color.Empty
        Me.GetCookie.Size = New System.Drawing.Size(360, 40)
        Me.GetCookie.TabIndex = 16
        Me.GetCookie.Text = "如何获取cookie"
        Me.GetCookie.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.GetCookie.UseAccentColor = False
        Me.GetCookie.UseVisualStyleBackColor = True
        Me.GetCookie.Visible = False
        '
        'TextOpenAIAcc
        '
        Me.TextOpenAIAcc.AllowPromptAsInput = True
        Me.TextOpenAIAcc.AnimateReadOnly = False
        Me.TextOpenAIAcc.AsciiOnly = False
        Me.TextOpenAIAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextOpenAIAcc.BeepOnError = False
        Me.TextOpenAIAcc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAIAcc.Depth = 0
        Me.TextOpenAIAcc.Enabled = False
        Me.TextOpenAIAcc.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextOpenAIAcc.HidePromptOnLeave = False
        Me.TextOpenAIAcc.HideSelection = True
        Me.TextOpenAIAcc.Hint = "openAI 账号（暂不可用）"
        Me.TextOpenAIAcc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextOpenAIAcc.LeadingIcon = Nothing
        Me.TextOpenAIAcc.Location = New System.Drawing.Point(16, 72)
        Me.TextOpenAIAcc.Mask = ""
        Me.TextOpenAIAcc.MaxLength = 32767
        Me.TextOpenAIAcc.MouseState = MaterialSkin.MouseState.OUT
        Me.TextOpenAIAcc.Name = "TextOpenAIAcc"
        Me.TextOpenAIAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextOpenAIAcc.PrefixSuffixText = Nothing
        Me.TextOpenAIAcc.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextOpenAIAcc.ReadOnly = False
        Me.TextOpenAIAcc.RejectInputOnFirstFailure = False
        Me.TextOpenAIAcc.ResetOnPrompt = True
        Me.TextOpenAIAcc.ResetOnSpace = True
        Me.TextOpenAIAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextOpenAIAcc.SelectedText = ""
        Me.TextOpenAIAcc.SelectionLength = 0
        Me.TextOpenAIAcc.SelectionStart = 0
        Me.TextOpenAIAcc.ShortcutsEnabled = True
        Me.TextOpenAIAcc.Size = New System.Drawing.Size(360, 36)
        Me.TextOpenAIAcc.SkipLiterals = True
        Me.TextOpenAIAcc.TabIndex = 14
        Me.TextOpenAIAcc.TabStop = False
        Me.TextOpenAIAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextOpenAIAcc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAIAcc.TrailingIcon = Nothing
        Me.TextOpenAIAcc.UseSystemPasswordChar = False
        Me.TextOpenAIAcc.UseTallSize = False
        Me.TextOpenAIAcc.ValidatingType = Nothing
        '
        'CheckIsPlus
        '
        Me.CheckIsPlus.AutoSize = True
        Me.CheckIsPlus.Depth = 0
        Me.CheckIsPlus.Enabled = False
        Me.CheckIsPlus.Location = New System.Drawing.Point(16, 165)
        Me.CheckIsPlus.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckIsPlus.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckIsPlus.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckIsPlus.Name = "CheckIsPlus"
        Me.CheckIsPlus.ReadOnly = False
        Me.CheckIsPlus.Ripple = True
        Me.CheckIsPlus.Size = New System.Drawing.Size(194, 37)
        Me.CheckIsPlus.TabIndex = 13
        Me.CheckIsPlus.Text = "Plus账号（暂不可用）"
        Me.ToolTip1.SetToolTip(Me.CheckIsPlus, "请在开始之前确保你的网络可以访问chatGPT")
        Me.CheckIsPlus.UseVisualStyleBackColor = True
        '
        'TextOpenAICookie
        '
        Me.TextOpenAICookie.AllowPromptAsInput = True
        Me.TextOpenAICookie.AnimateReadOnly = False
        Me.TextOpenAICookie.AsciiOnly = False
        Me.TextOpenAICookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextOpenAICookie.BeepOnError = False
        Me.TextOpenAICookie.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAICookie.Depth = 0
        Me.TextOpenAICookie.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextOpenAICookie.HidePromptOnLeave = False
        Me.TextOpenAICookie.HideSelection = True
        Me.TextOpenAICookie.Hint = "openAI Cookie"
        Me.TextOpenAICookie.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextOpenAICookie.LeadingIcon = Nothing
        Me.TextOpenAICookie.Location = New System.Drawing.Point(16, 72)
        Me.TextOpenAICookie.Mask = ""
        Me.TextOpenAICookie.MaxLength = 32767
        Me.TextOpenAICookie.MouseState = MaterialSkin.MouseState.OUT
        Me.TextOpenAICookie.Name = "TextOpenAICookie"
        Me.TextOpenAICookie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextOpenAICookie.PrefixSuffixText = Nothing
        Me.TextOpenAICookie.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextOpenAICookie.ReadOnly = False
        Me.TextOpenAICookie.RejectInputOnFirstFailure = False
        Me.TextOpenAICookie.ResetOnPrompt = True
        Me.TextOpenAICookie.ResetOnSpace = True
        Me.TextOpenAICookie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextOpenAICookie.SelectedText = ""
        Me.TextOpenAICookie.SelectionLength = 0
        Me.TextOpenAICookie.SelectionStart = 0
        Me.TextOpenAICookie.ShortcutsEnabled = True
        Me.TextOpenAICookie.Size = New System.Drawing.Size(360, 36)
        Me.TextOpenAICookie.SkipLiterals = True
        Me.TextOpenAICookie.TabIndex = 11
        Me.TextOpenAICookie.TabStop = False
        Me.TextOpenAICookie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextOpenAICookie.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAICookie.TrailingIcon = Nothing
        Me.TextOpenAICookie.UseSystemPasswordChar = False
        Me.TextOpenAICookie.UseTallSize = False
        Me.TextOpenAICookie.ValidatingType = Nothing
        '
        'TextOpenAIPass
        '
        Me.TextOpenAIPass.AllowPromptAsInput = True
        Me.TextOpenAIPass.AnimateReadOnly = False
        Me.TextOpenAIPass.AsciiOnly = False
        Me.TextOpenAIPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextOpenAIPass.BeepOnError = False
        Me.TextOpenAIPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAIPass.Depth = 0
        Me.TextOpenAIPass.Enabled = False
        Me.TextOpenAIPass.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextOpenAIPass.HidePromptOnLeave = False
        Me.TextOpenAIPass.HideSelection = True
        Me.TextOpenAIPass.Hint = "openAI 密码（暂不可用）"
        Me.TextOpenAIPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextOpenAIPass.LeadingIcon = Nothing
        Me.TextOpenAIPass.Location = New System.Drawing.Point(16, 120)
        Me.TextOpenAIPass.Mask = ""
        Me.TextOpenAIPass.MaxLength = 32767
        Me.TextOpenAIPass.MouseState = MaterialSkin.MouseState.OUT
        Me.TextOpenAIPass.Name = "TextOpenAIPass"
        Me.TextOpenAIPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextOpenAIPass.PrefixSuffixText = Nothing
        Me.TextOpenAIPass.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextOpenAIPass.ReadOnly = False
        Me.TextOpenAIPass.RejectInputOnFirstFailure = False
        Me.TextOpenAIPass.ResetOnPrompt = True
        Me.TextOpenAIPass.ResetOnSpace = True
        Me.TextOpenAIPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextOpenAIPass.SelectedText = ""
        Me.TextOpenAIPass.SelectionLength = 0
        Me.TextOpenAIPass.SelectionStart = 0
        Me.TextOpenAIPass.ShortcutsEnabled = True
        Me.TextOpenAIPass.Size = New System.Drawing.Size(360, 36)
        Me.TextOpenAIPass.SkipLiterals = True
        Me.TextOpenAIPass.TabIndex = 8
        Me.TextOpenAIPass.TabStop = False
        Me.TextOpenAIPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextOpenAIPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextOpenAIPass.TrailingIcon = Nothing
        Me.TextOpenAIPass.UseSystemPasswordChar = False
        Me.TextOpenAIPass.UseTallSize = False
        Me.TextOpenAIPass.ValidatingType = Nothing
        '
        'OptionCookie
        '
        Me.OptionCookie.AutoSize = True
        Me.OptionCookie.Depth = 0
        Me.OptionCookie.Location = New System.Drawing.Point(64, 24)
        Me.OptionCookie.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionCookie.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionCookie.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionCookie.Name = "OptionCookie"
        Me.OptionCookie.Ripple = True
        Me.OptionCookie.Size = New System.Drawing.Size(88, 37)
        Me.OptionCookie.TabIndex = 4
        Me.OptionCookie.TabStop = True
        Me.OptionCookie.Text = "Cookie"
        Me.ToolTip1.SetToolTip(Me.OptionCookie, "使用cookie登录")
        Me.OptionCookie.UseVisualStyleBackColor = True
        '
        'OptionAccAndPass
        '
        Me.OptionAccAndPass.AutoSize = True
        Me.OptionAccAndPass.Checked = True
        Me.OptionAccAndPass.Depth = 0
        Me.OptionAccAndPass.Location = New System.Drawing.Point(240, 24)
        Me.OptionAccAndPass.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionAccAndPass.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionAccAndPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionAccAndPass.Name = "OptionAccAndPass"
        Me.OptionAccAndPass.Ripple = True
        Me.OptionAccAndPass.Size = New System.Drawing.Size(99, 37)
        Me.OptionAccAndPass.TabIndex = 3
        Me.OptionAccAndPass.TabStop = True
        Me.OptionAccAndPass.Text = "账号密码"
        Me.ToolTip1.SetToolTip(Me.OptionAccAndPass, "使用账号密码登录（暂不可用）")
        Me.OptionAccAndPass.UseVisualStyleBackColor = True
        '
        'GetAPI
        '
        Me.GetAPI.AutoSize = False
        Me.GetAPI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GetAPI.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.GetAPI.Depth = 0
        Me.GetAPI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GetAPI.HighEmphasis = True
        Me.GetAPI.Icon = Nothing
        Me.GetAPI.Location = New System.Drawing.Point(24, 120)
        Me.GetAPI.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GetAPI.MouseState = MaterialSkin.MouseState.HOVER
        Me.GetAPI.Name = "GetAPI"
        Me.GetAPI.NoAccentTextColor = System.Drawing.Color.Empty
        Me.GetAPI.Size = New System.Drawing.Size(376, 40)
        Me.GetAPI.TabIndex = 25
        Me.GetAPI.Text = "如何获取API"
        Me.GetAPI.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.GetAPI.UseAccentColor = False
        Me.GetAPI.UseVisualStyleBackColor = True
        '
        'ComboModSelect
        '
        Me.ComboModSelect.AutoResize = False
        Me.ComboModSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboModSelect.Depth = 0
        Me.ComboModSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ComboModSelect.DropDownHeight = 118
        Me.ComboModSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboModSelect.DropDownWidth = 121
        Me.ComboModSelect.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ComboModSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboModSelect.FormattingEnabled = True
        Me.ComboModSelect.Hint = "模型选择"
        Me.ComboModSelect.IntegralHeight = False
        Me.ComboModSelect.ItemHeight = 29
        Me.ComboModSelect.Location = New System.Drawing.Point(24, 344)
        Me.ComboModSelect.MaxDropDownItems = 4
        Me.ComboModSelect.MouseState = MaterialSkin.MouseState.OUT
        Me.ComboModSelect.Name = "ComboModSelect"
        Me.ComboModSelect.Size = New System.Drawing.Size(376, 35)
        Me.ComboModSelect.StartIndex = 0
        Me.ComboModSelect.TabIndex = 24
        Me.ComboModSelect.UseTallSize = False
        '
        'TextProxServer
        '
        Me.TextProxServer.AllowPromptAsInput = True
        Me.TextProxServer.AnimateReadOnly = False
        Me.TextProxServer.AsciiOnly = False
        Me.TextProxServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextProxServer.BeepOnError = False
        Me.TextProxServer.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextProxServer.Depth = 0
        Me.TextProxServer.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextProxServer.HidePromptOnLeave = False
        Me.TextProxServer.HideSelection = True
        Me.TextProxServer.Hint = "代理（可不填，连接前请确保你的网路能访问chatGPT）"
        Me.TextProxServer.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextProxServer.LeadingIcon = Nothing
        Me.TextProxServer.Location = New System.Drawing.Point(24, 296)
        Me.TextProxServer.Mask = ""
        Me.TextProxServer.MaxLength = 32767
        Me.TextProxServer.MouseState = MaterialSkin.MouseState.OUT
        Me.TextProxServer.Name = "TextProxServer"
        Me.TextProxServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextProxServer.PrefixSuffixText = Nothing
        Me.TextProxServer.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextProxServer.ReadOnly = False
        Me.TextProxServer.RejectInputOnFirstFailure = False
        Me.TextProxServer.ResetOnPrompt = True
        Me.TextProxServer.ResetOnSpace = True
        Me.TextProxServer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextProxServer.SelectedText = ""
        Me.TextProxServer.SelectionLength = 0
        Me.TextProxServer.SelectionStart = 0
        Me.TextProxServer.ShortcutsEnabled = True
        Me.TextProxServer.Size = New System.Drawing.Size(376, 36)
        Me.TextProxServer.SkipLiterals = True
        Me.TextProxServer.TabIndex = 22
        Me.TextProxServer.TabStop = False
        Me.TextProxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextProxServer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.ToolTip1.SetToolTip(Me.TextProxServer, "请在开始之前确保你的网络可以访问chatGPT")
        Me.TextProxServer.TrailingIcon = Nothing
        Me.TextProxServer.UseSystemPasswordChar = False
        Me.TextProxServer.UseTallSize = False
        Me.TextProxServer.ValidatingType = Nothing
        '
        'TextAPIKey
        '
        Me.TextAPIKey.AllowPromptAsInput = True
        Me.TextAPIKey.AnimateReadOnly = False
        Me.TextAPIKey.AsciiOnly = False
        Me.TextAPIKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TextAPIKey.BeepOnError = False
        Me.TextAPIKey.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextAPIKey.Depth = 0
        Me.TextAPIKey.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.TextAPIKey.HidePromptOnLeave = False
        Me.TextAPIKey.HideSelection = True
        Me.TextAPIKey.Hint = "API Key"
        Me.TextAPIKey.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TextAPIKey.LeadingIcon = Nothing
        Me.TextAPIKey.Location = New System.Drawing.Point(24, 72)
        Me.TextAPIKey.Mask = ""
        Me.TextAPIKey.MaxLength = 32767
        Me.TextAPIKey.MouseState = MaterialSkin.MouseState.OUT
        Me.TextAPIKey.Name = "TextAPIKey"
        Me.TextAPIKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextAPIKey.PrefixSuffixText = Nothing
        Me.TextAPIKey.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TextAPIKey.ReadOnly = False
        Me.TextAPIKey.RejectInputOnFirstFailure = False
        Me.TextAPIKey.ResetOnPrompt = True
        Me.TextAPIKey.ResetOnSpace = True
        Me.TextAPIKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextAPIKey.SelectedText = ""
        Me.TextAPIKey.SelectionLength = 0
        Me.TextAPIKey.SelectionStart = 0
        Me.TextAPIKey.ShortcutsEnabled = True
        Me.TextAPIKey.Size = New System.Drawing.Size(376, 36)
        Me.TextAPIKey.SkipLiterals = True
        Me.TextAPIKey.TabIndex = 18
        Me.TextAPIKey.TabStop = False
        Me.TextAPIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextAPIKey.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TextAPIKey.TrailingIcon = Nothing
        Me.TextAPIKey.UseSystemPasswordChar = False
        Me.TextAPIKey.UseTallSize = False
        Me.TextAPIKey.ValidatingType = Nothing
        '
        'OptionAPI
        '
        Me.OptionAPI.AutoSize = True
        Me.OptionAPI.Depth = 0
        Me.OptionAPI.Location = New System.Drawing.Point(256, 24)
        Me.OptionAPI.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionAPI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionAPI.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionAPI.Name = "OptionAPI"
        Me.OptionAPI.Ripple = True
        Me.OptionAPI.Size = New System.Drawing.Size(77, 37)
        Me.OptionAPI.TabIndex = 4
        Me.OptionAPI.TabStop = True
        Me.OptionAPI.Text = "API版"
        Me.ToolTip1.SetToolTip(Me.OptionAPI, "使用OpenAI官方的API接入。不填APIKey会使用我们的APIKey")
        Me.OptionAPI.UseVisualStyleBackColor = True
        '
        'OptionWeb
        '
        Me.OptionWeb.AutoSize = True
        Me.OptionWeb.Checked = True
        Me.OptionWeb.Depth = 0
        Me.OptionWeb.Location = New System.Drawing.Point(80, 24)
        Me.OptionWeb.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionWeb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.OptionWeb.MouseState = MaterialSkin.MouseState.HOVER
        Me.OptionWeb.Name = "OptionWeb"
        Me.OptionWeb.Ripple = True
        Me.OptionWeb.Size = New System.Drawing.Size(83, 37)
        Me.OptionWeb.TabIndex = 3
        Me.OptionWeb.TabStop = True
        Me.OptionWeb.Text = "网页版"
        Me.ToolTip1.SetToolTip(Me.OptionWeb, "使用逆向的网页版ChatGPT API，链接有可能不稳定")
        Me.OptionWeb.UseVisualStyleBackColor = True
        '
        'Launch
        '
        Me.Launch.AutoSize = False
        Me.Launch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Launch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Launch.Depth = 0
        Me.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Launch.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Launch.HighEmphasis = True
        Me.Launch.Icon = Nothing
        Me.Launch.Location = New System.Drawing.Point(24, 552)
        Me.Launch.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Launch.MouseState = MaterialSkin.MouseState.HOVER
        Me.Launch.Name = "Launch"
        Me.Launch.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Launch.Size = New System.Drawing.Size(152, 40)
        Me.Launch.TabIndex = 15
        Me.Launch.Text = "启动服务器"
        Me.ToolTip1.SetToolTip(Me.Launch, "启动服务")
        Me.Launch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Launch.UseAccentColor = False
        Me.Launch.UseVisualStyleBackColor = True
        '
        'ActionBar
        '
        Me.ActionBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ActionBar.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ActionBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ActionBar.Location = New System.Drawing.Point(0, 24)
        Me.ActionBar.Name = "ActionBar"
        Me.ActionBar.Size = New System.Drawing.Size(1128, 48)
        Me.ActionBar.TabIndex = 16
        Me.ActionBar.Text = " 《数字生命》"
        Me.ActionBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(1000, 768)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(202, 37)
        Me.MaterialRadioButton1.TabIndex = 1
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "MaterialRadioButton1"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'para
        '
        Me.para.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.para.Location = New System.Drawing.Point(24, 664)
        Me.para.Multiline = True
        Me.para.Name = "para"
        Me.para.Size = New System.Drawing.Size(1024, 24)
        Me.para.TabIndex = 26
        '
        'logData
        '
        Me.logData.BackColor = System.Drawing.SystemColors.Menu
        Me.logData.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.logData.Location = New System.Drawing.Point(480, 96)
        Me.logData.Multiline = True
        Me.logData.Name = "logData"
        Me.logData.ReadOnly = True
        Me.logData.Size = New System.Drawing.Size(568, 552)
        Me.logData.TabIndex = 30
        '
        'Save
        '
        Me.Save.AutoSize = False
        Me.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Save.Depth = 0
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Save.HighEmphasis = True
        Me.Save.Icon = Nothing
        Me.Save.Location = New System.Drawing.Point(328, 552)
        Me.Save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Save.MouseState = MaterialSkin.MouseState.HOVER
        Me.Save.Name = "Save"
        Me.Save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Save.Size = New System.Drawing.Size(120, 40)
        Me.Save.TabIndex = 31
        Me.Save.Text = "保存选项配置"
        Me.ToolTip1.SetToolTip(Me.Save, "保存所有配置项")
        Me.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Save.UseAccentColor = False
        Me.Save.UseVisualStyleBackColor = True
        '
        'TextStatus
        '
        Me.TextStatus.BackColor = System.Drawing.Color.Red
        Me.TextStatus.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextStatus.Location = New System.Drawing.Point(24, 608)
        Me.TextStatus.Name = "TextStatus"
        Me.TextStatus.Size = New System.Drawing.Size(336, 40)
        Me.TextStatus.TabIndex = 33
        Me.TextStatus.Text = "未启动"
        Me.TextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckLog
        '
        Me.CheckLog.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckLog.Depth = 0
        Me.CheckLog.Location = New System.Drawing.Point(368, 608)
        Me.CheckLog.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckLog.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CheckLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.CheckLog.Name = "CheckLog"
        Me.CheckLog.ReadOnly = False
        Me.CheckLog.Ripple = True
        Me.CheckLog.Size = New System.Drawing.Size(80, 40)
        Me.CheckLog.TabIndex = 40
        Me.CheckLog.Text = "日志"
        Me.ToolTip1.SetToolTip(Me.CheckLog, "显示实时日志")
        Me.CheckLog.UseVisualStyleBackColor = True
        '
        'Editor
        '
        Me.Editor.AutoSize = False
        Me.Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Editor.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Lower
        Me.Editor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Editor.Depth = 0
        Me.Editor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Editor.HighEmphasis = True
        Me.Editor.Icon = Nothing
        Me.Editor.Location = New System.Drawing.Point(184, 552)
        Me.Editor.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Editor.MouseState = MaterialSkin.MouseState.HOVER
        Me.Editor.Name = "Editor"
        Me.Editor.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Editor.Size = New System.Drawing.Size(136, 40)
        Me.Editor.TabIndex = 39
        Me.Editor.Text = "编辑提示词"
        Me.Editor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Editor.UseAccentColor = False
        Me.Editor.UseVisualStyleBackColor = True
        '
        'IPBox
        '
        Me.IPBox.Location = New System.Drawing.Point(664, 840)
        Me.IPBox.Name = "IPBox"
        Me.IPBox.Size = New System.Drawing.Size(128, 21)
        Me.IPBox.TabIndex = 41
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(664, 864)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(128, 21)
        Me.PortBox.TabIndex = 42
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1117, 1074)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.IPBox)
        Me.Controls.Add(Me.Editor)
        Me.Controls.Add(Me.CheckLog)
        Me.Controls.Add(Me.TextStatus)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.logData)
        Me.Controls.Add(Me.para)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.ActionBar)
        Me.Controls.Add(Me.Launch)
        Me.Controls.Add(Me.GroupGPTVersion)
        Me.DrawerWidth = 400
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(3, 26, 3, 3)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "数字生命"
        Me.GroupGPTVersion.ResumeLayout(False)
        Me.GroupGPTVersion.PerformLayout()
        Me.GroupLogin.ResumeLayout(False)
        Me.GroupLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupGPTVersion As GroupBox
    Friend WithEvents OptionAPI As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents OptionWeb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents TextAPIKey As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents Launch As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ActionBar As Label
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents ComboModSelect As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents TextProxServer As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents para As TextBox
    Friend WithEvents logData As TextBox
    Friend WithEvents Save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextStatus As Label
    Friend WithEvents GroupLogin As GroupBox
    Friend WithEvents GetCookie As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TextOpenAIAcc As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents CheckIsPlus As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents TextOpenAICookie As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents TextOpenAIPass As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents OptionCookie As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents OptionAccAndPass As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents GetAPI As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CheckBW As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents CheckStream As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents ComboCharacterSelect As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CheckLog As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Editor As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IPBox As TextBox
    Friend WithEvents PortBox As TextBox
End Class
