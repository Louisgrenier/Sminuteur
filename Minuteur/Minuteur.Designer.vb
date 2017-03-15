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
<<<<<<< HEAD
        Me.SuspendLayout()
        '
=======
        Me.LblAfficheur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblAfficheur
        '
        Me.LblAfficheur.BackColor = System.Drawing.Color.Transparent
        Me.LblAfficheur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAfficheur.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAfficheur.Location = New System.Drawing.Point(0, 0)
        Me.LblAfficheur.Name = "LblAfficheur"
        Me.LblAfficheur.Size = New System.Drawing.Size(316, 307)
        Me.LblAfficheur.TabIndex = 0
        Me.LblAfficheur.Text = "Label1"
        Me.LblAfficheur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
>>>>>>> Modeling
        'Minuteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.Name = "Minuteur"
        Me.Size = New System.Drawing.Size(842, 463)
        Me.ResumeLayout(False)

    End Sub
=======
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.LblAfficheur)
        Me.Name = "Minuteur"
        Me.Size = New System.Drawing.Size(316, 307)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblAfficheur As Windows.Forms.Label
>>>>>>> Modeling
End Class
