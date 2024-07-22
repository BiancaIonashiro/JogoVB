<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnC1L1 = New System.Windows.Forms.Button()
        Me.btnC2L1 = New System.Windows.Forms.Button()
        Me.btnC3L1 = New System.Windows.Forms.Button()
        Me.btnC1L2 = New System.Windows.Forms.Button()
        Me.btnC2L2 = New System.Windows.Forms.Button()
        Me.btnC3L2 = New System.Windows.Forms.Button()
        Me.btnC1L3 = New System.Windows.Forms.Button()
        Me.btnC2L3 = New System.Windows.Forms.Button()
        Me.btnC3L3 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnJogar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnC1L1
        '
        Me.btnC1L1.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.btnC1L1.Location = New System.Drawing.Point(88, 41)
        Me.btnC1L1.Name = "btnC1L1"
        Me.btnC1L1.Size = New System.Drawing.Size(53, 23)
        Me.btnC1L1.TabIndex = 10
        Me.btnC1L1.UseVisualStyleBackColor = True
        '
        'btnC2L1
        '
        Me.btnC2L1.Location = New System.Drawing.Point(147, 41)
        Me.btnC2L1.Name = "btnC2L1"
        Me.btnC2L1.Size = New System.Drawing.Size(53, 23)
        Me.btnC2L1.TabIndex = 20
        Me.btnC2L1.UseVisualStyleBackColor = True
        '
        'btnC3L1
        '
        Me.btnC3L1.Location = New System.Drawing.Point(206, 41)
        Me.btnC3L1.Name = "btnC3L1"
        Me.btnC3L1.Size = New System.Drawing.Size(53, 23)
        Me.btnC3L1.TabIndex = 21
        Me.btnC3L1.UseVisualStyleBackColor = True
        '
        'btnC1L2
        '
        Me.btnC1L2.Location = New System.Drawing.Point(88, 70)
        Me.btnC1L2.Name = "btnC1L2"
        Me.btnC1L2.Size = New System.Drawing.Size(53, 23)
        Me.btnC1L2.TabIndex = 22
        Me.btnC1L2.UseVisualStyleBackColor = True
        '
        'btnC2L2
        '
        Me.btnC2L2.Location = New System.Drawing.Point(147, 70)
        Me.btnC2L2.Name = "btnC2L2"
        Me.btnC2L2.Size = New System.Drawing.Size(53, 23)
        Me.btnC2L2.TabIndex = 23
        Me.btnC2L2.UseVisualStyleBackColor = True
        '
        'btnC3L2
        '
        Me.btnC3L2.Location = New System.Drawing.Point(206, 70)
        Me.btnC3L2.Name = "btnC3L2"
        Me.btnC3L2.Size = New System.Drawing.Size(53, 23)
        Me.btnC3L2.TabIndex = 24
        Me.btnC3L2.UseVisualStyleBackColor = True
        '
        'btnC1L3
        '
        Me.btnC1L3.Location = New System.Drawing.Point(88, 99)
        Me.btnC1L3.Name = "btnC1L3"
        Me.btnC1L3.Size = New System.Drawing.Size(53, 23)
        Me.btnC1L3.TabIndex = 25
        Me.btnC1L3.UseVisualStyleBackColor = True
        '
        'btnC2L3
        '
        Me.btnC2L3.Location = New System.Drawing.Point(147, 99)
        Me.btnC2L3.Name = "btnC2L3"
        Me.btnC2L3.Size = New System.Drawing.Size(53, 23)
        Me.btnC2L3.TabIndex = 26
        Me.btnC2L3.UseVisualStyleBackColor = True
        '
        'btnC3L3
        '
        Me.btnC3L3.Location = New System.Drawing.Point(206, 99)
        Me.btnC3L3.Name = "btnC3L3"
        Me.btnC3L3.Size = New System.Drawing.Size(53, 23)
        Me.btnC3L3.TabIndex = 27
        Me.btnC3L3.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(128, 173)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(102, 23)
        Me.btnReset.TabIndex = 28
        Me.btnReset.Text = "Recarregar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnJogar
        '
        Me.btnJogar.Location = New System.Drawing.Point(128, 140)
        Me.btnJogar.Name = "btnJogar"
        Me.btnJogar.Size = New System.Drawing.Size(102, 27)
        Me.btnJogar.TabIndex = 29
        Me.btnJogar.Text = "Jogar"
        Me.btnJogar.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 232)
        Me.Controls.Add(Me.btnJogar)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnC3L3)
        Me.Controls.Add(Me.btnC2L3)
        Me.Controls.Add(Me.btnC1L3)
        Me.Controls.Add(Me.btnC3L2)
        Me.Controls.Add(Me.btnC2L2)
        Me.Controls.Add(Me.btnC1L2)
        Me.Controls.Add(Me.btnC3L1)
        Me.Controls.Add(Me.btnC2L1)
        Me.Controls.Add(Me.btnC1L1)
        Me.Name = "frmGame"
        Me.Text = "JogoDaVelha"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnC1L1 As Button
    Friend WithEvents btnC2L1 As Button
    Friend WithEvents btnC3L1 As Button
    Friend WithEvents btnC1L2 As Button
    Friend WithEvents btnC2L2 As Button
    Friend WithEvents btnC3L2 As Button
    Friend WithEvents btnC1L3 As Button
    Friend WithEvents btnC2L3 As Button
    Friend WithEvents btnC3L3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnJogar As Button
End Class
