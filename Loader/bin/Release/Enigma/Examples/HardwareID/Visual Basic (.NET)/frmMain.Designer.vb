<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbRegName = New System.Windows.Forms.Label()
        Me.lbRegInfo = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.tbKey = New System.Windows.Forms.TextBox()
        Me.lbKey = New System.Windows.Forms.Label()
        Me.tbUserInfo = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.tbHardware = New System.Windows.Forms.TextBox()
        Me.lbHardware = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbRegName
        '
        Me.lbRegName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbRegName.ForeColor = System.Drawing.Color.Red
        Me.lbRegName.Location = New System.Drawing.Point(15, 257)
        Me.lbRegName.Name = "lbRegName"
        Me.lbRegName.Size = New System.Drawing.Size(376, 16)
        Me.lbRegName.TabIndex = 23
        Me.lbRegName.Text = "UNREGISTERED"
        Me.lbRegName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbRegInfo
        '
        Me.lbRegInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbRegInfo.Location = New System.Drawing.Point(15, 241)
        Me.lbRegInfo.Name = "lbRegInfo"
        Me.lbRegInfo.Size = New System.Drawing.Size(160, 16)
        Me.lbRegInfo.TabIndex = 22
        Me.lbRegInfo.Text = "This copy is registered to:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(295, 209)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 20)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(191, 209)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 20)
        Me.btnRegister.TabIndex = 20
        Me.btnRegister.Text = "Register"
        '
        'tbKey
        '
        Me.tbKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbKey.Location = New System.Drawing.Point(7, 145)
        Me.tbKey.Multiline = True
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Size = New System.Drawing.Size(384, 56)
        Me.tbKey.TabIndex = 19
        '
        'lbKey
        '
        Me.lbKey.Location = New System.Drawing.Point(7, 129)
        Me.lbKey.Name = "lbKey"
        Me.lbKey.Size = New System.Drawing.Size(88, 16)
        Me.lbKey.TabIndex = 18
        Me.lbKey.Text = "Registration key"
        '
        'tbUserInfo
        '
        Me.tbUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbUserInfo.Location = New System.Drawing.Point(7, 97)
        Me.tbUserInfo.Name = "tbUserInfo"
        Me.tbUserInfo.Size = New System.Drawing.Size(384, 20)
        Me.tbUserInfo.TabIndex = 17
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(7, 81)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 16)
        Me.label1.TabIndex = 16
        Me.label1.Text = "User information"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(287, 49)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(104, 20)
        Me.btnCopy.TabIndex = 15
        Me.btnCopy.Text = "Copy to clipboard"
        '
        'tbHardware
        '
        Me.tbHardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tbHardware.Location = New System.Drawing.Point(7, 49)
        Me.tbHardware.Name = "tbHardware"
        Me.tbHardware.ReadOnly = True
        Me.tbHardware.Size = New System.Drawing.Size(264, 20)
        Me.tbHardware.TabIndex = 14
        '
        'lbHardware
        '
        Me.lbHardware.Location = New System.Drawing.Point(7, 33)
        Me.lbHardware.Name = "lbHardware"
        Me.lbHardware.Size = New System.Drawing.Size(88, 16)
        Me.lbHardware.TabIndex = 13
        Me.lbHardware.Text = "PC Hardware ID"
        '
        'lbInfo
        '
        Me.lbInfo.Location = New System.Drawing.Point(7, 9)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(400, 16)
        Me.lbInfo.TabIndex = 12
        Me.lbInfo.Text = "This example shows you how to work with Enigma API under .NET application."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 278)
        Me.Controls.Add(Me.lbRegName)
        Me.Controls.Add(Me.lbRegInfo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.tbKey)
        Me.Controls.Add(Me.lbKey)
        Me.Controls.Add(Me.tbUserInfo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.tbHardware)
        Me.Controls.Add(Me.lbHardware)
        Me.Controls.Add(Me.lbInfo)
        Me.Name = "frmMain"
        Me.Text = "Test .NET Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbRegName As System.Windows.Forms.Label
    Private WithEvents lbRegInfo As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnRegister As System.Windows.Forms.Button
    Private WithEvents tbKey As System.Windows.Forms.TextBox
    Private WithEvents lbKey As System.Windows.Forms.Label
    Private WithEvents tbUserInfo As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnCopy As System.Windows.Forms.Button
    Private WithEvents tbHardware As System.Windows.Forms.TextBox
    Private WithEvents lbHardware As System.Windows.Forms.Label
    Private WithEvents lbInfo As System.Windows.Forms.Label

End Class
