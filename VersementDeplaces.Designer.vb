<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VersementDeplaces
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
        Me.BtnFermer = New System.Windows.Forms.Button
        Me.BtnSupprimer = New System.Windows.Forms.Button
        Me.BtnModifier = New System.Windows.Forms.Button
        Me.BtnEnregistrer = New System.Windows.Forms.Button
        Me.BtnAjouter = New System.Windows.Forms.Button
        Me.BtnDernier = New System.Windows.Forms.Button
        Me.Btnprecedent = New System.Windows.Forms.Button
        Me.BtnSuivant = New System.Windows.Forms.Button
        Me.BtnPremier = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnOK = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtNumR = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(361, 215)
        Me.DataGridView1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "versementDeplaces"
        '
        'BtnFermer
        '
        Me.BtnFermer.Location = New System.Drawing.Point(133, 97)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 23)
        Me.BtnFermer.TabIndex = 34
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(106, 19)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.BtnSupprimer.TabIndex = 33
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Location = New System.Drawing.Point(286, 19)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(75, 23)
        Me.BtnModifier.TabIndex = 32
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.Location = New System.Drawing.Point(187, 19)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnregistrer.TabIndex = 31
        Me.BtnEnregistrer.Text = "enregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(25, 19)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.BtnAjouter.TabIndex = 30
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'BtnDernier
        '
        Me.BtnDernier.Location = New System.Drawing.Point(613, 48)
        Me.BtnDernier.Name = "BtnDernier"
        Me.BtnDernier.Size = New System.Drawing.Size(75, 23)
        Me.BtnDernier.TabIndex = 38
        Me.BtnDernier.Text = "Dernier"
        Me.BtnDernier.UseVisualStyleBackColor = True
        '
        'Btnprecedent
        '
        Me.Btnprecedent.Location = New System.Drawing.Point(529, 48)
        Me.Btnprecedent.Name = "Btnprecedent"
        Me.Btnprecedent.Size = New System.Drawing.Size(75, 23)
        Me.Btnprecedent.TabIndex = 37
        Me.Btnprecedent.Tag = "precedent"
        Me.Btnprecedent.Text = "Precedent"
        Me.Btnprecedent.UseVisualStyleBackColor = True
        '
        'BtnSuivant
        '
        Me.BtnSuivant.Location = New System.Drawing.Point(448, 48)
        Me.BtnSuivant.Name = "BtnSuivant"
        Me.BtnSuivant.Size = New System.Drawing.Size(75, 23)
        Me.BtnSuivant.TabIndex = 36
        Me.BtnSuivant.Text = "Suivant"
        Me.BtnSuivant.UseVisualStyleBackColor = True
        '
        'BtnPremier
        '
        Me.BtnPremier.Location = New System.Drawing.Point(367, 48)
        Me.BtnPremier.Name = "BtnPremier"
        Me.BtnPremier.Size = New System.Drawing.Size(75, 23)
        Me.BtnPremier.TabIndex = 35
        Me.BtnPremier.Text = "Premier"
        Me.BtnPremier.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFermer)
        Me.GroupBox2.Controls.Add(Me.BtnSupprimer)
        Me.GroupBox2.Controls.Add(Me.BtnDernier)
        Me.GroupBox2.Controls.Add(Me.BtnEnregistrer)
        Me.GroupBox2.Controls.Add(Me.Btnprecedent)
        Me.GroupBox2.Controls.Add(Me.BtnModifier)
        Me.GroupBox2.Controls.Add(Me.BtnSuivant)
        Me.GroupBox2.Controls.Add(Me.BtnAjouter)
        Me.GroupBox2.Controls.Add(Me.BtnPremier)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 126)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(104, 56)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(94, 31)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtNumR)
        Me.GroupBox3.Controls.Add(Me.BtnOK)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(388, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(341, 105)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        '
        'TxtNumR
        '
        Me.TxtNumR.Location = New System.Drawing.Point(154, 19)
        Me.TxtNumR.Name = "TxtNumR"
        Me.TxtNumR.Size = New System.Drawing.Size(171, 20)
        Me.TxtNumR.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Num D'entreprise"
        '
        'VersementDeplaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 464)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VersementDeplaces"
        Me.Text = "VersementDeplaces"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents BtnDernier As System.Windows.Forms.Button
    Friend WithEvents Btnprecedent As System.Windows.Forms.Button
    Friend WithEvents BtnSuivant As System.Windows.Forms.Button
    Friend WithEvents BtnPremier As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNumR As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
