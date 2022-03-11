Imports System.IO

Public Class Frm_Main

    Private ReadOnly DT_Segreteria As New DataTable("Segreteria")
    Private ReadOnly DT_Bilancio As New DataTable("Bilancio")
    Private ReadOnly DT_Piattaforma As New DataTable("Piattaforma")
    Private ReadOnly DT_Altro As New DataTable("Altro")
    Private ReadOnly DT_Vuote As New DataTable("Vuote")

    Sub New()
        InitializeComponent()

        DT_Segreteria.Columns.Add("Nome")
        DT_Bilancio.Columns.Add("Nome")
        DT_Piattaforma.Columns.Add("Nome")
        DT_Altro.Columns.Add("Nome")
        DT_Vuote.Columns.Add("Nome")

        Me.Icon = My.Resources.Martin_Berube_Character_Knight
        Label1.Image = My.Resources.Martin_Berube_Character_Knight.ToBitmap

        Dim RND As New Random()
        Btn_Info.ForeColor = Color.FromArgb(255, Rnd.Next(255), Rnd.Next(255), Rnd.Next(255))
    End Sub

    Private Async Sub Frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim PesoTot As Long = 0
            Dim TabTotFull As Integer = 0

            Dim Tasko As New Task(Sub()
                                      Dim DI As New DirectoryInfo(Application.StartupPath)
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
                                                              DT_Segreteria.Rows.Add(Str)

                                                          Case "tbil", "tper"
                                                              DT_Bilancio.Rows.Add(Str)

                                                          Case "tpro", "tpri", "tdir", "temo", "tlim"
                                                              DT_Piattaforma.Rows.Add(Str)

                                                          Case "tlog", "twsn", "twsx"
                                                              DT_Altro.Rows.Add(Str)

                                                          Case Else
                                                              DT_Altro.Rows.Add(Str)

                                                      End Select
                                                  Else
                                                      DT_Vuote.Rows.Add(Str)
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

            Dim TabTot As Integer = (DT_Segreteria.Rows.Count + DT_Bilancio.Rows.Count + DT_Piattaforma.Rows.Count + DT_Altro.Rows.Count)
            Lbl_TabelleTot.Text = String.Format("Il backup ha un peso di {0} e contiene {1} tabelle, di cui {2} contenenti dati.",
                                                PesoTot.ToSize(2), TabTotFull, TabTot)

            Lbl_TabelleTot.ForeColor = Color.ForestGreen
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btns_Click(sender As Object, e As EventArgs) Handles Btn_Segreteria.Click, Btn_Bilancio.Click, Btn_Piattaforma.Click, Btn_Altro.Click, Btn_Vuote.Click, Btn_Info.Click
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

            Case Else
                FrmW = New Frm_About
                FrmW.ShowDialog()
                Exit Sub
        End Select

        FrmW.StartPosition = FormStartPosition.CenterScreen
        FrmW.Show()
    End Sub
End Class