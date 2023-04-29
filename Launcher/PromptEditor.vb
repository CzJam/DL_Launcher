Imports System.IO
Imports System.Threading

Public Class PromptEditor
    Dim currentFile As String
    Private Sub PromptEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 840
        If Login.ComboModSelect.Text.Contains("3.5") Then
            ActionBar.Text = " 提示词编辑器 " & Login.ComboCharacterSelect.Text & "/" & Login.ComboModSelect.Text
            currentFile = Login.ComboCharacterSelect.Text & "35.txt"
            PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
        Else

            If Login.ComboModSelect.Text.Contains("4") Then
                ActionBar.Text = " 提示词编辑器 " & Login.ComboCharacterSelect.Text & "/" & Login.ComboModSelect.Text
                currentFile = Login.ComboCharacterSelect.Text & "4.txt"
                PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
            Else
                PromptTextBox.Text = "未找到提示词"
            End If
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        File.WriteAllText("GPT\prompts\" & currentFile, PromptTextBox.Text)
        Msgbox2(Me, "成功", "已保存！点击确定关闭窗口",, False, )
        Close()
    End Sub

    Private Sub Restore_Click(sender As Object, e As EventArgs) Handles Restore.Click
        Dim confirm As String
        confirm = Msgbox2(Me, "提示", "要恢复原始提示词吗？当前提示词将被覆盖！",, True, )
        If confirm = "OK" Then
            PromptTextBox.Text = "恢复中..."
            Dim uu As New Thread(AddressOf Startcopy)
            uu.Start()
        End If
    End Sub

    Sub Startcopy()
        Shell("cmd /c del GPT\prompts\" & currentFile, vbHide)
        Shell("cmd /c copy GPT\prompts_default\" & currentFile & " " & "GPT\prompts\" & currentFile)
        Thread.Sleep(1500)
        PromptTextBox.Text = File.ReadAllText("GPT\prompts\" & currentFile)
    End Sub
End Class