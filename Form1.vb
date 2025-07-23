Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Drawing.Design
Public Class Tova

    ' Chaîne de connexion
    Dim connStr As String = "server=localhost;user=root;password=;database=Atricle"
    Dim connection As New MySqlConnection(connStr)
    Public query As String
    Private Sub Panel_boder(p As Panel, diametre As Integer)
        'bordur des panel
        Dim crayon As New Drawing2D.GraphicsPath()
        Dim bwidth As Integer = 5
        Dim bcolor As Color = Color.DarkBlue

        crayon.StartFigure()
        crayon.AddArc(0, 0, diametre, diametre, 180, 90)
        crayon.AddArc(p.Width - diametre, 0, diametre, diametre, 270, 90)
        crayon.AddArc(p.Width - diametre, p.Height - diametre, diametre, diametre, 0, 90)
        crayon.AddArc(0, p.Height - diametre, diametre, diametre, 90, 90)
        crayon.CloseFigure()
        p.Region = New Region(crayon)
    End Sub
    Private Sub paint_panel(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub
    Private Sub redimenstion_flowlayout1()
        FlowLayoutPanel1.Padding = New Padding(0, 0, 0, 0)
        Dim py As Integer = -1
        Dim nbr As Integer = 0
        Dim taille_libre As Integer = 0
        For Each p As Panel In FlowLayoutPanel1.Controls.OfType(Of Panel)()
            If py = -1 Then
                py = p.Top

            End If
            If p.Top = py Then
                nbr += 1

            Else
                Exit For
            End If

        Next
        taille_libre = FlowLayoutPanel1.ClientSize.Width - (321 * nbr)
        FlowLayoutPanel1.Padding = New Padding((taille_libre / 2) + 1, 0, taille_libre / 2, 0)
    End Sub
    Private Sub redimenstion_flowlayout3()
        FlowLayoutPanel3.Padding = New Padding(0, 0, 0, 0)
        Dim py As Integer = -1
        Dim nbr As Integer = 0
        Dim taille_libre As Integer = 0
        For Each p As Panel In FlowLayoutPanel3.Controls.OfType(Of Panel)()
            If py = -1 Then
                py = p.Top

            End If
            If p.Top = py Then
                nbr += 1

            Else
                Exit For
            End If

        Next
        taille_libre = FlowLayoutPanel3.ClientSize.Width - (321 * nbr)
        FlowLayoutPanel3.Padding = New Padding((taille_libre / 2) + 1, 0, taille_libre / 2, 0)
    End Sub

    Private Sub Gride_affiche()
        Try
            connection.Open()

            ' La requête SQL
            Dim query As String = "SELECT * FROM Article"

            ' L’adaptateur de données
            Dim adapter As New MySqlDataAdapter(query, connection)

            ' Le conteneur pour les données
            Dim table As New DataTable()

            ' Remplir la DataTable avec les données de MySQL
            adapter.Fill(table)

            ' Afficher dans le DataGridView
            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub affiche_article(query As String)
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel3.Controls.Clear()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader = cmd.ExecuteReader()

            While reader.Read
                Dim picturbox As New PictureBox With {
                    .Width = 296,
                    .Height = 326,
                    .ImageLocation = reader("img"),
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .Location = New Point(0, 70)
                    }
                Dim panelg As New Panel With {
                .Width = 300,
                .Height = 400,
                .Anchor = AnchorStyles.None,
                .BackColor = ColorTranslator.FromHtml("#767676"),
                .Margin = New Padding(10)
            }
                Dim panels As New Panel With {
                .Width = 296,
                .Height = 396,
                .Dock = DockStyle.Fill,
                .BackColor = Color.White,
                .Anchor = AnchorStyles.None,
                .Location = New Point(2, 2)
                }
                ' 1️⃣ Créer un panel pour cette ligne
                Dim panel As New Panel With {
                .Width = 300,
                .Height = 70,
                .Anchor = AnchorStyles.None,
                .BackColor = Color.LightGray,
                .Margin = New Padding(10)
            }

                ' 2️⃣ Label pour le nom
                Dim lblNom As New Label With {
                .Text = reader("nom").ToString,
                .Location = New Point(10, 10),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .AutoSize = True
            }

                ' 3️⃣ Label pour le prix
                Dim lblPrix As New Label With {
                .Text = "Prix : " & reader("prix").ToString & " Ar",
                .Location = New Point(10, 35),
                .AutoSize = True
            }
                Dim Acheterbtn As New Button With {
                .Text = "Acheter",
                .Location = New Point(210, 5),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .AutoSize = True,
                .BackColor = Color.White
                }
                Dim detailbtn As New Button With {
                .Text = "Detail",
                .Location = New Point(210, 35),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .AutoSize = True,
                .BackColor = Color.White
                }

                ' 5️⃣ Ajouter les éléments au panel
                panel.Controls.Add(lblNom)
                panel.Controls.Add(lblPrix)
                panel.Controls.Add(Acheterbtn)
                panel.Controls.Add(detailbtn)

                panels.Controls.Add(panel)
                panels.Controls.Add(picturbox)
                panelg.Controls.Add(panels)

                ' 6️⃣ Ajouter le panel au FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(panelg)
                Panel_boder(panelg, 10)
                Panel_boder(panels, 10)

                AddHandler panels.Paint, AddressOf paint_panel
                AddHandler panelg.Paint, AddressOf paint_panel

                Dim picturbox1 As New PictureBox With {
                    .Width = 296,
                    .Height = 326,
                    .ImageLocation = reader("img"),
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .Location = New Point(0, 70)
                    }

                Dim panelg1 As New Panel With {
                .Width = 300,
                .Height = 400,
                .Anchor = AnchorStyles.None,
                .BackColor = ColorTranslator.FromHtml("#767676"),
                .Margin = New Padding(10)
            }
                Dim panels1 As New Panel With {
                .Width = 296,
                .Height = 396,
                .Dock = DockStyle.Fill,
                .BackColor = Color.White,
                .Anchor = AnchorStyles.None,
                .Location = New Point(2, 2)
                }
                ' 1️⃣ Créer un panel pour cette ligne
                Dim panel1 As New Panel With {
                .Width = 300,
                .Height = 70,
                .Anchor = AnchorStyles.None,
                .BackColor = Color.LightGray,
                .Margin = New Padding(10)
            }

                ' 2️⃣ Label pour le nom
                Dim lblNom1 As New Label With {
                .Text = reader("nom").ToString,
                .Location = New Point(10, 10),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .AutoSize = True
            }

                ' 3️⃣ Label pour le prix
                Dim lblPrix1 As New Label With {
                .Text = "Prix : " & reader("prix").ToString & " Ar",
                .Location = New Point(10, 35),
                .AutoSize = True
            }
                Dim modifibtn As New Button With {
                .Text = "Modifier",
                .Tag = reader("Id_article") & "|" & reader("Nom") & "|" & reader("Prix") & "|" & reader("nom_categorie") & "|" & reader("img"),
                .Location = New Point(200, 5),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .Width = 90,
                .AutoSize = True,
                .BackColor = Color.White
                }
                Dim supprimerbtn As New Button With {
                .Text = "Supprimer",
                .Tag = reader("id_article") & "|" & reader("nom") & "|" & reader("img"),
                .Location = New Point(200, 35),
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                 .Width = 90,
                .AutoSize = True,
                .BackColor = Color.White
                }

                ' 5️⃣ Ajouter les éléments au panel
                panel1.Controls.Add(lblNom1)
                panel1.Controls.Add(lblPrix1)
                panel1.Controls.Add(modifibtn)
                panel1.Controls.Add(supprimerbtn)

                panels1.Controls.Add(picturbox1)
                panels1.Controls.Add(panel1)
                panelg1.Controls.Add(panels1)


                ' 6️⃣ Ajouter le panel au FlowLayoutPanel
                FlowLayoutPanel3.Controls.Add(panelg1)
                Panel_boder(panelg1, 10)
                Panel_boder(panels1, 10)

                AddHandler supprimerbtn.Click, AddressOf supprimerbtn_click
                AddHandler modifibtn.Click, AddressOf modifibtn_click
                AddHandler panels1.Paint, AddressOf paint_panel
                AddHandler panelg1.Paint, AddressOf paint_panel


            End While


        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub supprimerbtn_click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim f As New Form_confirmation()
        Dim info() As String = btn.Tag.ToString.Split("|"c)
        f.Label_supprimer.Text = "Supprimer " & info(1) & " du vente"
        f.id = CInt(Trim(info(0)))
        If info(2) <> "" Then
            f.PictureBox_Supprimer.ImageLocation = info(2)
        End If

        f.ShowDialog()
    End Sub
    Private Sub modifibtn_click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim m As New Ajout()


        m.StartPosition = FormStartPosition.CenterParent

        m.mode = "Modifi"
        Dim info() As String = btn.Tag.ToString.Split("|"c)
        m.id = CInt(info(0))
        m.TextBox_Nom.Text = info(1)
        m.TextBox_Prix.Text = info(2)
        m.ComboBox_categorie.Text = info(3)
        m.emplacement = info(4)
        If info(4) <> "" Then
            m.PictureBox_ajout.ImageLocation = info(4)
        End If
        m.TextBox_nom_image.Text = ""
        m.Label_form1.Text = "Modifier l'information de " & info(1)
        m.BackColor = Color.Khaki
        m.ShowDialog()
    End Sub
    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        Dim f As New Ajout()
        f.StartPosition = FormStartPosition.CenterParent

        f.mode = "Ajout"
        f.TextBox_Nom.Text = ""
        f.TextBox_Prix.Text = ""
        f.ComboBox_categorie.Text = ""
        f.PictureBox_ajout.ImageLocation = ""
        f.TextBox_nom_image.Text = ""
        f.Label_form1.Text = "Ajouter une nouvelle article"
        f.BackColor = Color.Cyan
        f.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Load

        Dim dossier As String = Application.StartupPath & "\Images"

        If Not IO.Directory.Exists(dossier) Then
            IO.Directory.CreateDirectory(dossier)
        End If
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel3.Controls.Clear()
        Gride_affiche()
        query = "select article.* , categorie.nom as nom_categorie from article join categorie on article.id_categorie = categorie.id_categorie"
        affiche_article(query)
    End Sub

    Private Sub FlowLayoutPanel1_SizeChanged(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.SizeChanged
        redimenstion_flowlayout1()
    End Sub

    Private Sub Tova_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        redimenstion_flowlayout1()
        redimenstion_flowlayout3()
    End Sub


    Private Sub btn_Acceuil_Click(sender As Object, e As EventArgs) Handles btn_Acceuil.Click
        btn_Acceuil.BackColor = ColorTranslator.FromHtml("#767676")
        btn_Acceuil.ForeColor = Color.White
        btn_acheter.BackColor = Color.Cyan
        btn_acheter.ForeColor = Color.Black
        btn_Vendre.BackColor = Color.Cyan
        btn_Vendre.ForeColor = Color.Black
        Panel_vendre.Visible = False
        Panel_milieu.Visible = False
        Panel_Aceuil.Visible = True
    End Sub

    Private Sub btn_acheter_Click(sender As Object, e As EventArgs) Handles btn_acheter.Click
        btn_Acceuil.BackColor = Color.cyan
        btn_Acceuil.ForeColor = Color.Black
        btn_acheter.BackColor = ColorTranslator.FromHtml("#767676")
        btn_acheter.ForeColor = Color.White
        btn_Vendre.BackColor = Color.Cyan
        btn_Vendre.ForeColor = Color.Black
        Panel_vendre.Visible = False
        Panel_milieu.Visible = True
        Panel_Aceuil.Visible = False
    End Sub

    Private Sub btn_Vendre_Click(sender As Object, e As EventArgs) Handles btn_Vendre.Click
        btn_Acceuil.BackColor = Color.Cyan
        btn_Acceuil.ForeColor = Color.Black
        btn_acheter.BackColor = Color.Cyan
        btn_acheter.ForeColor = Color.Black
        btn_Vendre.BackColor = ColorTranslator.FromHtml("#767676")
        btn_Vendre.ForeColor = Color.White
        Panel_vendre.Visible = True
        Panel_milieu.Visible = False
        Panel_Aceuil.Visible = False
    End Sub


    Private Sub FlowLayoutPanel3_SizeChanged(sender As Object, e As EventArgs) Handles FlowLayoutPanel3.SizeChanged
        redimenstion_flowlayout3()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Recherche.TextChanged

        If TextBox_Recherche.Text = "" Then
            query = "select article.* , categorie.nom as nom_categorie from article join categorie on article.id_categorie = categorie.id_categorie"
        Else
            query = "select article.* , categorie.nom as nom_categorie from article join categorie 
on article.id_categorie = categorie.id_categorie where article.nom like '%" & Trim(TextBox_Recherche.Text) & "%' "
        End If
        Try
            affiche_article(query)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        redimenstion_flowlayout3()
        redimenstion_flowlayout1()

    End Sub

    Private Sub Button_actualiser_Click(sender As Object, e As EventArgs) Handles Button_actualiser.Click

        query = "select article.* , categorie.nom as nom_categorie from article join categorie on article.id_categorie = categorie.id_categorie"
        affiche_article(query)
        redimenstion_flowlayout3()
        redimenstion_flowlayout1()
    End Sub

End Class
