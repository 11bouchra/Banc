Imports System.Data.SqlClient
Public Class retraitDeplaces
    Private lst As BindingManagerBase
    Private populaire As Populaire
    Private DaR As SqlDataAdapter
    Private DtR As New DataTable
    Private Sub retraitDeplaces_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.populaire = New Populaire
        'Me.populaire.ChargerRetrait()
        'Me.DataGridView1.DataSource = Me.populaire.Dtr
        'Me.lst = BindingContext(Me.populaire.Dtr)
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "select * from retraitdeplaces"
        Me.DaR = New SqlDataAdapter(cmd)
        Me.DaR.Fill(DtR)
        Me.DataGridView1.DataSource = DtR

        Me.lst = BindingContext(DtR)

        Dim cb As New SqlCommandBuilder(DaR)
        Me.DaR.InsertCommand = cb.GetInsertCommand
        Me.DaR.DeleteCommand = cb.GetDeleteCommand
        Me.DaR.UpdateCommand = cb.GetUpdateCommand
    End Sub
    Private Sub BtnPremier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPremier.Click
        Me.Lst.Position = 0
    End Sub
    Private Sub BtnSuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuivant.Click
        Me.Lst.Position += 1
    End Sub
    Private Sub Btnprecedent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprecedent.Click
        Me.Lst.Position -= 1
    End Sub
    Private Sub BtnDernier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDernier.Click
        Me.lst.Position = Me.DtR.Rows.Count - 1
    End Sub
    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        Me.DaR.Update(Me.DtR)
        Me.lst.AddNew()
    End Sub
    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaR.Update(DtR)
    End Sub
    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.DtR.Rows(Me.lst.Position).Delete()
    End Sub
    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaR.Update(DtR)
    End Sub
    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub
End Class