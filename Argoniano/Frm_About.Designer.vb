<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_About
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_About))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Versione = New System.Windows.Forms.Label()
        Me.Lnk_Email = New System.Windows.Forms.LinkLabel()
        Me.Lnk_Capozzoli = New System.Windows.Forms.LinkLabel()
        Me.Lnk_Disactive = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Argoniano"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Versione
        '
        Me.Lbl_Versione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Versione.Location = New System.Drawing.Point(82, 54)
        Me.Lbl_Versione.Name = "Lbl_Versione"
        Me.Lbl_Versione.Size = New System.Drawing.Size(190, 22)
        Me.Lbl_Versione.TabIndex = 2
        Me.Lbl_Versione.Text = "v 0.0"
        Me.Lbl_Versione.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lnk_Email
        '
        Me.Lnk_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnk_Email.LinkColor = System.Drawing.Color.Green
        Me.Lnk_Email.Location = New System.Drawing.Point(12, 192)
        Me.Lnk_Email.Name = "Lnk_Email"
        Me.Lnk_Email.Size = New System.Drawing.Size(260, 20)
        Me.Lnk_Email.TabIndex = 4
        Me.Lnk_Email.TabStop = True
        Me.Lnk_Email.Text = "gianluigi@capozzoli.me"
        Me.Lnk_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lnk_Capozzoli
        '
        Me.Lnk_Capozzoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnk_Capozzoli.LinkColor = System.Drawing.Color.BlueViolet
        Me.Lnk_Capozzoli.Location = New System.Drawing.Point(12, 160)
        Me.Lnk_Capozzoli.Name = "Lnk_Capozzoli"
        Me.Lnk_Capozzoli.Size = New System.Drawing.Size(125, 20)
        Me.Lnk_Capozzoli.TabIndex = 5
        Me.Lnk_Capozzoli.TabStop = True
        Me.Lnk_Capozzoli.Text = "www.capozzoli.me"
        Me.Lnk_Capozzoli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lnk_Disactive
        '
        Me.Lnk_Disactive.ActiveLinkColor = System.Drawing.Color.Navy
        Me.Lnk_Disactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnk_Disactive.LinkColor = System.Drawing.Color.Red
        Me.Lnk_Disactive.Location = New System.Drawing.Point(147, 160)
        Me.Lnk_Disactive.Name = "Lnk_Disactive"
        Me.Lnk_Disactive.Size = New System.Drawing.Size(125, 20)
        Me.Lnk_Disactive.TabIndex = 6
        Me.Lnk_Disactive.TabStop = True
        Me.Lnk_Disactive.Text = "www.disactive.com"
        Me.Lnk_Disactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 62)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Creato with ♥ da Gianluigi Capozzoli" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Per il Liceo Ettore Majorana di Rho (MI)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 226)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 123)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Frm_About
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lnk_Disactive)
        Me.Controls.Add(Me.Lnk_Capozzoli)
        Me.Controls.Add(Me.Lnk_Email)
        Me.Controls.Add(Me.Lbl_Versione)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About that shit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_Versione As Label
    Friend WithEvents Lnk_Email As LinkLabel
    Friend WithEvents Lnk_Capozzoli As LinkLabel
    Friend WithEvents Lnk_Disactive As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
