Public Class Frm_Impostazioni

    Private Sub Frm_Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Txt_Path.Text = My.Settings.PathBackup
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Apri_Click(sender As Object, e As EventArgs) Handles Btn_Apri.Click
        Try
            Using FBD As New FolderBrowserDialog
                With FBD
                    .Description = "Seleziona la cartella contenente i backup .TXT"
                    .RootFolder = Environment.SpecialFolder.Desktop
                    .ShowNewFolderButton = False
                End With

                If FBD.ShowDialog = DialogResult.OK Then
                    Txt_Path.Text = FBD.SelectedPath
                Else
                    Exit Sub
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        Try
            My.Settings.PathBackup = Txt_Path.Text.Trim
            My.Settings.Save()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Annulla_Click(sender As Object, e As EventArgs) Handles Btn_Annulla.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class