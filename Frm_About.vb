Public Class Frm_About

    Sub New()
        InitializeComponent()

        Me.Icon = My.Resources.Martin_Berube_Character_Knight
        PictureBox1.Image = My.Resources.Martin_Berube_Character_Knight.ToBitmap

        Lbl_Versione.Text = String.Format("v {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub

    Private Sub Lnk_Capozzoli_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_Capozzoli.LinkClicked
        Try
            Process.Start("https://capozzoli.me")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Lnk_Disactive_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_Disactive.LinkClicked
        Try
            Process.Start("https://disactive.com")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Lnk_Email_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnk_Email.LinkClicked
        Try
            Process.Start("mailto:gianluigi@capozzoli.me")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class