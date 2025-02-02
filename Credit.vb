Imports System.Data.SqlClient

Public Class Credit

    Private lst As BindingManagerBase
    Private DaC As SqlDataAdapter
    Private DtC As New DataTable
    Private DaCl As SqlDataAdapter
    Private DtCl As New DataTable
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
        Me.DaC.Update(Me.DtC)
        Me.lst.AddNew()
    End Sub

    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaC.Update(DtC)
    End Sub

    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.DtC.Rows(Me.lst.Position).Delete()
    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaC.Update(DtC)
    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub Credit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "select * from client"
        Me.DaC = New SqlDataAdapter(cmd)
        Me.DaC.Fill(DtC)
        Me.CmbNum.DataSource = DtC
        Me.CmbNum.DisplayMember = Me.DtC.Columns(0).ColumnName

        'Me.lst = BindingContext(DtC)

        Dim cb As New SqlCommandBuilder(DaCl)
        Me.DaCl.InsertCommand = cb.GetInsertCommand
        Me.DaCl.DeleteCommand = cb.GetDeleteCommand
        Me.DaCl.UpdateCommand = cb.GetUpdateCommand
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNum.SelectedIndexChanged
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "SELECT     * FROM Credit  where Credit.NumCompte =@NumCompte"
        cmd.Parameters.AddWithValue("@NumCompte", Me.DtC.Rows(Me.CmbNum.SelectedIndex).Item(0))
        Me.DaCl = New SqlDataAdapter(cmd)
        Me.DtCl.Rows.Clear()
        Me.DaCl.Fill(DtCl)
        Me.DataGridView1.DataSource = DtCl

        Me.lst = BindingContext(DtCl)
    End Sub
End Class