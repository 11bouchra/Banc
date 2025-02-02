Public Class MenuUtilisateur

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim n As New retraitDeplaces
        n.Show()
    End Sub

    Private Sub BtnCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCredit.Click
        Dim n As New Credit
        n.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n As New OuvertureDeCompte
        n.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n As New AchatDevise
        n.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As New VersementDeplaces
        n.Show()
    End Sub
End Class