<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_View
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
        Me.ToolBarTop = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_Files = New System.Windows.Forms.ToolStripComboBox()
        Me.Btn_Cerca = New System.Windows.Forms.ToolStripButton()
        Me.Txt_Cerca = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_Esporta = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FileCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGV_Centrale = New System.Windows.Forms.DataGridView()
        Me.ToolBarBottom = New System.Windows.Forms.StatusStrip()
        Me.Lbl_Stato = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lbl_TotRighe = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pb_Progresso = New System.Windows.Forms.ToolStripProgressBar()
        Me.Lbl_TempoImpegato = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolBarTop.SuspendLayout()
        CType(Me.DGV_Centrale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBarBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarTop
        '
        Me.ToolBarTop.AutoSize = False
        Me.ToolBarTop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolBarTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBarTop.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolBarTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Cmb_Files, Me.Btn_Cerca, Me.Txt_Cerca, Me.Btn_Esporta})
        Me.ToolBarTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolBarTop.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarTop.Name = "ToolBarTop"
        Me.ToolBarTop.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolBarTop.Size = New System.Drawing.Size(1134, 35)
        Me.ToolBarTop.TabIndex = 0
        Me.ToolBarTop.Text = "Toolbar sopra"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.BlueViolet
        Me.ToolStripLabel1.Image = Global.Argoniano.My.Resources.Resources.table
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 32)
        Me.ToolStripLabel1.Text = "Tabella:"
        '
        'Cmb_Files
        '
        Me.Cmb_Files.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmb_Files.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmb_Files.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Cmb_Files.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Cmb_Files.Name = "Cmb_Files"
        Me.Cmb_Files.Size = New System.Drawing.Size(500, 35)
        Me.Cmb_Files.Sorted = True
        '
        'Btn_Cerca
        '
        Me.Btn_Cerca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Cerca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Cerca.ForeColor = System.Drawing.Color.MediumBlue
        Me.Btn_Cerca.Image = Global.Argoniano.My.Resources.Resources.magnifier
        Me.Btn_Cerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Cerca.Name = "Btn_Cerca"
        Me.Btn_Cerca.Size = New System.Drawing.Size(69, 32)
        Me.Btn_Cerca.Text = "&Cerca"
        '
        'Txt_Cerca
        '
        Me.Txt_Cerca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Txt_Cerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cerca.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt_Cerca.Name = "Txt_Cerca"
        Me.Txt_Cerca.Size = New System.Drawing.Size(350, 35)
        '
        'Btn_Esporta
        '
        Me.Btn_Esporta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileCSVToolStripMenuItem, Me.FileXMLToolStripMenuItem, Me.FileHTMLToolStripMenuItem})
        Me.Btn_Esporta.ForeColor = System.Drawing.Color.ForestGreen
        Me.Btn_Esporta.Image = Global.Argoniano.My.Resources.Resources.database_go
        Me.Btn_Esporta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Esporta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Esporta.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.Btn_Esporta.Name = "Btn_Esporta"
        Me.Btn_Esporta.Size = New System.Drawing.Size(91, 32)
        Me.Btn_Esporta.Text = "&Esporta"
        '
        'FileCSVToolStripMenuItem
        '
        Me.FileCSVToolStripMenuItem.Name = "FileCSVToolStripMenuItem"
        Me.FileCSVToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.FileCSVToolStripMenuItem.Text = "File &CSV"
        '
        'FileXMLToolStripMenuItem
        '
        Me.FileXMLToolStripMenuItem.Name = "FileXMLToolStripMenuItem"
        Me.FileXMLToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.FileXMLToolStripMenuItem.Text = "File &XML"
        '
        'FileHTMLToolStripMenuItem
        '
        Me.FileHTMLToolStripMenuItem.Name = "FileHTMLToolStripMenuItem"
        Me.FileHTMLToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.FileHTMLToolStripMenuItem.Text = "File &HTML"
        '
        'DGV_Centrale
        '
        Me.DGV_Centrale.AllowUserToAddRows = False
        Me.DGV_Centrale.AllowUserToDeleteRows = False
        Me.DGV_Centrale.AllowUserToOrderColumns = True
        Me.DGV_Centrale.AllowUserToResizeRows = False
        Me.DGV_Centrale.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Centrale.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Centrale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Centrale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Centrale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Centrale.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Centrale.Location = New System.Drawing.Point(0, 35)
        Me.DGV_Centrale.Name = "DGV_Centrale"
        Me.DGV_Centrale.ReadOnly = True
        Me.DGV_Centrale.RowHeadersVisible = False
        Me.DGV_Centrale.RowHeadersWidth = 62
        Me.DGV_Centrale.RowTemplate.Height = 28
        Me.DGV_Centrale.Size = New System.Drawing.Size(1134, 491)
        Me.DGV_Centrale.TabIndex = 1
        '
        'ToolBarBottom
        '
        Me.ToolBarBottom.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolBarBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lbl_Stato, Me.Lbl_TotRighe, Me.Pb_Progresso, Me.Lbl_TempoImpegato})
        Me.ToolBarBottom.Location = New System.Drawing.Point(0, 526)
        Me.ToolBarBottom.Name = "ToolBarBottom"
        Me.ToolBarBottom.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.ToolBarBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolBarBottom.Size = New System.Drawing.Size(1134, 35)
        Me.ToolBarBottom.TabIndex = 3
        Me.ToolBarBottom.Text = "Toolbar sotto"
        '
        'Lbl_Stato
        '
        Me.Lbl_Stato.AutoSize = False
        Me.Lbl_Stato.Name = "Lbl_Stato"
        Me.Lbl_Stato.Size = New System.Drawing.Size(250, 30)
        Me.Lbl_Stato.Text = ":)"
        Me.Lbl_Stato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotRighe
        '
        Me.Lbl_TotRighe.AutoSize = False
        Me.Lbl_TotRighe.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.Lbl_TotRighe.Name = "Lbl_TotRighe"
        Me.Lbl_TotRighe.Size = New System.Drawing.Size(200, 30)
        Me.Lbl_TotRighe.Text = "Righe totali: 0"
        Me.Lbl_TotRighe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pb_Progresso
        '
        Me.Pb_Progresso.Name = "Pb_Progresso"
        Me.Pb_Progresso.Size = New System.Drawing.Size(150, 29)
        Me.Pb_Progresso.Step = 1
        '
        'Lbl_TempoImpegato
        '
        Me.Lbl_TempoImpegato.Name = "Lbl_TempoImpegato"
        Me.Lbl_TempoImpegato.Size = New System.Drawing.Size(154, 30)
        Me.Lbl_TempoImpegato.Text = "Tempo impiegato (just4fun)"
        Me.Lbl_TempoImpegato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_View
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1134, 561)
        Me.Controls.Add(Me.DGV_Centrale)
        Me.Controls.Add(Me.ToolBarBottom)
        Me.Controls.Add(Me.ToolBarTop)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(1150, 600)
        Me.Name = "Frm_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Argoniano"
        Me.ToolBarTop.ResumeLayout(False)
        Me.ToolBarTop.PerformLayout()
        CType(Me.DGV_Centrale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolBarBottom.ResumeLayout(False)
        Me.ToolBarBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolBarTop As ToolStrip
    Friend WithEvents Cmb_Files As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Txt_Cerca As ToolStripTextBox
    Friend WithEvents Btn_Cerca As ToolStripButton
    Friend WithEvents DGV_Centrale As DataGridView
    Friend WithEvents ToolBarBottom As StatusStrip
    Friend WithEvents Lbl_Stato As ToolStripStatusLabel
    Friend WithEvents Lbl_TotRighe As ToolStripStatusLabel
    Friend WithEvents Lbl_TempoImpegato As ToolStripStatusLabel
    Friend WithEvents Pb_Progresso As ToolStripProgressBar
    Friend WithEvents Btn_Esporta As ToolStripDropDownButton
    Friend WithEvents FileCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileHTMLToolStripMenuItem As ToolStripMenuItem
End Class
