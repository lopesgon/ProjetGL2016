<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNouvPersPhys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNouvPersPhys))
        Me.lblNom = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.tbTelephone = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.tbFax = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.gbDonneesClient = New System.Windows.Forms.GroupBox()
        Me.btnAjoutAdresse = New System.Windows.Forms.Button()
        Me.dgvAdresses = New System.Windows.Forms.DataGridView()
        Me.colAdr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupprimer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.gbDonneesClient.SuspendLayout()
        CType(Me.dgvAdresses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(8, 22)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(33, 13)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "&Nom*"
        '
        'tbNom
        '
        Me.tbNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNom.Location = New System.Drawing.Point(61, 19)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(151, 20)
        Me.tbNom.TabIndex = 1
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(8, 47)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(47, 13)
        Me.lblPrenom.TabIndex = 2
        Me.lblPrenom.Text = "&Prénom*"
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(61, 45)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(151, 20)
        Me.tbPrenom.TabIndex = 3
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(8, 74)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(29, 13)
        Me.lblTelephone.TabIndex = 4
        Me.lblTelephone.Text = "&Tél.*"
        '
        'tbTelephone
        '
        Me.tbTelephone.Location = New System.Drawing.Point(61, 71)
        Me.tbTelephone.Name = "tbTelephone"
        Me.tbTelephone.Size = New System.Drawing.Size(151, 20)
        Me.tbTelephone.TabIndex = 5
        '
        'lblFax
        '
        Me.lblFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(218, 22)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(24, 13)
        Me.lblFax.TabIndex = 6
        Me.lblFax.Text = "&Fax"
        '
        'tbFax
        '
        Me.tbFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFax.Location = New System.Drawing.Point(265, 19)
        Me.tbFax.Name = "tbFax"
        Me.tbFax.Size = New System.Drawing.Size(125, 20)
        Me.tbFax.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(218, 47)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "&Email"
        '
        'tbEmail
        '
        Me.tbEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmail.Location = New System.Drawing.Point(265, 44)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(125, 20)
        Me.tbEmail.TabIndex = 9
        '
        'gbDonneesClient
        '
        Me.gbDonneesClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDonneesClient.Controls.Add(Me.btnAjoutAdresse)
        Me.gbDonneesClient.Controls.Add(Me.tbEmail)
        Me.gbDonneesClient.Controls.Add(Me.lblEmail)
        Me.gbDonneesClient.Controls.Add(Me.tbFax)
        Me.gbDonneesClient.Controls.Add(Me.lblFax)
        Me.gbDonneesClient.Controls.Add(Me.tbTelephone)
        Me.gbDonneesClient.Controls.Add(Me.lblTelephone)
        Me.gbDonneesClient.Controls.Add(Me.tbPrenom)
        Me.gbDonneesClient.Controls.Add(Me.lblPrenom)
        Me.gbDonneesClient.Controls.Add(Me.tbNom)
        Me.gbDonneesClient.Controls.Add(Me.lblNom)
        Me.gbDonneesClient.Location = New System.Drawing.Point(8, 7)
        Me.gbDonneesClient.Name = "gbDonneesClient"
        Me.gbDonneesClient.Size = New System.Drawing.Size(405, 102)
        Me.gbDonneesClient.TabIndex = 0
        Me.gbDonneesClient.TabStop = False
        Me.gbDonneesClient.Text = "Informations client"
        '
        'btnAjoutAdresse
        '
        Me.btnAjoutAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjoutAdresse.Location = New System.Drawing.Point(265, 73)
        Me.btnAjoutAdresse.Name = "btnAjoutAdresse"
        Me.btnAjoutAdresse.Size = New System.Drawing.Size(125, 23)
        Me.btnAjoutAdresse.TabIndex = 11
        Me.btnAjoutAdresse.Text = "&Ajouter adresse"
        Me.btnAjoutAdresse.UseVisualStyleBackColor = True
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
        Me.dgvAdresses.Location = New System.Drawing.Point(8, 115)
        Me.dgvAdresses.Name = "dgvAdresses"
        Me.dgvAdresses.Size = New System.Drawing.Size(405, 83)
        Me.dgvAdresses.TabIndex = 10
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
        Me.btnEnregistrer.Location = New System.Drawing.Point(300, 204)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(109, 23)
        Me.btnEnregistrer.TabIndex = 11
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'FrmNouvPersPhys
        '
        Me.AcceptButton = Me.btnEnregistrer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 237)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.dgvAdresses)
        Me.Controls.Add(Me.gbDonneesClient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(437, 276)
        Me.Name = "FrmNouvPersPhys"
        Me.Text = "Nouvelle personne physique"
        Me.gbDonneesClient.ResumeLayout(False)
        Me.gbDonneesClient.PerformLayout()
        CType(Me.dgvAdresses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents tbTelephone As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents tbFax As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents gbDonneesClient As GroupBox
    Friend WithEvents colSupprimer As DataGridViewButtonColumn
    Friend WithEvents colCP As DataGridViewTextBoxColumn
    Friend WithEvents colPays As DataGridViewTextBoxColumn
    Friend WithEvents colLieu As DataGridViewTextBoxColumn
    Friend WithEvents colNPA As DataGridViewTextBoxColumn
    Friend WithEvents colAdr1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvAdresses As DataGridView
    Friend WithEvents btnAjoutAdresse As Button
    Friend WithEvents btnEnregistrer As Button
End Class
