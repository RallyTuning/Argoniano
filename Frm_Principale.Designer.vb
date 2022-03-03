<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principale
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principale))
        Me.ToolBarTop = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_Files = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Txt_Cerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_CercaCol = New System.Windows.Forms.ToolStripComboBox()
        Me.Btn_Cerca = New System.Windows.Forms.ToolStripButton()
        Me.Btn_WTF = New System.Windows.Forms.ToolStripButton()
        Me.DGV_Centrale = New System.Windows.Forms.DataGridView()
        Me.ToolBarBottom = New System.Windows.Forms.StatusStrip()
        Me.Lbl_Stato = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lbl_TotRighe = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lbl_TempoImpegato = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UselessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolBarTop.SuspendLayout()
        CType(Me.DGV_Centrale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolBarBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarTop
        '
        Me.ToolBarTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBarTop.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolBarTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Cmb_Files, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.Txt_Cerca, Me.ToolStripLabel5, Me.Cmb_CercaCol, Me.Btn_Cerca, Me.Btn_WTF})
        Me.ToolBarTop.Location = New System.Drawing.Point(0, 0)
        Me.ToolBarTop.Name = "ToolBarTop"
        Me.ToolBarTop.Size = New System.Drawing.Size(1228, 39)
        Me.ToolBarTop.TabIndex = 0
        Me.ToolBarTop.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(117, 34)
        Me.ToolStripLabel1.Text = "File da aprire:"
        '
        'Cmb_Files
        '
        Me.Cmb_Files.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cmb_Files.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmb_Files.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Cmb_Files.Name = "Cmb_Files"
        Me.Cmb_Files.Size = New System.Drawing.Size(400, 39)
        Me.Cmb_Files.Sorted = True
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 34)
        Me.ToolStripLabel2.Text = "Cerca:"
        '
        'Txt_Cerca
        '
        Me.Txt_Cerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cerca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_Cerca.Name = "Txt_Cerca"
        Me.Txt_Cerca.Size = New System.Drawing.Size(250, 39)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(120, 34)
        Me.ToolStripLabel5.Text = "nella colonna:"
        '
        'Cmb_CercaCol
        '
        Me.Cmb_CercaCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmb_CercaCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmb_CercaCol.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Cmb_CercaCol.Name = "Cmb_CercaCol"
        Me.Cmb_CercaCol.Size = New System.Drawing.Size(250, 33)
        '
        'Btn_Cerca
        '
        Me.Btn_Cerca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_Cerca.Image = CType(resources.GetObject("Btn_Cerca.Image"), System.Drawing.Image)
        Me.Btn_Cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Cerca.Name = "Btn_Cerca"
        Me.Btn_Cerca.Size = New System.Drawing.Size(59, 29)
        Me.Btn_Cerca.Text = "&Cerca"
        '
        'Btn_WTF
        '
        Me.Btn_WTF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_WTF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_WTF.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_WTF.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Btn_WTF.Image = CType(resources.GetObject("Btn_WTF.Image"), System.Drawing.Image)
        Me.Btn_WTF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_WTF.Name = "Btn_WTF"
        Me.Btn_WTF.Size = New System.Drawing.Size(78, 29)
        Me.Btn_WTF.Text = "(?) &Info"
        '
        'DGV_Centrale
        '
        Me.DGV_Centrale.AllowUserToAddRows = False
        Me.DGV_Centrale.AllowUserToDeleteRows = False
        Me.DGV_Centrale.AllowUserToOrderColumns = True
        Me.DGV_Centrale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Centrale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Centrale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Centrale.Location = New System.Drawing.Point(0, 39)
        Me.DGV_Centrale.Name = "DGV_Centrale"
        Me.DGV_Centrale.ReadOnly = True
        Me.DGV_Centrale.RowHeadersWidth = 62
        Me.DGV_Centrale.RowTemplate.Height = 28
        Me.DGV_Centrale.Size = New System.Drawing.Size(1228, 569)
        Me.DGV_Centrale.TabIndex = 2
        '
        'ToolBarBottom
        '
        Me.ToolBarBottom.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolBarBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lbl_Stato, Me.Lbl_TotRighe, Me.Lbl_TempoImpegato})
        Me.ToolBarBottom.Location = New System.Drawing.Point(0, 608)
        Me.ToolBarBottom.Name = "ToolBarBottom"
        Me.ToolBarBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolBarBottom.Size = New System.Drawing.Size(1228, 36)
        Me.ToolBarBottom.TabIndex = 3
        Me.ToolBarBottom.Text = "StatusStrip1"
        '
        'Lbl_Stato
        '
        Me.Lbl_Stato.AutoSize = False
        Me.Lbl_Stato.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Lbl_Stato.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Lbl_Stato.Name = "Lbl_Stato"
        Me.Lbl_Stato.Size = New System.Drawing.Size(300, 29)
        Me.Lbl_Stato.Text = ":)"
        Me.Lbl_Stato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotRighe
        '
        Me.Lbl_TotRighe.AutoSize = False
        Me.Lbl_TotRighe.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Lbl_TotRighe.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Lbl_TotRighe.Name = "Lbl_TotRighe"
        Me.Lbl_TotRighe.Size = New System.Drawing.Size(200, 29)
        Me.Lbl_TotRighe.Text = "Righe totali: 0"
        Me.Lbl_TotRighe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TempoImpegato
        '
        Me.Lbl_TempoImpegato.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Lbl_TempoImpegato.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Lbl_TempoImpegato.Name = "Lbl_TempoImpegato"
        Me.Lbl_TempoImpegato.Size = New System.Drawing.Size(235, 29)
        Me.Lbl_TempoImpegato.Text = "Tempo impiegato (just4fun)"
        Me.Lbl_TempoImpegato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UselessTimer
        '
        Me.UselessTimer.Enabled = True
        '
        'Frm_Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 644)
        Me.Controls.Add(Me.DGV_Centrale)
        Me.Controls.Add(Me.ToolBarBottom)
        Me.Controls.Add(Me.ToolBarTop)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(600, 700)
        Me.Name = "Frm_Principale"
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Txt_Cerca As ToolStripTextBox
    Friend WithEvents Btn_Cerca As ToolStripButton
    Friend WithEvents Cmb_CercaCol As ToolStripComboBox
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents DGV_Centrale As DataGridView
    Friend WithEvents Btn_WTF As ToolStripButton
    Friend WithEvents ToolBarBottom As StatusStrip
    Friend WithEvents Lbl_Stato As ToolStripStatusLabel
    Friend WithEvents Lbl_TotRighe As ToolStripStatusLabel
    Friend WithEvents Lbl_TempoImpegato As ToolStripStatusLabel
    Friend WithEvents UselessTimer As Timer
End Class
