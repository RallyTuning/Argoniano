Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Frm_View

    Private ReadOnly DT_File As DataTable
    Private ReadOnly DT_Contenuto As New DataTable

    Sub New(DT As DataTable)
        InitializeComponent()

        DT_File = DT

        Me.Text = DT.TableName
        Me.Icon = My.Resources.Martin_Berube_Character_Knight

        If My.Settings.FullScreen Then
            Me.WindowState = FormWindowState.Maximized
        Else
            If My.Settings.Dimensioni = New Size(0, 0) Then
                Me.Size = New Size(1100, 600)
            Else
                Me.Size = My.Settings.Dimensioni
            End If
        End If

        DGV_Centrale.DoubleBuffering(True)
        ToolBarTop.DoubleBuffering(True)
        ToolBarBottom.DoubleBuffering(True)
    End Sub

    Private Sub Frm_Principale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            With Cmb_Files.ComboBox
                .DataSource = DT_File
                .DisplayMember = "Nome"
                .ValueMember = "Nome"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_Principale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            My.Settings.Dimensioni = Me.Size
            My.Settings.FullScreen = (Me.WindowState = FormWindowState.Maximized)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cmb_Files_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Files.SelectedIndexChanged
        Try
            Txt_Cerca.Text = String.Empty

            If Cmb_Files.SelectedIndex > 0 Then LeggiFile()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Cerca_Click(sender As Object, e As EventArgs) Handles Btn_Cerca.Click
        Try
            If Cmb_Files.SelectedIndex > 0 Then LeggiFile()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txt_Cerca_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Cerca.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then Call Btn_Cerca_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region " Esporta Stampa "

    Private Sub Btn_Esporta_DropDownOpened(sender As Object, e As EventArgs) Handles Btn_Esporta.DropDownOpened
        Try
            FileCSVToolStripMenuItem.Enabled = DGV_Centrale.Rows.Count > 0
            FileXMLToolStripMenuItem.Enabled = DGV_Centrale.Rows.Count > 0
            FileHTMLToolStripMenuItem.Enabled = DGV_Centrale.Rows.Count > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FileCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileCSVToolStripMenuItem.Click
        Try
            If DGV_Centrale.Rows.Count > 0 Then
                EsportaCSV()
            Else
                MessageBox.Show("Impossibile esportare una tabella vuota!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Nell'eventualità che il primo controllo salti per qualche mistero dell'informatica
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FileXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileXMLToolStripMenuItem.Click
        Try
            If DGV_Centrale.Rows.Count > 0 Then
                EsportaXML()
            Else
                MessageBox.Show("Impossibile esportare una tabella vuota!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Nell'eventualità che il primo controllo salti per qualche mistero dell'informatica
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FileHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileHTMLToolStripMenuItem.Click
        Try
            If DGV_Centrale.Rows.Count > 0 Then
                EsportaHTML()
            Else
                MessageBox.Show("Impossibile esportare una tabella vuota!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Nell'eventualità che il primo controllo salti per qualche mistero dell'informatica
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region " SUBS "

    Private Async Sub LeggiFile()
        Dim Filtro As String = String.Empty

        Try
            Dim FiSi As Long = 0
            Dim CR As DataRowView = TryCast(Cmb_Files.ComboBox.SelectedItem, DataRowView)

            Me.Text = DT_File.TableName & " - " & CR.Item("Nome").ToString
            ToolBarTop.Enabled = False
            Pb_Progresso.Value = 0
            If String.IsNullOrEmpty(Txt_Cerca.Text) Then
                Txt_Cerca.Text = "Attendere prego..."
            End If
            Lbl_Stato.Text = "Ricerca in corso..."
            Lbl_TotRighe.Text = "Righe totali: ..."
            Lbl_TempoImpegato.Text = "..."
            Lbl_Stato.ForeColor = Color.DodgerBlue

            Dim Crono As New Stopwatch
            Crono.Start()

            Await Task.Run(Sub()
                               Try
                                   'Legge il file
                                   Dim LineeFile As New List(Of String)
                                   Dim FilePath As String = Path.Combine(My.Settings.PathBackup, CR.Item("Nome").ToString & ".txt")
                                   Dim FI As New FileInfo(FilePath) 'Solo per il report finale
                                   FiSi = FI.Length 'Solo per il report finale

                                   Filtro = ToolBarTop.InvocaFunzioneSicuro(Function() Txt_Cerca.Text.Trim)

                                   LineeFile = PulisciFatture(FilePath)

                                   'Pulizia datatable
                                   DT_Contenuto.Columns.Clear()
                                   DT_Contenuto.Rows.Clear()

                                   'Crea le colonne datatable
                                   For Each Col As String In LineeFile(0).Split(vbTab)
                                       DT_Contenuto.Columns.Add(New DataColumn(Col.Trim))
                                   Next

                                   'Legge le altre righe (il contenuto) al datatable
                                   For L As Integer = 1 To LineeFile.Count - 1
                                       Dim Lsplitted() As String = LineeFile(L).Split(vbTab)

                                       DT_Contenuto.Rows.Add(Lsplitted)
                                   Next

                                   'Crea colonne listview e combobox
                                   DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns.Clear())
                                   DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Clear())

                                   'Dim ColWidthS As Integer = 0
                                   For Each Col As DataColumn In DT_Contenuto.Columns
                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns.Add(Col.ColumnName, Col.ColumnName))
                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns(Col.ColumnName).Width =
                                                                           TextRenderer.MeasureText(Col.ColumnName, DGV_Centrale.DefaultCellStyle.Font).Width + 10)
                                       'ColWidthS += DGV_Centrale.Columns(Col.ColumnName).Width
                                   Next

                                   'Sistema l'ultima colonna
                                   'Dim ColW As Integer = DGV_Centrale.Columns(DGV_Centrale.Columns.Count - 1).Width
                                   'Dim DGVW As Integer = DGV_Centrale.Width

                                   'If (ColW + DGVW) > (ColWidthS - 20) Then
                                   '    DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns(DGV_Centrale.Columns.Count - 1).Width =
                                   '                                    ColW + DGVW - ColWidthS - 20)
                                   'End If

                                   'Carica il contenuto del datatable
                                   Dim Rows_Filtrate As New List(Of DataRow)

                                   If String.IsNullOrWhiteSpace(Filtro) Or String.Equals(Filtro, "Attendere prego...") Then
                                       For Each Rw As DataRow In DT_Contenuto.Rows
                                           Rows_Filtrate.Add(Rw)
                                       Next
                                   Else
                                       Dim Q As String = ""

                                       For Each C As DataGridViewTextBoxColumn In DGV_Centrale.Columns
                                           Q &= C.HeaderCell.Value & " LIKE '%" & Filtro & "%' OR "
                                       Next

                                       Q = Q.Remove(Q.Length - 3, 2).Trim()

                                       Rows_Filtrate.AddRange(DT_Contenuto.Select(Q).ToList)
                                   End If

                                   'Aggiunge le righe al datagridview
                                   DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Clear())

                                   ToolBarBottom.InvocaMetodoSicuro(Sub() Pb_Progresso.Maximum = Rows_Filtrate.Count)

                                   For Each R As DataRow In Rows_Filtrate
                                       Dim Celle As New ArrayList From {R(0).ToString}

                                       For C As Integer = 1 To R.ItemArray.Count - 1
                                           Celle.Add(R(C).ToString)
                                       Next

                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Add(Celle.ToArray))

                                       ToolBarBottom.InvocaMetodoSicuro(Sub() Pb_Progresso.PerformStep())
                                   Next

                               Catch od As ObjectDisposedException
                                   If Debugger.IsAttached Then
                                       MessageBox.Show(od.ToString, "ORRORE")
                                   End If

                                   Exit Try
                               Catch ex As Exception
                                   Throw New Exception(ex.Message, ex)
                               End Try
                           End Sub)

            Crono.Stop()
            Lbl_TempoImpegato.Text = "Impiegati " & Math.Round(Crono.Elapsed.TotalSeconds, 1) &
                " secondi per elaborare un file di " & FiSi.ToSize(1)

        Catch ex As Exception
            Lbl_Stato.Text = "Errore elaborazione!"
            Lbl_Stato.ForeColor = Color.Crimson
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If Not ToolBarTop.IsDisposed Then ToolBarTop.Enabled = True
            If Not Txt_Cerca.IsDisposed Then
                If String.IsNullOrWhiteSpace(Filtro) Or String.Equals(Filtro, "Attendere prego...") Then Txt_Cerca.Text = ""
            End If
            If Not Lbl_TotRighe.IsDisposed Or DGV_Centrale.IsDisposed Then Lbl_TotRighe.Text = "Righe totali: " & DGV_Centrale.Rows.Count

            If Not Lbl_Stato.IsDisposed Then
                If Not Lbl_Stato.Text = "Errore elaborazione!" Then
                    Lbl_Stato.Text = "Elaborazione completata!"
                    Lbl_Stato.ForeColor = Color.ForestGreen
                End If
            End If
        End Try
    End Sub

    Private Function TheFile(Estensione As String) As String
        Try
            Using SFD As New SaveFileDialog
                With SFD
                    .DefaultExt = String.Format(".{0}", Estensione)
                    .Filter = String.Format("File {0} | *.{1}", Estensione.ToUpper, Estensione)
                    .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    .OverwritePrompt = True
                    .RestoreDirectory = True
                    .ShowHelp = True
                    .SupportMultiDottedExtensions = False
                    .Title = "Seleziona dove salvare il file esportato"
                    .ValidateNames = True
                    .FileName = TryCast(ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_Files.ComboBox.SelectedItem), DataRowView).Item("Nome").ToString
                End With

                If SFD.ShowDialog = DialogResult.OK Then
                    Return SFD.FileName
                Else
                    Return String.Empty
                End If
            End Using
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Async Sub EsportaCSV()
        Dim FileSave As String = TheFile("csv")
        If Not String.IsNullOrWhiteSpace(FileSave) Then
            Await Task.Run(Sub()
                               Dim SB As New StringBuilder

                               'Header
                               Dim TmpHead As String = String.Empty
                               For Each C As DataGridViewColumn In DGV_Centrale.Columns
                                   TmpHead &= C.HeaderText & ";"
                               Next
                               SB.AppendLine(TmpHead)

                               'Righe
                               For Each L As DataGridViewRow In DGV_Centrale.Rows
                                   'Celle
                                   For Each E As DataGridViewCell In L.Cells
                                       SB.Append(E.Value.ToString.Replace(";", "|") & ";")
                                   Next

                                   SB.Append(Environment.NewLine)
                               Next

                               Using FS As New FileStream(FileSave, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                                   FS.SetLength(0)

                                   Using SW As New StreamWriter(FS, Encoding.UTF8)
                                       SW.Write(SB.ToString)
                                   End Using
                               End Using
                           End Sub)

            MessageBox.Show("Esportazione completata!", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Async Sub EsportaXML()
        Dim FileSave As String = TheFile("xml")
        If Not String.IsNullOrWhiteSpace(FileSave) Then

            Await Task.Run(Sub()
                               Dim Settings As New XmlWriterSettings With {
                                   .Indent = True,
                                   .Encoding = Encoding.UTF8
                               }

                               Using FS As New FileStream(FileSave, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                                   FS.SetLength(0)

                                   Using XW As XmlWriter = XmlWriter.Create(FS, Settings)
                                       With XW
                                           XW.WriteStartDocument()

                                           XW.WriteComment("Argoniano Export By Gianluigi Capozzoli - www.capozzoli.me - www.disactive.com - gianluigi@capozzoli.me")
                                           XW.WriteComment("Creato " & Date.Now.ToLongDateString & " alle " & Date.Now.ToLongTimeString)

                                           XW.WriteStartElement(ToolBarTop.InvocaFunzioneSicuro(Function() TryCast(ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_Files.ComboBox.SelectedItem), DataRowView).Item("Nome").ToString))

                                           'Righe
                                           For Each L As DataGridViewRow In DGV_Centrale.Rows
                                               XW.WriteStartElement("RIGA")

                                               'Celle
                                               For Each E As DataGridViewCell In L.Cells
                                                   XW.WriteStartElement(DGV_Centrale.Columns(E.ColumnIndex).HeaderText) 'Tag

                                                   'Controlla se ha caratteri speciali e li mette sotto CData
                                                   If E.Value.ToString.HaCaratteriSpecialissimi Then
                                                       XW.WriteCData(E.Value.ToString)
                                                   Else
                                                       XW.WriteString(E.Value.ToString)
                                                   End If

                                                   XW.WriteEndElement()
                                               Next

                                               XW.WriteEndElement()
                                           Next

                                           XW.WriteEndDocument() 'End Documents!!
                                           XW.Flush()
                                           XW.Close()
                                       End With
                                   End Using
                               End Using
                           End Sub)

            MessageBox.Show("Esportazione completata!", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Async Sub EsportaHTML()
        Dim FileSave As String = TheFile("html")
        If Not String.IsNullOrWhiteSpace(FileSave) Then

            Await Task.Run(Sub()
                               Dim SB As New StringBuilder
                               SB.AppendLine("<HTML>")
                               SB.AppendLine("<style>table {padding:2px; border:1px solid black; border-collapse:collapse;} .tb, th {padding:2px; background-color:lightblue; border:1px solid} .tr, td {padding:2.5px; border:1px solid}</style>")
                               SB.AppendLine("<body><h2>TABELLA: " &
                                             ToolBarTop.InvocaFunzioneSicuro(Function() TryCast(ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_Files.ComboBox.SelectedItem), DataRowView).Item("Nome").ToString) &
                                             "</h2></body>")
                               SB.AppendLine("<table>")

                               'Header
                               SB.AppendLine("<tr>")
                               For Each C As DataGridViewColumn In DGV_Centrale.Columns
                                   SB.AppendLine(String.Format("<th>{0}</th>", C.HeaderText))
                               Next
                               SB.AppendLine("</tr>")

                               'Righe
                               For Each L As DataGridViewRow In DGV_Centrale.Rows
                                   SB.AppendLine("<tr>")

                                   'Celle
                                   For Each E As DataGridViewCell In L.Cells
                                       SB.AppendLine(String.Format("<td>{0}</td>", E.Value.ToString))
                                   Next

                                   SB.AppendLine("</tr>")
                               Next

                               SB.AppendLine("</table>")
                               SB.AppendLine("</HTML>")

                               Using FS As New FileStream(FileSave, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                                   FS.SetLength(0)

                                   Using SW As New StreamWriter(FS, Encoding.UTF8)
                                       SW.Write(SB.ToString)
                                   End Using
                               End Using
                           End Sub)

            MessageBox.Show("Esportazione completata!", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Private Sub Frm_View_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    Try
    '        'Si si lo so, lo esegue due volte
    '        If DGV_Centrale.Columns.Count > 0 Then
    '            Dim ColWidthS As Integer = 0
    '            For Each Col As DataColumn In DT_Contenuto.Columns
    '                ColWidthS += DGV_Centrale.Columns(Col.ColumnName).Width
    '            Next

    '            'Sistema l'ultima colonna
    '            Dim ColW As Integer = DGV_Centrale.Columns(DGV_Centrale.Columns.Count - 1).Width
    '            Dim DGVW As Integer = DGV_Centrale.Width

    '            If (ColW + DGVW) > (ColWidthS - 20) Then
    '                DGV_Centrale.Columns(DGV_Centrale.Columns.Count - 1).Width = ColW + DGVW - ColWidthS - 20
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

#End Region

End Class
