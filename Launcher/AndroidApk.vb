Public Class SelectClient
    Dim ip = Login.IPBox.Text
    Dim port = Login.PortBox.Text
    Private Sub AndroidApk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 520
        Width = 270
        IPAddr.Text = ip & ":" & port
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Shell("cmd /c explorer.exe apks", vbHide)

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Log("Starting UE process")
        Shell("cmd /c Client\T.exe -ip=" & ip & " -port=" & port, vbHide)
    End Sub

    Private Sub ClientDetector_Tick(sender As Object, e As EventArgs) Handles ClientDetector.Tick
        If Not Login.TextStatus.Text = "服务器已启动！点击此处选择客户端" Then
            ClientDetector.Enabled = False
            Close()
        End If
    End Sub
End Class