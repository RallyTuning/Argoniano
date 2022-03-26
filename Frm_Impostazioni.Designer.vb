<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Impostazioni
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
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Annulla = New System.Windows.Forms.Button()
        Me.Txt_Path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Apri = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_OK
        '
        Me.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btn_OK.Location = New System.Drawing.Point(297, 119)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(75, 30)
        Me.Btn_OK.TabIndex = 3
        Me.Btn_OK.Text = "&OK"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Btn_Annulla
        '
        Me.Btn_Annulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Annulla.Location = New System.Drawing.Point(12, 119)
        Me.Btn_Annulla.Name = "Btn_Annulla"
        Me.Btn_Annulla.Size = New System.Drawing.Size(75, 30)
        Me.Btn_Annulla.TabIndex = 4
        Me.Btn_Annulla.Text = "&Annulla"
        Me.Btn_Annulla.UseVisualStyleBackColor = True
        '
        'Txt_Path
        '
        Me.Txt_Path.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Path.Location = New System.Drawing.Point(12, 37)
        Me.Txt_Path.Name = "Txt_Path"
        Me.Txt_Path.Size = New System.Drawing.Size(317, 23)
        Me.Txt_Path.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cartella dei backup:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Apri
        '
        Me.Btn_Apri.Image = Global.Argoniano.My.Resources.Resources.folder
        Me.Btn_Apri.Location = New System.Drawing.Point(335, 37)
        Me.Btn_Apri.Name = "Btn_Apri"
        Me.Btn_Apri.Size = New System.Drawing.Size(37, 23)
        Me.Btn_Apri.TabIndex = 1
        Me.Btn_Apri.UseVisualStyleBackColor = True
        '
        'Frm_Impostazioni
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.Btn_Apri)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Path)
        Me.Controls.Add(Me.Btn_Annulla)
        Me.Controls.Add(Me.Btn_OK)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Impostazioni"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Impostazioni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Annulla As Button
    Friend WithEvents Txt_Path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Apri As Button
End Class
