Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form_confirmation
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
    Private Sub Button_supprimer_Click(sender As Object, e As EventArgs) Handles Button_supprimer.Click
        Try
            Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=Atricle")
            Dim query As String = "delete from article where id_article=@id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", Id)
            connection.Open()
            Dim row As Integer = cmd.ExecuteNonQuery()
            If row > 0 Then
                MessageBox.Show("Supprimer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        id = 0
        Me.Close()
    End Sub

    Private Sub nutton_annuler_supprimer_Click(sender As Object, e As EventArgs) Handles nutton_annuler_supprimer.Click
        Me.Close()
    End Sub

    Private Sub Form_confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = New Region(RoundForm(Me.ClientRectangle, 20))
    End Sub
End Class