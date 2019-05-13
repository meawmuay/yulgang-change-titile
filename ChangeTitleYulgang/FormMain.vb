Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class FormMain
    Private _filenameListBox As String = "db.ini"
    Private _starting As Boolean = False
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    Private Declare Function SetWindowText Lib "user32" Alias "SetWindowTextA"  (ByVal hWnd As IntPtr, ByVal text As String) As IntPtr
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer


    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim title = InputBox("กรุณาใส่ชื่อที่ต้องการ")
        If title IsNot "" Then
            ListBoxTitleName.Items.Add(title)
            SaveListBoxToTextFile()
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If ListBoxTitleName.SelectedIndex > -1 Then
            ListBoxTitleName.Items.RemoveAt(ListBoxTitleName.SelectedIndex)
            SaveListBoxToTextFile()
        Else
            MsgBox("กรุณาเลือกรายการที่ต้องการลบก่อน!")
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If ListBoxTitleName.SelectedIndex > -1 Then
            Dim title = InputBox("กรุณาใส่ชื่อที่ต้องการ", , ListBoxTitleName.SelectedItem.ToString())
            ListBoxTitleName.Items(ListBoxTitleName.SelectedIndex) = title
            SaveListBoxToTextFile()
        Else
            MsgBox("กรุณาเลือกรายการที่ต้องการแก้ไขก่อน!")
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " " & Assembly.GetExecutingAssembly().GetName().Version.ToString()
        LoadListBoxFromTextFile()
    End Sub

    Private Sub LoadListBoxFromTextFile()
        Dim currentPath As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
        Dim filePath As String = New Uri(Path.Combine(currentPath, _filenameListBox)).LocalPath
        If File.Exists(filePath) Then
            Dim objStreamReader As StreamReader
            Dim strLine As String
            objStreamReader = New StreamReader(filePath)
            strLine = objStreamReader.ReadLine
            Do While Not strLine Is Nothing
                ListBoxTitleName.Items.Add(strLine)
                strLine = objStreamReader.ReadLine
            Loop
            objStreamReader.Close()
        End If
    End Sub

    Private Sub SaveListBoxToTextFile()
        Dim currentPath As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
        Dim filePath As String = New Uri(Path.Combine(currentPath, _filenameListBox)).LocalPath
        Dim file As StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, False)
        For Each item In ListBoxTitleName.Items
            file.WriteLine(item.ToString())
        Next
        file.Close()
    End Sub

    Private Sub ButtonChangeTitileName_Click(sender As Object, e As EventArgs) Handles ButtonChangeTitileName.Click
        'Dim windowToFind As IntPtr = FindWindow(Nothing, "YGOnline")
        'SetWindowText(WindowToFind, "ทดสอบแก้ไข  - ร้านค้า1 - วุธ+101")
        StartChangeTitle()
    End Sub

    Private sub ChangeTitleYgOnline

    End sub

    Private Sub TimerCheckActiveWindow_Tick(sender As Object, e As EventArgs) Handles TimerCheckActiveWindow.Tick
        Dim title As New Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, title, title.Capacity)
        if title.ToString().StartsWith("YGOnline") Then
            SetWindowText(hWnd, "YGOnline - " & ListBoxTitleName.SelectedItem.ToString())
            TimerCheckActiveWindow.Enabled = False
            StopChangeTitle()
        End If
    End Sub

    Private sub StartChangeTitle()
        If ListBoxTitleName.SelectedIndex <= -1 Then
            MsgBox("กรุณาเลือกรายการที่ต้องการใช้งานก่อน!")
            return
        End If

        _starting = True
        ButtonChangeTitileName.Text = "รอเลือกหน้าต่างเกม..."
        ButtonChangeTitileName.Enabled = False
        TimerCheckActiveWindow.Enabled = True
        TimerAutoStop.Enabled = True
        TopMost = True
    End sub

    Private sub StopChangeTitle()
        _starting = False
        ButtonChangeTitileName.Text = "เริ่มทำงาน"
        ButtonChangeTitileName.Enabled = True
        TimerCheckActiveWindow.Enabled = False
        TimerAutoStop.Enabled = False
        TopMost = False
    End sub

    Private Sub TimerAutoStop_Tick(sender As Object, e As EventArgs) Handles TimerAutoStop.Tick
        If _starting Then
            StopChangeTitle()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FormCredit.Show()
    End Sub
End Class
