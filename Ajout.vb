Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Windows.Win32.System

Public Class Ajout
    Public mode As String
    Dim cat As Integer
    Public id As Integer
    Private Function RoundForm(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub RemplirComboCategorie()
        Dim query As String = "SELECT nom FROM Categorie"
        Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=Atricle")

        Try
            connection.Open()
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBox_categorie.Items.Clear()

            While reader.Read()
                ComboBox_categorie.Items.Add(reader("nom").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub modifier(id As Integer, nom As String, prix As String, categorie As Integer)
        Try
            Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=Atricle")

            Dim query As String = "UPDATE article SET nom = @nom, prix = @prix, id_categorie = @id_categorie ,img = @img WHERE id_article = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nom", nom)
            cmd.Parameters.AddWithValue("@prix", CDbl(prix))
            cmd.Parameters.AddWithValue("@id_categorie", CInt(categorie))
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@img", emplacement)
            connection.Open()
            Dim exec As Integer = cmd.ExecuteNonQuery()
            If exec > 0 Then
                MessageBox.Show("modification reussi")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public emplacement As String
    Private Sub ajouter(nom As String, prix As String, categorie As Integer)
        Try

            Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=Atricle")

            Dim query As String = "insert into article(nom,prix,id_categorie,img) values(@nom,@prix,@id_categorie,@img)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nom", nom)
            cmd.Parameters.AddWithValue("@prix", CDbl(prix))
            cmd.Parameters.AddWithValue("@id_categorie", CInt(categorie))
            cmd.Parameters.AddWithValue("@img", emplacement)

            connection.Open()

            Dim executer As Integer = cmd.ExecuteNonQuery()
            If executer > 0 Then
                MessageBox.Show("ajouter")
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ajoutcategorie(categorie)
        Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=Atricle")

        Dim query As String = "insert into categorie(nom) value(@categorie)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@categorie", categorie)

        connection.Open()

        Dim rw As Integer = cmd.ExecuteNonQuery()
        If rw > 0 Then
            MessageBox.Show("categorie ajouter")
        End If

        connection.Close()

    End Sub
    Private Sub prendreidcategori(categorie)
        Try
            Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=Atricle")

            Dim query As String = "select id_categorie from categorie where nom=@nom"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nom", categorie)

            connection.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                cat = CInt(reader("id_categorie"))
            Else
                MessageBox.Show("categorie nouvelle")
                cat = 0
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If mode = "Ajout" Then
                If ComboBox_categorie.Text <> "" Then
                    prendreidcategori(Trim(ComboBox_categorie.Text))

                    If cat = 0 Then
                        ajoutcategorie(Trim(ComboBox_categorie.Text))
                    End If

                End If

                prendreidcategori(Trim(ComboBox_categorie.Text))
                ajouter(Trim(TextBox_Nom.Text), Trim(TextBox_Prix.Text), cat)
                MessageBox.Show("AAAAAJOUTER")

            ElseIf mode = "Modifi" Then

                If ComboBox_categorie.Text <> "" Then
                    prendreidcategori(Trim(ComboBox_categorie.Text))

                    If cat = 0 Then
                        ajoutcategorie(Trim(ComboBox_categorie.Text))

                    End If

                End If
                prendreidcategori(Trim(ComboBox_categorie.Text))
                modifier(id, TextBox_Nom.Text, TextBox_Prix.Text, cat)
                MessageBox.Show("MModifier")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        id = 0
        cat = 0

        emplacement = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Ajout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat = 0
        RemplirComboCategorie()
        Me.Region = New Region(RoundForm(Me.ClientRectangle, 20))

    End Sub

    Private Sub Button_import_Click(sender As Object, e As EventArgs) Handles Button_import.Click

        Dim ofd As New OpenFileDialog()
        ofd.Title = "choisir une image"
        ofd.Filter = "fichiers image|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim origine_img As String = ofd.FileName
            TextBox_nom_image.Text = ofd.FileName
            Dim destination As String = Application.StartupPath & "\images"
            If IO.Directory.Exists(destination) Then
                IO.Directory.CreateDirectory(destination)
            End If
            Dim nom_fichier As String = "img_" & Now.ToString("yyyymmddhhmmss") & IO.Path.GetExtension(origine_img)
            Dim chemindestination As String = IO.Path.Combine(destination, nom_fichier)
            IO.File.Copy(origine_img, chemindestination, overwrite:=False)
            PictureBox_ajout.Image = Image.FromFile(chemindestination)

            emplacement = chemindestination
        End If


    End Sub
End Class