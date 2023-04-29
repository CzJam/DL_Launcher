Imports MaterialSkin.Controls

Module ProfileExecutor

    Public Declare Function GetConfigInfo Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String,
                                                                                                      ByVal lpKeyName As String,
                                                                                                      ByVal lpDefault As String,
                                                                                                      ByVal lpReturnedString As String,
                                                                                                      ByVal nSize As Integer,
                                                                                                      ByVal lpFileName As String) As Integer

    Public Declare Function WriteConfigInfo Lib “kernel32” Alias “WritePrivateProfileStringA” (ByVal lpApplicationName As String,
                                                                                               ByVal lpKeyName As String,
                                                                                               ByVal lpString As String,
                                                                                               ByVal lpFileName As String) As Integer

    Public Function ReadConfig(AppName As String, keyName As String, file As String)
        Dim Str As String = LSet(Str, 256)
        GetConfigInfo(AppName, keyName, "N/A", Str, Len(Str), file)
        Return Left(Str, InStr(Str, Chr(0)) - 1)

    End Function


    Public Sub WriteConfig(AppName As String, keyName As String, value As String, file As String)
        WriteConfigInfo(AppName, keyName, value, file)
    End Sub

    Public Function Msgbox2(form As Form, title As String, content As String, Optional okBtn As String = "确定", Optional cancel As Boolean = False, Optional noBtn As String = "取消") As String
        Dim ms As New MaterialDialog(form, title, content, okBtn, cancel, noBtn)
        Dim result As DialogResult = ms.ShowDialog(form)
        Return result.ToString
    End Function

    Public Sub SnackBar(form As Form, content As String, Optional duration As Integer = 3000)
        Dim sb As New MaterialSnackBar(content, duration)
        sb.Show(form)
    End Sub
End Module
