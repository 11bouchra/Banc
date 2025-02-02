Public Class FenetreConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim U As New Utilisateur(Me.TxtLogin.Text, Me.TxtPsw.Text)
        U.Auth.Authentifier()
    End Sub
End Class
