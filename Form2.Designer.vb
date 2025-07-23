<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_confirmation
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
        Button_supprimer = New Button()
        nutton_annuler_supprimer = New Button()
        Panel1 = New Panel()
        PictureBox_Supprimer = New PictureBox()
        Label_supprimer = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox_Supprimer, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button_supprimer
        ' 
        Button_supprimer.BackColor = Color.Tomato
        Button_supprimer.Dock = DockStyle.Right
        Button_supprimer.FlatStyle = FlatStyle.Flat
        Button_supprimer.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button_supprimer.Location = New Point(170, 0)
        Button_supprimer.Name = "Button_supprimer"
        Button_supprimer.Size = New Size(156, 45)
        Button_supprimer.TabIndex = 0
        Button_supprimer.Text = "Supprimer"
        Button_supprimer.UseVisualStyleBackColor = False
        ' 
        ' nutton_annuler_supprimer
        ' 
        nutton_annuler_supprimer.BackColor = Color.Cyan
        nutton_annuler_supprimer.Dock = DockStyle.Fill
        nutton_annuler_supprimer.FlatStyle = FlatStyle.Flat
        nutton_annuler_supprimer.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nutton_annuler_supprimer.Location = New Point(0, 0)
        nutton_annuler_supprimer.Name = "nutton_annuler_supprimer"
        nutton_annuler_supprimer.Size = New Size(170, 45)
        nutton_annuler_supprimer.TabIndex = 0
        nutton_annuler_supprimer.Text = "Annuler"
        nutton_annuler_supprimer.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tomato
        Panel1.Controls.Add(PictureBox_Supprimer)
        Panel1.Controls.Add(Label_supprimer)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(326, 435)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox_Supprimer
        ' 
        PictureBox_Supprimer.Location = New Point(14, 82)
        PictureBox_Supprimer.Name = "PictureBox_Supprimer"
        PictureBox_Supprimer.Size = New Size(296, 326)
        PictureBox_Supprimer.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox_Supprimer.TabIndex = 1
        PictureBox_Supprimer.TabStop = False
        ' 
        ' Label_supprimer
        ' 
        Label_supprimer.AutoSize = True
        Label_supprimer.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_supprimer.Location = New Point(12, 9)
        Label_supprimer.Name = "Label_supprimer"
        Label_supprimer.Size = New Size(71, 30)
        Label_supprimer.TabIndex = 0
        Label_supprimer.Text = "Label1"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(nutton_annuler_supprimer)
        Panel2.Controls.Add(Button_supprimer)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 436)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(326, 45)
        Panel2.TabIndex = 1
        ' 
        ' Form_confirmation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(326, 481)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form_confirmation"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox_Supprimer, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button_supprimer As Button
    Friend WithEvents nutton_annuler_supprimer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_supprimer As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox_Supprimer As PictureBox
End Class
