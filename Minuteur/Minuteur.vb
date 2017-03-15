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
        e.Graphics.DrawArc(p, rt, 0, TrackBar1.Value)

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged

        Invalidate()

    End Sub
#End Region

#Region "propriété"

    <Description("Start ou Stop horloge")>
    Public Property Etat As Boolean

        Get
            Return Etat
        End Get

        Set(value As Boolean)
            Etat = value
        End Set
    End Property

    <Description("Temps minute")>
    Public Property temps As Boolean

        Get
            Return Etat
        End Get

        Set(value As Single)
            Etat = value
        End Set
    End Property

#End Region

End Class
