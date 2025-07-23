<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout
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
        TextBox_Nom = New TextBox()
        TextBox_Prix = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox_categorie = New ComboBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label_form1 = New Label()
        PictureBox_ajout = New PictureBox()
        Label5 = New Label()
        TextBox_nom_image = New TextBox()
        Button_import = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox_ajout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_Nom
        ' 
        TextBox_Nom.Location = New Point(122, 33)
        TextBox_Nom.Name = "TextBox_Nom"
        TextBox_Nom.Size = New Size(162, 23)
        TextBox_Nom.TabIndex = 0
        ' 
        ' TextBox_Prix
        ' 
        TextBox_Prix.Location = New Point(122, 62)
        TextBox_Prix.Name = "TextBox_Prix"
        TextBox_Prix.Size = New Size(129, 23)
        TextBox_Prix.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Dock = DockStyle.Right
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(163, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 45)
        Button1.TabIndex = 2
        Button1.Text = "Valider"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tomato
        Button2.Dock = DockStyle.Fill
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(0, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 45)
        Button2.TabIndex = 3
        Button2.Text = "Annule"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 4
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 15)
        Label2.TabIndex = 5
        Label2.Text = "Prix"
        ' 
        ' ComboBox_categorie
        ' 
        ComboBox_categorie.FormattingEnabled = True
        ComboBox_categorie.Location = New Point(122, 91)
        ComboBox_categorie.Name = "ComboBox_categorie"
        ComboBox_categorie.Size = New Size(162, 23)
        ComboBox_categorie.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 7
        Label3.Text = "Categorie"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 544)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 2, 0, 0)
        Panel1.Size = New Size(326, 47)
        Panel1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(250, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 9
        Label4.Text = "MGA"
        ' 
        ' Label_form1
        ' 
        Label_form1.AutoSize = True
        Label_form1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_form1.Location = New Point(12, 9)
        Label_form1.Name = "Label_form1"
        Label_form1.Size = New Size(67, 21)
        Label_form1.TabIndex = 10
        Label_form1.Text = "Ajouter"
        ' 
        ' PictureBox_ajout
        ' 
        PictureBox_ajout.Location = New Point(15, 183)
        PictureBox_ajout.Name = "PictureBox_ajout"
        PictureBox_ajout.Size = New Size(296, 326)
        PictureBox_ajout.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox_ajout.TabIndex = 11
        PictureBox_ajout.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 15)
        Label5.TabIndex = 12
        Label5.Text = "Import une image"
        ' 
        ' TextBox_nom_image
        ' 
        TextBox_nom_image.Location = New Point(122, 122)
        TextBox_nom_image.Name = "TextBox_nom_image"
        TextBox_nom_image.Size = New Size(162, 23)
        TextBox_nom_image.TabIndex = 13
        ' 
        ' Button_import
        ' 
        Button_import.Location = New Point(285, 122)
        Button_import.Name = "Button_import"
        Button_import.Size = New Size(32, 23)
        Button_import.TabIndex = 14
        Button_import.Text = "..."
        Button_import.UseVisualStyleBackColor = True
        ' 
        ' Ajout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Khaki
        ClientSize = New Size(326, 591)
        ControlBox = False
        Controls.Add(Button_import)
        Controls.Add(TextBox_nom_image)
        Controls.Add(Label5)
        Controls.Add(PictureBox_ajout)
        Controls.Add(Label_form1)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(ComboBox_categorie)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox_Prix)
        Controls.Add(TextBox_Nom)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Ajout"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "lllllllt9"
        Panel1.ResumeLayout(False)
        CType(PictureBox_ajout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_Nom As TextBox
    Friend WithEvents TextBox_Prix As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_categorie As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_form1 As Label
    Friend WithEvents PictureBox_ajout As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_nom_image As TextBox
    Friend WithEvents Button_import As Button
End Class
