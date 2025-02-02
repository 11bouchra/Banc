Imports System.Data.SqlClient

Public Class AchatDevise
    Private lst As BindingManagerBase
    Private DaAD As SqlDataAdapter
    Private DtAV As New DataTable
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
        Me.lst.Position = Me.DtAV.Rows.Count - 1
    End Sub

    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        Me.DaAD.Update(Me.DtAV)
        Me.lst.AddNew()
    End Sub

    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaAD.Update(DtAV)
    End Sub

    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.DtAV.Rows(Me.lst.Position).Delete()
    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaAD.Update(DtAV)
    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub AchatDevise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "select * from AchatDevise"
        Me.DaAD = New SqlDataAdapter(cmd)
        Me.DaAD.Fill(DtAV)
        Me.DataGridView1.DataSource = DtAV

        Me.lst = BindingContext(DtAV)

        Dim cb As New SqlCommandBuilder(DaAD)
        Me.DaAD.InsertCommand = cb.GetInsertCommand
        Me.DaAD.DeleteCommand = cb.GetDeleteCommand
        Me.DaAD.UpdateCommand = cb.GetUpdateCommand
    End Sub
End Class