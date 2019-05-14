<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ListBoxTitleName = New System.Windows.Forms.ListBox()
        Me.ButtonChangeTitileName = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TimerCheckActiveWindow = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAutoStop = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'ListBoxTitleName
        '
        Me.ListBoxTitleName.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.ListBoxTitleName.FormattingEnabled = true
        Me.ListBoxTitleName.ItemHeight = 14
        Me.ListBoxTitleName.Location = New System.Drawing.Point(12, 37)
        Me.ListBoxTitleName.Name = "ListBoxTitleName"
        Me.ListBoxTitleName.Size = New System.Drawing.Size(417, 116)
        Me.ListBoxTitleName.TabIndex = 0
        '
        'ButtonChangeTitileName
        '
        Me.ButtonChangeTitileName.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.ButtonChangeTitileName.Location = New System.Drawing.Point(435, 37)
        Me.ButtonChangeTitileName.Name = "ButtonChangeTitileName"
        Me.ButtonChangeTitileName.Size = New System.Drawing.Size(110, 116)
        Me.ButtonChangeTitileName.TabIndex = 1
        Me.ButtonChangeTitileName.Text = "เริ่มทำงาน"
        Me.ButtonChangeTitileName.UseVisualStyleBackColor = true
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 161)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.Text = "เพิ่ม"
        Me.ButtonAdd.UseVisualStyleBackColor = true
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 161)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 3
        Me.ButtonEdit.Text = "แก้ไข"
        Me.ButtonEdit.UseVisualStyleBackColor = true
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(174, 161)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "ลบ"
        Me.ButtonDelete.UseVisualStyleBackColor = true
        '
        'TimerCheckActiveWindow
        '
        Me.TimerCheckActiveWindow.Interval = 200
        '
        'TimerAutoStop
        '
        Me.TimerAutoStop.Interval = 60000
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "โดย ๑แมวหมวย๑ แห่งพรรคMaYaKinG "
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(557, 24)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 196)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonChangeTitileName)
        Me.Controls.Add(Me.ListBoxTitleName)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมเปลี่ยนชื่อหน้าต่าง Yulgang"
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ListBoxTitleName As ListBox
    Friend WithEvents ButtonChangeTitileName As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TimerCheckActiveWindow As Timer
    Friend WithEvents TimerAutoStop As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
