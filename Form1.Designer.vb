<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tova
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tova))
        Panel_gauche = New Panel()
        Panel3 = New Panel()
        btn_Vendre = New Button()
        Panel2 = New Panel()
        btn_acheter = New Button()
        Panel1 = New Panel()
        btn_Acceuil = New Button()
        Panel_gauche_haut = New Panel()
        Button_ajouter = New Button()
        Panel_bas = New Panel()
        Panel_milieu = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        DataGridView1 = New DataGridView()
        Panel_Aceuil = New Panel()
        Panel_vendre = New Panel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Panel4 = New Panel()
        TextBox_Recherche = New TextBox()
        Label2 = New Label()
        Panel_recherc = New Panel()
        Button_actualiser = New Button()
        Panel_gauche.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel_milieu.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel_vendre.SuspendLayout()
        Panel4.SuspendLayout()
        Panel_recherc.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_gauche
        ' 
        Panel_gauche.BackColor = Color.Cyan
        Panel_gauche.Controls.Add(Panel3)
        Panel_gauche.Controls.Add(Panel2)
        Panel_gauche.Controls.Add(Panel1)
        Panel_gauche.Controls.Add(Panel_gauche_haut)
        Panel_gauche.Dock = DockStyle.Left
        Panel_gauche.Location = New Point(0, 0)
        Panel_gauche.Name = "Panel_gauche"
        Panel_gauche.Size = New Size(181, 539)
        Panel_gauche.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btn_Vendre)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 254)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(181, 45)
        Panel3.TabIndex = 4
        ' 
        ' btn_Vendre
        ' 
        btn_Vendre.BackColor = Color.Cyan
        btn_Vendre.Dock = DockStyle.Fill
        btn_Vendre.FlatAppearance.BorderSize = 0
        btn_Vendre.FlatStyle = FlatStyle.Flat
        btn_Vendre.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Vendre.Location = New Point(0, 0)
        btn_Vendre.Name = "btn_Vendre"
        btn_Vendre.Size = New Size(181, 45)
        btn_Vendre.TabIndex = 0
        btn_Vendre.Text = "Vendre"
        btn_Vendre.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btn_acheter)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 209)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(181, 45)
        Panel2.TabIndex = 3
        ' 
        ' btn_acheter
        ' 
        btn_acheter.BackColor = Color.Cyan
        btn_acheter.Dock = DockStyle.Fill
        btn_acheter.FlatAppearance.BorderSize = 0
        btn_acheter.FlatStyle = FlatStyle.Flat
        btn_acheter.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_acheter.Location = New Point(0, 0)
        btn_acheter.Name = "btn_acheter"
        btn_acheter.Size = New Size(181, 45)
        btn_acheter.TabIndex = 0
        btn_acheter.Text = "Acheter"
        btn_acheter.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_Acceuil)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 164)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 45)
        Panel1.TabIndex = 2
        ' 
        ' btn_Acceuil
        ' 
        btn_Acceuil.BackColor = Color.Cyan
        btn_Acceuil.Dock = DockStyle.Fill
        btn_Acceuil.FlatAppearance.BorderSize = 0
        btn_Acceuil.FlatStyle = FlatStyle.Flat
        btn_Acceuil.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Acceuil.ForeColor = SystemColors.ControlText
        btn_Acceuil.Location = New Point(0, 0)
        btn_Acceuil.Name = "btn_Acceuil"
        btn_Acceuil.Size = New Size(181, 45)
        btn_Acceuil.TabIndex = 0
        btn_Acceuil.Text = "Acceuil"
        btn_Acceuil.UseVisualStyleBackColor = False
        ' 
        ' Panel_gauche_haut
        ' 
        Panel_gauche_haut.BackColor = Color.Cyan
        Panel_gauche_haut.Dock = DockStyle.Top
        Panel_gauche_haut.Location = New Point(0, 0)
        Panel_gauche_haut.Name = "Panel_gauche_haut"
        Panel_gauche_haut.Size = New Size(181, 164)
        Panel_gauche_haut.TabIndex = 0
        ' 
        ' Button_ajouter
        ' 
        Button_ajouter.Location = New Point(6, 3)
        Button_ajouter.Name = "Button_ajouter"
        Button_ajouter.Size = New Size(104, 38)
        Button_ajouter.TabIndex = 6
        Button_ajouter.Text = "Ajouter"
        Button_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Panel_bas
        ' 
        Panel_bas.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Panel_bas.Dock = DockStyle.Bottom
        Panel_bas.Location = New Point(0, 539)
        Panel_bas.Name = "Panel_bas"
        Panel_bas.Size = New Size(1087, 22)
        Panel_bas.TabIndex = 1
        ' 
        ' Panel_milieu
        ' 
        Panel_milieu.AutoScroll = True
        Panel_milieu.BackColor = SystemColors.ButtonFace
        Panel_milieu.Controls.Add(FlowLayoutPanel1)
        Panel_milieu.Dock = DockStyle.Fill
        Panel_milieu.Location = New Point(181, 0)
        Panel_milieu.Name = "Panel_milieu"
        Panel_milieu.Size = New Size(906, 539)
        Panel_milieu.TabIndex = 2
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = SystemColors.ButtonFace
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(906, 539)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(626, 399)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(449, 150)
        DataGridView1.TabIndex = 1
        ' 
        ' Panel_Aceuil
        ' 
        Panel_Aceuil.AutoScroll = True
        Panel_Aceuil.BackColor = SystemColors.ButtonFace
        Panel_Aceuil.Dock = DockStyle.Fill
        Panel_Aceuil.Location = New Point(181, 0)
        Panel_Aceuil.Name = "Panel_Aceuil"
        Panel_Aceuil.Size = New Size(906, 539)
        Panel_Aceuil.TabIndex = 3
        ' 
        ' Panel_vendre
        ' 
        Panel_vendre.AutoScroll = True
        Panel_vendre.BackColor = SystemColors.ButtonFace
        Panel_vendre.Controls.Add(FlowLayoutPanel3)
        Panel_vendre.Controls.Add(Panel4)
        Panel_vendre.Dock = DockStyle.Fill
        Panel_vendre.Location = New Point(181, 0)
        Panel_vendre.Name = "Panel_vendre"
        Panel_vendre.Size = New Size(906, 539)
        Panel_vendre.TabIndex = 4
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.AutoScroll = True
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.BackColor = Color.White
        FlowLayoutPanel3.Dock = DockStyle.Fill
        FlowLayoutPanel3.Location = New Point(0, 0)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(573, 539)
        FlowLayoutPanel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button_ajouter)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(573, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(333, 539)
        Panel4.TabIndex = 0
        ' 
        ' TextBox_Recherche
        ' 
        TextBox_Recherche.BorderStyle = BorderStyle.FixedSingle
        TextBox_Recherche.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Recherche.Location = New Point(133, 8)
        TextBox_Recherche.Name = "TextBox_Recherche"
        TextBox_Recherche.Size = New Size(226, 33)
        TextBox_Recherche.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlDark
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 0
        Label2.Text = "Recherche :"
        ' 
        ' Panel_recherc
        ' 
        Panel_recherc.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Panel_recherc.BackColor = SystemColors.ControlDark
        Panel_recherc.Controls.Add(TextBox_Recherche)
        Panel_recherc.Controls.Add(Label2)
        Panel_recherc.Location = New Point(701, 352)
        Panel_recherc.Name = "Panel_recherc"
        Panel_recherc.Size = New Size(362, 54)
        Panel_recherc.TabIndex = 0
        ' 
        ' Button_actualiser
        ' 
        Button_actualiser.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button_actualiser.Location = New Point(984, 324)
        Button_actualiser.Name = "Button_actualiser"
        Button_actualiser.Size = New Size(75, 23)
        Button_actualiser.TabIndex = 7
        Button_actualiser.Text = "Actualiser"
        Button_actualiser.UseVisualStyleBackColor = True
        ' 
        ' Tova
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1087, 561)
        Controls.Add(Button_actualiser)
        Controls.Add(DataGridView1)
        Controls.Add(Panel_recherc)
        Controls.Add(Panel_milieu)
        Controls.Add(Panel_Aceuil)
        Controls.Add(Panel_vendre)
        Controls.Add(Panel_gauche)
        Controls.Add(Panel_bas)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Tova"
        Text = "Tova"
        Panel_gauche.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel_milieu.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel_vendre.ResumeLayout(False)
        Panel_vendre.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel_recherc.ResumeLayout(False)
        Panel_recherc.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_gauche As Panel
    Friend WithEvents Panel_bas As Panel
    Friend WithEvents Panel_milieu As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel_gauche_haut As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents btn_Vendre As Button
    Friend WithEvents btn_acheter As Button
    Friend WithEvents btn_Acceuil As Button
    Friend WithEvents Panel_Aceuil As Panel
    Friend WithEvents Panel_vendre As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox_Recherche As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_recherc As Panel
    Friend WithEvents Button_actualiser As Button

End Class
