Imports System.IO
Imports System.Reflection

Public Class FormCredit
    '
    'The Main API call that will be used for the playback. Simply change the “Integer” to "Long"
    'if your using Classic VB like VB 6.0.
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal _
        lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
            Integer, ByVal hwndCallback As Integer) As Integer

    '
    'Will hold the path to the movie file.
    Dim currentPath As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
    Dim filename As String = New Uri(Path.Combine(currentPath, "credit.vd")).LocalPath

    '
    'Holds the return value of mciSendstring. Not used for anything in this article though.
    Dim retVal As Integer

    Private Sub PlayVideo()
        ''
        ''Now add the quotes around the path.
        filename = Chr(34) & filename & Chr(34)

        '
        'Specify the mpegvideo driver to play the movies which should play most movie formats without any problems.
        'This code will have the video open in Panel and the alias name will be “movie”.
        '
        retVal = mciSendString("open " & filename & " type mpegvideo alias movie parent " _
            & PanelVideo.Handle.ToInt32 & " style child", "", 0, 0)

        'Start Playing the movie once you’ve setup the device with your file.
        retVal = mciSendString("play movie from 0 repeat", "", 0, 0)
    End Sub

    Private Sub StopVideo() 
        'Will Stop the playback if its currently playing.
        retVal = mciSendString("stop movie", "", 0, 0)

    End Sub

    Private Sub FormCredit_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        retVal = mciSendString("close movie", "", 0, 0)
    End Sub

    Private Sub FormCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayVideo()
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Process.Start(LinkLabel.Text)
    End Sub
End Class