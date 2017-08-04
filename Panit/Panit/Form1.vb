Public Class Form1
    Dim myBrush As New SolidBrush(Color.Black)
    Dim down As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillEllipse(Brushes.Green, 300, 100, 100, 100)
        Dim blackPen As New Pen(Color.Black)
        draw.DrawLine(blackPen, 350, 10, 350, 420)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y
    End Sub

    Private Sub Form1_BackgroundImageChanged(sender As Object, e As EventArgs) Handles Me.BackgroundImageChanged

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If down Then
            draw.FillEllipse(myBrush, X, Y, VScrollBar1.Value, VScrollBar1.Value)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        down = True

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        down = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        myBrush.Color = Color.Blue
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        myBrush.Color = Color.Green
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        myBrush.Color = Color.Pink
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myBrush.Color = Color.Brown
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        myBrush.Color = Color.Orange
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        myBrush.Color = Color.Gray
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        myBrush.Color = Color.Cyan
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        myBrush.Color = Color.Gold
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myBrush.Color = Color.Silver
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        myBrush.Color = Color.Maroon
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        myBrush.Color = Color.Firebrick
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        myBrush.Color = Color.Crimson
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        myBrush.Color = Color.Olive
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        myBrush.Color = Color.White
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        draw.FillRectangle(Brushes.White, 500, 500, 500, 500)
    End Sub
End Class
