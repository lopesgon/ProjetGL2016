<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTB
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTB))
        Me.msTB = New System.Windows.Forms.MenuStrip()
        Me.msiCoobâtir = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiCoobâtirQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjets = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjetsNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjetsAfficher = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClients = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClientsNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClientsAfficher = New System.Windows.Forms.ToolStripMenuItem()
        Me.calTb = New System.Windows.Forms.MonthCalendar()
        Me.chartEvolution = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgbTb = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facturé = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corpsmetier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etatAvancement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.msTB.SuspendLayout()
        CType(Me.chartEvolution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbTb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msTB
        '
        Me.msTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiCoobâtir, Me.msiProjets, Me.msiClients})
        Me.msTB.Location = New System.Drawing.Point(0, 0)
        Me.msTB.Name = "msTB"
        Me.msTB.Size = New System.Drawing.Size(688, 24)
        Me.msTB.TabIndex = 0
        Me.msTB.Text = "MenuStrip1"
        '
        'msiCoobâtir
        '
        Me.msiCoobâtir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiCoobâtirQuitter})
        Me.msiCoobâtir.Name = "msiCoobâtir"
        Me.msiCoobâtir.Size = New System.Drawing.Size(77, 20)
        Me.msiCoobâtir.Text = "COOBÂTIR"
        '
        'msiCoobâtirQuitter
        '
        Me.msiCoobâtirQuitter.Name = "msiCoobâtirQuitter"
        Me.msiCoobâtirQuitter.Size = New System.Drawing.Size(111, 22)
        Me.msiCoobâtirQuitter.Text = "Quitter"
        '
        'msiProjets
        '
        Me.msiProjets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiProjetsNouveau, Me.msiProjetsAfficher})
        Me.msiProjets.Name = "msiProjets"
        Me.msiProjets.Size = New System.Drawing.Size(55, 20)
        Me.msiProjets.Text = "Projets"
        '
        'msiProjetsNouveau
        '
        Me.msiProjetsNouveau.Name = "msiProjetsNouveau"
        Me.msiProjetsNouveau.Size = New System.Drawing.Size(156, 22)
        Me.msiProjetsNouveau.Text = "Nouveau projet"
        '
        'msiProjetsAfficher
        '
        Me.msiProjetsAfficher.Name = "msiProjetsAfficher"
        Me.msiProjetsAfficher.Size = New System.Drawing.Size(156, 22)
        Me.msiProjetsAfficher.Text = "Afficher projets"
        '
        'msiClients
        '
        Me.msiClients.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiClientsNouveau, Me.msiClientsAfficher})
        Me.msiClients.Name = "msiClients"
        Me.msiClients.Size = New System.Drawing.Size(55, 20)
        Me.msiClients.Text = "Clients"
        '
        'msiClientsNouveau
        '
        Me.msiClientsNouveau.Name = "msiClientsNouveau"
        Me.msiClientsNouveau.Size = New System.Drawing.Size(154, 22)
        Me.msiClientsNouveau.Text = "Nouveau client"
        '
        'msiClientsAfficher
        '
        Me.msiClientsAfficher.Name = "msiClientsAfficher"
        Me.msiClientsAfficher.Size = New System.Drawing.Size(154, 22)
        Me.msiClientsAfficher.Text = "Afficher clients"
        '
        'calTb
        '
        Me.calTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calTb.Location = New System.Drawing.Point(443, 33)
        Me.calTb.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.calTb.Name = "calTb"
        Me.calTb.TabIndex = 1
        '
        'chartEvolution
        '
        Me.chartEvolution.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chartEvolution.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartEvolution.Legends.Add(Legend1)
        Me.chartEvolution.Location = New System.Drawing.Point(13, 207)
        Me.chartEvolution.Name = "chartEvolution"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartEvolution.Series.Add(Series1)
        Me.chartEvolution.Size = New System.Drawing.Size(657, 193)
        Me.chartEvolution.TabIndex = 2
        Me.chartEvolution.Text = "Evolution du résultat"
        '
        'dgbTb
        '
        Me.dgbTb.AllowUserToDeleteRows = False
        Me.dgbTb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbTb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.facturé, Me.corpsmetier, Me.etatAvancement})
        Me.dgbTb.Location = New System.Drawing.Point(13, 33)
        Me.dgbTb.Name = "dgbTb"
        Me.dgbTb.Size = New System.Drawing.Size(418, 162)
        Me.dgbTb.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "ID Projet"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'facturé
        '
        Me.facturé.HeaderText = "Montant facturé"
        Me.facturé.Name = "facturé"
        Me.facturé.ReadOnly = True
        '
        'corpsmetier
        '
        Me.corpsmetier.HeaderText = "Nb corps de métiers"
        Me.corpsmetier.Name = "corpsmetier"
        Me.corpsmetier.ReadOnly = True
        '
        'etatAvancement
        '
        Me.etatAvancement.HeaderText = "Avancement du projet"
        Me.etatAvancement.Name = "etatAvancement"
        Me.etatAvancement.ReadOnly = True
        '
        'frmTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 412)
        Me.Controls.Add(Me.dgbTb)
        Me.Controls.Add(Me.chartEvolution)
        Me.Controls.Add(Me.calTb)
        Me.Controls.Add(Me.msTB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msTB
        Me.Name = "frmTB"
        Me.Text = "COOBÂTIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msTB.ResumeLayout(False)
        Me.msTB.PerformLayout()
        CType(Me.chartEvolution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbTb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msTB As MenuStrip
    Friend WithEvents msiCoobâtir As ToolStripMenuItem
    Friend WithEvents msiCoobâtirQuitter As ToolStripMenuItem
    Friend WithEvents msiProjets As ToolStripMenuItem
    Friend WithEvents msiProjetsNouveau As ToolStripMenuItem
    Friend WithEvents msiProjetsAfficher As ToolStripMenuItem
    Friend WithEvents msiClients As ToolStripMenuItem
    Friend WithEvents msiClientsNouveau As ToolStripMenuItem
    Friend WithEvents msiClientsAfficher As ToolStripMenuItem
    Friend WithEvents calTb As MonthCalendar
    Friend WithEvents chartEvolution As DataVisualization.Charting.Chart
    Friend WithEvents dgbTb As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents facturé As DataGridViewTextBoxColumn
    Friend WithEvents corpsmetier As DataGridViewTextBoxColumn
    Friend WithEvents etatAvancement As DataGridViewTextBoxColumn
End Class
