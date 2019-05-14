<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCredit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCredit))
        Me.PanelVideo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout
        '
        'PanelVideo
        '
        Me.PanelVideo.Location = New System.Drawing.Point(-192, 85)
        Me.PanelVideo.Name = "PanelVideo"
        Me.PanelVideo.Size = New System.Drawing.Size(1336, 820)
        Me.PanelVideo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(307, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(27, 547)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(-1, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 547)
        Me.Panel3.TabIndex = 4
        '
        'Label
        '
        Me.Label.AutoSize = true
        Me.Label.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        Me.Label.Location = New System.Drawing.Point(66, 11)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(201, 28)
        Me.Label.TabIndex = 5
        Me.Label.Text = "โปรแกรมนี้จัดทำให้ใช้ฟรี "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"โดย ๑แมวหมวย๑ แห่งพรรคMaYaKinG "
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = true
        Me.LinkLabel.Location = New System.Drawing.Point(37, 50)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(255, 13)
        Me.LinkLabel.TabIndex = 6
        Me.LinkLabel.TabStop = true
        Me.LinkLabel.Text = "https://github.com/meawmuay/yulgang-change-titile"
        '
        'FormCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(333, 588)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelVideo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FormCredit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PanelVideo As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label As Label
    Friend WithEvents LinkLabel As LinkLabel
End Class
