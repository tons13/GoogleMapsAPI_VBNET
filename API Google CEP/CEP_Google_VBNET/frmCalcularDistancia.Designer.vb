<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcularDistancia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrigem = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.bntDistancia = New System.Windows.Forms.Button()
        Me.bntCalcula = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDistancia = New System.Windows.Forms.Label()
        Me.lblDistanciaKm = New System.Windows.Forms.Label()
        Me.rbVeiculo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino:"
        '
        'txtOrigem
        '
        Me.txtOrigem.Location = New System.Drawing.Point(15, 80)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.Size = New System.Drawing.Size(415, 20)
        Me.txtOrigem.TabIndex = 2
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(15, 135)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(415, 20)
        Me.txtDestino.TabIndex = 3
        '
        'bntDistancia
        '
        Me.bntDistancia.Location = New System.Drawing.Point(323, 246)
        Me.bntDistancia.Name = "bntDistancia"
        Me.bntDistancia.Size = New System.Drawing.Size(107, 47)
        Me.bntDistancia.TabIndex = 4
        Me.bntDistancia.Text = "Distancia XML"
        Me.bntDistancia.UseVisualStyleBackColor = True
        '
        'bntCalcula
        '
        Me.bntCalcula.Location = New System.Drawing.Point(15, 246)
        Me.bntCalcula.Name = "bntCalcula"
        Me.bntCalcula.Size = New System.Drawing.Size(107, 47)
        Me.bntCalcula.TabIndex = 5
        Me.bntCalcula.Text = "Calcular Distancia"
        Me.bntCalcula.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "A distancia é :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "A distancia em km :"
        '
        'lblDistancia
        '
        Me.lblDistancia.AutoSize = True
        Me.lblDistancia.Location = New System.Drawing.Point(114, 169)
        Me.lblDistancia.Name = "lblDistancia"
        Me.lblDistancia.Size = New System.Drawing.Size(0, 13)
        Me.lblDistancia.TabIndex = 8
        '
        'lblDistanciaKm
        '
        Me.lblDistanciaKm.AutoSize = True
        Me.lblDistanciaKm.Location = New System.Drawing.Point(114, 197)
        Me.lblDistanciaKm.Name = "lblDistanciaKm"
        Me.lblDistanciaKm.Size = New System.Drawing.Size(0, 13)
        Me.lblDistanciaKm.TabIndex = 9
        '
        'rbVeiculo
        '
        Me.rbVeiculo.AutoSize = True
        Me.rbVeiculo.Checked = True
        Me.rbVeiculo.Location = New System.Drawing.Point(15, 28)
        Me.rbVeiculo.Name = "rbVeiculo"
        Me.rbVeiculo.Size = New System.Drawing.Size(62, 17)
        Me.rbVeiculo.TabIndex = 10
        Me.rbVeiculo.TabStop = True
        Me.rbVeiculo.Text = "Veículo"
        Me.rbVeiculo.UseVisualStyleBackColor = True
        '
        'frmCalcularDistancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 317)
        Me.Controls.Add(Me.rbVeiculo)
        Me.Controls.Add(Me.lblDistanciaKm)
        Me.Controls.Add(Me.lblDistancia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bntCalcula)
        Me.Controls.Add(Me.bntDistancia)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtOrigem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCalcularDistancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Google Distancia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrigem As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents bntDistancia As System.Windows.Forms.Button
    Friend WithEvents bntCalcula As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDistancia As System.Windows.Forms.Label
    Friend WithEvents lblDistanciaKm As System.Windows.Forms.Label
    Friend WithEvents rbVeiculo As System.Windows.Forms.RadioButton
End Class
