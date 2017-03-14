Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub


    Private Sub Minuteur_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim p As New Pen(Color.Green, 10)

        'Create rectangle objects
        Dim rt As New Rectangle(100, 150, 80, 100)

        'Draw arcs
        e.Graphics.DrawArc(p, rt, 0, -90)


    End Sub

End Class
