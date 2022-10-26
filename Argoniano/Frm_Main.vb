Imports System.IO

Public Class Frm_Main

    Private ReadOnly DT_Segreteria As New DataTable("Segreteria")
    Private ReadOnly DT_Bilancio As New DataTable("Bilancio")
    Private ReadOnly DT_Piattaforma As New DataTable("Piattaforma")
    Private ReadOnly DT_Altro As New DataTable("Altro")
    Private ReadOnly DT_Vuote As New DataTable("Vuote")

    Sub New()
        InitializeComponent()

        DT_Segreteria.Columns.AddRange({New DataColumn("Nome"), New DataColumn("NomeBello")})
        DT_Bilancio.Columns.AddRange({New DataColumn("Nome"), New DataColumn("NomeBello")})
        DT_Piattaforma.Columns.AddRange({New DataColumn("Nome"), New DataColumn("NomeBello")})
        DT_Altro.Columns.AddRange({New DataColumn("Nome"), New DataColumn("NomeBello")})
        DT_Vuote.Columns.AddRange({New DataColumn("Nome"), New DataColumn("NomeBello")})

        Me.Icon = My.Resources.Martin_Berube_Character_Knight
        Label1.Image = My.Resources.Martin_Berube_Character_Knight.ToBitmap

        Dim RND As New Random()
        Btn_Info.ForeColor = Color.FromArgb(255, Rnd.Next(255), Rnd.Next(255), Rnd.Next(255))
    End Sub

    Private Sub Frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If String.IsNullOrWhiteSpace(My.Settings.PathBackup) Then
                Lbl_TabelleTot.Text = "Nessun backup rilevato!"
                Lbl_TabelleTot.ForeColor = Color.OrangeRed

                Using FBD As New FolderBrowserDialog
                    With FBD
                        .Description = "Seleziona la cartella contenente i backup .TXT"
                        .RootFolder = Environment.SpecialFolder.Desktop
                        .ShowNewFolderButton = False
                    End With

                    If FBD.ShowDialog = DialogResult.OK Then
                        My.Settings.PathBackup = FBD.SelectedPath
                        My.Settings.Save()
                    Else
                        Exit Sub
                    End If
                End Using
            End If

            LeggiBackup()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub LeggiBackup()
        Try
            Btn_Segreteria.Enabled = False
            Btn_Bilancio.Enabled = False
            Btn_Piattaforma.Enabled = False
            Btn_Altro.Enabled = False
            Btn_Vuote.Enabled = False

            If String.IsNullOrWhiteSpace(My.Settings.PathBackup) Then
                Lbl_TabelleTot.Text = "Nessun backup rilevato!"
                Lbl_TabelleTot.ForeColor = Color.OrangeRed

                Exit Sub
            End If

            Lbl_TabelleTot.Text = "Caricamento..."
            Lbl_TabelleTot.ForeColor = Color.DarkCyan

            Dim PesoTot As Long = 0
            Dim TabTotFull As Integer = 0

            DT_Segreteria.Rows.Clear()
            DT_Bilancio.Rows.Clear()
            DT_Piattaforma.Rows.Clear()
            DT_Altro.Rows.Clear()
            DT_Vuote.Rows.Clear()

            Dim T As String = "// Seleziona una tabella //"
            DT_Segreteria.Rows.Add(T, T)
            DT_Bilancio.Rows.Add(T, T)
            DT_Piattaforma.Rows.Add(T, T)
            DT_Altro.Rows.Add(T, T)
            DT_Vuote.Rows.Add(T, T)

            Dim Tasko As New Task(Sub()
                                      Dim DI As New DirectoryInfo(My.Settings.PathBackup)
                                      Dim FIarr As FileInfo() = DI.GetFiles("*.txt")
                                      TabTotFull = FIarr.Count

                                      For Each Fri As FileInfo In FIarr
                                          PesoTot += Fri.Length

                                          Using FS As New FileStream(Fri.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                                              Using SR As New StreamReader(FS, System.Text.Encoding.Default)
                                                  Dim Lin() As String = SR.ReadToEnd.Split(Environment.NewLine)
                                                  Dim Str As String = Fri.Name.Replace(Fri.Extension, "")

                                                  If Lin.Count > 2 Then
                                                      Dim Cat As String = Str.Split("_").First

                                                      Select Case Cat.ToLower
                                                          Case "talu", "tdid", "tscu"
                                                              DT_Segreteria.Rows.Add(Str, Str.NormalizzaNome)

                                                          Case "tbil", "tper"
                                                              DT_Bilancio.Rows.Add(Str, Str.NormalizzaNome)

                                                          Case "tpro", "tpri", "tdir", "temo", "tlim"
                                                              DT_Piattaforma.Rows.Add(Str, Str.NormalizzaNome)

                                                          Case "tlog", "twsn", "twsx"
                                                              DT_Altro.Rows.Add(Str, Str.NormalizzaNome)

                                                          Case Else
                                                              DT_Altro.Rows.Add(Str, Str.NormalizzaNome)

                                                      End Select
                                                  Else
                                                      DT_Vuote.Rows.Add(Str, Str.NormalizzaNome)
                                                  End If
                                              End Using
                                          End Using
                                      Next
                                  End Sub)
            Tasko.Start()
            Await Tasko

            Btn_Segreteria.Enabled = True
            Btn_Bilancio.Enabled = True
            Btn_Piattaforma.Enabled = True
            Btn_Altro.Enabled = True
            Btn_Vuote.Enabled = True

            Dim TabTot As Integer = (DT_Segreteria.Rows.Count + DT_Bilancio.Rows.Count + DT_Piattaforma.Rows.Count + DT_Altro.Rows.Count) - 4 '-4 per via dei "seleziona una tabella" per ogni datatable
            Lbl_TabelleTot.Text = String.Format("Il backup ha un peso di {0} e contiene {1} tabelle, di cui {2} contenenti dati.",
                                                PesoTot.ToSize(2), TabTotFull, TabTot)

            Lbl_TabelleTot.ForeColor = Color.ForestGreen
        Catch ex As Exception
            Lbl_TabelleTot.Text = ex.Message
            Lbl_TabelleTot.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Btns_Click(sender As Object, e As EventArgs) Handles Btn_Segreteria.Click, Btn_Bilancio.Click, Btn_Piattaforma.Click, Btn_Altro.Click, Btn_Vuote.Click, Btn_Info.Click, Btn_Impostazioni.Click
        Try
            Dim The_Nome As String = CType(sender, Button).Name.Replace("Btn_", String.Empty) 'Non mi ricordo come richiamare il datatable tramite il suo nome sottoforma di stringa
            Arap(The_Nome)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Arap(Cosa As String)
        Dim FrmW As Form

        Select Case Cosa
            Case "Segreteria"
                FrmW = New Frm_View(DT_Segreteria)

            Case "Bilancio"
                FrmW = New Frm_View(DT_Bilancio)

            Case "Piattaforma"
                FrmW = New Frm_View(DT_Piattaforma)

            Case "Altro"
                FrmW = New Frm_View(DT_Altro)

            Case "Vuote"
                FrmW = New Frm_View(DT_Vuote)

            Case "Impostazioni"
                FrmW = New Frm_Impostazioni
                If FrmW.ShowDialog() = DialogResult.OK Then
                    'Chiude prima le altre finestre attive (nel caso l'utente abbia cambiato directory)
                    My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(F) F.Close())

                    LeggiBackup()
                End If

                Exit Sub

            Case Else
                FrmW = New Frm_About
                FrmW.ShowDialog()
                Exit Sub
        End Select

        FrmW.StartPosition = FormStartPosition.CenterScreen
        FrmW.Show()
    End Sub
End Class