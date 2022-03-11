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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_View))
        Me.ToolBarTop = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_Files = New System.Windows.Forms.ToolStripComboBox()
        Me.Btn_Cerca = New System.Windows.Forms.ToolStripButton()
        Me.Txt_Cerca = New System.Windows.Forms.ToolStripTextBox()
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
        Me.ToolBarTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Cmb_Files, Me.Btn_Cerca, Me.Txt_Cerca})
        Me.ToolBarTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolBarTop.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarTop.Name = "ToolBarTop"
        Me.ToolBarTop.Size = New System.Drawing.Size(784, 32)
        Me.ToolBarTop.TabIndex = 0
        Me.ToolBarTop.Text = "Toolbar sopra"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.BlueViolet
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 29)
        Me.ToolStripLabel1.Text = "Tabella:"
        '
        'Cmb_Files
        '
        Me.Cmb_Files.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cmb_Files.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmb_Files.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Cmb_Files.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Cmb_Files.Items.AddRange(New Object() {"/ Seleziona una tabella /"})
        Me.Cmb_Files.Name = "Cmb_Files"
        Me.Cmb_Files.Size = New System.Drawing.Size(335, 32)
        Me.Cmb_Files.Sorted = True
        '
        'Btn_Cerca
        '
        Me.Btn_Cerca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Cerca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_Cerca.ForeColor = System.Drawing.Color.MediumBlue
        Me.Btn_Cerca.Image = CType(resources.GetObject("Btn_Cerca.Image"), System.Drawing.Image)
        Me.Btn_Cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Cerca.Name = "Btn_Cerca"
        Me.Btn_Cerca.Size = New System.Drawing.Size(53, 29)
        Me.Btn_Cerca.Text = "&Cerca"
        '
        'Txt_Cerca
        '
        Me.Txt_Cerca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Txt_Cerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cerca.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt_Cerca.Name = "Txt_Cerca"
        Me.Txt_Cerca.Size = New System.Drawing.Size(234, 32)
        '
        'DGV_Centrale
        '
        Me.DGV_Centrale.AllowUserToAddRows = False
        Me.DGV_Centrale.AllowUserToDeleteRows = False
        Me.DGV_Centrale.AllowUserToOrderColumns = True
        Me.DGV_Centrale.AllowUserToResizeRows = False
        Me.DGV_Centrale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Centrale.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Centrale.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DGV_Centrale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Centrale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Centrale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Centrale.GridColor = System.Drawing.SystemColors.Control
        Me.DGV_Centrale.Location = New System.Drawing.Point(0, 32)
        Me.DGV_Centrale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV_Centrale.Name = "DGV_Centrale"
        Me.DGV_Centrale.ReadOnly = True
        Me.DGV_Centrale.RowHeadersVisible = False
        Me.DGV_Centrale.RowHeadersWidth = 62
        Me.DGV_Centrale.RowTemplate.Height = 28
        Me.DGV_Centrale.Size = New System.Drawing.Size(784, 393)
        Me.DGV_Centrale.TabIndex = 2
        '
        'ToolBarBottom
        '
        Me.ToolBarBottom.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolBarBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lbl_Stato, Me.Lbl_TotRighe, Me.Pb_Progresso, Me.Lbl_TempoImpegato})
        Me.ToolBarBottom.Location = New System.Drawing.Point(0, 425)
        Me.ToolBarBottom.Name = "ToolBarBottom"
        Me.ToolBarBottom.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.ToolBarBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolBarBottom.Size = New System.Drawing.Size(784, 36)
        Me.ToolBarBottom.TabIndex = 3
        Me.ToolBarBottom.Text = "Toolbar sotto"
        '
        'Lbl_Stato
        '
        Me.Lbl_Stato.AutoSize = False
        Me.Lbl_Stato.Name = "Lbl_Stato"
        Me.Lbl_Stato.Size = New System.Drawing.Size(250, 31)
        Me.Lbl_Stato.Text = ":)"
        Me.Lbl_Stato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotRighe
        '
        Me.Lbl_TotRighe.AutoSize = False
        Me.Lbl_TotRighe.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.Lbl_TotRighe.Name = "Lbl_TotRighe"
        Me.Lbl_TotRighe.Size = New System.Drawing.Size(200, 31)
        Me.Lbl_TotRighe.Text = "Righe totali: 0"
        Me.Lbl_TotRighe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pb_Progresso
        '
        Me.Pb_Progresso.Name = "Pb_Progresso"
        Me.Pb_Progresso.Size = New System.Drawing.Size(100, 30)
        Me.Pb_Progresso.Step = 1
        '
        'Lbl_TempoImpegato
        '
        Me.Lbl_TempoImpegato.Name = "Lbl_TempoImpegato"
        Me.Lbl_TempoImpegato.Size = New System.Drawing.Size(154, 31)
        Me.Lbl_TempoImpegato.Text = "Tempo impiegato (just4fun)"
        Me.Lbl_TempoImpegato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.DGV_Centrale)
        Me.Controls.Add(Me.ToolBarBottom)
        Me.Controls.Add(Me.ToolBarTop)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
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
End Class
