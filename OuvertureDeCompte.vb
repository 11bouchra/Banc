Imports System.Data.SqlClient

Public Class OuvertureDeCompte
    Private lst As BindingManagerBase
    Private DaOv As sqlDataAdapter
    Private DtOv As New DataTable
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
        'Me.lst.Position = Me.......................
    End Sub

    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        Me.DaOv.Update(Me.DtOv)
        Me.lst.AddNew()
    End Sub

    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaOv.Update(DtOv)
    End Sub

    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.DtOv.Rows(Me.lst.Position).Delete()
    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaOv.Update(DtOv)
    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub OuvertureDeCompte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "select * from ouverturedecompte"
        Me.DaOv = New SqlDataAdapter(cmd)
        Me.DaOv.Fill(DtOv)
        Me.DataGridView1.DataSource = DtOv

        Me.lst = BindingContext(DtOv)

        Dim cb As New SqlCommandBuilder(DaOv)
        Me.DaOv.InsertCommand = cb.GetInsertCommand
        Me.DaOv.DeleteCommand = cb.GetDeleteCommand
        Me.DaOv.UpdateCommand = cb.GetUpdateCommand
    End Sub
End Class