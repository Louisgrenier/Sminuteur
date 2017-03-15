Option Strict On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

#Region "variable global"
    Dim m_etat As String
    Dim minutes As Integer = 0
    Dim seconde As Integer = 0
    Public Enum EtatChrono
        Play = 1
        Pause = 0
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

        If seconde <> 0 Then
            seconde = seconde - 1
        ElseIf seconde = 0 Then
            minutes = minutes - 1

            seconde = 60
        End If
        LblChrono.Text = minutes & " : " & seconde

    End Sub

    Private Sub Minuteur_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Affichage initial
        LblChrono.Text = "00 : 00"
        minutes = 0
        seconde = 0

    End Sub

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
    Public Property Temporisation As Integer

        Get
            Return Temporisation
        End Get

        Set(value As Integer)
            Temporisation = value
            minutes = value
        End Set
    End Property

#End Region

End Class
