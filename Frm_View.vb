Imports System.ComponentModel
Imports System.IO

Public Class Frm_View

    Private ReadOnly DT_File As DataTable
    Private ReadOnly DT_Contenuto As New DataTable

    Sub New(DT As DataTable)
        InitializeComponent()

        DT_File = DT

        Me.Text = "Argoniano - " & DT.TableName

        Me.Icon = My.Resources.Martin_Berube_Character_Knight

        If My.Settings.Dimensioni = New Size(0, 0) Then
            Me.Size = New Size(1000, 800)
        Else
            Me.Size = My.Settings.Dimensioni
        End If

        Cmb_Files.SelectedIndex = 0

        DGV_Centrale.DoubleBuffering(True)
        ToolBarTop.DoubleBuffering(True)
        ToolBarBottom.DoubleBuffering(True)
    End Sub

    Private Sub Frm_Principale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            For Each R As DataRow In DT_File.Rows
                Cmb_Files.Items.Add(R.Item("Nome").ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_Principale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            My.Settings.Dimensioni = Me.Size
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

#Region " SUBS "

    Private Async Sub LeggiFile()
        Try
            Dim FiSi As Long = 0

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
                                   Dim FilePath As String = Application.StartupPath & "\" & ToolBarTop.InvocaFunzioneSicuro(Function() Cmb_Files.Text) & ".txt"
                                   Dim FI As New FileInfo(FilePath) 'Solo per il report finale
                                   FiSi = FI.Length 'Solo per il report finale

                                   Dim Filtro As String = ToolBarTop.InvocaFunzioneSicuro(Function() Txt_Cerca.Text.Trim)

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

                                   For Each Col As DataColumn In DT_Contenuto.Columns
                                       DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns.Add(Col.ColumnName, Col.ColumnName))
                                   Next
                                   DGV_Centrale.InvocaMetodoSicuro(Sub() DGV_Centrale.Columns(DGV_Centrale.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill)

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
                                   Exit Sub
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
            ToolBarTop.Enabled = True
            Txt_Cerca.Text = ""
            Lbl_TotRighe.Text = "Righe totali: " & DGV_Centrale.Rows.Count
            If Not Lbl_Stato.Text = "Errore elaborazione!" Then
                Lbl_Stato.Text = "Elaborazione completata!"
                Lbl_Stato.ForeColor = Color.ForestGreen
            End If
        End Try
    End Sub

#End Region

End Class
