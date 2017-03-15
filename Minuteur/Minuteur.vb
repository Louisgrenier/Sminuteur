Option Strict On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class Minuteur

#Region "variable global"
    Dim minutes As Integer = 0
    Dim seconde As Integer = 0
    Public Structure EtatChrono
        Const Play = "Start"
        Const Pause = "Stop"
    End Structure
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
        seconde = 60

    End Sub

#End Region

#Region "propriété"

    <Description("Marche, Pause ou reset du chrono")>
    Public Property Etat As EtatChrono

        Get
            Return Etat
        End Get

        Set(value As EtatChrono)
            Etat = value
            If value = "Start" Then
                Chrono.Start()
            ElseIf value = "Stop" Then
                Chrono.Stop()
            End If
        End Set
    End Property

    <Description("Temps minute")>
    Public Property Temporisation As Integer

        Get
            Return m_temps
        End Get

        Set(value As Integer)
            m_temps = value
            minutes = value
        End Set
    End Property

#End Region

End Class
