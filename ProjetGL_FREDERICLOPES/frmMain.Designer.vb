<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.msTB = New System.Windows.Forms.MenuStrip()
        Me.msiCoobâtir = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiCoobâtirQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjets = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjetsNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjetsAfficher = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClients = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClientsNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiClientsAfficher = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'msTB
        '
        Me.msTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiCoobâtir, Me.msiProjets, Me.msiClients, Me.WindowsMenu})
        Me.msTB.Location = New System.Drawing.Point(0, 0)
        Me.msTB.Name = "msTB"
        Me.msTB.Size = New System.Drawing.Size(438, 24)
        Me.msTB.TabIndex = 0
        Me.msTB.Text = "MenuStrip1"
        '
        'msiCoobâtir
        '
        Me.msiCoobâtir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiCoobâtirQuitter})
        Me.msiCoobâtir.Name = "msiCoobâtir"
        Me.msiCoobâtir.Size = New System.Drawing.Size(77, 20)
        Me.msiCoobâtir.Text = "&COOBÂTIR"
        '
        'msiCoobâtirQuitter
        '
        Me.msiCoobâtirQuitter.Name = "msiCoobâtirQuitter"
        Me.msiCoobâtirQuitter.Size = New System.Drawing.Size(111, 22)
        Me.msiCoobâtirQuitter.Text = "&Quitter"
        '
        'msiProjets
        '
        Me.msiProjets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiProjetsNouveau, Me.msiProjetsAfficher})
        Me.msiProjets.Name = "msiProjets"
        Me.msiProjets.Size = New System.Drawing.Size(55, 20)
        Me.msiProjets.Text = "&Projets"
        '
        'msiProjetsNouveau
        '
        Me.msiProjetsNouveau.Name = "msiProjetsNouveau"
        Me.msiProjetsNouveau.Size = New System.Drawing.Size(156, 22)
        Me.msiProjetsNouveau.Text = "Nouveau &projet"
        '
        'msiProjetsAfficher
        '
        Me.msiProjetsAfficher.Name = "msiProjetsAfficher"
        Me.msiProjetsAfficher.Size = New System.Drawing.Size(156, 22)
        Me.msiProjetsAfficher.Text = "&Afficher projets"
        '
        'msiClients
        '
        Me.msiClients.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiClientsNouveau, Me.msiClientsAfficher})
        Me.msiClients.Name = "msiClients"
        Me.msiClients.Size = New System.Drawing.Size(55, 20)
        Me.msiClients.Text = "C&lients"
        '
        'msiClientsNouveau
        '
        Me.msiClientsNouveau.Name = "msiClientsNouveau"
        Me.msiClientsNouveau.Size = New System.Drawing.Size(154, 22)
        Me.msiClientsNouveau.Text = "Nouveau c&lient"
        '
        'msiClientsAfficher
        '
        Me.msiClientsAfficher.Name = "msiClientsAfficher"
        Me.msiClientsAfficher.Size = New System.Drawing.Size(154, 22)
        Me.msiClientsAfficher.Text = "&Afficher clients"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(63, 20)
        Me.WindowsMenu.Text = "F&enêtres"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaïque &verticale"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaïque &horizontale"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CloseAllToolStripMenuItem.Text = "&Fermer tout"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(438, 266)
        Me.Controls.Add(Me.msTB)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msTB
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COOBÂTIR"
        Me.msTB.ResumeLayout(False)
        Me.msTB.PerformLayout()
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
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
End Class
