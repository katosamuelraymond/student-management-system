Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class loginform
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles pwdvisible.CheckedChanged
        If pwdvisible.Checked Then
            ' Show password
            stdpswdarea.PasswordChar = ControlChars.NullChar
        Else
            ' Hide password
            stdpswdarea.PasswordChar = "*"c
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dashboard.Show()
    End Sub
End Class
