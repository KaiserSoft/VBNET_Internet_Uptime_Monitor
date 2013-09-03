Public Class frmAbout

    Private Sub frmabout_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = 27 Or e.KeyCode = 13 Then
            Me.Close()
        End If
    End Sub

    Private Sub frmabout_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'frmAbout.CancelButton = Keys.Escape
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not txtBTC.Text = "" Then
            Clipboard.SetText(txtBTC.Text)
        End If
    End Sub

    Private Sub linkWebsite_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkWebsite.LinkClicked
        Process.Start(linkWebsite.Text)
    End Sub

    Private Sub linkSource_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkSource.LinkClicked
        Process.Start(linkSource.Text)
    End Sub
End Class