Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur



    Protected Overrides Sub onpaint(e As PaintEventArgs)

        Dim p As New Pen(Color.Green, 10)

        'Create rectangle objects
        Dim rt As New Rectangle(100, 100, 80, 100)

        'Draw arcs
        e.Graphics.DrawArc(p, rt, 0, TrackBar1.Value)

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged

        Invalidate()

    End Sub
End Class
