Option Strict On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

#Region "variable global"
    Dim m_etat As String
    Dim minutes As Single = 0
    Dim seconde As Single = 0
    Dim calc_sec As Single
    Dim max_sec As Single

    Dim Mem_min As Single
    Public Enum EtatChrono
        Play = 1
        Pause = 0
    End Enum
#End Region

#Region "Code evenement form"

    Private Sub Chrono_Tick(sender As Object, e As EventArgs) Handles Chrono.Tick

        If seconde <> 0 Then
            seconde = seconde - 1
            calc_sec = calc_sec - 1
        ElseIf seconde = 0 Then
            minutes = minutes - 1

            seconde = 60
        End If
        LblChrono.Text = minutes & " : " & seconde

        If seconde = 0 And minutes = 0 Then
            Chrono.Stop()
        End If

        Invalidate()

    End Sub

    Private Sub Minuteur_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Affichage initial
        LblChrono.Text = "00 : 00"
        minutes = 0
        seconde = 0

    End Sub

#End Region

#Region "Sub sans evenement"

    Protected Overrides Sub onpaint(e As PaintEventArgs)

        Dim p As New Pen(Color.Green, 5)

        'Create rectangle objects
        Dim rt As New Rectangle(2, 2, (Size.Width - 4), (Size.Height - 4))

        'Draw arcs selon fonction de calcul d'angle
        e.Graphics.DrawArc(p, rt, -90, CalcAff)

    End Sub

    Private Function CalcAff() As Single
        'calcul d'angle selon les seconde
        '360° -> max sec 
        ' ?   -> x sec

        Dim angle As Single

        angle = (calc_sec * 360) / max_sec

        Return angle

    End Function

#End Region

#Region "propriété"

    <Description("Marche, Pause ou reset du chrono")>
    Public Property Etat As EtatChrono

        Get
            Return Etat
        End Get

        Set(value As EtatChrono)
            If value = 1 Then
                Chrono.Start()
            ElseIf value = 0 Then
                Chrono.Stop()
            End If
        End Set

    End Property

    <Description("Temps minute")>
    Public Property Temporisation As Single

        Get
            Return Temporisation
        End Get

        Set(value As Single)

            Mem_min = value
            minutes = value
            max_sec = 60 * minutes
            calc_sec = max_sec

        End Set
    End Property

#End Region

End Class
