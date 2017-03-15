Option Strict On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

#Region "variable global"
    Dim m_Etat As Integer
    Dim m_temps As Single
    Public Enum EtatChrono
        Play = 1
        Pause = 2
        Reset = 3
    End Enum
#End Region

#Region "Code"

    Protected Overrides Sub onpaint(e As PaintEventArgs)

        Dim p As New Pen(Color.Green, 10)

        'Create rectangle objects
        Dim rt As New Rectangle(2, 2, Size.Width, Size.Height)

        'Draw arcs
        e.Graphics.DrawArc(p, rt, 0, 360)

    End Sub

    Private Sub Chrono_Tick(sender As Object, e As EventArgs) Handles Chrono.Tick

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
            LblChrono.Text = minute & " : " & seconde
        End While


    End Sub

    'Private Sub chrono()

    '    Dim minute As Single = Me.Temporisation
    '    Dim seconde As Single = 60

    '    'Affichage initial
    '    LblChrono.Text = minute & " : " & seconde

    '    While minute <> 0
    '        If seconde <> 0 Then
    '            seconde = seconde - 1
    '        ElseIf seconde = 0 Then
    '            minute = minute - 1
    '            seconde = 60
    '        End If
    '        LblChrono.Text = minute & " : " & seconde
    '    End While
    'End Sub



#End Region

#Region "propriété"

    <Description("Marche, Pause ou reset du chrono")>
    Public Property Etat As Integer

        Get
            Return m_Etat
        End Get

        Set(value As Integer)
            m_Etat = value
            If value = 1 Then
                Chrono.Start()
            ElseIf value = 2 Then
                Chrono.Stop()
            ElseIf value = 3 Then
                Reset()
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
