<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbNum = New System.Windows.Forms.ComboBox
        Me.BtnAjouter = New System.Windows.Forms.Button
        Me.BtnEnregistrer = New System.Windows.Forms.Button
        Me.BtnModifier = New System.Windows.Forms.Button
        Me.BtnSupprimer = New System.Windows.Forms.Button
        Me.BtnPremier = New System.Windows.Forms.Button
        Me.BtnSuivant = New System.Windows.Forms.Button
        Me.Btnprecedent = New System.Windows.Forms.Button
        Me.BtnDernier = New System.Windows.Forms.Button
        Me.BtnFermer = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(457, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "credit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NumCompte"
        '
        'CmbNum
        '
        Me.CmbNum.FormattingEnabled = True
        Me.CmbNum.Location = New System.Drawing.Point(133, 81)
        Me.CmbNum.Name = "CmbNum"
        Me.CmbNum.Size = New System.Drawing.Size(121, 21)
        Me.CmbNum.TabIndex = 20
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(26, 294)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.BtnAjouter.TabIndex = 21
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.Location = New System.Drawing.Point(133, 293)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnregistrer.TabIndex = 22
        Me.BtnEnregistrer.Text = "enregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Location = New System.Drawing.Point(229, 293)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(75, 23)
        Me.BtnModifier.TabIndex = 23
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(337, 293)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.BtnSupprimer.TabIndex = 24
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnPremier
        '
        Me.BtnPremier.Location = New System.Drawing.Point(523, 135)
        Me.BtnPremier.Name = "BtnPremier"
        Me.BtnPremier.Size = New System.Drawing.Size(75, 23)
        Me.BtnPremier.TabIndex = 25
        Me.BtnPremier.Text = "Premier"
        Me.BtnPremier.UseVisualStyleBackColor = True
        '
        'BtnSuivant
        '
        Me.BtnSuivant.Location = New System.Drawing.Point(523, 177)
        Me.BtnSuivant.Name = "BtnSuivant"
        Me.BtnSuivant.Size = New System.Drawing.Size(75, 23)
        Me.BtnSuivant.TabIndex = 26
        Me.BtnSuivant.Text = "Suivant"
        Me.BtnSuivant.UseVisualStyleBackColor = True
        '
        'Btnprecedent
        '
        Me.Btnprecedent.Location = New System.Drawing.Point(523, 219)
        Me.Btnprecedent.Name = "Btnprecedent"
        Me.Btnprecedent.Size = New System.Drawing.Size(75, 23)
        Me.Btnprecedent.TabIndex = 27
        Me.Btnprecedent.Tag = "precedent"
        Me.Btnprecedent.Text = "Precedent"
        Me.Btnprecedent.UseVisualStyleBackColor = True
        '
        'BtnDernier
        '
        Me.BtnDernier.Location = New System.Drawing.Point(523, 262)
        Me.BtnDernier.Name = "BtnDernier"
        Me.BtnDernier.Size = New System.Drawing.Size(75, 23)
        Me.BtnDernier.TabIndex = 28
        Me.BtnDernier.Text = "Dernier"
        Me.BtnDernier.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(428, 293)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 23)
        Me.BtnFermer.TabIndex = 29
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'Credit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 372)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnDernier)
        Me.Controls.Add(Me.Btnprecedent)
        Me.Controls.Add(Me.BtnSuivant)
        Me.Controls.Add(Me.BtnPremier)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.BtnAjouter)
        Me.Controls.Add(Me.CmbNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Credit"
        Me.Text = "Credit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbNum As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnPremier As System.Windows.Forms.Button
    Friend WithEvents BtnSuivant As System.Windows.Forms.Button
    Friend WithEvents Btnprecedent As System.Windows.Forms.Button
    Friend WithEvents BtnDernier As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
End Class
