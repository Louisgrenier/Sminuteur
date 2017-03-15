Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

#Region "Code"

    Protected Overrides Sub onpaint(e As PaintEventArgs)

        Dim p As New Pen(Color.Green, 10)

        'Create rectangle objects
        Dim rt As New Rectangle(100, 100, 80, 100)

        'Draw arcs
        e.Graphics.DrawArc(p, rt, 0, 360)

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs)

        Invalidate()

    End Sub





    Private Sub chrono()













    End Sub



#End Region

#Region "propriété"

    <Description("Start chrono")>
    Public Property Etat As Boolean

        Get
            Return Etat
        End Get

        Set(value As Boolean)
            Etat = value
            chrono()
        End Set
    End Property

    <Description("Temps minute")>
    Public Property temps As Single

        Get
            Return temps
        End Get

        Set(value As Single)
            temps = value
        End Set
    End Property

#End Region

End Class
