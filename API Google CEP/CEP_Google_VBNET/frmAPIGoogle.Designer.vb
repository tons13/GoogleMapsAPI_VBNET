<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPIGoogle
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
        Me.btnGetCEP = New System.Windows.Forms.Button()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.bntGoogle = New System.Windows.Forms.Button()
        Me.bntGoogleMaps = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bntDistanciaXML = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetCEP
        '
        Me.btnGetCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCEP.Location = New System.Drawing.Point(154, 176)
        Me.btnGetCEP.Name = "btnGetCEP"
        Me.btnGetCEP.Size = New System.Drawing.Size(108, 38)
        Me.btnGetCEP.TabIndex = 0
        Me.btnGetCEP.Text = "Obter CEP"
        Me.btnGetCEP.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(27, 48)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(386, 20)
        Me.txtEndereco.TabIndex = 1
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(27, 93)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(386, 20)
        Me.txtCidade.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estado Sigla"
        '
        'txtCEP
        '
        Me.txtCEP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCEP.Enabled = False
        Me.txtCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCEP.Location = New System.Drawing.Point(273, 190)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(140, 24)
        Me.txtCEP.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CEP"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(298, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Location = New System.Drawing.Point(27, 137)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(183, 21)
        Me.cboUF.TabIndex = 11
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(298, 137)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(115, 23)
        Me.btnLimpar.TabIndex = 12
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'bntGoogle
        '
        Me.bntGoogle.Enabled = False
        Me.bntGoogle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntGoogle.Location = New System.Drawing.Point(27, 236)
        Me.bntGoogle.Name = "bntGoogle"
        Me.bntGoogle.Size = New System.Drawing.Size(113, 39)
        Me.bntGoogle.TabIndex = 13
        Me.bntGoogle.Text = "Google Maps XML"
        Me.bntGoogle.UseVisualStyleBackColor = True
        '
        'bntGoogleMaps
        '
        Me.bntGoogleMaps.Enabled = False
        Me.bntGoogleMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntGoogleMaps.Location = New System.Drawing.Point(154, 236)
        Me.bntGoogleMaps.Name = "bntGoogleMaps"
        Me.bntGoogleMaps.Size = New System.Drawing.Size(108, 39)
        Me.bntGoogleMaps.TabIndex = 14
        Me.bntGoogleMaps.Text = "Google Maps"
        Me.bntGoogleMaps.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bntDistanciaXML)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 303)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "API .NET"
        '
        'bntDistanciaXML
        '
        Me.bntDistanciaXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntDistanciaXML.Location = New System.Drawing.Point(14, 172)
        Me.bntDistanciaXML.Name = "bntDistanciaXML"
        Me.bntDistanciaXML.Size = New System.Drawing.Size(113, 39)
        Me.bntDistanciaXML.TabIndex = 16
        Me.bntDistanciaXML.Text = "Obter Distancia XML"
        Me.bntDistanciaXML.UseVisualStyleBackColor = True
        '
        'frmAPIGoogle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(442, 317)
        Me.Controls.Add(Me.bntGoogleMaps)
        Me.Controls.Add(Me.bntGoogle)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.btnGetCEP)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAPIGoogle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "API "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetCEP As System.Windows.Forms.Button
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCEP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents bntGoogle As System.Windows.Forms.Button
    Friend WithEvents bntGoogleMaps As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bntDistanciaXML As System.Windows.Forms.Button

End Class
