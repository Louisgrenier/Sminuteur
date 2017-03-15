Option Strict On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

    Dim m_Etat As Boolean
    Dim m_temps As Single

#Region "Code"

    Protected Overrides Sub onpaint(e As PaintEventArgs)

        Dim p As New Pen(Color.Green, 10)

        'Create rectangle objects
        Dim rt As New Rectangle(2, 2, Size.Width, Size.Height)

        'Draw arcs
        e.Graphics.DrawArc(p, rt, 0, 360)

    End Sub

    Private Sub chrono()

        Dim minute As Single = Me.Temporisation
        Dim seconde As Single = 60

        'Affichage initial
        LblChrono.Text = minute & " : " & seconde

        While minute <> 0
            If seconde <> 0 Then
                seconde = seconde - 1
            ElseIf seconde = 0 Then
                minute = minute - 1
                seconde = 60
            End If
        End While
    End Sub



#End Region

#Region "propriété"

    <Description("Start chrono")>
    Public Property Etat As Boolean

        Get
            Return m_Etat
        End Get

        Set(value As Boolean)
            m_Etat = value
            If value = True Then
                chrono()
            End If
        End Set
    End Property

    <Description("Temps minute")>
    Public Property Temporisation As Single

        Get
            Return m_temps
        End Get

        Set(value As Single)
            m_temps = value
        End Set
    End Property

#End Region

End Class
