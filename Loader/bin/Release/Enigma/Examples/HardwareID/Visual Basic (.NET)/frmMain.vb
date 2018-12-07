Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbHardware.Text = Enigma_IDE.EP_RegHardwareID()
        OnRegistration(Enigma_IDE.EP_RegLoadAndCheckKey())
    End Sub

    Private Sub OnRegistration(registered As Boolean)
        If registered Then
            Dim sName As String = ""
            ' Create variable for registration name
            Dim sKey As String = ""
            ' Create variable for registration key
            Enigma_IDE.EP_RegLoadKey(sName, sKey)
            ' Load registration information
            ' Set control text to registred user information
            lbRegName.Text = sName
        Else
            ' Unregistered text
            lbRegName.Text = "UNREGISTERED"
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        tbHardware.Copy()
    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        If Enigma_IDE.EP_RegCheckAndSaveKey(tbUserInfo.Text, tbKey.Text) Then
            OnRegistration(True)
            MessageBox.Show("Registration key is valid!" & vbLf & "Thanks you for registration!!!", "Registration completed")
        Else
            OnRegistration(False)
            MessageBox.Show("Registration key is invalid!" & vbLf & "Please, try again!!!", "Registration incompleted")
        End If
    End Sub

End Class
