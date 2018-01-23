Public Class FormScreen

    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.BackColor = Color.AliceBlue
        Me.TransparencyKey = Color.AliceBlue
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub FormScreen_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Me.FormBorderStyle = FormBorderStyle.None Then
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Green, ButtonBorderStyle.Solid)
        End If
    End Sub

    Private Sub FormScreen_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
        Else
            Me.FormBorderStyle = FormBorderStyle.None
        End If
    End Sub
End Class