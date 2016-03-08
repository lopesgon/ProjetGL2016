<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTypeClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTypeClient))
        Me.rbPhysique = New System.Windows.Forms.RadioButton()
        Me.rbMorale = New System.Windows.Forms.RadioButton()
        Me.gbTypeClient = New System.Windows.Forms.GroupBox()
        Me.btnConfirmer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.gbTypeClient.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbPhysique
        '
        Me.rbPhysique.AutoSize = True
        Me.rbPhysique.Checked = True
        Me.rbPhysique.Location = New System.Drawing.Point(18, 19)
        Me.rbPhysique.Name = "rbPhysique"
        Me.rbPhysique.Size = New System.Drawing.Size(115, 17)
        Me.rbPhysique.TabIndex = 0
        Me.rbPhysique.TabStop = True
        Me.rbPhysique.Text = "Personne &physique"
        Me.rbPhysique.UseVisualStyleBackColor = True
        '
        'rbMorale
        '
        Me.rbMorale.AutoSize = True
        Me.rbMorale.Location = New System.Drawing.Point(18, 45)
        Me.rbMorale.Name = "rbMorale"
        Me.rbMorale.Size = New System.Drawing.Size(104, 17)
        Me.rbMorale.TabIndex = 1
        Me.rbMorale.Text = "Personne &morale"
        Me.rbMorale.UseVisualStyleBackColor = True
        '
        'gbTypeClient
        '
        Me.gbTypeClient.Controls.Add(Me.rbPhysique)
        Me.gbTypeClient.Controls.Add(Me.rbMorale)
        Me.gbTypeClient.Location = New System.Drawing.Point(12, 12)
        Me.gbTypeClient.Name = "gbTypeClient"
        Me.gbTypeClient.Size = New System.Drawing.Size(227, 72)
        Me.gbTypeClient.TabIndex = 2
        Me.gbTypeClient.TabStop = False
        Me.gbTypeClient.Text = "&Type de client"
        '
        'btnConfirmer
        '
        Me.btnConfirmer.Location = New System.Drawing.Point(164, 90)
        Me.btnConfirmer.Name = "btnConfirmer"
        Me.btnConfirmer.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmer.TabIndex = 3
        Me.btnConfirmer.Text = "&Confirmer"
        Me.btnConfirmer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(83, 90)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 4
        Me.btnAnnuler.Text = "&Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'FrmTypeClient
        '
        Me.AcceptButton = Me.btnConfirmer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(251, 122)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnConfirmer)
        Me.Controls.Add(Me.gbTypeClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTypeClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau client"
        Me.gbTypeClient.ResumeLayout(False)
        Me.gbTypeClient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbPhysique As RadioButton
    Friend WithEvents rbMorale As RadioButton
    Friend WithEvents gbTypeClient As GroupBox
    Friend WithEvents btnConfirmer As Button
    Friend WithEvents btnAnnuler As Button
End Class
