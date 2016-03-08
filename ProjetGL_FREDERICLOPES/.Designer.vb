<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNouvelleAdresse
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNouvelleAdresse))
        Me.lblAdresse1 = New System.Windows.Forms.Label()
        Me.tbAdresse1 = New System.Windows.Forms.TextBox()
        Me.lblAdresse2 = New System.Windows.Forms.Label()
        Me.tbAdresse2 = New System.Windows.Forms.TextBox()
        Me.lblNPA = New System.Windows.Forms.Label()
        Me.tbNPA = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.tbVille = New System.Windows.Forms.TextBox()
        Me.lblPays = New System.Windows.Forms.Label()
        Me.cbPays = New System.Windows.Forms.ComboBox()
        Me.btnConfirmer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.tbCP = New System.Windows.Forms.TextBox()
        Me.erpNPA = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.erpNPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdresse1
        '
        Me.lblAdresse1.AutoSize = True
        Me.lblAdresse1.Location = New System.Drawing.Point(12, 15)
        Me.lblAdresse1.Name = "lblAdresse1"
        Me.lblAdresse1.Size = New System.Drawing.Size(55, 13)
        Me.lblAdresse1.TabIndex = 0
        Me.lblAdresse1.Text = "&Adresse1*"
        '
        'tbAdresse1
        '
        Me.tbAdresse1.Location = New System.Drawing.Point(73, 12)
        Me.tbAdresse1.Name = "tbAdresse1"
        Me.tbAdresse1.Size = New System.Drawing.Size(218, 20)
        Me.tbAdresse1.TabIndex = 1
        '
        'lblAdresse2
        '
        Me.lblAdresse2.AutoSize = True
        Me.lblAdresse2.Location = New System.Drawing.Point(12, 41)
        Me.lblAdresse2.Name = "lblAdresse2"
        Me.lblAdresse2.Size = New System.Drawing.Size(51, 13)
        Me.lblAdresse2.TabIndex = 2
        Me.lblAdresse2.Text = "A&dresse2"
        '
        'tbAdresse2
        '
        Me.tbAdresse2.Location = New System.Drawing.Point(73, 38)
        Me.tbAdresse2.Name = "tbAdresse2"
        Me.tbAdresse2.Size = New System.Drawing.Size(218, 20)
        Me.tbAdresse2.TabIndex = 3
        '
        'lblNPA
        '
        Me.lblNPA.AutoSize = True
        Me.lblNPA.Location = New System.Drawing.Point(12, 67)
        Me.lblNPA.Name = "lblNPA"
        Me.lblNPA.Size = New System.Drawing.Size(33, 13)
        Me.lblNPA.TabIndex = 4
        Me.lblNPA.Text = "&NPA*"
        '
        'tbNPA
        '
        Me.tbNPA.Location = New System.Drawing.Point(73, 64)
        Me.tbNPA.Name = "tbNPA"
        Me.tbNPA.Size = New System.Drawing.Size(100, 20)
        Me.tbNPA.TabIndex = 5
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Location = New System.Drawing.Point(12, 93)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(30, 13)
        Me.lblVille.TabIndex = 6
        Me.lblVille.Text = "&Ville*"
        '
        'tbVille
        '
        Me.tbVille.Location = New System.Drawing.Point(73, 90)
        Me.tbVille.Name = "tbVille"
        Me.tbVille.Size = New System.Drawing.Size(100, 20)
        Me.tbVille.TabIndex = 7
        '
        'lblPays
        '
        Me.lblPays.AutoSize = True
        Me.lblPays.Location = New System.Drawing.Point(12, 119)
        Me.lblPays.Name = "lblPays"
        Me.lblPays.Size = New System.Drawing.Size(34, 13)
        Me.lblPays.TabIndex = 8
        Me.lblPays.Text = "Pa&ys*"
        '
        'cbPays
        '
        Me.cbPays.FormattingEnabled = True
        Me.cbPays.Items.AddRange(New Object() {"Allemagne", "Angleterre", "Autriche", "Belgique", "Espagne", "France", "Italie", "Liechtenstein", "Luxembourg", "Portugal", "Suisse"})
        Me.cbPays.Location = New System.Drawing.Point(73, 116)
        Me.cbPays.Name = "cbPays"
        Me.cbPays.Size = New System.Drawing.Size(100, 21)
        Me.cbPays.Sorted = True
        Me.cbPays.TabIndex = 9
        Me.cbPays.Text = "(Choisir pays)"
        '
        'btnConfirmer
        '
        Me.btnConfirmer.Enabled = False
        Me.btnConfirmer.Location = New System.Drawing.Point(216, 169)
        Me.btnConfirmer.Name = "btnConfirmer"
        Me.btnConfirmer.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmer.TabIndex = 12
        Me.btnConfirmer.Text = "&Confirmer"
        Me.btnConfirmer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(135, 169)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 13
        Me.btnAnnuler.Text = "Ann&uler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(12, 146)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(21, 13)
        Me.lblCP.TabIndex = 10
        Me.lblCP.Text = "C&P"
        '
        'tbCP
        '
        Me.tbCP.Location = New System.Drawing.Point(73, 143)
        Me.tbCP.Name = "tbCP"
        Me.tbCP.Size = New System.Drawing.Size(100, 20)
        Me.tbCP.TabIndex = 11
        '
        'erpNPA
        '
        Me.erpNPA.ContainerControl = Me
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 180)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(107, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "* champs obligatoires"
        '
        'FrmNouvelleAdresse
        '
        Me.AcceptButton = Me.btnConfirmer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnuler
        Me.ClientSize = New System.Drawing.Size(306, 202)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.tbCP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnConfirmer)
        Me.Controls.Add(Me.cbPays)
        Me.Controls.Add(Me.lblPays)
        Me.Controls.Add(Me.tbVille)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.tbNPA)
        Me.Controls.Add(Me.lblNPA)
        Me.Controls.Add(Me.tbAdresse2)
        Me.Controls.Add(Me.lblAdresse2)
        Me.Controls.Add(Me.tbAdresse1)
        Me.Controls.Add(Me.lblAdresse1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNouvelleAdresse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nouvelle adresse"
        CType(Me.erpNPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdresse1 As Label
    Friend WithEvents tbAdresse1 As TextBox
    Friend WithEvents lblAdresse2 As Label
    Friend WithEvents tbAdresse2 As TextBox
    Friend WithEvents lblNPA As Label
    Friend WithEvents tbNPA As TextBox
    Friend WithEvents lblVille As Label
    Friend WithEvents tbVille As TextBox
    Friend WithEvents lblPays As Label
    Friend WithEvents cbPays As ComboBox
    Friend WithEvents btnConfirmer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents lblCP As Label
    Friend WithEvents tbCP As TextBox
    Friend WithEvents erpNPA As ErrorProvider
    Friend WithEvents lblInfo As Label
End Class
