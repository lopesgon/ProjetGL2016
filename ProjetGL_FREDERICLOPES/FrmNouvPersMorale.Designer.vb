<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNouvPersMorale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNouvPersMorale))
        Me.gbDonneesClient = New System.Windows.Forms.GroupBox()
        Me.btnAjoutAdresse = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.tbTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.lblRaisonSociale = New System.Windows.Forms.Label()
        Me.dgvAdresses = New System.Windows.Forms.DataGridView()
        Me.colAdr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupprimer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.lblIde = New System.Windows.Forms.Label()
        Me.tbIde = New System.Windows.Forms.TextBox()
        Me.hlppNouvPersMorale = New System.Windows.Forms.HelpProvider()
        Me.gbDonneesClient.SuspendLayout()
        CType(Me.dgvAdresses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDonneesClient
        '
        Me.gbDonneesClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDonneesClient.Controls.Add(Me.tbIde)
        Me.gbDonneesClient.Controls.Add(Me.lblIde)
        Me.gbDonneesClient.Controls.Add(Me.btnAjoutAdresse)
        Me.gbDonneesClient.Controls.Add(Me.tbEmail)
        Me.gbDonneesClient.Controls.Add(Me.lblEmail)
        Me.gbDonneesClient.Controls.Add(Me.tbFax)
        Me.gbDonneesClient.Controls.Add(Me.lblFax)
        Me.gbDonneesClient.Controls.Add(Me.tbTelephone)
        Me.gbDonneesClient.Controls.Add(Me.lblTelephone)
        Me.gbDonneesClient.Controls.Add(Me.tbNom)
        Me.gbDonneesClient.Controls.Add(Me.lblRaisonSociale)
        Me.gbDonneesClient.Location = New System.Drawing.Point(12, 12)
        Me.gbDonneesClient.Name = "gbDonneesClient"
        Me.gbDonneesClient.Size = New System.Drawing.Size(413, 127)
        Me.gbDonneesClient.TabIndex = 0
        Me.gbDonneesClient.TabStop = False
        Me.gbDonneesClient.Text = "Données entreprise"
        '
        'btnAjoutAdresse
        '
        Me.btnAjoutAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjoutAdresse.Location = New System.Drawing.Point(282, 97)
        Me.btnAjoutAdresse.Name = "btnAjoutAdresse"
        Me.btnAjoutAdresse.Size = New System.Drawing.Size(125, 23)
        Me.btnAjoutAdresse.TabIndex = 10
        Me.btnAjoutAdresse.Text = "&Ajouter adresse"
        Me.btnAjoutAdresse.UseVisualStyleBackColor = True
        '
        'tbEmail
        '
        Me.tbEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmail.Location = New System.Drawing.Point(50, 45)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(166, 20)
        Me.tbEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 48)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 13)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "&Email*"
        '
        'tbFax
        '
        Me.tbFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFax.Location = New System.Drawing.Point(257, 71)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(74, 20)
        Me.tbFax.TabIndex = 9
        '
        'lblFax
        '
        Me.lblFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(222, 74)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(24, 13)
        Me.lblFax.TabIndex = 8
        Me.lblFax.Text = "&Fax"
        '
        'tbTelephone
        '
        Me.tbTelephone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTelephone.Location = New System.Drawing.Point(257, 45)
        Me.tbTelephone.Name = "tbTelephone"
        Me.tbTelephone.Size = New System.Drawing.Size(150, 20)
        Me.tbTelephone.TabIndex = 5
        '
        'lblTelephone
        '
        Me.lblTelephone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(222, 48)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(29, 13)
        Me.lblTelephone.TabIndex = 4
        Me.lblTelephone.Text = "&Tél.*"
        '
        'tbNom
        '
        Me.tbNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNom.Location = New System.Drawing.Point(94, 19)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(313, 20)
        Me.tbNom.TabIndex = 1
        '
        'lblRaisonSociale
        '
        Me.lblRaisonSociale.AutoSize = True
        Me.lblRaisonSociale.Location = New System.Drawing.Point(6, 22)
        Me.lblRaisonSociale.Name = "lblRaisonSociale"
        Me.lblRaisonSociale.Size = New System.Drawing.Size(80, 13)
        Me.lblRaisonSociale.TabIndex = 0
        Me.lblRaisonSociale.Text = "&Raison sociale*"
        '
        'dgvAdresses
        '
        Me.dgvAdresses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAdresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdresses.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdresses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAdr1, Me.colNPA, Me.colLieu, Me.colPays, Me.colCP, Me.colSupprimer})
        Me.dgvAdresses.Location = New System.Drawing.Point(12, 145)
        Me.dgvAdresses.Name = "dgvAdresses"
        Me.dgvAdresses.Size = New System.Drawing.Size(413, 98)
        Me.dgvAdresses.TabIndex = 1
        '
        'colAdr1
        '
        Me.colAdr1.FillWeight = 154.1006!
        Me.colAdr1.HeaderText = "Adresse1"
        Me.colAdr1.Name = "colAdr1"
        '
        'colNPA
        '
        Me.colNPA.FillWeight = 45.45186!
        Me.colNPA.HeaderText = "NPA"
        Me.colNPA.Name = "colNPA"
        '
        'colLieu
        '
        Me.colLieu.FillWeight = 59.14906!
        Me.colLieu.HeaderText = "Lieu"
        Me.colLieu.Name = "colLieu"
        '
        'colPays
        '
        Me.colPays.FillWeight = 59.14906!
        Me.colPays.HeaderText = "Pays"
        Me.colPays.Name = "colPays"
        '
        'colCP
        '
        Me.colCP.FillWeight = 59.14906!
        Me.colCP.HeaderText = "CP"
        Me.colCP.Name = "colCP"
        '
        'colSupprimer
        '
        Me.colSupprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colSupprimer.FillWeight = 30.0!
        Me.colSupprimer.HeaderText = "X"
        Me.colSupprimer.Name = "colSupprimer"
        Me.colSupprimer.Width = 30
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrer.Location = New System.Drawing.Point(294, 249)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(131, 23)
        Me.btnEnregistrer.TabIndex = 2
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'lblIde
        '
        Me.lblIde.AutoSize = True
        Me.hlppNouvPersMorale.SetHelpKeyword(Me.lblIde, "Numéro d'identification de l'entreprise")
        Me.hlppNouvPersMorale.SetHelpString(Me.lblIde, "Numéro d'identification de l'entreprise")
        Me.lblIde.Location = New System.Drawing.Point(6, 74)
        Me.lblIde.Name = "lblIde"
        Me.hlppNouvPersMorale.SetShowHelp(Me.lblIde, True)
        Me.lblIde.Size = New System.Drawing.Size(29, 13)
        Me.lblIde.TabIndex = 6
        Me.lblIde.Text = "&IDE*"
        '
        'tbIde
        '
        Me.tbIde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIde.Location = New System.Drawing.Point(50, 71)
        Me.tbIde.Name = "tbIde"
        Me.tbIde.Size = New System.Drawing.Size(166, 20)
        Me.tbIde.TabIndex = 6
        '
        'FrmNouvPersMorale
        '
        Me.AcceptButton = Me.btnEnregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.gbDonneesClient)
        Me.Controls.Add(Me.dgvAdresses)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNouvPersMorale"
        Me.Text = "Nouvelle personne morale"
        Me.gbDonneesClient.ResumeLayout(False)
        Me.gbDonneesClient.PerformLayout()
        CType(Me.dgvAdresses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDonneesClient As GroupBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbFax As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents tbTelephone As TextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents lblRaisonSociale As Label
    Friend WithEvents dgvAdresses As DataGridView
    Friend WithEvents btnAjoutAdresse As Button
    Friend WithEvents colSupprimer As DataGridViewButtonColumn
    Friend WithEvents colCP As DataGridViewTextBoxColumn
    Friend WithEvents colPays As DataGridViewTextBoxColumn
    Friend WithEvents colLieu As DataGridViewTextBoxColumn
    Friend WithEvents colNPA As DataGridViewTextBoxColumn
    Friend WithEvents colAdr1 As DataGridViewTextBoxColumn
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents tbIde As TextBox
    Friend WithEvents lblIde As Label
    Friend WithEvents hlppNouvPersMorale As HelpProvider
End Class
