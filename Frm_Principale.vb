Imports System.ComponentModel
Imports System.IO

Public Class Frm_Principale

    Private ReadOnly DT_File As New DataTable
    Private ReadOnly DT_Contenuto As New DataTable

    Sub New()
        InitializeComponent()

        Me.Icon = My.Resources.Martin_Berube_Character_Knight

        DGV_Centrale.DoubleBuffering(True)

        If My.Settings.Fullscreen = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            If My.Settings.Dimensioni = New Size(0, 0) Then
                Me.Size = New Size(1000, 800)
            Else
                Me.Size = My.Settings.Dimensioni
            End If
        End If

        DT_File.Columns.Add("Nome")
    End Sub

    Private Async Sub Frm_Principale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Cmb_Files.Items.Clear()
            Cmb_Files.Items.Add("Lettura backup...")
            Cmb_Files.SelectedIndex = 0

            Dim LstFiles As New List(Of String)
            Dim Tasko As New Task(Sub()
                                      Dim DI As New DirectoryInfo(Application.StartupPath)
                                      Dim FIarr As FileInfo() = DI.GetFiles("*.txt")

                                      For Each Fri As FileInfo In FIarr
                                          Using FS As New FileStream(Fri.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                                              Using SR As New StreamReader(FS, System.Text.Encoding.Default)
                                                  Dim Lin() As String = SR.ReadToEnd.Split(Environment.NewLine)

                                                  If Lin.Count > 2 Then
                                                      Dim Str As String = Fri.Name.Replace(Fri.Extension, "")
                                                      LstFiles.Add(Str)
                                                      DT_File.Rows.Add(Str)
                                                  End If
                                              End Using
                                          End Using
                                      Next
                                  End Sub)
            Tasko.Start()
            Await Tasko

            Cmb_Files.Items.Clear()
            Cmb_Files.Items.Add("Seleziona un file")
            Cmb_Files.SelectedIndex = 0
            Cmb_Files.Items.AddRange(LstFiles.ToArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_Principale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            My.Settings.Fullscreen = Me.WindowState
            My.Settings.Dimensioni = Me.Size
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cmb_Files_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Files.SelectedIndexChanged
        Try
            Txt_Cerca.Text = String.Empty

            If Cmb_Files.SelectedIndex > 0 Then
                LeggiFile()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Cerca_Click(sender As Object, e As EventArgs) Handles Btn_Cerca.Click
        Try
            If Cmb_Files.SelectedIndex > 0 Then
                LeggiFile()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Cmb_Files_TextChanged(sender As Object, e As EventArgs) Handles Cmb_Files.TextChanged
    '    Try
    '        Dim Rows() As DataRow = DT_File.Select("Nome LIKE '%" & ToolStripComboBox1.Text & "%'")

    '        Dim AC As New AutoCompleteStringCollection
    '        For Each R As DataRow In Rows
    '            AC.Add(R.Item("Nome").ToString)
    '        Next

    '        ToolStripComboBox1.AutoCompleteCustomSource = Nothing
    '        ToolStripComboBox1.AutoCompleteCustomSource = AC
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub Btn_WTF_Click(sender As Object, e As EventArgs) Handles Btn_WTF.Click
        Try
            Frm_About.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UselessTimer_Tick(sender As Object, e As EventArgs) Handles UselessTimer.Tick
        Try
            Lbl_TotRighe.Text = "Righe totali: " & DGV_Centrale.Rows.Count
        Catch ex As Exception
            Lbl_TotRighe.Text = "Righe totali: boh"
        End Try
    End Sub

#Region " SUBS "

    'Private Sub CaricaListaFiles()
    '    Cmb_Files.Items.Clear()

    '    Cmb_Files.Items.Add("// Seleziona un file //")
    '    Cmb_Files.SelectedIndex = 0

    '    Dim DI As New DirectoryInfo(Application.StartupPath)
    '    Dim FIarr As FileInfo() = DI.GetFiles("*.txt")

    '    For Each Fri As FileInfo In FIarr
    '        Using FS As New FileStream(Fri.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
    '            Using SR As New StreamReader(FS, System.Text.Encoding.Default)
    '                Dim Lin() As String = SR.ReadToEnd.Split(Environment.NewLine)

    '                If Lin.Count > 2 Then
    '                    Dim Str As String = Fri.Name.Replace(Fri.Extension, "")
    '                    Cmb_Files.Items.Add(Str)
    '                    DT_File.Rows.Add(Str)
    '                End If
    '            End Using
    '        End Using
    '    Next
    'End Sub

    Private Async Sub LeggiFile()
        Try
            Dim FiSi As Long = 0
            Dim Crono As New Stopwatch
            Crono.Start()

            Await Task.Run(Sub()
                               Try
                                   ToolBarTop.InvocaMetodoSicuro(Sub() ToolBarTop.Enabled = False)
                                   ToolBarBottom.InvocaMetodoSicuro(Sub() Lbl_Stato.Text = "Ricerca in corso...")
                                   ToolBarBottom.InvocaMetodoSicuro(Sub() Lbl_Stato.ForeColor = Color.DodgerBlue)

                                   'Legge il file
                                   Dim LineeFile As New List(Of String)
                                   Dim FilePath As String = Application.StartupPath & "\" & ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_Files.Text) & ".txt"
                                   Dim FI As New FileInfo(FilePath) 'Solo per il report finale
                                   FiSi = FI.Length 'Solo per il report finale

                                   Dim Filtro As String = ToolBarTop.InvocaFunzioneSicuro(Function() Txt_Cerca.Text.Trim)
                                   Dim ColNome As String = ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_CercaCol.Text.Trim)

                                   LineeFile = PulisciFatture(FilePath)

                                   'Using FS As New FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                                   '    Using SR As New StreamReader(FS, System.Text.Encoding.Default)

                                   '        Do Until SR.EndOfStream
                                   '            Dim LineaRaw As String = SR.ReadLine().Trim
                                   '            LineeFile.Add(LineaRaw)
                                   '        Loop
                                   '    End Using
                                   'End Using

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
                                   ToolBarTop.InvocaMetodoSicuro(Sub() Cmb_CercaCol.Items.Clear())

                                   For Each Col As DataColumn In DT_Contenuto.Columns
                                       ToolBarTop.InvocaMetodoSicuro(Sub() Cmb_CercaCol.Items.Add(Col.ColumnName))
                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns.Add(Col.ColumnName, Col.ColumnName))
                                   Next

                                   DGV_Centrale.InvocaMetodoSicuro(Sub() Cmb_CercaCol.SelectedIndex = 0)

                                   'Carica il contenuto del datatable
                                   Dim Rows_Filtrate As New List(Of DataRow)

                                   If String.IsNullOrWhiteSpace(Filtro) Then
                                       For Each Rw As DataRow In DT_Contenuto.Rows
                                           Rows_Filtrate.Add(Rw)
                                       Next
                                   Else
                                       Rows_Filtrate = DT_Contenuto.Select(ColNome & " LIKE '%" & Filtro & "%'").ToList
                                   End If

                                   DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Clear())

                                   For Each R As DataRow In Rows_Filtrate
                                       Dim Celle As New ArrayList From {R(0).ToString}

                                       For C As Integer = 1 To R.ItemArray.Count - 1
                                           Celle.Add(R(C).ToString)
                                       Next

                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Add(Celle.ToArray))
                                   Next

                                   If Not String.IsNullOrWhiteSpace(Filtro) Then
                                       ToolBarTop.InvocaMetodoSicuro(Sub() Cmb_CercaCol.SelectedItem = ColNome)
                                   End If
                               Catch ex As Exception
                                   Throw New Exception(ex.Message, ex)
                               End Try
                           End Sub)

            Crono.Stop()
            Lbl_TempoImpegato.Text = "Impiegati " & Math.Round(Crono.Elapsed.TotalSeconds, 1) &
                " secondi per leggere ed elaborare un file di " & FiSi.ToSize(1)
        Catch ex As Exception
            Lbl_Stato.Text = "Errore elaborazione!"
            Lbl_Stato.ForeColor = Color.Crimson
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ToolBarTop.Enabled = True
            If Not Lbl_Stato.Text = "Errore elaborazione!" Then
                Lbl_Stato.Text = "Elaborazione completata!"
                Lbl_Stato.ForeColor = Color.ForestGreen
            End If
        End Try
    End Sub

    Private Function CaricaContenuto(Optional Filtro As String = "") As Boolean
        Try
            Dim Rows_Filtrate As New List(Of DataRow)

            If String.IsNullOrWhiteSpace(Filtro) Then
                For Each Rw As DataRow In DT_Contenuto.Rows
                    Rows_Filtrate.Add(Rw)
                Next
            Else
                Dim ColNome As String = ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_CercaCol.Text.Trim)
                Rows_Filtrate = DT_Contenuto.Select(ColNome & " LIKE '%" & Filtro & "%'").ToList
            End If

            DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Clear())

            For Each R As DataRow In Rows_Filtrate
                Dim Celle As New ArrayList From {R(0).ToString}

                For C As Integer = 1 To R.ItemArray.Count - 1
                    Celle.Add(R(C).ToString)
                Next

                DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Rows.Add(Celle.ToArray))
            Next

            Return True
        Catch ex As Exception
            Throw New Exception("Errore ricerca!")
            Return False
        Finally
            ToolBarTop.InvocaMetodoSicuro(Sub() Cmb_Files.Enabled = True)
            ToolBarTop.InvocaMetodoSicuro(Sub() Btn_Cerca.Enabled = True)
            ToolBarBottom.InvocaMetodoSicuro(Sub() Lbl_Stato.Text = "Ricerca completata!")
            ToolBarBottom.InvocaMetodoSicuro(Sub() Lbl_Stato.ForeColor = Color.ForestGreen)
            ToolBarBottom.InvocaMetodoSicuro(Sub() Lbl_TotRighe.Text = "Righe totali: " & DGV_Centrale.Rows.Count)
        End Try
    End Function

#End Region

End Class
