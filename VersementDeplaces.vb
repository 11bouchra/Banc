Imports System.Data.SqlClient

Public Class VersementDeplaces

    Private lst As BindingManagerBase
    Private DaV As sqldataAdapter
    Private DtV As New DataTable
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
        Me.lst.Position = Me.DtV.Rows.Count - 1
    End Sub

    Private Sub BtnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjouter.Click
        Me.DaV.Update(Me.DtV)
        Me.lst.AddNew()
    End Sub

    Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaV.Update(DtV)
    End Sub

    Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click
        Me.DtV.Rows(Me.lst.Position).Delete()
    End Sub

    Private Sub BtnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifier.Click
        Me.lst.Position += 1
        Me.lst.Position -= 1
        Me.DaV.Update(DtV)
    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub VersementDeplaces_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand = Service.user.Auth.cnx.CreateCommand
        cmd.CommandText = "SELECT *  FROM VersementDeplaces"
        Me.DaV = New SqlDataAdapter(cmd)
        Me.DaV.Fill(DtV)
        Me.DataGridView1.DataSource = DtV

        Me.lst = BindingContext(DtV)

        Dim cb As New SqlCommandBuilder(DaV)
        Me.DaV.InsertCommand = cb.GetInsertCommand
        Me.DaV.DeleteCommand = cb.GetDeleteCommand
        Me.DaV.UpdateCommand = cb.GetUpdateCommand
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Me.DaV = Drv.GetDataAdapter("SELECT *  FROM         VersementDeplaces  WHERE   VersementDeplaces.RefV =" & Me.TxtNumR.Text)
        Me.DtV = Dao.GetData(DaV)
        Me.DataGridView1.DataSource = DtV
    End Sub
End Class