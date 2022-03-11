<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Segreteria = New System.Windows.Forms.Button()
        Me.Btn_Bilancio = New System.Windows.Forms.Button()
        Me.Btn_Piattaforma = New System.Windows.Forms.Button()
        Me.Btn_Altro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_TabelleTot = New System.Windows.Forms.Label()
        Me.Btn_Info = New System.Windows.Forms.Button()
        Me.Btn_Vuote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Segreteria
        '
        Me.Btn_Segreteria.Enabled = False
        Me.Btn_Segreteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Segreteria.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Segreteria.Location = New System.Drawing.Point(15, 54)
        Me.Btn_Segreteria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Segreteria.Name = "Btn_Segreteria"
        Me.Btn_Segreteria.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Segreteria.TabIndex = 1
        Me.Btn_Segreteria.Text = "&Segreteria"
        Me.Btn_Segreteria.UseVisualStyleBackColor = True
        '
        'Btn_Bilancio
        '
        Me.Btn_Bilancio.Enabled = False
        Me.Btn_Bilancio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bilancio.ForeColor = System.Drawing.Color.Green
        Me.Btn_Bilancio.Location = New System.Drawing.Point(180, 54)
        Me.Btn_Bilancio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Bilancio.Name = "Btn_Bilancio"
        Me.Btn_Bilancio.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Bilancio.TabIndex = 2
        Me.Btn_Bilancio.Text = "&Bilancio"
        Me.Btn_Bilancio.UseVisualStyleBackColor = True
        '
        'Btn_Piattaforma
        '
        Me.Btn_Piattaforma.Enabled = False
        Me.Btn_Piattaforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Piattaforma.ForeColor = System.Drawing.Color.Goldenrod
        Me.Btn_Piattaforma.Location = New System.Drawing.Point(15, 123)
        Me.Btn_Piattaforma.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Piattaforma.Name = "Btn_Piattaforma"
        Me.Btn_Piattaforma.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Piattaforma.TabIndex = 3
        Me.Btn_Piattaforma.Text = "&Piattaforma"
        Me.Btn_Piattaforma.UseVisualStyleBackColor = True
        '
        'Btn_Altro
        '
        Me.Btn_Altro.Enabled = False
        Me.Btn_Altro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Altro.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Btn_Altro.Location = New System.Drawing.Point(180, 123)
        Me.Btn_Altro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Altro.Name = "Btn_Altro"
        Me.Btn_Altro.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Altro.TabIndex = 4
        Me.Btn_Altro.Text = "&Altro"
        Me.Btn_Altro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Argoniano"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_TabelleTot
        '
        Me.Lbl_TabelleTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TabelleTot.ForeColor = System.Drawing.Color.OrangeRed
        Me.Lbl_TabelleTot.Location = New System.Drawing.Point(15, 261)
        Me.Lbl_TabelleTot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_TabelleTot.Name = "Lbl_TabelleTot"
        Me.Lbl_TabelleTot.Size = New System.Drawing.Size(318, 51)
        Me.Lbl_TabelleTot.TabIndex = 4
        Me.Lbl_TabelleTot.Text = "Caricamento..."
        Me.Lbl_TabelleTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Info
        '
        Me.Btn_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Info.Location = New System.Drawing.Point(180, 192)
        Me.Btn_Info.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Info.Name = "Btn_Info"
        Me.Btn_Info.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Info.TabIndex = 4
        Me.Btn_Info.Text = "&Info"
        Me.Btn_Info.UseVisualStyleBackColor = True
        '
        'Btn_Vuote
        '
        Me.Btn_Vuote.Enabled = False
        Me.Btn_Vuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Vuote.ForeColor = System.Drawing.Color.DimGray
        Me.Btn_Vuote.Location = New System.Drawing.Point(15, 192)
        Me.Btn_Vuote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Vuote.Name = "Btn_Vuote"
        Me.Btn_Vuote.Size = New System.Drawing.Size(153, 58)
        Me.Btn_Vuote.TabIndex = 3
        Me.Btn_Vuote.Text = "&Vuote"
        Me.Btn_Vuote.UseVisualStyleBackColor = True
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 321)
        Me.Controls.Add(Me.Lbl_TabelleTot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Vuote)
        Me.Controls.Add(Me.Btn_Piattaforma)
        Me.Controls.Add(Me.Btn_Info)
        Me.Controls.Add(Me.Btn_Bilancio)
        Me.Controls.Add(Me.Btn_Altro)
        Me.Controls.Add(Me.Btn_Segreteria)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argoniano"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Segreteria As Button
    Friend WithEvents Btn_Bilancio As Button
    Friend WithEvents Btn_Piattaforma As Button
    Friend WithEvents Btn_Altro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_TabelleTot As Label
    Friend WithEvents Btn_Info As Button
    Friend WithEvents Btn_Vuote As Button
End Class
