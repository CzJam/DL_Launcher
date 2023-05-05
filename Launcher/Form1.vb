Imports System.Threading
Imports System.IO
Imports System.Text

Public Class Login
    Dim model(), characterName() As String
    Dim apiKey, chatVer, account, passwd, cookie, proxy, plusVer, mode, stream, chara, brainWash As String
    Dim ip, port As String
    Dim apiKeyConfig, chatVerConfig, accountConfig, passwdConfig, cookieConfig, proxyConfig, plusVerConfig, modeConfig, actionBarText, streamConfig, showCommand, charaConfig, brainWashConfig, showLog As String
    Dim lastLine As String
    Dim configFile = Application.StartupPath & "/Config/config.ini"
    Dim modelFile = Application.StartupPath & "/Config/model.ini"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Shell("cmd /c del loglauncher.log")
        actionBarText = " 《数字生命》" & ReadConfig("uiconfig", "version", configFile)
        Thread.Sleep(500)
        'logData.Text = My.Settings.testmode
        ActionBar.Text = actionBarText
        logData.BackColor = Color.FromArgb(231, 231, 231)
        CheckForIllegalCrossThreadCalls = False
        Height = 700
        Width = 470
        Shell("cmd /c del log.log")
        Shell("cmd /c echo. > log.log")
        Shell("cmd /c echo. > logdata.txt")
        TextOpenAICookie.Visible = False
        apiKeyConfig = ReadConfig("uiconfig", "apikey", configFile)
        chatVerConfig = ReadConfig("uiconfig", "chatver", configFile)
        accountConfig = ReadConfig("uiconfig", "acco", configFile)
        passwdConfig = ReadConfig("uiconfig", "password", configFile)
        cookieConfig = ReadConfig("uiconfig", "accesstoken", configFile)
        proxyConfig = ReadConfig("uiconfig", "proxy", configFile)
        plusVerConfig = ReadConfig("uiconfig", "paid", configFile)
        modeConfig = ReadConfig("uiconfig", "model", configFile)
        streamConfig = ReadConfig("uiconfig", "stream", configFile)
        charaConfig = ReadConfig("uiconfig", "character", configFile)
        showLog = ReadConfig("uiconfig", "showlog", configFile)
        showCommand = ReadConfig("uiconfig", "showcommand", configFile)
        GetIpAddress()
        If showCommand = "True" Then
            Height = 700
        Else
            Height = 660
        End If
        Log("Starting launcher.")
        If Not Directory.Exists("GPT\prompts") Then
            Shell("cmd /c echo d | xcopy GPT\prompts_default GPT\prompts")
            Log("Prompts not exist, copied.")
        Else
            Log("Prompts folder exist, skip copy.")

        End If

        If showLog = "True" Then
            Width = 1060
            CheckLog.Checked = True
        Else
            Width = 470
            CheckLog.Checked = False
        End If
        If apiKeyConfig = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & apiKeyConfig
            TextAPIKey.Text = apiKeyConfig
        End If
        'End If



        '3
        If accountConfig = "" And OptionAPI.Checked = False Then
            account = ""
        Else
            account = " --email " & accountConfig
            TextOpenAIAcc.Text = accountConfig
        End If

        '4
        If passwdConfig = "" And OptionAPI.Checked = False Then
            passwd = ""
        Else
            passwd = " --password " & passwdConfig
            TextOpenAIPass.Text = passwdConfig
        End If


        '5
        If cookieConfig = "" And OptionAPI.Checked = False Then
            cookie = ""
        Else
            cookie = " --accessToken " & cookieConfig
            TextOpenAICookie.Text = cookieConfig
        End If


        '6

        If proxyConfig = "" Then
            proxy = ""
        Else
            proxy = " --proxy " & proxyConfig
            TextProxServer.Text = proxyConfig
        End If


        '7
        'MsgBox(modeConfig)

        If OptionAPI.Checked Then
            plusVer = ""
            Dim comboData = ReadConfig("model", "api", modelFile)
            model = Split(comboData, ",")
            ComboModSelect.Items.Clear()
            GetCookie.Visible = True
            For Each ii In model
                ComboModSelect.Items.Add(ii)
            Next ii

            TextAPIKey.Text = apiKey
        Else
            Dim comboData = ReadConfig("model", "web", modelFile)
            model = Split(comboData, ",")
            ComboModSelect.Items.Clear()
            GetCookie.Visible = False
            For Each i In model
                ComboModSelect.Items.Add(i)
            Next i
            If plusVerConfig = "True" Then
                CheckIsPlus.Checked = True
            Else
                CheckIsPlus.Checked = False

            End If
        End If
        ComboModSelect.Text = modeConfig



        '9
        If streamConfig = "True" Then
            CheckStream.Checked = True
            stream = " --stream True"

        Else
            stream = " --stream False"
            CheckStream.Checked = False
        End If

        If brainWashConfig = "True" Then
            CheckBW.Checked = True
            brainWash = " --brainwash True"

        Else
            brainWash = " --brainwash False"
            CheckBW.Checked = False
        End If

        '10
        Dim comboDataCharacter = ReadConfig("model", "character", modelFile)
        model = Split(comboDataCharacter, ",")
        ComboCharacterSelect.Items.Clear()

        For Each u In model
            ComboCharacterSelect.Items.Add(u)
        Next u
        ComboCharacterSelect.Text = charaConfig



        mode = " --model " & modeConfig
        chara = " --character " & charaConfig

        chatVer = " --chatVer " & chatVerConfig
        If chatVerConfig = "3" Then
            OptionAPI.PerformClick()
            account = ""
            passwd = ""
            plusVer = ""
        End If
        'ComboModSelect.SelectedText = modeConfig
        UpdateCommand()
        OptionCookie.PerformClick()

    End Sub


    Private Sub OptionWeb_CheckedChanged(sender As Object, e As EventArgs) Handles OptionWeb.Click

        CheckBW.Enabled = True
        If CheckBW.Checked Then
            brainWash = " --brainwash True"
        Else
            brainWash = " --brainwash False"
        End If

        TextAPIKey.Visible = False
        'TextProxServer.Hint = "代理服务器链接(必填)"
        GroupLogin.Visible = True
        ComboModSelect.Location = New Point(24, 344)
        TextProxServer.Location = New Point(24, 296)
        apiKey = ""
        Dim comboData = ReadConfig("model", "web", modelFile)
        model = Split(comboData, ",")
        ComboModSelect.Items.Clear()

        For Each i In model
            ComboModSelect.Items.Add(i)
        Next i
        ComboModSelect.Text = modeConfig

        account = " --email " & TextOpenAIAcc.Text
        passwd = " --password " & TextOpenAIPass.Text
        cookie = " --accessToken " & TextOpenAICookie.Text
        If CheckIsPlus.Checked Then
            plusVer = " --paid True"
        Else
            plusVer = " --paid False"
        End If

        chatVer = " --chatVer 1"
        chatVerConfig = "1"
        My.Settings.Save()
        UpdateCommand()

    End Sub

    Private Sub OptionAPI_CheckedChanged_1(sender As Object, e As EventArgs) Handles OptionAPI.CheckedChanged

    End Sub

    Private Sub OptionAPI_CheckedChanged(sender As Object, e As EventArgs) Handles OptionAPI.Click

        TextAPIKey.Visible = True
        CheckBW.Enabled = False
        brainWash = " --brainwash False"

        GroupLogin.Visible = False
        'TextProxServer.Hint = "代理服务器链接(必填)"
        ComboModSelect.Location = New Point(24, 224)
        TextProxServer.Location = New Point(24, 176)
        chatVer = " --chatVer 3"
        Dim comboData = ReadConfig("model", "api", modelFile)
        model = Split(comboData, ",")
        ComboModSelect.Items.Clear()

        For Each ii In model
            ComboModSelect.Items.Add(ii)
        Next ii
        ComboModSelect.Text = modeConfig
        If TextAPIKey.Text = "" Then
            apiKey = ""
        Else
            apiKey = " --APIKey " & TextAPIKey.Text
        End If

        If TextProxServer.Text = "" Then
            proxy = ""
        Else
            proxy = " --proxy " & TextProxServer.Text
        End If
        account = ""
        passwd = ""
        cookie = ""
        plusVer = ""

        chatVerConfig = "3"
        My.Settings.Save()
        UpdateCommand()
    End Sub

    Private Sub TextOpenAIAcc_Click_1(sender As Object, e As EventArgs) Handles TextAPIKey.TextChanged
        apiKey = " --APIKey " & TextAPIKey.Text

        UpdateCommand()
    End Sub




    Private Sub CheckLog_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLog.CheckedChanged
        If CheckLog.Checked Then
            Width = 1070
        Else
            Width = 470
        End If
    End Sub

    Private Sub CheckLog_NewCheckedChanged(sender As Object, e As EventArgs) Handles CheckLog.Click
        If CheckLog.Checked Then
            Width = 1060
        Else
            Width = 470
        End If
    End Sub

    Private Sub LaunchPH_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub GetAPI_Click(sender As Object, e As EventArgs) Handles GetAPI.Click
        Shell("cmd /c start guide/getapi.html")
    End Sub

    Private Sub ActionBar_Click(sender As Object, e As EventArgs) Handles ActionBar.Click
        If showCommand = "True" Then
            showCommand = "False"
            WriteConfig("uiconfig", "showcommand", "False", configFile)
            Height = 660
        Else
            showCommand = "True"
            WriteConfig("uiconfig", "showcommand", "True", configFile)
            Height = 700
        End If

    End Sub

    Private Sub TextStatus_Click_1(sender As Object, e As EventArgs) Handles TextStatus.Click
        If TextStatus.Text = "服务器已启动！点击此处选择客户端" Then
            SelectClient.Show()
        End If
    End Sub

    'Private Sub TextStatus_Click(sender As Object, e As EventArgs) Handles TextStatus.MouseWheel
    '    Shell("cmd /c start loglauncher.log", vbHide)

    'End Sub

    Private Sub Editor_Click(sender As Object, e As EventArgs) Handles Editor.Click
        PromptEditor.Show()
    End Sub

    Private Sub CheckBW_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBW.CheckedChanged


        If CheckBW.Checked = "True" Then
            brainWash = " --brainwash True"
        Else
            brainWash = " --brainwash False"
        End If
        UpdateCommand()

    End Sub

    Private Sub TextOpenAIAcc_Click(sender As Object, e As EventArgs) Handles TextOpenAIAcc.Click
        If OptionAPI.Checked = False Then
            account = " --email " & TextOpenAIAcc.Text
        End If
        UpdateCommand()
    End Sub

    Private Sub TextOpenAIPass_Click(sender As Object, e As EventArgs) Handles TextOpenAIPass.Click
        If OptionAPI.Checked = False Then

            passwd = " --password " & TextOpenAIPass.Text
        End If
        UpdateCommand()
    End Sub

    Private Sub CheckIsPlus_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIsPlus.Click
        If CheckIsPlus.Checked And OptionAPI.Checked = False Then
            plusVer = " --paid True"
        Else
            plusVer = " --paid False"

        End If

        UpdateCommand()
    End Sub

    Private Sub ComboModSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboModSelect.SelectedIndexChanged
        'MsgBox(ComboModSelect.SelectedIndex)
        mode = " --model " & ComboModSelect.Text

        UpdateCommand()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles Launch.Click
        SaveConfig()

        'Shell("cmd /c del log_async.log")
        Shell("cmd /c echo. > log_async.log")
        Dim launcher As New Thread(AddressOf StartServer)
        launcher.Start()
    End Sub

    Sub StartServer()
        Log("Starting socketserver.")
        Launch.Text = "启动中"
        TextStatus.Text = "正在启动..."
        TextStatus.BackColor = Color.Red

        'Dim confirm As String
        'confirm = Msgbox2(Me, "服务器已启动", "请选择客户端类型", "手机端", True, "电脑端")
        'If confirm = "OK" Then
        '    MsgBox("OK")
        'Else
        '    MsgBox("no")
        'End If

        Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
        Shell("cmd /c taskkill /f /t /im T.exe", vbHide)
        SelectClient.Close()
        Thread.Sleep(1000)
        Shell("cmd /c " & para.Text, vbHide)
        Log("Using flags：" & para.Text)
        Dim logContent, logSpliter(), lastContent, totalContent() As String
        Dim totalLine As Integer
        Do


            Thread.Sleep(1000)
            'Log("Read log_async.log.")
            logContent = File.ReadAllText("log_async.log", Encoding.Default)
            logSpliter = Split(logContent, " INFO ")
            totalContent = Split(logContent, vbCrLf)
            totalLine = UBound(totalContent)
            logData.Text = logContent + vbCrLf
            logData.SelectionStart = logData.Text.Length
            logData.ScrollToCaret()

            'If totalLine < 32 Then
            '    logData.Text = logContent
            'Else
            '    'AuxData.Text = ""
            '    For i = totalLine - 32 To totalLine
            '        AuxData.AppendText(totalContent(i) + vbCrLf)
            '    Next i

            '    File.WriteAllText("temp", AuxData.Text)
            '    logData.Text = File.ReadAllText("temp")
            'End If
            Try
                lastContent = logSpliter(UBound(logSpliter))
                'If lastContent.Contains("退出") Then
                '    Log("Detect [退出] keyword, kill all process.")

                '    Shell("cmd /c taskkill /f /t /im Launcher.exe", vbHide)
                '    Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
                '    Shell("cmd /c taskkill /f /t /im T.exe", vbHide)
                'End If

                If logContent.Contains("Initializing Server") Then
                    If Not SC("tasklist | findstr /i SocketServer.exe").Contains("Console") Then

                        Log("Socketserver status: offline !!!")
                        TextStatus.Text = "未启动"
                        TextStatus.BackColor = Color.Red
                        logData.AppendText(vbCrLf + "服务器进程已退出！")
                        Shell("cmd /c taskkill /f /t /im T.exe", vbHide)

                        Exit Do
                    Else
                        Log("Socketserver status: online.")
                    End If
                End If


                If lastContent.Contains("Server is listening on") Then
                    Log("Waiting for connection...")


                    Dim ipData() = Split(logSpliter(UBound(logSpliter)), ":")
                    ip = Replace(ipData(0), "Server is listening on", "")
                    port = Replace(ipData(1), "...", "")
                    Launch.Text = "重启服务器"
                    TextStatus.Text = "服务器已启动！点击此处选择客户端"
                    'TextStatus.Text = "服务器已启动"
                    IPBox.Text = ip
                    PortBox.Text = Replace(port, vbCrLf, "")
                    'SelectClient.Show()
                    TextStatus.BackColor = Color.FromArgb(0, 192, 0)
                    'TextStatus.p
                    Thread.Sleep(2000)

                End If

                If lastContent.Contains("Connected by") Then
                    Log("Client connected.")

                    Launch.Text = "重启服务器"
                    TextStatus.Text = "已连接"
                    SelectClient.Close()
                    'LaunchPH.Enabled = False
                    'LaunchUE.Enabled = False

                End If

                If lastContent.Contains("WinError") Then
                    Log("Client disconnected.")

                    Launch.Text = "重启服务器"
                    TextStatus.Text = "未启动"
                    TextStatus.BackColor = Color.Red
                    'Dim confirm As String
                    'confirm = Msgbox2(Me, "客户端已断开", "请选择客户端类型重新连接", "电脑端", True, "手机端")
                    'If confirm = "OK" Then
                    '    Log("Starting UE process")

                    '    Shell("cmd /c Client\T.exe -ip=" & ip & " -port=" & port, vbHide)
                    'Else
                    '    AndroidApk.Show()

                    'End If

                End If
                logData.Focus()
                logData.ScrollToCaret()

            Catch
            End Try
        Loop
        logData.Height = 584
        Dim ipRawData() As String

        ipRawData = Split(File.ReadAllText("logdata.txt"), "Server is listening on ")

    End Sub

    Private Sub ComboCharacterSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCharacterSelect.SelectedIndexChanged
        chara = " --character " & ComboCharacterSelect.Text
        UpdateCommand()
    End Sub

    Private Sub CheckStream_CheckedChanged(sender As Object, e As EventArgs) Handles CheckStream.CheckedChanged
        If CheckStream.Checked Then
            stream = " --stream True"
            WriteConfig("uiconfig", "stream", "True", configFile)

        Else
            stream = " --stream False"
            WriteConfig("uiconfig", "stream", "False", configFile)


        End If
        My.Settings.Save()
        UpdateCommand()
    End Sub


    Private Sub TextOpenAIPass_Click_1(sender As Object, e As EventArgs) Handles TextOpenAIPass.TextChanged
        passwd = " --password " & TextOpenAIPass.Text
        UpdateCommand()
    End Sub



    Private Sub GetCookie_Click(sender As Object, e As EventArgs) Handles GetCookie.Click
        Shell("cmd /c start guide/getcookie.html"， vbHide)
    End Sub


    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveConfig()
        Msgbox2(Me, "成功", "已保存配置！",, False, )
    End Sub

    Private Sub TextOpenAICookie_Click(sender As Object, e As EventArgs) Handles TextOpenAICookie.TextChanged
        cookie = " --accessToken " & TextOpenAICookie.Text
        UpdateCommand()
    End Sub

    Private Sub TextOpenAIProxy_Click(sender As Object, e As EventArgs) Handles TextProxServer.TextChanged
        proxy = " --proxy " & TextProxServer.Text
        UpdateCommand()
    End Sub




    Private Sub OptionCookie_CheckedChanged_1(sender As Object, e As EventArgs) Handles OptionCookie.Click
        TextOpenAICookie.Visible = True
        TextOpenAIAcc.Visible = False
        TextOpenAIPass.Visible = False
        GetCookie.Visible = True
        CheckIsPlus.Enabled = True
        CheckIsPlus.Text = "Plus账号"
        GroupLogin.Height = 208
        cookie = " --accessToken " & TextOpenAICookie.Text
        account = ""
        passwd = ""
        plusVer = ""
        If CheckIsPlus.Checked Then
            plusVer = " --paid True"
        Else
            plusVer = " --paid False"
        End If
        UpdateCommand()
    End Sub

    Private Sub OptionAccAndPass_CheckedChanged(sender As Object, e As EventArgs) Handles OptionAccAndPass.CheckedChanged

    End Sub

    Private Sub OptionAccAndPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles OptionAccAndPass.Click
        TextOpenAICookie.Visible = False
        TextOpenAIAcc.Visible = True
        GetCookie.Visible = False
        CheckIsPlus.Enabled = False
        CheckIsPlus.Text = "Plus账号（暂不可用）"
        plusVer = " --paid False"
        TextOpenAIPass.Visible = True
        GroupLogin.Height = 208
        account = " --email " & TextOpenAIAcc.Text
        passwd = " --password " & TextOpenAIPass.Text
        'If CheckIsPlus.Checked Then
        '    plusVer = " --paid True"
        'Else
        '    plusVer = " --paid False"
        'End If
        cookie = ""

        UpdateCommand()
    End Sub

    Sub UpdateCommand()
        If TextAPIKey.Text = "" Then
            apiKey = ""
        End If
        If TextOpenAIAcc.Text = "" Then
            account = ""
        End If

        If TextOpenAIPass.Text = "" Then
            passwd = ""
        End If

        If TextOpenAICookie.Text = "" Then
            cookie = ""
        End If

        If TextProxServer.Text = "" Then
            proxy = ""
        End If


        para.Text = "SocketServer.exe " & chatVer & apiKey & account & passwd & cookie & proxy & plusVer & brainWash & mode & stream & chara
        Log("Command update：" & para.Text)

    End Sub

    Private Sub CloseForm() Handles Me.FormClosed

        Shell("cmd /c taskkill /f /t /im SocketServer.exe", vbHide)
        Shell("cmd /c taskkill /f /t /im Launcher.exe", vbHide)

    End Sub

    Sub SaveConfig()
        'Log("Save all config.")

        If OptionWeb.Checked Then
            WriteConfig("uiconfig", "chatver", "1", configFile)
        Else
            WriteConfig("uiconfig", "chatver", "3", configFile)
        End If

        WriteConfig("uiconfig", "apikey", TextAPIKey.Text, configFile)
        WriteConfig("uiconfig", "acco", TextOpenAIAcc.Text, configFile)
        WriteConfig("uiconfig", "password", TextOpenAIPass.Text, configFile)
        WriteConfig("uiconfig", "accesstoken", TextOpenAICookie.Text, configFile)
        WriteConfig("uiconfig", "proxy", TextProxServer.Text, configFile)
        WriteConfig("uiconfig", "model", ComboModSelect.Text, configFile)

        If CheckStream.Checked Then
            WriteConfig("uiconfig", "stream", "True", configFile)
        Else
            WriteConfig("uiconfig", "stream", "False", configFile)

        End If

        WriteConfig("uiconfig", "character", ComboCharacterSelect.Text, configFile)

        If CheckLog.Checked Then

            WriteConfig("uiconfig", "showlog", "True", configFile)

        Else
            WriteConfig("uiconfig", "showlog", "False", configFile)

        End If
    End Sub

End Class



'"--chatVer", type = int, required = True) 接入chatgpt版本，1为网页版，3为api版
'    "--APIKey", type = str, required = False) chatVer=3专用：openAI的API Key, 不填就用我们的服务器， 有流量限制。
'    "--email", type = str, required = False) chatVer=1专用：openAI账号
'"--password", type = str, required = False) chatVer=1专用：openAI密码
'"--accessToken", type = str, required = False) chatVer=1专用：openAI cookie，
'    "--proxy", type=str, required=False) 代理服务器链接，用clash可以设置成127.0.0.1:7890
'    "--paid", type = bool, required = False) chatVer=1专用：是否为plus账号 True / False
'    "--model", type = str, required = False) 模型选择，chatVer=1时且
'    "--stream", type = bool, required = True) 是否流式输出语音 True/False
'    "--character", type = str, required = True) 角色选择，现在有两个 paimon yunfei