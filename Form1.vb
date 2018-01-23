Imports System.Drawing.Imaging

Public Class Form1
    Public formscreen As FormScreen
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        formscreen = New FormScreen
        formscreen.Show()
    End Sub

    Private Sub ButtonCapture_Click(sender As Object, e As EventArgs) Handles ButtonCapture.Click
        formscreen.Hide()
        Dim bmp As Bitmap = New Bitmap(formscreen.Width, formscreen.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.CopyFromScreen(formscreen.Location, New Point(0, 0), bmp.Size)
        g.Dispose()
        PictureBox1.Image = bmp
        formscreen.Show()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If PictureBox1.Image IsNot Nothing Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(SaveFileDialog1.FileName + ".png", ImageFormat.Png)
            End If
        End If
    End Sub
End Class
