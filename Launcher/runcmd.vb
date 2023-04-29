Module runcmd
    Public Function SC(ByVal strCMD As String) As String
        Dim p As New Process

        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + strCMD
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()

        Dim result As String = p.StandardOutput.ReadToEnd()
        p.Close()
        Return result

    End Function

    Public Sub Log(content As String)
        IO.File.AppendAllText("loglauncher.log", Now.ToString("【yyyy-MM-dd HH:mm:ss】   ") & content & vbCrLf)
    End Sub

End Module
