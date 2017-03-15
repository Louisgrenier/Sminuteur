<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Minuteur
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblChrono = New System.Windows.Forms.Label()
        Me.Chrono = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblChrono
        '
        Me.LblChrono.BackColor = System.Drawing.Color.Transparent
        Me.LblChrono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblChrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChrono.Location = New System.Drawing.Point(0, 0)
        Me.LblChrono.Name = "LblChrono"
        Me.LblChrono.Size = New System.Drawing.Size(316, 307)
        Me.LblChrono.TabIndex = 0
        Me.LblChrono.Text = "Label1"
        Me.LblChrono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chrono
        '
        Me.Chrono.Interval = 1000
        '
        'Minuteur
        '
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.LblChrono)
        Me.Name = "Minuteur"
        Me.Size = New System.Drawing.Size(316, 307)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblChrono As Windows.Forms.Label
    Friend WithEvents Chrono As Windows.Forms.Timer
End Class
